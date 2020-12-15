using System;
using CaravanLib.Models;

namespace CaravanConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //D
            Beurs beurs;
            //I
            #region BEURS TESTING
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
            beurs.Add(new Auto(180, "BMW", new Aanhangwagen(4, 150, "Ruben", 50), 1000, 4, 300, "Ruben", 12000));
            //motorhome: 5m², 120km/u, VW , aanhangwagen(4 banden, 50kg, eigenaar = Toon, €100), 500kg trekgewicht, 2 banden, 150kg, eigenaar = Toon, €5.000
            beurs.Add(new Motorhome(5, 120, "VW", new Aanhangwagen(4, 50, "Toon", 100), 500, 2, 150, "Toon", 5000));
            //transportboot: 50kg belading, 20000kg max belading, 50km/u, Smolders, eigenaar = Kenan, €500.000
            beurs.Add(new Transportboot(50, 20000, 50, "Smolders", "Kenan", 500000));
            #endregion
            #region INPUT TESTING

            //FOUTE INPUTS: foute inputs testen voor de classes
            //Aanhangwagen: 1 Band, 0 gewicht , Eigenaar Coffe, prijs 10
            Aanhangwagen aanhangwagen = new Aanhangwagen(1, 0, "Coffe", 10);
            //Auto: Maximum snelheid = 1km/h, merk = Mercedes, aanhangwagen(1 band, 20kg, eigenaar = Franck, €400.000), 10kg trekgewicht, 3 banden, 5000kg, eigenaar = Jos, €20.000 
            Auto auto = new Auto(1, "Mercedes", new Aanhangwagen(1, 20, "Franck", 400.000), 10000, 3, 5000, "Jos", 20000);
            //caravan: 10m², 5 banden, 3000kg, eigenaar = Francis, €150.000
            Caravan caravan = new Caravan(10, 5, 10, "Francis", 150000);
            //huis: 13 slaapkamers, 110m², eigenaar = Joe, €150.000
            Huis huis = new Huis(13, 110, "Joe", 12000);
            //kasteel: 1 slaapkamers, 302m², eigenaar = Professor X, €1.100.000 
            Kasteel kasteel = new Kasteel(1, 302, "Professor X", 1100000);
            //Motorhome: 50m, 120 max snelheid, Merk , MaximaalTrekgewicht , 6 banden, 750kg gewicht, eigenaar , prijs.
            Motorhome motorhome = new Motorhome(0, 120, "Arca-Home", new Caravan(25, 2, 500, "Joey", 1000), 15000, 6, 1600, "Cowboy Jack", 25000);
            //Transportboot: Gewicht 100, Maxgewicht 50, MaxSnelheid 10, Merk 0, Eigenaar 0, Prijs 0.5
            Transportboot transportboot = new Transportboot(100, 500, 10, "", "", 0.5);
            //Woonboot: Slaapkamers 1, bewoonbaarOPP -5, Merk 0, Eigenaar, Prijs
            Woonboot woonboot = new Woonboot(1, -5, 20, "", "Jarno Armoede", 1000);
            #endregion

            #region METHOD TESTING

            //METHOD TEST INPUTS: verder alle methods testen van elke class
            Auto testauto = new Auto(150, "Audi", new Aanhangwagen(4, 50, "Jan", 100), 600, 4, 200, "Jos", 10000);
            //P
            //METHOD TESTING AUTO
            testauto.Versnel(50); // test versnel
            testauto.Vertraag(30);// test vertraag
            testauto.Versnel(150);// test maximum snelheid
            testauto.Vertraag(180);//stistand voor koppeling aanhangwagen
            testauto.KoppelAanhangwagen(aanhangwagen); // koppeling aanhangwagen

            //METHOD TESTING CARAVAN
            Caravan testcaravan = new Caravan(20, 6, 2500, "Kurda K", 160000);
            testauto.KoppelAanhangwagen(caravan);

            //METHOD TESTING WOONBOOT
            Woonboot testwoonboot = new Woonboot(4, 40, 100, "VanWall", "Barrack", 1000000);
            testwoonboot.Versnel(80);
            testwoonboot.Versnel(30);
            testwoonboot.Vertraag(130);
            testwoonboot.VerkoopAan("DeFille");

            //METHOD TESTING TRANSPORTBOOT
            Transportboot testtransportboot = new Transportboot(40, 4000, 90, "Containerships", "Arno", 2300000);
            testtransportboot.Versnel(80);
            testtransportboot.Versnel(30);
            testtransportboot.Vertraag(130);
            testtransportboot.VerkoopAan("Rubens");

            //METHOD TESTING MOTORHOME
            Motorhome testMotorhome = new Motorhome(50, 75, "MMH", new Caravan(30, 4, 1000, "Donnel", 99000), 1200, 4, 1500, "Toon", 270000);
            testMotorhome.Versnel(50);
            testMotorhome.Versnel(40);
            testMotorhome.Vertraag(30);
            testMotorhome.BepaalPrijs(5);
            #endregion 
            //O
            //Console.WriteLine(
            //    $"*****AANHANGWAGEN*****\n{aanhangwagen}\n" +
            //    $"*****AUTO*****\n{auto}\n" +
            //    $"*****CARAVAN*****\n{caravan}\n" +
            //    $"*****HUIS*****\n{huis}\n" +
            //    $"*****KASTEEL*****\n{kasteel}\n" +
            //    $"*****MOTORHOME*****\n{motorhome}\n" +
            //    $"*****TRANSPORTBOOT*****\n{transportboot}\n" +
            //    $"*****WOONBOOT*****\n{woonboot}\n");
            //BeursShow(beurs);
            Console.ReadLine();
        }

        private static void BeursShow(Beurs beurs)
        {
            Console.WriteLine("BELAADBAAR");
            foreach (var item in beurs.GetBelaadbaarLijst())
            {
                if (item != null)
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
        }
    }
}
