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
  - Microsoft.AspNetCore.WebUtilities (2.2.0)
  - Microsoft.EntityFrameworkCore.SqlServer (6.0.10)
  - Microsoft.EntityFrameworkCore.Tools (6.0.10)
  - Newtonsoft.Json (13.0.1)
* Application
  - AutoMapper (12.0.0)
  - AutoMapper.Extensions.Microsoft.DependencyInjection (12.0.0)
  - MediatR (11.0.0)
  - MediatR.Extensions.Microsoft.DependencyInjection (11.0.0)
  - Microsoft.AspNetCore.Authentication.JwtBearer (6.0.10)
  - Microsoft.Extensions.Options.Configurations (6.0.0)
* Web
  - Microsoft.EntityFrameworkCore.Designer (6.0.10)
  - Swashbuckle.AspNetCore (6.2.3)

### Uruchomienie aplikacji webowej:
  >W Konsoli poleceń będąc w lokalizacji projektu "Web" należy wykonać polecenie
  * Dla wersji developerskiej
    npm run dev
  
  * Dla wersji produkcyjnej
    npm run build
