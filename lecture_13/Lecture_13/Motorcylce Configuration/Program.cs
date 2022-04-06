using System;

namespace Motorcylce_Configuration
{
    class Program
    {
        static void Main()
        {
            Moto[] motos = new Moto[4];
            motos[0]= new ("Izh25", "Izhevsk", 60);
            motos[0].MotoEng= new Moto.Engine("gas", 200, 110);

            motos[1]= new ("j23", "Java", 70);
            motos[1].MotoEng = new Moto.Engine("gas", 210, 150);

            motos[2] = new ("H25", "Honda", 87);
            motos[2].MotoEng = new Moto.Engine("electro", 220, 114);

            motos[3] = new("", "", 87);
            motos[3].MotoEng = new Moto.Engine("steam", 220, 114);

            for (int i=0; i<motos.Length; i++)
            {
                Console.Write($"{ i + 1}. ");
                Console.WriteLine(motos[i]);
                Console.Write($"{i + 1}.{i + 1} ");
                Console.WriteLine(motos[i].MotoEng);
            }
        }
    }
}
