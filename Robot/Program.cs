using Robot;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//var s = new Robot.LandSquare(1, 1);

//s.Draw();

var m = new Map();
m.Squares[9, 2] = new DoorSquare(9, 2);
m.LinkSquares();
m.Draw();

var p = new Player(m.Squares[1,1]);


Thread.Sleep(500);

p.Turn();
Thread.Sleep(500);
p.MoveForward();
Thread.Sleep(500);
p.MoveForward();


bool play = true;

Console.WriteLine("Where do you want to go? W,A,S,D, or E to exit");

while (play)
{
    char key = Screen.GetKeyPress(
        new char[] { 'W', 'A', 'S', 'D', 'E' });

    char keyUpper = char.ToUpper(key);

    if ('E' == keyUpper)
    {
        play = false;
    }
    else if ('W' == keyUpper)
    {
        p.MoveForward();
    }
    else if ('A' == keyUpper)
    {
        p.Turn();
    }
    else if ('S' == keyUpper)
    {
        //player.Move(Direction.Down);
    }
    else if ('D' == keyUpper)
    {
        p.Turn();
    }
}
