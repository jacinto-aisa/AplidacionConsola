using BibliotecaClases.Colecciones.Genericos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.Repositorio
{
    public class SerializacionDiccionario : IRepositorioDiccionario
    {
        public Dictionary<int, IElemento>? DameLista()
        {
            var json = File.ReadAllText(@"C:\datos\path.json");
            Dictionary<int,IElemento>? lista = JsonConvert.DeserializeObject<Dictionary<int,IElemento>>(json, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
            return lista;
        }

        public void GuardaLista(Dictionary<int, IElemento> lista)
        {
            var json = JsonConvert.SerializeObject(lista, new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
            File.WriteAllText(@"C:\datos\path.json", json);
        }
    }
}
