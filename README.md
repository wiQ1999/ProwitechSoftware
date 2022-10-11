## Opis projektu
  ...

### Architektura 3-warstwowa:
* Infrastructure
  >Bazowa wartwa apliakcji zaweirająca najbardziej podstawowe modele danych. Zarządza wymianą danych z zewnętrznymi źrółami danych takimi jak baza danych lub Web API. Określa również standard wymiany informacji między warstwą apliakcji.
* Application
  >Główna logika przetwarzania informacji między warstwą interfejsu użytkownika a infrastruktury.
* Web
  >Warstwa prezentacji zawierająca frontendową aplikację klienta Svelte oraz kontrolery Web API do obsługi zapytań.

### pakiety NuGet:
* Infrastructure
  - Microsoft.EntityFrameworkCore.SqlServer (6.0.10)
  - Microsoft.EntityFrameworkCore.Tools (6.0.10)
* Application
  - AutoMapper (12.0.0)
  - AutoMapper.Extensions.Microsoft.DependencyInjection (12.0.0)
  - MediatR (11.0.0)
  - MediatR.Extensions.Microsoft.DependencyInjection (11.0.0)
* Web
  - Swashbuckle.AspNetCore (6.2.3)
