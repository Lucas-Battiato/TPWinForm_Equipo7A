# Gestión de Catálogo de Artículos
### Trabajo Práctico — Programación III · UTN · Equipo 7A

Aplicación de escritorio desarrollada en **C# / Windows Forms** para la administración del catálogo de artículos de un comercio. La información cargada está pensada para ser consumida por distintos canales externos (webs, e-commerce, apps mobile, etc.), por lo que la aplicación actúa como panel de gestión central.

---

## Tecnologías

- C# / .NET — Windows Forms
- SQL Server (base de datos provista por la cátedra)
- Arquitectura en capas: `dominio`, `negocio`, `presentación`

---

## Estructura de la solución

```
TPWinForm_Equipo7A/
├── dominio/          → Entidades: Artículo, Marca, Categoría, Imagen
├── negocio/          → Lógica de negocio y acceso a datos
└── TPWinForm_Equipo7A/ → Capa de presentación (formularios WinForms)
```

---

## Ventanas de la aplicación

### 🏠 Formulario Principal
Menú de navegación central. Da acceso a todas las secciones: artículos, marcas y categorías.


---

### 📋 Listado de Artículos
Muestra todos los artículos registrados en una grilla.  
Permite **buscar** por código, nombre, marca o categoría.  
Desde aquí se puede acceder a las acciones de agregar, modificar, eliminar y ver detalle.

> **Restricciones:** la eliminación solicita confirmación antes de ejecutarse.

<img width="1048" height="571" alt="imagen" src="https://github.com/user-attachments/assets/c612b469-7b8b-4e36-b472-1931d1f7b7e1" />


---

### ➕ Agregar / ✏️ Modificar Artículo
Formulario para la carga o edición de un artículo. Campos:

| Campo | Tipo |
|---|---|
| Código | Texto (obligatorio, único) |
| Nombre | Texto (obligatorio) |
| Descripción | Texto largo |
| Marca | Desplegable (selección de lista) |
| Categoría | Desplegable (selección de lista) |
| Precio | Numérico (obligatorio, mayor a 0) |
| Imágenes | Texto (pueden ser varias. Eliminables mediante doble click) |

> **Restricciones:** los campos obligatorios se validan antes de guardar. Marca y Categoría deben existir previamente en sus respectivas listas.

<img width="606" height="576" alt="imagen" src="https://github.com/user-attachments/assets/e63d0ff7-de4d-4714-84cb-06b71a5cb9e8" />

<img width="606" height="574" alt="imagen" src="https://github.com/user-attachments/assets/404d77b9-a455-467c-90ff-53df667fb4dd" />


---

### 🔍 Detalle de Artículo
Vista de solo lectura con toda la información del artículo seleccionado, incluyendo el carrusel/galería de imágenes asociadas.

<img width="651" height="424" alt="imagen" src="https://github.com/user-attachments/assets/a4d5110d-4387-49df-ab9c-dcba878c3838" />


---

### 🏷️ Gestión de Marcas
ABM (Alta, Baja, Modificación) de marcas disponibles.  

> **Restricciones:** no se puede eliminar una marca que esté asociada a uno o más artículos.

<img width="391" height="387" alt="imagen" src="https://github.com/user-attachments/assets/89cc10d0-66c2-4428-8194-d18c19c3afa2" />


---

### 📂 Gestión de Categorías
ABM de categorías disponibles.  

> **Restricciones:** igual que marcas, no se permite eliminar si está en uso.

<img width="394" height="389" alt="imagen" src="https://github.com/user-attachments/assets/ee4d14fe-72c7-42dc-a8df-8df3e1042620" />


---

## Requisitos para ejecutar

1. SQL Server instalado y accesible.
2. Restaurar o adjuntar la base de datos provista por la cátedra.
3. Verificar la cadena de conexión en el proyecto (`negocio`).
4. Compilar y ejecutar desde Visual Studio.
