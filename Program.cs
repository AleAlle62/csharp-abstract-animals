using System;
using static csharp_abstract_animals.Animali;


//es 1

//CANE
Console.WriteLine("CANE:");
Cane Pluto = new Cane();
Pluto.Dormi();
Pluto.Verso();
Pluto.Mangia();
Console.WriteLine("");



//PASSEROTTO
Console.WriteLine("PASSEROTTO:");
Passerotto Cip = new Passerotto();
Cip.Dormi();
Cip.Verso();
Cip.Mangia();

//es 2
Cip.IVola();
Console.WriteLine("");



//AQUILA
Console.WriteLine("AQUILA:");
Aquila Frank = new Aquila();
Frank.Dormi();
Frank.Verso();
Frank.Mangia();

//es 2
Frank.IVola(); 
Console.WriteLine("");


//DELFINO
Console.WriteLine("DELFINO:");
Delfino Dino = new Delfino();
Dino.Dormi();
Dino.Verso();
Dino.Mangia();

//es 2
Dino.INuota();
Console.WriteLine("");


