using Shared.Entities;

namespace Api.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DataContext context)
        {
            // Busca por un Persona
            if (context.Personas.Any())
            {
                return; // La tabla Personas fue inicializada
            }

            var personas = new Personas[]
            {
                new Personas { Nombre = "Luis" },
                new Personas { Nombre = "Facundo" },
                new Personas { Nombre = "Juan" },
                new Personas { Nombre = "Trinidad" },
                new Personas { Nombre = "Eva" },
                new Personas { Nombre = "Chuli" }
            };

            context.Personas.AddRangeAsync(personas).Wait();
            context.SaveChangesAsync();
        }
    }
}
