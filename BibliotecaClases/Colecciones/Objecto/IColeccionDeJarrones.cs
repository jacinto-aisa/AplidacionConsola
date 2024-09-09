namespace BibliotecaClases.Colecciones.Objecto
{
    public interface IColeccionDeJarrones
    {
        void Adjuntar(object obj);
        void Eliminar(object obj);
        bool ExisteJarron(object obj);
        void LimpiarColeccion();
        void Ordenar();
    }
}