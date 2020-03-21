using Models.PourTous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.EquipeBleue
{
    public class BleueShipFactory : ShipFactory
    {
        public override AircraftCarrier CreateAircraftCarrier()
        {
            return new BleueAircraftCarrier();
        }

        public override BattleShip CreateBattleShip()
        {
            return new BleueBattleShip();
        }

        public override Cruiser CreateCruiser()
        {
            return new BleueCruiser();
        }

        public override Destroyer CreateDestroyer()
        {
            return new BleueDestroyer();
        }
    }
}
