
namespace Funnybird
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
            this.bird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Score = new System.Windows.Forms.Label();
            this.pipedown = new System.Windows.Forms.PictureBox();
            this.pipeup = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).BeginInit();
            this.SuspendLayout();
            // 
            // bird
            // 
            this.bird.Image = global::Funnybird.Properties.Resources.bird;
            this.bird.Location = new System.Drawing.Point(106, 267);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(106, 95);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            this.bird.Click += new System.EventHandler(this.Form1_Load);
            // 
            // ground
            // 
            this.ground.Image = global::Funnybird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-2, 659);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1126, 106);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.Gametimer);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.SystemColors.Info;
            this.Score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Score.Font = new System.Drawing.Font("Ravie", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.ForeColor = System.Drawing.Color.OrangeRed;
            this.Score.Location = new System.Drawing.Point(28, 685);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(186, 82);
            this.Score.TabIndex = 2;
            this.Score.Text = "Score: 0\r\n\r\n";
            // 
            // pipedown
            // 
            this.pipedown.Image = global::Funnybird.Properties.Resources.pipedown;
            this.pipedown.Location = new System.Drawing.Point(805, -1);
            this.pipedown.Name = "pipedown";
            this.pipedown.Size = new System.Drawing.Size(217, 253);
            this.pipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipedown.TabIndex = 3;
            this.pipedown.TabStop = false;
            // 
            // pipeup
            // 
            this.pipeup.Image = global::Funnybird.Properties.Resources.pipe;
            this.pipeup.Location = new System.Drawing.Point(507, 432);
            this.pipeup.Name = "pipeup";
            this.pipeup.Size = new System.Drawing.Size(217, 232);
            this.pipeup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeup.TabIndex = 4;
            this.pipeup.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1121, 762);
            this.Controls.Add(this.pipeup);
            this.Controls.Add(this.pipedown);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.bird);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyisUp);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipedown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.PictureBox pipedown;
        private System.Windows.Forms.PictureBox pipeup;
    }
}

