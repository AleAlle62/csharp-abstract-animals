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
        }

        //es 2
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
                Console.WriteLine("ZZZZZZ");
            }
            //verso
            public override void Verso()
            {
                Console.WriteLine("BAU");
            }
            //cosa mangia
            public override void Mangia()
            {
                Console.WriteLine("CIBO PER CANI");
            }
        }

        //PASSEROTTO
        public class Passerotto : Animale
        {
            //dormire
            public override void Dormi()
            {
                Console.WriteLine("ZZZZZZ");
            }
            //verso
            public override void Verso()
            {
                Console.WriteLine("CIP");
            }
            //cosa mangia
            public override void Mangia()
            {
                Console.WriteLine("VERMI");
            }
            //volare
            public void IVola()
            {
                Console.WriteLine("Sto Volando!!!");
            }
        }

        //AQUILA
        public class Aquila : Animale
        {
            //dormire
            public override void Dormi()
            {
                Console.WriteLine("ZZZZZZ");
            }
            //verso
            public override void Verso()
            {
                Console.WriteLine("CRA");
            }
            //cosa mangia
            public override void Mangia()
            {
                Console.WriteLine("CONIGLI");
            }
            //volare
            public void IVola()
            {
                Console.WriteLine("Sto Volando!!!");
            }
        }

        //DELFINO
        public class Delfino : Animale
        {
            //dormire
            public override void Dormi()
            {
                Console.WriteLine("ZZZZZZ");
            }
            //verso
            public override void Verso()
            {
                Console.WriteLine("SCREEE");
            }
            //cosa mangia
            public override void Mangia()
            {
                Console.WriteLine("PESCI");
            }
            //nuotare
            public void INuota()
            {
                Console.WriteLine("Sto Nuotando!!!");
            }
        }
    }
}
