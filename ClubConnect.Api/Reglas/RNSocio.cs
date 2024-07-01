using ClubConnect.Api.Models.Data;
using ClubConnect.Api.Models.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ClubConnect.Api.Reglas
{
    public class RNSocio
    {
        public static async Task<Socio?> BuscarSocio(DataContext db, int id)
        {
            try
            {
                var socio = await db.Socios.FirstOrDefaultAsync(s => s.Id == id);
                return socio ?? null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar socio: {ex.Message}");
                return null;
            }

        }
    }
}
