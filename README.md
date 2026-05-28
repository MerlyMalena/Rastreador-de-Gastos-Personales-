# Rastreador-de-Gastos-Personales-
Práctica de MVC + Razor

# Rastreador de Gastos Personales

¡Bienvenido al **Rastreador de Gastos Personales**! Este es un mini-proyecto web desarrollado para poner en práctica los fundamentos del patrón de arquitectura **MVC (Modelo-Vista-Controlador)** y el motor de vistas **Razor** utilizando **ASP.NET Core**.

La aplicación permite a los usuarios registrar sus gastos diarios, clasificarlos por categorías y visualizar alertas visuales dinámicas basadas en los montos registrados.

---

## Características del Proyecto

* **Listado de Gastos:** Una tabla interactiva que muestra la descripción, el monto, la categoría y la fecha de cada gasto.
* **Lógica Razor Dinámica:** Los gastos que superen un monto límite (ej. $50) cambian de estilo visual automáticamente (alertas en color rojo) directamente desde la vista.
* **Cálculos en el Controlador:** El controlador procesa la lógica de negocio para calcular el gasto total acumulado y enviarlo a la pantalla principal.
* **Formulario de Registro:** Permite añadir nuevos gastos capturando datos numéricos (`decimal`) y fechas (`DateTime`), procesados mediante peticiones `POST`.
* **Persistencia en Memoria:** Los datos se manejan temporalmente en una lista estática dentro del servidor para simular el comportamiento de una base de datos.

---

## Estructura Arquitectónica (MVC)

El proyecto sigue estrictamente la separación de responsabilidades de ASP.NET Core MVC:

* **Models/Gasto.cs:** Define las propiedades del objeto Gasto (Id, Descripcion, Monto, Categoria, Fecha).
* **Controllers/GastosController.cs:** El cerebro de la app. Filtra los datos, realiza las sumatorias y coordina el flujo entre el modelo y las vistas.
* **Views/Gastos/:** Contiene los archivos `.cshtml` (Razor) que renderizan el HTML dinámico en el servidor.

---

## 🛠️ Tecnologías Utilizadas

* **Backend:** .NET 8.0 / ASP.NET Core MVC
* **Frontend:** Razor Views, HTML5, CSS3, Bootstrap (para estilos rápidos)
* **Control de Versiones:** Git & GitHub

---

## 💻 Cómo Ejecutar el Proyecto Localmente

Para correr este proyecto en tu máquina, asegúrate de tener instalado el **SDK de .NET**. Luego, sigue estos pasos desde tu terminal:

1. **Clonar el repositorio:**
   ```bash
   git clone [https://github.com/TU_USUARIO/Rastreador-de-Gastos-Personales.git](https://github.com/TU_USUARIO/Rastreador-de-Gastos-Personales.git)
