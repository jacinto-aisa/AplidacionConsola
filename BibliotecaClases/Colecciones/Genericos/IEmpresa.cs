namespace BibliotecaClases.Colecciones.Genericos
{
    public interface IEmpresa
    {
        void Add(IElemento elemento);
        double CosteTotal { get; set; }
        int NumeroElementos { get; set; }   
        void Delete(int id);
        IElemento? GetElemento(int id);
    }
}