<p align="center">
    <h3 align="center">Juan David Leon Barrera</h3>
	<p align="center">
		<img src="https://img.shields.io/badge/.NET-5C2D91?logo=.net&logoColor=white" alt="template repository">
		<img src="https://img.shields.io/static/v1?label=proyecto&message=Api Rest&color=white" alt="v1.0.0">
		<img src="https://img.shields.io/static/v1?label=version&message=1.0.0&color=red" alt="v1.2">
		<img src="https://img.shields.io/static/v1?label=licencia&message=juan leon&color=green" alt="no tiene">
	</p>
</p>


# 🚩 Objetivo

Este proyecto esta desarrollado C# utilizando CodeFirst y Sql Server; con el fin de demostrar habilidades en el manejo del framework; para ello se planteo un ejercicio con el fin de darle solución desde el BackEnd.

# 📄 Descripción del proyecto

## ✔ Reto

Crear un CRUD para una tabla persona. Agrege la tabla Rol para darle mas dinamismo a las consultas.

## ❌ Supuestos y restricciones

- No hay

# 🔥 Ejecucion de proyecto

Para que el proyecto funcione correctamente se debe de tener instalado:

- IDE de desarrollo (Visual Studio 2019)
- SQL Server
- Postman (aunque el proyecto usa Swagger asi que no es obligatorio)

Una vez se tengan las herramientas instaladas:

1. Clonar el repositorio
2. Crear en Sql Server una base de datos llamada "DigitalSpace"
    - 💡 Si desea cambiarle el nombre es tan facil como ir al proyecto GameStore.API y en el `appsetting.json` cambiar la propiedad **Initial Catalog = Nombre_Base_Datos** 
    en la cadena de conexion.
3. Abrir la consola de "Administrador de paquetes" (Herramientas > Administrador de paquetes NuGet > Consola de administracion de paquetes) y en el proyecto donde se ejecutara la consola ponerlo en Domain. Ejecutar el comando `update-database`; 
esto creara las tablas y las llenara con el *sedder*
4. Luego ejecutar el proyecto con **IIS Express**.
5. Ya estara corriendo la aplicacion desde en endpoint de swagger en la ruta estandar https://localhost:44392/swagger/index.html
