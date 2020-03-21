using Models.PourTous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.EquipeRouge
{
    public class RougeShipFactory : ShipFactory
    {
        public override AircraftCarrier CreateAircraftCarrier()
        {
            return new RougeAircraftCarrier();
        }

        public override BattleShip CreateBattleShip()
        {
            return new RougeBattleShip();
        }

        public override Cruiser CreateCruiser()
        {
            return new RougeCruiser();
        }

        public override Destroyer CreateDestroyer()
        {
            return new RougeDestroyer();
        }
    }
}
