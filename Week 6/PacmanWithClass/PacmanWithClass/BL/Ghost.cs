using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacmanWithClass.BL
{
    class Ghost
    {
        public int x;
        public int y;
        public string ghostDirection;
        public char ghostCharacter;
        public float speed;
        public char previousItem;
        public float deltaChange;
        public Grid mazeGrid;
        public Ghost(int x,int y,char ghostCharacter, string ghostDirection, float speed,char previousItem,Grid mazeGrid)
        {
            this.x = x;
            this.y = y;
            this.ghostDirection = ghostDirection;
            this.ghostCharacter = ghostCharacter;
            this.speed = speed;
            this.previousItem = previousItem;
            this.mazeGrid = mazeGrid;
        }
        public void setDirection(string ghostDirection)
        {
            this.ghostDirection = ghostDirection;

        }
        public string getDirection()
        {
            return ghostDirection;

        }
        public void remove()
        {
            mazeGrid.maze[x, y].setValue(previousItem);
            Console.SetCursorPosition(y, x);
            Console.Write(previousItem);
        }
        public void draw()
        {
            Console.SetCursorPosition(y, x);
            Console.Write(ghostCharacter);
        }
        public char getCharacter()
        {
            return ghostCharacter; 

        }
        public void changeDelta()
        {
            deltaChange = deltaChange + speed;
        }
        public float getDelta()
        {
            return deltaChange;
        }
        public void setDeltaZero()
        {
            deltaChange = 0;
        }
        public void move()
        {
            if(ghostDirection=="Left" || ghostDirection=="Right")
            {
                moveHorizontal();
            }
            if (ghostDirection == "Up" || ghostDirection == "Down")
            {
                moveVertical();
            }
            if (ghostDirection == "Random")
            {
                moveRandom();
            }
            if (ghostDirection == "Smart")
            {
                moveSmart();
            }
        }
        public void moveHorizontal()
        {
            
            if (ghostDirection=="Left" && mazeGrid.maze[x,y-1].getValue()!='|' && mazeGrid.maze[x,y-1].getValue()!='#')
            {
                remove();
                y = y-1;
                previousItem = mazeGrid.maze[x, y].getValue();
                draw();
                if (mazeGrid.maze[x, y- 1].getValue() == '|')
                {
                    ghostDirection = "Right";
                }
            }
            else if (ghostDirection == "Right" && mazeGrid.maze[x, y + 1].getValue() != '|' && mazeGrid.maze[x, y + 1].getValue() != '#')
            {
                remove();
                y = y + 1;
                previousItem = mazeGrid.maze[x, y].getValue();
                draw();
                if (mazeGrid.maze[x, y + 1].getValue() == '|')
                {
                    ghostDirection = "Left";
                }
            }
        }
        public void moveVertical()
        {
            if (ghostDirection == "Up" && mazeGrid.maze[x-1, y ].getValue() != '|' && mazeGrid.maze[x-1, y].getValue() != '#')
            {
                remove();
                x = x - 1;
                previousItem = mazeGrid.maze[x, y].getValue();
                draw();
                if (mazeGrid.maze[x-1,y].getValue() == '#')
                {
                    ghostDirection = "Down";
                }
            }
            else if (ghostDirection == "Down" && mazeGrid.maze[x+1, y].getValue() != '|' && mazeGrid.maze[x+1, y].getValue() != '#')
            {
                remove();
                x = x + 1;
                previousItem = mazeGrid.maze[x, y].getValue();
                draw();
                if (mazeGrid.maze[x+1,y].getValue() == '#')
                {
                    ghostDirection = "Up";
                }
            }
        }
        public int generateRandom()
        {
            Random R = new Random();
            int value = R.Next(4);
            return value;
        }
        public void moveRandom()
        {
            int value = generateRandom();
            if (value == 0)
            {
                if (mazeGrid.maze[x, y - 1].getValue() != '|' && mazeGrid.maze[x, y - 1].getValue() != '#' && mazeGrid.maze[x, y-1].getValue() != '%')
                {
                    remove();
                    y = y - 1;
                    previousItem = mazeGrid.maze[x, y].getValue();
                    draw();
                }
            }
            else if (value == 1)
            {
                if (mazeGrid.maze[x, y + 1].getValue() != '|' && mazeGrid.maze[x, y + 1].getValue() != '#' && mazeGrid.maze[x , y+1].getValue() != '%')
                {
                    remove();
                    y = y + 1;
                    previousItem = mazeGrid.maze[x, y].getValue();

                    draw();
                }
            }
            else if (value == 2)
            {
                if (mazeGrid.maze[x - 1, y].getValue() != '|' && mazeGrid.maze[x - 1, y].getValue() != '#' && mazeGrid.maze[x - 1, y].getValue() != '%')
                {
                    remove();
                    x = x - 1;
                    previousItem = mazeGrid.maze[x, y].getValue();

                    draw();
                }
            }
            else if (value == 3)
            {
                if (mazeGrid.maze[x + 1, y].getValue() != '|' && mazeGrid.maze[x + 1, y].getValue() != '#' && mazeGrid.maze[x+1,y].getValue()!='%')
                {
                    remove();
                    x = x + 1;
                    previousItem = mazeGrid.maze[x, y].getValue();

                    draw();
                }
            }
        }
        public void moveSmart()
        {
           
        }
    }
}
