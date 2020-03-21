namespace Models.PourTous
{
    public abstract class Destroyer : IShipProp
    {
        public abstract int NbSquare { get; set; }
        public abstract int NbSquareTouch { get; set; }
    }
}