using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PacmanWithClass.BL
{
    class Grid
    {
        public Cell[,] maze;
        public int rowSize;
        public int colSize;
        public Grid(int rowSize, int colSize, string path)
        {
            this.rowSize = rowSize;
            this.colSize = colSize;
            this.maze = new Cell[24, 71];
            if (File.Exists(path))
            {
                StreamReader fp = new StreamReader("maze.txt");
                string record;
                int row = 0;
                while ((record = fp.ReadLine()) != null)
                {
                    for (int x = 0; x < 71; x++)
                    {
                        Cell c = new Cell(record[x], x, row);
                        maze[row, x] = c;
                    }
                    row++;
                }

                fp.Close();
            }
        }
        public Cell getLeftCell(Cell c)
        {
            c.y--;
            return c;
        }
        public Cell getRightCell(Cell c)
        {
            c.y++;
            return c;
        }
        public Cell getUpCell(Cell c)
        {
            c.x--;
            return c;
        }
        public Cell getDownCell(Cell c)
        {
            c.x++;
            return c;
        }
        public Cell findPacman()
        {
            foreach (Cell c in maze)
            {
                if(c.value=='P')
                {
                    return c;
                }
            }
            return null;
        }
        public Cell findGhost(char value)
        {
            foreach (Cell c in maze)
            {
                if (c.value == value)
                {
                    return c;
                    
                }
            }
            return null;
        }
        public static void Draw()
        {

        }
        public  void DrawMaze()
        {
            for (int x = 0; x < 24; x++)
            {
                for (int y = 0; y < 71; y++)
                {
                    Console.Write(maze[x,y].value);
                }
                Console.WriteLine();
            }
        }
    }
}
