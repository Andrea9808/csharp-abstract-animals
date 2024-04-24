using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{

  

    //CLASSI ASTRATTE
    public  abstract class Animale
    {
        public void Dormi()
        {
            Console.WriteLine("DORME: zzz");
        }
        public abstract void Verso();
        public abstract void Mangia();
    }

    //INTERFACE
    public interface INuotante
    {
        public void Nuota();
    }

    public interface IVolante
    {
        public void Vola();
    }

}
