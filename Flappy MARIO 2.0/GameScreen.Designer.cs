
namespace Flappy_MARIO_2._0
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.scoreBoard = new System.Windows.Forms.Label();
            this.Fireball1 = new System.Windows.Forms.PictureBox();
            this.fireball3 = new System.Windows.Forms.PictureBox();
            this.Buttom = new System.Windows.Forms.PictureBox();
            this.Fireball4 = new System.Windows.Forms.PictureBox();
            this.marioBox = new System.Windows.Forms.PictureBox();
            this.Fireball2 = new System.Windows.Forms.PictureBox();
            this.moveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Fireball1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireball3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buttom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fireball4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marioBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fireball2)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreBoard
            // 
            this.scoreBoard.AutoSize = true;
            this.scoreBoard.BackColor = System.Drawing.Color.Azure;
            this.scoreBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreBoard.Location = new System.Drawing.Point(36, 30);
            this.scoreBoard.Name = "scoreBoard";
            this.scoreBoard.Size = new System.Drawing.Size(94, 25);
            this.scoreBoard.TabIndex = 0;
            this.scoreBoard.Text = "Score: 0";
            this.scoreBoard.Click += new System.EventHandler(this.scoreBoard_Click);
            // 
            // Fireball1
            // 
            this.Fireball1.Image = global::Flappy_MARIO_2._0.Properties.Resources.Lava_Bubble_SMR;
            this.Fireball1.Location = new System.Drawing.Point(214, 240);
            this.Fireball1.Name = "Fireball1";
            this.Fireball1.Size = new System.Drawing.Size(94, 126);
            this.Fireball1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fireball1.TabIndex = 1;
            this.Fireball1.TabStop = false;
            // 
            // fireball3
            // 
            this.fireball3.Image = global::Flappy_MARIO_2._0.Properties.Resources.Lava_Bubble_SMR;
            this.fireball3.Location = new System.Drawing.Point(605, 207);
            this.fireball3.Name = "fireball3";
            this.fireball3.Size = new System.Drawing.Size(134, 159);
            this.fireball3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fireball3.TabIndex = 2;
            this.fireball3.TabStop = false;
            // 
            // Buttom
            // 
            this.Buttom.Image = ((System.Drawing.Image)(resources.GetObject("Buttom.Image")));
            this.Buttom.Location = new System.Drawing.Point(-127, 372);
            this.Buttom.Name = "Buttom";
            this.Buttom.Size = new System.Drawing.Size(1189, 180);
            this.Buttom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Buttom.TabIndex = 3;
            this.Buttom.TabStop = false;
            // 
            // Fireball4
            // 
            this.Fireball4.Image = global::Flappy_MARIO_2._0.Properties.Resources.Lava_Bubble_SMR;
            this.Fireball4.Location = new System.Drawing.Point(806, 12);
            this.Fireball4.Name = "Fireball4";
            this.Fireball4.Size = new System.Drawing.Size(138, 172);
            this.Fireball4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fireball4.TabIndex = 4;
            this.Fireball4.TabStop = false;
            // 
            // marioBox
            // 
            this.marioBox.Image = ((System.Drawing.Image)(resources.GetObject("marioBox.Image")));
            this.marioBox.Location = new System.Drawing.Point(32, 113);
            this.marioBox.Name = "marioBox";
            this.marioBox.Size = new System.Drawing.Size(60, 71);
            this.marioBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.marioBox.TabIndex = 5;
            this.marioBox.TabStop = false;
            // 
            // Fireball2
            // 
            this.Fireball2.Image = global::Flappy_MARIO_2._0.Properties.Resources.Lava_Bubble_SMR;
            this.Fireball2.Location = new System.Drawing.Point(376, 1);
            this.Fireball2.Name = "Fireball2";
            this.Fireball2.Size = new System.Drawing.Size(138, 189);
            this.Fireball2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fireball2.TabIndex = 6;
            this.Fireball2.TabStop = false;
            // 
            // moveTimer
            // 
            this.moveTimer.Enabled = true;
            this.moveTimer.Interval = 20;
            this.moveTimer.Tick += new System.EventHandler(this.moveTimerEvent);
            // 
            // GameScreen
            // 
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(956, 531);
            this.Controls.Add(this.Fireball2);
            this.Controls.Add(this.marioBox);
            this.Controls.Add(this.Fireball4);
            this.Controls.Add(this.Buttom);
            this.Controls.Add(this.fireball3);
            this.Controls.Add(this.Fireball1);
            this.Controls.Add(this.scoreBoard);
            this.Name = "GameScreen";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyISdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyISup);
            ((System.ComponentModel.ISupportInitialize)(this.Fireball1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireball3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Buttom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fireball4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marioBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fireball2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Mario;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox flameDOWN1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox flameDOWN2;
        private System.Windows.Forms.PictureBox flameUP1;
        private System.Windows.Forms.PictureBox flameUP2;
        private System.Windows.Forms.Timer eventTimer;
        private System.Windows.Forms.Label scoreBoard;
        private System.Windows.Forms.PictureBox Fireball1;
        private System.Windows.Forms.PictureBox fireball3;
        private System.Windows.Forms.PictureBox Buttom;
        private System.Windows.Forms.PictureBox Fireball4;
        private System.Windows.Forms.PictureBox marioBox;
        private System.Windows.Forms.PictureBox Fireball2;
        private System.Windows.Forms.Timer moveTimer;
    }
}