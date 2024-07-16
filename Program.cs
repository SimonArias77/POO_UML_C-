// // Declaramos una variable
// using POO_UML.models;

// int numero;

// // inicializamos la variable
// numero = 67;

// // usamos la varible
// Console.WriteLine(numero);

// // instanciando una clase
// var estudianteNuevo = new Estudiante(1, "Juan", "Perez", 32, "juanperez@gmail.com");

// estudianteNuevo.Id = 1;
// estudianteNuevo.Nombre = "Juan";
// estudianteNuevo.Apellido = "Perez";
// estudianteNuevo.Edad = 25;
// estudianteNuevo.Correo = "juanperez@gmail.com"

using POO_UML.Models;

var empleado1 = new Empleado("Simon","Arias", "sariass07@gmail.com", 1000000, 10, 10, 10);

Console.WriteLine(empleado1.ToString());