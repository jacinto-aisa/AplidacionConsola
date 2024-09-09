using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.ReflexionInstrospeccion
{

    public class ExploradorDePersonal (Object elementoRecibido)
    {
        public string DameClase()
        {
            return elementoRecibido.GetType().Name;
        }
        public ArrayList DameMetodos()
        {
            ArrayList ret = [];
            foreach (MethodInfo metodo in elementoRecibido.GetType().GetMethods())
            {
                ret.Add(metodo.Name + ":" + metodo.DeclaringType);

            }
            return ret;
        }
        public ArrayList DamePropiedadesPublicasInstancia()
        {
            ArrayList ret = [];
            foreach(PropertyInfo propiedad in 
                elementoRecibido.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                ret.Add(propiedad.Name + ":" + propiedad.DeclaringType);
            }
            return ret;
        }
        public ArrayList DamePropiedadesPublicas()
        {
            ArrayList ret = [];
            foreach (PropertyInfo propiedad in
                elementoRecibido.GetType().GetProperties(BindingFlags.Public | BindingFlags.FlattenHierarchy))
            {
                ret.Add(propiedad.Name + ":" + propiedad.DeclaringType);
            }
            return ret;
        }

        public Type? DameClaseBase()
        {
            return elementoRecibido.GetType().BaseType;

        }
        public bool ImplementaInterface(Type interfaceType)
        {
            return elementoRecibido.GetType().GetInterfaces().Contains(interfaceType);
        }
    }
}
