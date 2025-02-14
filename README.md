# API de Productos en C# con ASP.NET Core

Este proyecto es una API REST desarrollada en C# con ASP.NET Core y Entity Framework Core. Permite realizar operaciones CRUD sobre una base de datos SQL Server para gestionar productos.

## Requisitos
- Visual Studio 2022 o superior
- .NET 8 o superior
- SQL Server

## Instalación y Configuración
1. **Clonar el repositorio**
   ```sh
   git clone <URL_DEL_REPOSITORIO>
   cd nombre-del-repositorio
   ```
2. **Configurar la base de datos**
   - Modificar el archivo `appsettings.json` con la cadena de conexión de tu SQL Server.
   - Ejecutar las migraciones:
     ```sh
     dotnet ef database update
     ```
3. **Ejecutar la API**
   ```sh
   dotnet run
   ```

## Endpoints
### Obtener todos los productos
```
GET /api/productos
```
### Obtener un producto por ID
```
GET /api/productos/{id}
```
### Crear un nuevo producto
```
POST /api/productos
Body (JSON):
{
  "nombre": "Ejemplo",
  "precio": 99.99,
  "stock": 10
}
```
### Actualizar un producto
```
PUT /api/productos/{id}
Body (JSON):
{
  "id": 1,
  "nombre": "Ejemplo Modificado",
  "precio": 79.99,
  "stock": 5
}
```
### Eliminar un producto
```
DELETE /api/productos/{id}
```

## Documentación con Swagger
Una vez ejecutada la API, puedes acceder a la documentación generada automáticamente en:
```
http://localhost:XXXX/swagger
```

## Autor ✒️

_Desarrolladrores del proyecto_

* **Josue Aaron Castillo ** - *Creacion de la Api* - ⌨️ con ❤️ por [JosueCast](https://github.com/JosueCast) 😊


## Documentación con Swagger
[![Google Drive](https://skillicons.dev/icons?i=gcp&perline=12)](https://drive.google.com/file/d/1vNjUwh6kjp2RQOpxkDOyf6uIm8Bf1Kb9/view?usp=sharing)



