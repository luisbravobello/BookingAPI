# 📅 Booking API - Sistema de Reservas y Citas

![.NET](https://img.shields.io/badge/.NET_8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
![Entity Framework Core](https://img.shields.io/badge/Entity_Framework-308DB5?style=for-the-badge&logo=nuget&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)

Una API RESTful construida con ASP.NET Core para la gestión de reservas y citas. Este proyecto demuestra buenas prácticas de desarrollo en backend, incluyendo arquitectura en capas, uso de DTOs y validación de reglas de negocio a nivel de base de datos.

## 🚀 Características Principales
- **Validación de Solapamiento:** Algoritmo de lógica de negocio que previene que dos clientes reserven el mismo servicio en horarios que se cruzan.
- **Patrón DTO:** Separación estricta entre las entidades de la base de datos y los objetos que recibe/devuelve la API (Data Transfer Objects).
- **Entity Framework Core (Code-First):** Diseño de la base de datos relacional generado íntegramente a partir de clases en C#.
- **Documentación Activa:** Integración nativa con Swagger / OpenAPI para pruebas interactivas.

## 🛠️ Tecnologías y Herramientas
- C# & ASP.NET Core 8 Web API
- Entity Framework Core (ORM)
- SQL Server
- Swagger (UI para testeo de API)

## 📁 Estructura del Proyecto
```text
BookingAPI/
├── Controllers/   # Controladores que exponen los endpoints HTTP
├── Models/        # Entidades del dominio (Cliente, Servicio, Reserva)
├── DTOs/          # Objetos de Transferencia de Datos (ej. CrearReservaDTO)
├── Data/          # ApplicationDbContext y configuración de EF Core
└── Migrations/    # Historial de versiones de la base de datos
```

## ⚙️ Instrucciones de Instalación
1. **Clonar el repositorio:**
   ```bash
   git clone https://github.com/tu-usuario/BookingAPI.git
   cd BookingAPI
   ```
2. **Configurar la Base de Datos:**
   - Asegúrate de tener SQL Server corriendo localmente.
   - Revisa el archivo `appsettings.json` y ajusta la cadena de conexión en `DefaultConnection` según tu entorno.
3. **Aplicar Migraciones (Consola de Administrador de Paquetes en Visual Studio):**
   ```powershell
   Update-Database
   ```
4. **Ejecutar la API:**
   Presiona `F5` en Visual Studio o ejecuta en consola:
   ```bash
   dotnet run
   ```
   > Automáticamente se abrirá Swagger en tu navegador para probar los endpoints.

## 📌 Endpoints Principales
| Método | Endpoint | Descripción |
|--------|----------|-------------|
| `GET` | `/api/Servicios` | Lista todos los servicios disponibles |
| `POST` | `/api/Servicios` | Crea un nuevo servicio |
| `POST` | `/api/Reservas` | Crea una reserva |

## Autor
**Luis Alejandro Bravo Bello**  
*Estudiante de Ingeniería de Software*
