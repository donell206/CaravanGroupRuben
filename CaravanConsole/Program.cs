using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaravanLib.Models;
using CaravanLib.Interfaces;

namespace CaravanConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //D
            Beurs beurs;
            string uitvoer;
            //I
            beurs = new Beurs();
            //CORRECTE INPUTS
            //aanhangwagen: 2 banden, 200kg, eigenaar = Mauro, €350
            beurs.Add(new Aanhangwagen(2, 200, "Mauro", 350));
            //caravan: 15m², 6 banden, 500kg, eigenaar = Francis, €1200
            beurs.Add(new Caravan(15, 6, 500, "Francis", 1200));
            //huis: 3 slaapkamers, 40m², eigenaar = Khadija, €350.000
            beurs.Add(new Huis(3, 40, "Khadija", 350000));
            //kasteel: 10 slaapkamers, 150m², eigenaar = Arno, €2.000.000
            beurs.Add(new Kasteel(10, 150, "Jarno", 2000000));
            //auto: 180 km/u, BMW, aanhangwagen(4 banden, 150kg, eigenaar = Ruben, €50), 1000kg trekgewicht, 4 banden, 300kg, eigenaar = Ruben, €12.000
            beurs.Add(new Auto(180, "BMW",new Aanhangwagen(4,150,"Ruben",50),1000,4,300,"Ruben",12000));
            //motorhome: 5m², 120km/u, VW , aanhangwagen(4 banden, 50kg, eigenaar = Toon, €100), 500kg trekgewicht, 2 banden, 150kg, eigenaar = Toon, €5.000
            beurs.Add(new Motorhome(5, 120, "VW", new Aanhangwagen(4, 50, "Toon", 100), 500, 2, 150, "Toon", 5000));
            //transportboot: 50kg belading, 20000kg max belading, 50km/u, Smolders, eigenaar = Kenan, €500.000
            beurs.Add(new Transportboot(50, 20000, 50, "Smolders", "Kenan", 500000));
            Console.WriteLine("BELAADBAAR");
            foreach (var item in beurs.GetBelaadbaarLijst())
            {
                if (item!=null)
                {
                    Console.WriteLine($"{item}\n************************************************");
                }
            }
            Console.WriteLine("BEWOONBAAR");
            foreach (var item in beurs.GetBewoonbaarLijst())
            {
                if (item != null)
                {
                    Console.WriteLine($"{item}\n************************************************");
                }
            }
            Console.WriteLine("TREKBAAR");       
            foreach (var item in beurs.GetTrekbaarLijst())
            {
                if (item != null)
                {
                    Console.WriteLine($"{item}\n************************************************");
                }
            }
            Console.WriteLine("TREKKERS");
            foreach (var item in beurs.GetTrekkerLijst())
            {
                if (item != null)
                {
                    Console.WriteLine($"{item}\n************************************************");
                }
            }
            Console.WriteLine("VOERTUIGEN");
            foreach (var item in beurs.GetVoertuigLijst())
            {
                if (item != null)
                {
                    Console.WriteLine($"{item}\n************************************************");
                }
            }
            Console.ReadLine();
        }
    }
}
