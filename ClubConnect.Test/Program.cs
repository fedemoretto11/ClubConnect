using ClubConnect.Api.Models.Entidades;
using ClubConnect.Api.Models.Servicios;
using static ClubConnect.Api.Models.Enum.Enum;

SocioServicio socioServicio = new();

// Llamada exitosa
Socio socio1 = socioServicio.CrearSocio(38437001, "Federico", "Moretto", "H Irigoyen 146", "(02268) 15510595", "fedemoretto94@gmail.com", CategoriaSocio.ACTIVO_PLENO, new DateTime(1994, 08, 05));



// Otro
Console.WriteLine(socio1.Dni);
Console.WriteLine(socio1.Nombre);
Console.WriteLine(socio1.Apellido);
Console.WriteLine(socio1.Direccion);
Console.WriteLine(socio1.Telefono);
Console.WriteLine(socio1.Email);
Console.WriteLine(socio1.Categoria);
Console.WriteLine(socio1.EstaActivo);
Console.WriteLine(socio1.FechaDeNacimiento);
Console.WriteLine(socio1.FechaDeRegistro);







