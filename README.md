# 🚀 API de Productos en C# con ASP.NET Core  

Este proyecto es una **API REST** desarrollada en **C# con ASP.NET Core** y **Entity Framework Core**.  
Permite realizar operaciones **CRUD** sobre una base de datos **SQL Server** para gestionar productos.  

---

## 📌 Requisitos  
🔹 **Visual Studio 2022** o superior  
🔹 **.NET 8** o superior  
🔹 **SQL Server**  

---

## 📂 Estructura del Proyecto  

```
📦 InventarioBackend  
 ┣ 📂 Controllers  
 ┃ ┗ 📜 ProductosController.cs  
 ┣ 📂 Models  
 ┃ ┗ 📜 Producto.cs  
 ┣ 📂 Data  
 ┃ ┗ 📜 ApplicationDbContext.cs  
 ┣ 📂 Repositories  
 ┃ ┣ 📜 IProductoRepository.cs  
 ┃ ┗ 📜 ProductoRepository.cs  
 ┣ 📜 appsettings.json  
 ┣ 📜 Program.cs  
 ┗ 📜 README.md  
```

---

## ⚙️ Instalación y Configuración  

### 1️⃣ **Clonar el repositorio**  
```sh
git clone https://github.com/JosueCast/API_REST.git
cd nombre-del-repositorio
```

### 2️⃣ **Configurar la base de datos**  
🔹 Modificar el archivo `appsettings.json` con la cadena de conexión de tu **SQL Server**.  
🔹 Ejecutar las migraciones:  
```sh
dotnet ef database update
```

### 3️⃣ **Ejecutar la API**  
```sh
dotnet run
```

---

## 📝 Endpoints  

### 🔹 Obtener todos los productos  
```http
GET /api/productos
```

### 🔹 Obtener un producto por ID  
```http
GET /api/productos/{id}
```

### 🔹 Crear un nuevo producto  
```http
POST /api/productos
```
📌 **Body (JSON):**  
```json
{
  "nombre": "Ejemplo",
  "precio": 99.99,
  "stock": 10
}
```

### 🔹

## **Video de prueba  con jquery,Html,css y JavaScript**
[![Descripción de la imagen](https://i.ytimg.com/vi/vUUnyEX3GWo/hq720.jpg?sqp=-oaymwEhCK4FEIIDSFryq4qpAxMIARUAAAAAGAElAADIQj0AgKJD&rs=AOn4CLDgL-1hWaMs8MgJReqzx6iFBJecpA)](https://drive.google.com/file/d/1hHdQsdUlbqdAfFdZOHY0sXabgWtzAxVm/view?usp=sharingg)

## Codigo del frontend (ojo revisar descripcion) 
click icono para codigo
[![Google Drive](https://skillicons.dev/icons?i=git&perline=12)](https://github.com/JosueCast/Frontend_Pruebas)


## **Video de prueba  con Postman**
[![Descripción de la imagen](https://i.ytimg.com/vi/5eozUmmJ6DE/maxresdefault.jpg)](https://drive.google.com/file/d/1vNjUwh6kjp2RQOpxkDOyf6uIm8Bf1Kb9/view?usp=sharing)

[![Google Drive](https://skillicons.dev/icons?i=gcp&perline=12)](https://drive.google.com/file/d/1vNjUwh6kjp2RQOpxkDOyf6uIm8Bf1Kb9/view?usp=sharing)



