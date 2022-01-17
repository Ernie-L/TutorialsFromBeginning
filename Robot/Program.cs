using Game;

GameEvents gameEvents = GameEvents.GetGameEvents();
Map fieldMap = new FieldMap();
Map treeMap = new TreeFieldMap();

Player robot = new RobotPlayer(fieldMap.Squares[1,1]);
fieldMap.Draw();

//Player robot2 = new RobotPlayer(map.Squares[0,0]);

//// TODO: Move the Robot to the door
//RobotMover mover = new RobotMover();

//mover.GetToDoor(robot);


//// After RobotMover is done, control the robot manually.
//Keyboard.PlayLoop(robot, robot2);
while (!Keyboard.PlayLoop(robot))
{

    if (!gameEvents.IsEmpty)
    {
        GameEvent gameEvent = gameEvents.RemoveEvent();

        if (gameEvent.Name == "LEAVE_FIELD")
        {
            robot.MoveTo(treeMap.Squares[1, 1]);
            treeMap.Draw();
        }

        if (gameEvent.Name == "LEAVE_TREES")
        {
            robot.MoveTo(fieldMap.Squares[1, 1]);
            fieldMap.Draw();
        }
    }
}


