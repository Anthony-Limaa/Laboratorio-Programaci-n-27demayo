using Laboratorio__Programación;

GestorEmpleados gestor = new GestorEmpleados("C:\\tmp\\EmpleadosDB.db"); //Acá es donde se pone la dirección para guardar la base de datos.
/*gestor.CrearTabla();*/ //Se llama la función para crear la tabla.

Empleados empleado1 = new Empleados(1, "John", "Mayers", 30, "Gerente", 2500); //Se empiezan a escribir las propiedades de cada empleado.
gestor.AgregarEmpleado(empleado1); //Se llama la función para agregar al empleado.

Empleados empleado2 = new Empleados(2, "Anthony", "Lima", 20, "Supervisor", 1200);
gestor.AgregarEmpleado(empleado2);

Empleados empleado3 = new Empleados(3, "Omar", "Godoy", 23, "Analista de datos", 3000);
gestor.AgregarEmpleado(empleado3);

Empleados empleado4 = new Empleados(4, "Hector", "Palma", 25, "Asistente administrativo", 2700);
gestor.AgregarEmpleado(empleado4);

Empleados empleado5 = new Empleados(5, "Marlon", "García", 23, "Analista de datos", 2000);
gestor.AgregarEmpleado(empleado5);

List<Empleados> listaEmpleados = gestor.ObtenerEmpleados(); //Acá se crea la lista de los empleados.

foreach (var empleado in listaEmpleados) //Función para leer la lista de empleados con sus propiedades.
{
    Console.WriteLine($"Id: {empleado.Id}, Nombre: {empleado.Nombre}, Apellido: {empleado.Apellido}, Edad: {empleado.Edad}, Cargo: {empleado.Cargo}, Sueldo: {empleado.Sueldo}");
}

