using System.Data;
using System.Security;
using ClubConnect.Api.Models.Data;
using ClubConnect.Api.Models.Entidades;
using ClubConnect.Api.Models.Servicios;
using static ClubConnect.Api.Models.Enum.SociosEnum; 

SocioServicio socioServicio = new();

// Llamada exitosa
//Socio socio1 = socioServicio.CrearSocio(38437001, "Federico", "Moretto", "H Irigoyen 146", "(02268) 15510595", "fedemoretto94@gmail.com", CategoriaSocio.ACTIVO_PLENO, new DateTime(1994, 08, 05));

void CrearSocioAccionEnLista(List<Socio> listaSocio)
{
	SocioServicio sc = new SocioServicio();

	Console.WriteLine("Ingrese el numero de dni: ");
	string dniString = Console.ReadLine();
	int dniInt;

	if (int.TryParse(dniString, out dniInt));
	else
	{
		Console.WriteLine("Por favor, ingrese un número válido para el DNI.");
		return;
	}
	Console.WriteLine("Ingrese el nombre: ");
	string nombre = Console.ReadLine();

	Console.WriteLine("Ingrese el apellido: ");
	string apellido = Console.ReadLine();

	Console.WriteLine("Ingrese la direccion: ");
	string direccion = Console.ReadLine();

	Console.WriteLine("Ingrese el telefono: ");
	string telefono = Console.ReadLine();

	Console.WriteLine("Ingrese el mail: ");
	string email = Console.ReadLine();

	
	DateTime dt = new DateTime(1994, 08, 05);
	Console.WriteLine("");
	Console.WriteLine("");
	Console.WriteLine("");


	Socio socio = sc.CrearSocio(dniInt, nombre, apellido, direccion, telefono, email, SeleccionarCategoria(), dt);
	listaSocio.Add(socio);

}

Socio CrearSocioAccion()
{
	SocioServicio sc = new SocioServicio();

	Console.WriteLine("Ingrese el numero de dni: ");
	string dniString = Console.ReadLine();
	int dniInt;

	if (int.TryParse(dniString, out dniInt)) ;
	else
	{
		Console.WriteLine("Por favor, ingrese un número válido para el DNI.");
		return null;
	}
	Console.WriteLine("Ingrese el nombre: ");
	string nombre = Console.ReadLine();

	Console.WriteLine("Ingrese el apellido: ");
	string apellido = Console.ReadLine();

	Console.WriteLine("Ingrese la direccion: ");
	string direccion = Console.ReadLine();

	Console.WriteLine("Ingrese el telefono: ");
	string telefono = Console.ReadLine();

	Console.WriteLine("Ingrese el mail: ");
	string email = Console.ReadLine();


	DateTime dt = new DateTime(1994, 08, 05);
	Console.WriteLine("");
	Console.WriteLine("");
	Console.WriteLine("");


	Socio socio = sc.CrearSocio(dniInt, nombre, apellido, direccion, telefono, email, SeleccionarCategoria(), dt);
	return socio;

}

void ImprimirSocio(Socio socio1)
{
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
	Console.WriteLine("-----");

}

CategoriaSocio SeleccionarCategoria()
{
	Console.WriteLine("Opciones de categoría:");
	Console.WriteLine("1. " + CategoriaSocio.ACTIVO_SIMPLE);
	Console.WriteLine("2. " + CategoriaSocio.VITALICIO);
	Console.WriteLine("3. " + CategoriaSocio.ACTIVO_PLENO);
	Console.WriteLine("Ingrese la opción: ");
	string opcion = Console.ReadLine();
	switch (opcion)
	{
		case "1":
			return CategoriaSocio.ACTIVO_SIMPLE;
		case "2":
			return CategoriaSocio.VITALICIO;
		case "3":
			return CategoriaSocio.ACTIVO_PLENO;
		default:
			return CategoriaSocio.ACTIVO_SIMPLE;
	}
		
}


List<Socio> listaSocio = new List<Socio>();
//CrearSocioAccionEnLista(listaSocio);
//CrearSocioAccion(listaSocio);
//listaSocio.ForEach(s => ImprimirSocio(s));

//Socio socio = CrearSocioAccion();
//using (var db = new ApplicationDbContext())
//{
//	db.Socios.Add(socio);
//	db.SaveChanges();
//}




