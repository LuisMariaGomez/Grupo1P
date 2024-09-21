using Shared.Entities;

namespace Api.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DataContext context)
        {
            // Busca por un TipoDocumento
            if (context.TipoDocumento.Any())
            {
                return; // La tabla TipoDocumento fue inicializada
            }

            var personas = new Personas[]
            {
                new Personas { Nombre = "Daniel" },
                new Personas { Nombre = "Agustina" },
                new Personas { Nombre = "Jorge" },
                new Personas { Nombre = "Clota" },
            };

            context.Personas.AddRangeAsync(personas).Wait();
            context.SaveChangesAsync();
        }
    }
}
