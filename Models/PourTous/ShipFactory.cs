using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.PourTous
{
    public abstract class ShipFactory
    {
        public abstract AircraftCarrier CreateAircraftCarrier();
        public abstract Cruiser CreateCruiser();
        public abstract BattleShip CreateBattleShip();
        public abstract Destroyer CreateDestroyer();
        
    }
}
