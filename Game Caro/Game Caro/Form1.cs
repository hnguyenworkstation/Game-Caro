using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Caro
{
    public partial class a : Form
    {
        private ChessBoard caro_board;
        private Graphics graphics;

        public a()
        {   
            InitializeComponent();
            caro_board = new ChessBoard();
            caro_board.createListBricks();
            graphics = pnlMainState.CreateGraphics();
        }

        private void timerRules_Tick(object sender, EventArgs e)
        {
            lblRules.Location = new Point(lblRules.Location.X, lblRules.Location.Y - 1);
            if (lblRules.Location.Y + lblRules.Height < 0)
            {
                lblRules.Location = new Point(lblRules.Location.X, pnlRules.Height);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblRules.Text = "Welcome you to the Caro\nChallenge...!";
            timerRules.Enabled = true;
        }

        private void pnlMainState_Paint(object sender, PaintEventArgs e)
        {
            // Draw the Chess board
            caro_board.drawCaroBoard(graphics);
        }

        private void pnlMainState_MouseClick(object sender, MouseEventArgs e)
        {
            // To check 
            caro_board.markChess(e.X, e.Y, graphics);
        }
    }
}
