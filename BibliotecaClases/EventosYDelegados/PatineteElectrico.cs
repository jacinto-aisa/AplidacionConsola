using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases.EventosYDelegados
{
    public class PatineteElectrico (double VelocidadPatinete)
    {
        public void Actua()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            var value = random.Next(0, 2);

            Action<double>? llamador = null;
            switch (value)
            {
                case 0: llamador = frenada => VelocidadPatinete *= frenada; break;
                case 1: llamador = aceleracion => VelocidadPatinete *= aceleracion;break;
                case 2: llamador = altura => VelocidadPatinete /= altura; break;
            }
            llamador?.Invoke(10);
            Console.WriteLine(VelocidadPatinete);
        }
    }
}
