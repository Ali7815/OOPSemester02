using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using EZInput;
using PacmanWithClass.UI;
using PacmanWithClass.BL;

namespace PacmanWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "maze.txt";
            Grid mazeGrid = new Grid(24, 71,path);
            Pacman player = new Pacman(9, 42, mazeGrid);
            Ghost G1 = new Ghost(15, 39, 'H', "Left", 0.1F,' ',mazeGrid);
            Ghost G2 = new Ghost(20, 57, 'V', "Up", 0.2F, ' ', mazeGrid);
            Ghost G3 = new Ghost(19, 26, 'R', "Random", 1F, ' ', mazeGrid);
            Ghost G4 = new Ghost(18, 21, 'C', "Smart", 0.5F, ' ', mazeGrid);
            List<Ghost> enemies = new List<Ghost>();
            enemies.Add(G1);
            enemies.Add(G2);
            enemies.Add(G3);
            enemies.Add(G4);
            mazeGrid.DrawMaze();
            player.draw();
            bool gameRunning = true;
            while(gameRunning)
            {
                Thread.Sleep(90);
                player.printScore();
                player.movePacman();
                foreach(Ghost G in enemies)
                {
                    
                    G.move();
                   
                }
            }

            Console.ReadKey();
               
        }
    }
}
