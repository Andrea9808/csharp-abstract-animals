using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Passerotto : Animale, IVolante
    {

        public override void Verso()
        {
            Console.WriteLine("VERSO: fa Tweet Tweet");
        }
        public override void Mangia()
        {
            Console.WriteLine("CIBO: Insetti");
        }
        public void Vola()
        {
            Console.WriteLine("Sto volando...");
        }
    }
}
