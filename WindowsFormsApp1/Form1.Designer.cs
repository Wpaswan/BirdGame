namespace WindowsFormsApp1
{
    partial class Form1
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
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.House = new System.Windows.Forms.PictureBox();
            this.FloppyBird1 = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.pipebottom2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.House)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FloppyBird1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom2)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.White;
            this.scoreText.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(2, 9);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(274, 71);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score:0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // House
            // 
            this.House.Image = global::WindowsFormsApp1.Properties.Resources.house;
            this.House.Location = new System.Drawing.Point(1057, 417);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(449, 377);
            this.House.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.House.TabIndex = 9;
            this.House.TabStop = false;
            // 
            // FloppyBird1
            // 
            this.FloppyBird1.BackColor = System.Drawing.Color.Snow;
            this.FloppyBird1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FloppyBird1.Image = global::WindowsFormsApp1.Properties.Resources.shapeBird1;
            this.FloppyBird1.Location = new System.Drawing.Point(263, 226);
            this.FloppyBird1.Name = "FloppyBird1";
            this.FloppyBird1.Size = new System.Drawing.Size(153, 149);
            this.FloppyBird1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FloppyBird1.TabIndex = 7;
            this.FloppyBird1.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.BackColor = System.Drawing.Color.Lime;
            this.pipeBottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pipeBottom.Image = global::WindowsFormsApp1.Properties.Resources.pipeBottom;
            this.pipeBottom.Location = new System.Drawing.Point(767, 560);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(195, 396);
            this.pipeBottom.TabIndex = 3;
            this.pipeBottom.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::WindowsFormsApp1.Properties.Resources.pipeTop;
            this.pipeTop.Location = new System.Drawing.Point(534, 9);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(187, 207);
            this.pipeTop.TabIndex = 2;
            this.pipeTop.TabStop = false;
            // 
            // pipebottom2
            // 
            this.pipebottom2.Image = global::WindowsFormsApp1.Properties.Resources.pipeBottom;
            this.pipebottom2.Location = new System.Drawing.Point(74, 616);
            this.pipebottom2.Name = "pipebottom2";
            this.pipebottom2.Size = new System.Drawing.Size(202, 306);
            this.pipebottom2.TabIndex = 10;
            this.pipebottom2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.sky1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1279, 791);
            this.Controls.Add(this.pipebottom2);
            this.Controls.Add(this.House);
            this.Controls.Add(this.FloppyBird1);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Name = "Form1";
            this.Text = "BirdGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.House)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FloppyBird1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipebottom2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox FloppyBird1;
        private System.Windows.Forms.PictureBox House;
        private System.Windows.Forms.PictureBox pipebottom2;
    }
}

