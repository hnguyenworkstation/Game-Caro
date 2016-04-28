namespace Game_Caro
{
    partial class a
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMainState = new System.Windows.Forms.Panel();
            this.aaaaa = new System.Windows.Forms.PictureBox();
            this.timerRules = new System.Windows.Forms.Timer(this.components);
            this.btnOnePlayer = new System.Windows.Forms.Button();
            this.btnTwoPlayers = new System.Windows.Forms.Button();
            this.btnRemake = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.pnlRules = new System.Windows.Forms.Panel();
            this.lblRules = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aaaaa)).BeginInit();
            this.pnlRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(734, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.saveGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onePlayerToolStripMenuItem,
            this.twoPlayerToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // onePlayerToolStripMenuItem
            // 
            this.onePlayerToolStripMenuItem.Name = "onePlayerToolStripMenuItem";
            this.onePlayerToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.onePlayerToolStripMenuItem.Text = "&One Player";
            // 
            // twoPlayerToolStripMenuItem
            // 
            this.twoPlayerToolStripMenuItem.Name = "twoPlayerToolStripMenuItem";
            this.twoPlayerToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.twoPlayerToolStripMenuItem.Text = "&Two Player";
            // 
            // saveGameToolStripMenuItem
            // 
            this.saveGameToolStripMenuItem.Name = "saveGameToolStripMenuItem";
            this.saveGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveGameToolStripMenuItem.Text = "&Save Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // pnlMainState
            // 
            this.pnlMainState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlMainState.Location = new System.Drawing.Point(222, 38);
            this.pnlMainState.Name = "pnlMainState";
            this.pnlMainState.Size = new System.Drawing.Size(501, 501);
            this.pnlMainState.TabIndex = 1;
            this.pnlMainState.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMainState_Paint);
            // 
            // aaaaa
            // 
            this.aaaaa.BackgroundImage = global::Game_Caro.Properties.Resources.caro;
            this.aaaaa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aaaaa.Location = new System.Drawing.Point(12, 38);
            this.aaaaa.Name = "aaaaa";
            this.aaaaa.Size = new System.Drawing.Size(192, 184);
            this.aaaaa.TabIndex = 2;
            this.aaaaa.TabStop = false;
            // 
            // timerRules
            // 
            this.timerRules.Interval = 25;
            this.timerRules.Tick += new System.EventHandler(this.timerRules_Tick);
            // 
            // btnOnePlayer
            // 
            this.btnOnePlayer.Font = new System.Drawing.Font("Miramonte", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOnePlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOnePlayer.Location = new System.Drawing.Point(12, 412);
            this.btnOnePlayer.Name = "btnOnePlayer";
            this.btnOnePlayer.Size = new System.Drawing.Size(192, 37);
            this.btnOnePlayer.TabIndex = 3;
            this.btnOnePlayer.Text = "One Player";
            this.btnOnePlayer.UseVisualStyleBackColor = true;
            // 
            // btnTwoPlayers
            // 
            this.btnTwoPlayers.Font = new System.Drawing.Font("Miramonte", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwoPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTwoPlayers.Location = new System.Drawing.Point(12, 455);
            this.btnTwoPlayers.Name = "btnTwoPlayers";
            this.btnTwoPlayers.Size = new System.Drawing.Size(192, 37);
            this.btnTwoPlayers.TabIndex = 4;
            this.btnTwoPlayers.Text = "Two Players";
            this.btnTwoPlayers.UseVisualStyleBackColor = true;
            // 
            // btnRemake
            // 
            this.btnRemake.Font = new System.Drawing.Font("Miramonte", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemake.Location = new System.Drawing.Point(12, 501);
            this.btnRemake.Name = "btnRemake";
            this.btnRemake.Size = new System.Drawing.Size(94, 37);
            this.btnRemake.TabIndex = 5;
            this.btnRemake.Text = "Remake";
            this.btnRemake.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Miramonte", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnQuit.Location = new System.Drawing.Point(112, 501);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(92, 37);
            this.btnQuit.TabIndex = 6;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            // 
            // pnlRules
            // 
            this.pnlRules.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRules.Controls.Add(this.lblRules);
            this.pnlRules.Location = new System.Drawing.Point(12, 228);
            this.pnlRules.Name = "pnlRules";
            this.pnlRules.Size = new System.Drawing.Size(192, 178);
            this.pnlRules.TabIndex = 7;
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.Location = new System.Drawing.Point(4, 158);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(0, 13);
            this.lblRules.TabIndex = 0;
            // 
            // a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.pnlRules);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnRemake);
            this.Controls.Add(this.btnTwoPlayers);
            this.Controls.Add(this.btnOnePlayer);
            this.Controls.Add(this.aaaaa);
            this.Controls.Add(this.pnlMainState);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "a";
            this.Text = "Game Caro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aaaaa)).EndInit();
            this.pnlRules.ResumeLayout(false);
            this.pnlRules.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onePlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMainState;
        private System.Windows.Forms.PictureBox aaaaa;
        private System.Windows.Forms.Timer timerRules;
        private System.Windows.Forms.Button btnOnePlayer;
        private System.Windows.Forms.Button btnTwoPlayers;
        private System.Windows.Forms.Button btnRemake;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel pnlRules;
        private System.Windows.Forms.Label lblRules;
    }
}

