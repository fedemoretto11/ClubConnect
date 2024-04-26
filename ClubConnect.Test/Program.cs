using ClubConnect.Core.Entidades;

Socio socio = new Socio();
Socio socio2 = new();
socio.Nombre = "Federico";
socio.Apellido = "Moretto";
socio.Direccion = "Hipolito Irigoyen 146";
socio.Telefono = "(02268) 15510595";
socio.Email = "fedemoretto94@gmail.com";
socio.Dni = 38437001;

Console.WriteLine("Id: " + socio.id);
Console.WriteLine("DNI: " + socio.Dni);
Console.WriteLine("Nombre: " + socio.Nombre);
Console.WriteLine("Apellido: " + socio.Apellido);
Console.WriteLine("Direccion: " + socio.Direccion);
Console.WriteLine("Telefono: " + socio.Telefono);
Console.WriteLine("Email: " + socio.Email);
