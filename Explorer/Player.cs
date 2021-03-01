using System;
using System.Collections.Generic;
using System.Text;

namespace Explorer
{
    public class Player
    {
        public char Display { get; } = 'P';

        private Map _map;

        public int X { get; private set; }
        public int Y { get; private set; }

        public Player(Map map, int x, int y)
        {
            _map = map;
            X = x;
            Y = y;
        }

        public void Draw()
        {
            Screen.WriteAt(Display, X, Y);
        }

        public void Up()
        {
            _map.Draw(X, Y);
            Y--;
            Draw();
        }

        public void Down()
        {
            _map.Draw(X, Y);
            Y++;
            Draw(); 
        }

        public void Right()
        {
            _map.Draw(X,Y);
            X++;
            Draw();
        }

        public void Left()
        {
            _map.Draw(X, Y);
            X--;
            Draw();
        }
    }
}
