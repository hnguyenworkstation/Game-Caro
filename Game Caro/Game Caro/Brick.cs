using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game_Caro
{
    class Brick
    {
        // Const width and height of one brick
        public const int Brick_Width = 25;
        public const int Brick_Height = 25;

        // Position of each Brick
        private int num_column;
        private int num_row;
        private int brick_Marked;  // check if the brick is marke
        private Point position;


        // Getters and Setters of each properties
        public int Num_row
        {
            get
            {
                return num_row;
            }

            set
            {
                num_row = value;
            }
        }

        public int Num_column
        {
            get
            {
                return num_column;
            }

            set
            {
                num_column = value;
            }
        }

        public Point Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }

        public int Brick_Marked
        {
            get
            {
                return brick_Marked;
            }

            set
            {
                brick_Marked = value;
            }
        }
    }
}
