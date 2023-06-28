Tutorial:

Krok 1: Przygotowanie projektu

Przenieś wszystkie pliki związane z latarką do folderu Assets w Unity.

Krok 2: Pobranie i import kontrolera pierwszej osoby

Pobierz podstawowy kontroler pierwszej osoby, na przykład ten: [https://assetstore.unity.com/packages/tools/input-management/mini-first-person-controller-174710].
Zaimportuj pobrany asset do projektu Unity, przeciągając go do okna projektu.
Następnie przeciągnij kontroler pierwszej osoby (First Person Controller) do sceny.

Krok 3: Dodanie latarki do sceny

Przeciągnij obiekt FBX reprezentujący latarkę na komponent Capsule Mesh w kontrolerze pierwszej osoby.
Przesuń latarkę obok postaci w scenie, tak aby była umiejscowiona zgodnie z oczekiwaniami.

Krok 4: Dodanie skryptu "latarkadrop" do latarki

Przeciągnij skrypt "latarkadrop" na komponent Capsule Mesh w kontrolerze pierwszej osoby.
W polu "objlatarki" w skrypcie "latarkadrop" ustaw obiekt "Latarka".

Krok 5: Dodanie skryptów do latarki

Przeciągnij skrypty "latarka" i "onoffLatarka" na obiekt reprezentujący latarkę w hierarchii.

W skrypcie "latarka" zmień pole "objektlatarki" na "Latarka".

W skrypcie "onoffLatarka" zmień pole "swiatlo" na "Spot".
Przypisz odpowiednie pliki audio do pól "latarkaon" i "latarkaoff" w skrypcie "onoffLatarka".

Krok 6: Dodanie podłogi

Dodaj podłogę do sceny, aby mieć miejsce, na którym możesz testować latarkę. (możesz opcjonalnie jeszcze dodać jakieś ciemne niebo itp..)

Krok 7: Uruchomienie sceny

Uruchom scenę i przetestuj działanie latarki.
Teraz powinieneś mieć działającą latarkę w swoim projekcie Unity. Możesz dostosować dodatkowe elementy i funkcje według własnych potrzeb.(Zasięg światła, intensywność, rozpraszanie albo możesz dodać inny model latarki)