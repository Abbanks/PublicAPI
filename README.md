# Basic Information API

A RESTful API built with ASP.NET Core that provides my basic information including email address, current datetime, and GitHub repository URL.

## API Documentation

### Endpoint

```
GET /api/Info
```

### Response Format

```json
{
  "email": "your-email@example.com",
  "current_datetime": "2025-01-30T09:30:00Z",
  "github_url": "https://github.com/yourusername/your-repo"
}
```

### Status Codes

- 200: Successful request

## Example Usage
```
curl -X GET https://your-domain.com/api/Info

# With headers
curl -X GET https://your-domain.com/api/Info \
  -H "Accept: application/json"
````

[![C# Developers](https://img.shields.io/badge/hire-C%23%20developers-blue)](https://hng.tech/hire/csharp-developers)

## Setup

1. Prerequisites:
   - .NET 8.0 SDK
   - Visual Studio 2022 or VS Code

2. Clone the repository:
   ```bash
   git clone https://github.com/Abbanks/PublicAPI.git
   cd PublicAPI
   ```

3. Install dependencies:
   ```bash
   dotnet restore
   ```

4. Run the application:
   ```bash
   dotnet run
   ```

6. Access the API:
   - Local endpoint: `https://localhost:7158/api/Info`
   - Swagger UI: `https://localhost:7158/swagger`


