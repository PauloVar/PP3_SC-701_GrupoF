Sistema Gestor de Vehículos (API REST)
1. Integrantes del Grupo
•	Alejandro Rodríguez Fuentes 
•	Paulo César Vargas Valenciano 
•	Jexon Salazar Cruz 

2. Repositorio del Proyecto
Enlace al repositorio:
https://github.com/PauloVar/PP3_SC-701_GrupoF.git 

3. Especificación Básica del Proyecto
3.a Arquitectura del Proyecto
El sistema fue desarrollado utilizando una arquitectura por capas, con el objetivo de garantizar separación de responsabilidades, mantenibilidad y escalabilidad.
La solución contiene tres proyectos principales:

🔹 Capa de Presentación (API)
Proyecto: PP3_SC-701_GrupoFAPI
•	Implementado con ASP.NET Core Web API 
•	Contiene: 
o	Controllers (VehiculosController) 
o	Middleware de manejo global de excepciones 
o	Configuración de Swagger 
Funciones:
•	Expone endpoints REST: 
o	GET (listar vehículos) 
o	GET por ID 
o	POST (crear vehículo) 
o	PUT (actualizar vehículo) 
o	DELETE (eliminar vehículo) 

🔹 Capa de Lógica de Negocio (BLL)
Proyecto: PP3_SC-701_GrupoFBLL
Contiene:
•	Interfaces (IVehiculoServicio) 
•	Servicios (VehiculoServicio) 
•	Validaciones de negocio 
Responsabilidades:
•	Aplicar reglas antes de acceder a datos 
•	Manejar excepciones de dominio 
Ejemplo de reglas:
•	No permitir vehículos nulos 
•	No permitir IDs duplicados 
•	Validar existencia del vehículo antes de modificar o eliminar 

🔹 Capa de Acceso a Datos (DAL)
Proyecto: PP3_SC-701_GrupoFDAL
Contiene:
•	Entidades (Vehiculo) 
•	Repositorio (VehiculoRepositorio) 
•	Interfaces (IVehiculoRepositorio) 
Responsabilidades:
•	Manejo de datos en memoria (lista estática) 
•	Operaciones CRUD 

3.b Libraries / Paquetes NuGet Utilizados
•	Microsoft.AspNetCore.Mvc 
•	Swashbuckle.AspNetCore (Swagger) 
•	Microsoft.OpenApi 
•	System.ComponentModel.Annotations 

3.c Principios SOLID Aplicados
🔹 Single Responsibility Principle (SRP)
Cada clase tiene una única responsabilidad:
•	VehiculoController → manejar HTTP 
•	VehiculoServicio → lógica de negocio 
•	VehiculoRepositorio → acceso a datos 
•	
🔹 Open/Closed Principle (OCP)
El sistema puede extenderse sin modificar clases existentes mediante interfaces.
🔹 Liskov Substitution Principle (LSP)
Las implementaciones pueden sustituir sus interfaces sin romper el sistema.
🔹 Interface Segregation Principle (ISP)
Se utilizan interfaces específicas:
•	IVehiculoServicio 
•	IVehiculoRepositorio 
🔹 Dependency Inversion Principle (DIP)
Se usa inyección de dependencias:
builder.Services.AddScoped<IVehiculoRepositorio, VehiculoRepositorio>();
builder.Services.AddScoped<IVehiculoServicio, VehiculoServicio>();

 Patrones de Diseño Utilizados
🔹 Repository Pattern
Encapsula el acceso a datos.
🔹 Service Layer Pattern
Centraliza la lógica de negocio.
🔹 Middleware Pattern
Manejo global de excepciones.

Manejo de Excepciones
Se implementó un middleware global:
•	Captura errores automáticamente 
•	Devuelve respuestas HTTP estándar: 
o	400 → BadRequest 
o	404 → NotFound 
o	409 → Conflict 
o	500 → Error interno 

 Consideraciones Generales
•	Arquitectura por capas respetada 
•	Uso de Dependency Injection 
•	Código limpio y organizado 
•	Convenciones: 
o	Clases: PascalCase 
o	Métodos: PascalCase 
o	Variables: camelCase 
•	Uso de Swagger para pruebas 

Funcionalidades Implementadas
 Listado de vehículos
Ver detalle de vehículo
Registrar vehículo
Modificar vehículo
Eliminar vehículo

Pruebas del API
Se utilizó Swagger UI para probar los endpoints:
•	GET /api/Vehiculos 
•	GET /api/Vehiculos/{id} 
•	POST /api/Vehiculos 
•	PUT /api/Vehiculos/{id} 
•	DELETE /api/Vehiculos/{id} 
