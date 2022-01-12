using Robot;

var m = new Map();
var p = new Player(m.Squares[1,1]);

//// TODO: Move the Robot to the door
RobotMover mover = new RobotMover();
//mover.



//// After RobotMover is done, control the robot manually.
Keyboard.PlayLoop(p);

