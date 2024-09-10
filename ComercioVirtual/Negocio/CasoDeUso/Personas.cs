namespace Negocio.CasoDeUso
{
    public static class Personas
    {
        public static async Task Crear(Shared.Dtos.Personas.CrearDTO persona)
        {
            ArgumentNullException.ThrowIfNull(persona);
            if (persona.Nombre == null)
                throw new ArgumentNullException(nameof(persona.Nombre));

            await Repositorio.Persona.Create(persona);
        }

        public static async Task Modificar(int id, Shared.Dtos.Personas.ModificarDTO personaModificar)
        {
            ArgumentNullException.ThrowIfNull(personaModificar);
            if (personaModificar.Nombre == null)
                throw new ArgumentNullException(nameof(personaModificar.Nombre));

            if (id <= 0)
                throw new ArgumentException("Id debe ser mayor a cero");

            await Repositorio.Persona.Update(id, personaModificar);
        }

        public static async Task<List<Shared.Entities.Personas>> ObtenerTodo()
        {
            return await Repositorio.Persona.Get();
        }

        public static async Task<Shared.Entities.Personas?> obtenerPorId(int id)
        {
            return await Repositorio.Persona.Get(id);
        }

        public static async Task<List<Shared.Entities.Personas>?> obtenerPorNombre(string nombre)
        {
            return await Repositorio.Persona.Get(nombre);
        }

        public static async Task Borrar(int id)
        {
            await Repositorio.Personas.Delete(id);
        }
    }
}
