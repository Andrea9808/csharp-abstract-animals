using System;
using System.Collections.Generic;

namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void FaiVolare(IVolante animale)
            {
                animale.Vola();
            }
            void FaiNuotare(INuotante animale)
            {
                animale.Nuota();
            }

            List<Animale> animals = new List<Animale>();

            animals.Add(new Cane());
            animals.Add(new Passerotto());
            animals.Add(new Aquila());
            animals.Add(new Delfino());

            string scelta = "";

            while (scelta != "0")
            {
                Console.WriteLine("Seleziona l'azione:");
                Console.WriteLine("1. Visualizza tutti gli animali");
                Console.WriteLine("2. Visualizza animali che volano");
                Console.WriteLine("3. Visualizza animali che nuotano");
                Console.WriteLine("4. Visualizza animali che camminano");
                Console.WriteLine("0. Esci");

                scelta = Console.ReadLine();

                foreach (Animale animal in animals)
                {
                    Console.WriteLine();
                    if (scelta == "1")
                    {
                        Console.WriteLine($"Tipo di animale: {animal.GetType().Name}");
                        animal.Verso();
                        animal.Dormi();
                        animal.Mangia();
                        Console.WriteLine();
                    }
                    else if (scelta == "2" && animal is IVolante)
                    {
                        Console.WriteLine($"Tipo di animale: {animal.GetType().Name}");
                        animal.Verso();
                        animal.Dormi();
                        animal.Mangia();
                        FaiVolare((IVolante)animal);
                        Console.WriteLine();
                    }
                    else if (scelta == "3" && animal is INuotante)
                    {
                        Console.WriteLine($"Tipo di animale: {animal.GetType().Name}");
                        animal.Verso();
                        animal.Dormi();
                        animal.Mangia();
                        FaiNuotare((INuotante)animal);
                        Console.WriteLine();
                    }
                    else if (scelta == "4" && animal is Cane)
                    {
                        Console.WriteLine($"Tipo di animale: {animal.GetType().Name}");
                        animal.Verso();
                        animal.Dormi();
                        animal.Mangia();
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine("Arrivederci!");
        }
    }
}