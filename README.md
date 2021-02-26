# Zmniejszacz zdjęć
Wykonany w ramach nauki C#

Program służy do zmniejszania rozmiaru zdjęć w formacie JPEG.
Zmniejszanie rozdzielczości odbywa się z zachowaniem proporcji obrazu, a także ustalonej maksymalnej szerokości oraz wysokości.
Do obsługi zdjęć została wykorzystana systemowa biblioteka GDI+.

# Funkcje
- Ustalanie maksymalnych wymiarów zdjęcia (domyślne wartości wynoszą 1024x1024 - jeżeli zdjęcie jest mniejsze od tych parametrów, to zostanie ono zapisane w pierwotnej rozdzielczości)
- Zmniejszanie z zachowaniem proporcji (np. jeżeli wymiary zdjęcia wynoszą 1280x720, a maksymalne ustawione są na 1024x1024, to w takim przypadku zdjęcie będzie miało finalną rozdzielczość 1024x576)
- Zmiana jakości (domyślna 80%)
- Drag&Drop
- Szybka zmiana rozmiaru z menu kontekstowego obsługiwanego pliku (zdjęcie/a jest/są nadpisywane wg. domyślnych ustawień jakości i rozmiaru. W ten sposób można zmniejszyć maksymalnie 15 zdjęć ze względu na ograniczenia systemu Windows. Funkcja dostępna po instalacji)
- Zmniejszanie przez CMD po podaniu bezpośrednich ścieżek plików
- Zmniejszanie poprzez przeciągnięcie plików na plik wykonywalny "Zmniejszacza" lub jego skrót
- Wbudowany de/instalator (kopiuje plik wykonywalny do stworzonego przez siebie folderu w "Program Files", a następnie tworzy wpisy w rejestrze do obsługi szybkiego zmniejszania oraz skrót na pulpicie. Przy deinstalacji wszystko to usuwa. Wymagane uprawnienia administratora)
