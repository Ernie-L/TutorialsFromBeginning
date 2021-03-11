namespace Explorer
{
    public abstract class Square
    {
        public virtual char Display { get; }
        public virtual string Name { get; }
        public virtual bool Passable { get; }
    }

    public class LandSquare : Square
    {
        public override char Display { get { return '.'; } }
        public override string Name { get { return "Land"; } }
        public override bool Passable { get { return true; } }
    }

    public class WaterSquare : Square
    {
        public override char Display { get { return '~'; } }
        public override string Name { get { return "Water"; } }
        public override bool Passable { get { return false; } }
    }
}