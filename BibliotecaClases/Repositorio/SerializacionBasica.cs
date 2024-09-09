using BibliotecaClases.Colecciones.Genericos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BibliotecaClases.Repositorio
{
    public class SerializacionBasica : IRepositorioColeccionDiccionario
    {
        public List<IElemento>? DameLista()
        {

            var json = File.ReadAllText(@"C:\datos\path.json");
            List<IElemento>? lista = JsonConvert.DeserializeObject<List<IElemento>>(json, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
            return lista;
        }

        public void GuardaLista(List<IElemento> lista)
        {
            var json = JsonConvert.SerializeObject(lista,new JsonSerializerSettings() {
                TypeNameHandling = TypeNameHandling.Auto
            });
            File.WriteAllText(@"C:\datos\path.json", json);
        }
    }
}
