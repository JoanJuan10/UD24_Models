# Ejercicios UD25
Proyecto base usado: Netflix_API (ER + SQL) [https://github.com/JoseMarin/Netflix_API]

#### 1. Description
```
API REST creada con .NET COre 3.1 utilizando varias entidades ER y conectada con base de datos en memoria
```

#### 2. Lista con los pasos mínimos que se necesitan para clonar exitosamente el proyecto

###### Install
```
IDE               Visual Studio 2019 Community Version
Core              C# 
Framework         NET Core 3.1
```
###### packages Nuget 
```
Install-Package Microsoft.EntityFrameworkCore.InMemory               -Version 3.1.8
Install-Package Microsoft.EntityFrameworkCore.Tools               -Version 3.1.8
Install-Package Microsoft.EntityFrameworkCore.SqlServer           -Version 3.1.8
```
#### 3. URIs endpoints.
EX1
```
Articulos
GET       /api/Articulos
POST      /api/Articulos
GET       /api/Articulos/{id}
PUT       /api/Articulos/{id}
DELETE    /api/Articulos/{id}

Fabricantes
GET       /api/Fabricantes
POST      /api/Fabricantes
GET       /api/Fabricantes/{id}
PUT       /api/Fabricantes/{id}
DELETE    /api/Fabricantes/{id}
```
EX2
```
Departamentos
GET       /api/Departamentos
POST      /api/Departamentos
GET       /api/Departamentos/{id}
PUT       /api/Departamentos/{id}
DELETE    /api/Departamentos/{id}

Empleados
GET       /api/Empleados
POST      /api/Empleados
GET       /api/Empleados/{id}
PUT       /api/Empleados/{id}
DELETE    /api/Empleados/{id}
```
EX3
```
Almacenes
GET       /api/Almacenes
POST      /api/Almacenes
GET       /api/Almacenes/{id}
PUT       /api/Almacenes/{id}
DELETE    /api/Almacenes/{id}

Cajas
GET       /api/Cajas
POST      /api/Cajas
GET       /api/Cajas/{id}
PUT       /api/Cajas/{id}
DELETE    /api/Cajas/{id}

```
EX4
```
Peliculas
GET       /api/Peliculas
POST      /api/Peliculas
GET       /api/Peliculas/{id}
PUT       /api/Peliculas/{id}
DELETE    /api/Peliculas/{id}

Salas
GET       /api/Salas
POST      /api/Salas
GET       /api/Salas/{id}
PUT       /api/Salas/{id}
DELETE    /api/Salas/{id}
```

#### 4. Screenshot imagen que indique cómo debe verse el proyecto.
##### EX1
![image](https://i.imgur.com/9V45scP.png)
##### EX2
![image](https://i.imgur.com/TwhgSLK.png)
##### EX3
![image](https://i.imgur.com/RxTIUhP.png)
##### EX4
![image](https://i.imgur.com/unDMb7i.png)

