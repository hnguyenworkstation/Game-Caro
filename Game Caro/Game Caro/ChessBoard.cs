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
        // Board properties
        private Board caro_board;

        // Create a global Pen to mark a chess
        public static Pen pen;
        public static SolidBrush whiteBrush;
        public static SolidBrush blackBrush;

        private const int NUM_ROW = 20;
        private const int NUM_COLUMN = 20;

        // List of the bricks on the board
        private Brick[,] list_brick;
        private int current_row, current_column;

        public int Current_row
        {
            get
            {
                return current_row;
            }

            set
            {
                current_row = value;
            }
        }

        public int Current_column
        {
            get
            {
                return current_column;
            }

            set
            {
                current_column = value;
            }
        }

        public ChessBoard ()
        {
            caro_board = new Board(NUM_COLUMN, NUM_ROW);
            pen = new Pen(Color.Red);
            whiteBrush = new SolidBrush(Color.White);
            blackBrush = new SolidBrush(Color.Black);
            list_brick = new Brick[NUM_ROW, NUM_COLUMN];
        }

        public void drawCaroBoard(Graphics g)
        {
            caro_board.drawBoard(g);
        }

        public void createListBricks()
        {
            for ( int i = 0; i < NUM_ROW; i++)
            {
                for (int j = 0; j < NUM_COLUMN; j++)
                {
                    list_brick[i, j] = new Brick(i, j, new Point(j * Brick.Brick_Width, i* Brick.Brick_Height), 0);
                }
            }
        }

        public bool markChess(int mouseX, int mouseY, Graphics g)
        {   
            // Don't draw when the cursor is on the line
            if (mouseX % Brick.Brick_Width == 0 || 
                mouseY % Brick.Brick_Height == 0)
            {
                return false;
            }

            int numColumn = mouseX / Brick.Brick_Width;
            int numRow = mouseY / Brick.Brick_Height;
            caro_board.createChess(g, list_brick[numRow, numColumn].Position, blackBrush);

            return true;
        }
    }
}
