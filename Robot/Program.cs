global using Game;
global using Maps;
global using Robot;
global using Tiles;
global using Squares;

GameEvents gameEvents = GameEvents.GetGameEvents();
Map fieldMap = new FieldMap();
Map treeMap = new TreeFieldMap();
Map startMap = new StarterMap();

//Player robot = new RobotPlayer(startMap.Squares[1, 1]);
//startMap.Draw();

Player bob = new Bob(startMap.Squares[1, 1]);
startMap.Draw();


while (!Keyboard.PlayLoop(bob))
{

    if (!gameEvents.IsEmpty)
    {
        GameEvent gameEvent = gameEvents.RemoveEvent();

        if (gameEvent.Name == "LEAVE_FIELD")
        {
            bob.MoveTo(treeMap.Squares[1, 1]);
            treeMap.Draw();
        }

        if (gameEvent.Name == "LEAVE_TREES")
        {
            bob.MoveTo(fieldMap.Squares[1, 1]);
            fieldMap.Draw();
        }

        if (gameEvent.Name == "LEAVE_STARTER_MAP")
        {
            bob.MoveTo(treeMap.Squares[1, 1]);
            treeMap.Draw();
        }
    }
}


