# 🛒 Lista de Compras

Aplicación web ASP.NET Core MVC para gestionar productos en una lista de compras personal, con autenticación individual y control de acceso. Implementa funcionalidades CRUD, Bootstrap con tema oscuro, protección de rutas, y despliegue con contenedores Docker.

---

## 🚀 Características

- ✅ CRUD completo de productos
- 🔐 Autenticación con **cuentas individuales** (`ASP.NET Identity`)
- 👤 Cada producto está asociado al **usuario que lo creó**
- 🔒 Restricción de acciones según el usuario autenticado
- 🎨 Interfaz moderna con **Bootstrap** en **modo oscuro**
- 🐳 Soporte para **contenedores Docker**
- 🌐 Localización en español (Cultura: `es-CR`)

---

## 🧱 Tecnologías usadas

| Tecnología         | Propósito                          |
|--------------------|-----------------------------------|
| ASP.NET Core MVC   | Backend + lógica de presentación  |
| Entity Framework   | Acceso a datos con migraciones    |
| Identity           | Autenticación y gestión de usuarios |
| Bootstrap          | Interfaz visual moderna            |
| Docker             | Contenedores para app y base de datos |
| SQL Server         | Base de datos relacional           |

---

## ⚙️ Requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [Docker](https://www.docker.com/)
- Visual Studio 2022 o VS Code

---

## 🛠️ Instalación y ejecución local

1. Clona el repositorio:

```bash
git clone https://github.com/ismaoft/ListaDeCompras.git
cd ListaDeCompras
```

2. Restaura los paquetes:

```bash
dotnet restore
```

3. Aplica las migraciones (si aún no están creadas):

```bash
dotnet ef database update
```

4. Ejecuta la aplicación:

```bash
dotnet run
```

5. Abre en navegador: `https://localhost:PORT`

---

## 🐳 Ejecutar con Docker

1. Construye los contenedores:

```bash
docker compose up --build
```

2. Accede en tu navegador a:  
   `http://localhost:PORT` (según mapeo de puertos configurado)

---

## 📷 Capturas (opcional)

> Puedes incluir aquí imágenes como:

- 🧾 Lista de productos
- 🔐 Pantalla de login
- ✏️ Vista de edición protegida

---

## 📄 Licencia

Este proyecto es de uso educativo y personal. Puedes modificarlo libremente según tus necesidades.

---

## 👨‍💻 Autor

**Ismael Salazar Blanco**  
📧 [Contacto profesional](https://ismael-salazar-blanco-portfolio.onrender.com/)
