using Game;

Map map = new Map();
Robot robot = new Robot(map.Squares[1,1]);

//// TODO: Move the Robot to the door
RobotMover mover = new RobotMover();
//mover.



//// After RobotMover is done, control the robot manually.
Keyboard.PlayLoop(robot);

