using System.Collections.Concurrent;

namespace Game
{
    public class GameEvent
    {
        public enum EventType
        {
            ENTERED_DOOR,
            FIGHT
        }

        public Player Player { get; set; }
        public EventType Type { get; set; }
        public string Name { get; set; }
    }

    public class GameEvents
    {
        private static GameEvents _instance;
        public static GameEvents GetGameEvents()
        {
            if (_instance == null)
                _instance = new GameEvents();

            return _instance;
        }

        private ConcurrentQueue<GameEvent> Queue = new ConcurrentQueue<GameEvent>();

        private GameEvents() { }

        public void AddEvent(GameEvent gameEvent)
        {
            Queue.Enqueue(gameEvent);
        }

        public GameEvent RemoveEvent()
        {
            GameEvent gameEvent;

            if (Queue.TryDequeue(out gameEvent))
            {
                return gameEvent;
            }

            return null;
        }

        public bool IsEmpty { get { return Queue.IsEmpty; } }
    }
}
