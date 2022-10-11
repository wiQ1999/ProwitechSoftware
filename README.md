## Opis projektu
  ...

### Architektura 3-warstwowa:
* Infrastructure
  Bazowa wartwa apliakcji zaweirająca najbardziej podstawowe modele danych. Zarządza wymianą danych z zewnętrznymi źrółami danych takimi jak baza danych lub Web API. Określa również standard wymiany informacji między warstwą apliakcji.
* Application
  Główna logika przetwarzania informacji między warstwą interfejsu użytkownika a infrastruktury.
* Web
  Warstwa prezentacji zawierająca frontendową aplikację klienta Svelte oraz kontrolery Web API do obsługi zapytań.
