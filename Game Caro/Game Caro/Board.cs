using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game_Caro
{
    class Board
    {
        // Properties of the Board
        private int _numColumn;
        private int _numRow;

        /// <summary>
        /// Default Constructor of the Board
        /// </summary>
        public Board()
        {
            _numColumn = 0;
            _numRow = 0;
        }

        public Board(int numColumn, int numRow)
        {
            _numColumn = numColumn;
            _numRow = numRow;
        }

        /// <summary>
        /// Draw the Board by drawing vertical and horizontal vertices
        /// </summary>
        /// <param name="g"></param>
        public void drawBoard(Graphics g)
        {
            for (int i = 0; i < 21; i++)
            {
                g.DrawLine(Program.pen, i * Brick.Brick_Width, 0, i * Brick.Brick_Width, _numColumn * Brick.Brick_Height);
            }

            for (int i = 0; i < 21; i++)
            {
                g.DrawLine(Program.pen, 0, i * Brick.Brick_Height, _numRow * Brick.Brick_Width, i * Brick.Brick_Height);
            }
        }
    }
}
