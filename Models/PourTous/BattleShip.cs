namespace Models.PourTous
{
    public abstract class BattleShip : IShipProp
    {
        public abstract int NbSquare { get; set; }
        public abstract int NbSquareTouch { get; set; }
    }
}