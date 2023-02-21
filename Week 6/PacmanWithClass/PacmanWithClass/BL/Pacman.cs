using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EZInput;
using System.Threading.Tasks;

namespace PacmanWithClass.BL
{
    class Pacman
    {
        public int x;
        public int y;
        public int score;
        Grid mazeGrid;
        public Pacman(int x,int y,Grid mazeGrid)
        {
            this.x = x;
            this.y = y;
            this.mazeGrid = mazeGrid;
        }
        public void remove()
        {
            mazeGrid.maze[x,y].setValue(' ');
            Console.SetCursorPosition(y,x);
            Console.Write(' ');
        }
        public void draw()
        {
            mazeGrid.maze[x, y].setValue('P');
            Console.SetCursorPosition(y,x);
            Console.Write("P");
        }
        public void calculateScore()
        {
            score++;
        }
        public void printScore()
        {
            Console.SetCursorPosition(90, 12);
            Console.WriteLine("Score : " + score);
        }
        public void movePacman()
        {
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                movePacmanLeft(mazeGrid.maze[x,y],mazeGrid.getLeftCell(mazeGrid.maze[x,y-1]));
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                movePacmanRight(mazeGrid.maze[x, y], mazeGrid.getRightCell(mazeGrid.maze[x, y + 1]));
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                movePacmanUpWard(mazeGrid.maze[x, y], mazeGrid.getUpCell(mazeGrid.maze[x-1, y]));
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                movePacmanDownWard(mazeGrid.maze[x, y], mazeGrid.getLeftCell(mazeGrid.maze[x+1, y ]));
            }
            
        }
        public void movePacmanLeft(Cell Current,Cell Next)
        {
            if (mazeGrid.maze[x,y - 1].getValue() == ' ' || mazeGrid.maze[x, y - 1].getValue() == '.')
            {
                remove();
                y = y - 1;
                
                draw();
                if (mazeGrid.maze[x, y-1].getValue() == '.')
                {
                    calculateScore();
                }

            }
        }
        public void movePacmanRight(Cell Current,Cell Next)
        {
            if (mazeGrid.maze[x, y + 1].getValue() == ' ' || mazeGrid.maze[x, y + 1].getValue() == '.')
            {
                remove();
                y = y + 1;

                draw();
                if (mazeGrid.maze[x, y+1].getValue() == '.')
                {
                    calculateScore();
                }

            }
        }
        public void movePacmanUpWard(Cell Current, Cell Next)
        {
            if (mazeGrid.maze[x-1, y ].getValue() == ' ' || mazeGrid.maze[x-1, y].getValue() == '.')
            {
                remove();
                x=x-1;
                draw();
                if (mazeGrid.maze[x-1, y].getValue() == '.')
                {
                    calculateScore();
                }

            }
        }
        public void movePacmanDownWard(Cell Current, Cell Next)
        {
            if (mazeGrid.maze[x + 1, y].getValue() == ' ' || mazeGrid.maze[x + 1, y].getValue() == '.')
            {
                remove();
                x = x + 1;
                draw();
                if (mazeGrid.maze[x+1, y].getValue() == '.')
                {
                    calculateScore();
                }

            }
        }
    }
}
