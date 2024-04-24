using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    public class Delfino : Animale, INuotante
    {

        public override void Verso()
        {
            Console.WriteLine("VERSO: ha una vasta gamma di suoni, tra cui fischi, clic e trilli");
        }
        public override void Mangia()
        {
            Console.WriteLine("CIBO: Pesci");
        }
        public void Nuota()
        {
            Console.WriteLine("Sto nuotando...");
        }
    }
}
