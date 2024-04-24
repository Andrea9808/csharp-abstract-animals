using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Aquila : Animale, IVolante
    {

        public override void Verso()
        {
            Console.WriteLine("VERSO: fa cri-cri");
        }
        public override void Mangia()
        {
            Console.WriteLine("CIBO: Piccoli mammiferi come conigli, roditori, ma anche di uccelli più piccoli, pesci");
        }
        public void Vola()
        {
            Console.WriteLine("Sto volando...");
        }
    }
}
