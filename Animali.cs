

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    internal class Animali
    {
        //es 1
        public abstract class Animale
        {
            public abstract void Dormi();
            public abstract void Verso();
            public abstract void Mangia();
            //variabili 
            protected string dormire = "come dorme:";
            protected string verso = "che verso fa:";
            protected string mangiare = "cosa mangia:";
            protected string cosafa = "vola o nuota:";

        }
        public interface IVola
        {
            void Vola();
        }
        public interface INuota
        {
            void Nuota();
        }

        //CANE
        public class Cane : Animale
        {
            //dormire
            public override void Dormi()
            {
                Console.WriteLine($"{dormire}ZZZZZZ");
            }
            //verso
            public override void Verso()
            {
                Console.WriteLine($"{verso}BAU");
            }
            //cosa mangia
            public override void Mangia()
            {
                Console.WriteLine($"{mangiare}CIBO PER CANI");
            }
        }

        //PASSEROTTO
        public class Passerotto : Animale
        {
            //dormire
            public override void Dormi()
            {
                Console.WriteLine($"{dormire}ZZZZZZ");
            }
            //verso
            public override void Verso()
            {
                Console.WriteLine($"{verso}CIP");
            }
            //cosa mangia
            public override void Mangia()
            {
                Console.WriteLine($"{mangiare}VERMI");
            }
            //volare
            public void IVola()
            {
                Console.WriteLine($"{cosafa}Sto Volando!!!");
            }
        }

        //AQUILA
        public class Aquila : Animale
        {
            //dormire
            public override void Dormi()
            {
                Console.WriteLine($"{dormire}ZZZZZZ");
            }
            //verso
            public override void Verso()
            {
                Console.WriteLine($"{verso}CRA");
            }
            //cosa mangia
            public override void Mangia()
            {
                Console.WriteLine($"{mangiare}CONIGLI");
            }
            //volare
            public void IVola()
            {
                Console.WriteLine($"{cosafa}Sto Volando!!!");
            }
        }

        //DELFINO
        public class Delfino : Animale
        {
            //dormire
            public override void Dormi()
            {
                Console.WriteLine($"{dormire}ZZZZZZ");
            }
            //verso
            public override void Verso()
            {
                Console.WriteLine($"{verso}SCREEE");
            }
            //cosa mangia
            public override void Mangia()
            {
                Console.WriteLine($"{mangiare}PESCI");
            }
            //nuotare
            public void INuota()
            {
                Console.WriteLine($"{cosafa}Sto Nuotando!!!");
            }
        }
    }
}