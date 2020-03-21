using Models.PourTous;
using Models.EquipeBleue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EquipeRouge;

namespace BatailleNavale
{
    class Program
    {
        static void Main(string[] args)
        {
            // création de la flotte bleue... le NbSquare aurait pû être mis par défaut dans la classe
            ShipFactory bshipfactory = new BleueShipFactory();
            AircraftCarrier bAircraftCarrier = bshipfactory.CreateAircraftCarrier();
            bAircraftCarrier.NbSquare = 5;
            BattleShip bBattleShip = bshipfactory.CreateBattleShip();
            bBattleShip.NbSquare = 4;
            Cruiser bCruiser = bshipfactory.CreateCruiser();
            bCruiser.NbSquare = 3;
            Destroyer bDestroyer = bshipfactory.CreateDestroyer();
            bDestroyer.NbSquare = 2;

            // création de la flotte rouge... le NbSquare aurait pû être mis par défaut dans la classe
            ShipFactory rshipfactory = new RougeShipFactory();
            AircraftCarrier rAircraftCarrier = rshipfactory.CreateAircraftCarrier();
            rAircraftCarrier.NbSquare = 5;
            BattleShip rBattleShip = rshipfactory.CreateBattleShip();
            rBattleShip.NbSquare = 4;
            Cruiser rCruiser = rshipfactory.CreateCruiser();
            rCruiser.NbSquare = 3;
            Destroyer rDestroyer = rshipfactory.CreateDestroyer();
            rDestroyer.NbSquare = 2;
            //





            Console.WriteLine(bshipfactory.CreateAircraftCarrier());
            Console.WriteLine("nbre case porte avion bleu : {0}" ,(bAircraftCarrier.NbSquare));

            Console.WriteLine(rshipfactory.CreateAircraftCarrier());
            Console.WriteLine("nbre case porte croiseur rouge : {0}", (rCruiser.NbSquare));


            // Console.WriteLine(bshipfactory);
            Console.ReadLine();
        }
    }
}
