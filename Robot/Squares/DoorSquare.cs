using Game;
using Tiles;

namespace Squares
{
    public class DoorSquare : Square
    {
        public override Tile Tile { get { return DoorTileSet.Closed; } }
        public override string Name { get { return "Door"; } }
        public override bool Passable { get { return true; } }

        private string EventName { get; }

        public DoorSquare(int x, int y, string eventName) : base(x, y) 
        {
            EventName = eventName;
        }

        public override bool EnterSquare(Player player)
        {
            bool moved = base.EnterSquare(player);

            if (moved)
            {
                GameEvents.GetGameEvents()
                    .AddEvent(new GameEvent() { 
                        Player = player, 
                        Type = GameEvent.EventType.ENTERED_DOOR,
                        Name = EventName});
            }

            return moved;
        }
    }

}