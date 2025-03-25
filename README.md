# Hermes-BackEnd

This is a **.NET 8 Web API** project called **Hermes-Backend**.

## 🚀 Prerequisites

Before running the project, make sure you have installed:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
- A code editor such as [Visual Studio Code](https://code.visualstudio.com/)

## 🚀 Installation and Execution

### 1️⃣ Clone the repository

```sh
git clone https://github.com/your-username/Hermes-Backend.git
cd Hermes-Backend
```
### 2️⃣ Restore Dependencies
Run the following command to install the necessary packages:
```sh
dotnet restore
```

## 🛠 Test Endpoint
A test endpoint has been created in Controllers/HelloController.cs:

```sh
using Microsoft.AspNetCore.Mvc;

namespace Hermes_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Hola desde Hermes-Backend!" });
        }
    }
}

```

### 3️⃣ Run the project
To start the API, use the following command:
```sh
dotnet run
```

## 📌 Test the endpoint
You can test the endpoint in Postman or in the browser by visiting:
```sh
http://localhost:5151/api/hello
```

It should return the following JSON response:
```sh
{
  "message": "Hello from Hermes-Backend!"
}
```




