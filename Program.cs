using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace Zmniejszacz_zdjęć
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary> 

        private static string _AppName = Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().GetName().Name);

        private static bool noGUI = false;

        private static NamedPipeServerStream srv;

        private static System.Timers.Timer aTimer;

        private static bool timedOut = false;

        [STAThread]
        static void Main(string[] args)
        {
            bool notAlreadyRunning = true;

            using(Mutex mutex = new Mutex(true, _AppName + "Singleton", out notAlreadyRunning))
            {
                if(notAlreadyRunning)
                {
                    if(args.Length > 0)
                    {
                        noGUI = true;

                        AddFiles(args);
                    }

                    srv = new NamedPipeServerStream(_AppName + "IPC", PipeDirection.InOut, 1, PipeTransmissionMode.Message, PipeOptions.Asynchronous);

                    if(noGUI)
                    {
                        aTimer = new System.Timers.Timer(400);
                        aTimer.Elapsed += OnTimedEvent;
                        aTimer.Enabled = true;

                        _ConnectionHandler();
                    }

                    else
                    {
                        srv.BeginWaitForConnection(new AsyncCallback(_AsyncConnectionHandler), srv);

                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        Application.Run(new FormMain());
                    }

                    srv.Close();
                }

                else
                {
                    NamedPipeClientStream cli = new NamedPipeClientStream(".", _AppName + "IPC", PipeDirection.InOut);
                    cli.Connect();

                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(cli, args);

                    cli.Close();
                }
            }
        }

        private static void _AsyncConnectionHandler(IAsyncResult result)
        {
            NamedPipeServerStream srv = result.AsyncState as NamedPipeServerStream;
            srv.EndWaitForConnection(result);

            BinaryFormatter bf = new BinaryFormatter();
            string[] inargs = bf.Deserialize(srv) as string[];

            AddFiles(inargs);

            srv.Close();

            srv = new NamedPipeServerStream(_AppName + "IPC", PipeDirection.InOut, 1, PipeTransmissionMode.Message, PipeOptions.Asynchronous);

            srv.BeginWaitForConnection(new AsyncCallback(_AsyncConnectionHandler), srv);
        }

        private static void _ConnectionHandler()
        {
            while(!timedOut)
            {
                aTimer.Start();

                srv.WaitForConnection();

                aTimer.Stop();

                BinaryFormatter bf = new BinaryFormatter();
                String[] inargs = bf.Deserialize(srv) as string[];

                AddFiles(inargs);

                srv.Close();

                srv = new NamedPipeServerStream(_AppName + "IPC", PipeDirection.InOut, 1, PipeTransmissionMode.Message, PipeOptions.Asynchronous);

                _ConnectionHandler();
            }
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            aTimer.Enabled = false;
            timedOut = true;

            Save();

            srv.Close();

            Environment.Exit(0);
        }

        private static void AddFiles(string[] files)
        {
            foreach (string file in files)
            {
                if (ImageHandler.isJpeg(file) && FileHandler.NotDuplicate(file))
                {
                    FileHandler.AddFile(file);
                }
            }
        }

        private static void Save()
        {
            int filesSaves = 0;

            foreach (string file in FileHandler.ReadFiles())
            {
                if (ImageHandler.Resize(file))
                {
                    if (ImageHandler.Save(file))
                    {
                        filesSaves++;
                    }
                }
            }

            MessageBox.Show("Zmniejszono i zapisano pomyślnie " + filesSaves + " z " + FileHandler.ReadFiles().Count + " zdjęć", "Podsumowanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
