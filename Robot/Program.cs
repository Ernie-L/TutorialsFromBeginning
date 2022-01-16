using Game;

Map map = new FieldMap();
Robot robot = new Robot(map.Squares[1,1]);

Robot robot2 = new Robot(map.Squares[0,0]);

//// TODO: Move the Robot to the door
RobotMover mover = new RobotMover();

//mover.GetToDoor(robot);


//// After RobotMover is done, control the robot manually.
Keyboard.PlayLoop(robot, robot2);

