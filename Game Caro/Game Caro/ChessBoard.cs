using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game_Caro
{
    class ChessBoard
    {
        private Board caro_board;
        private const int NUM_ROW = 20;
        private const int NUM_COLUMN = 20;

        public ChessBoard ()
        {
            caro_board = new Board(NUM_COLUMN, NUM_ROW);
        }

        public void drawCaroBoard(Graphics g)
        {
            caro_board.drawBoard(g);
        }
    }
}
