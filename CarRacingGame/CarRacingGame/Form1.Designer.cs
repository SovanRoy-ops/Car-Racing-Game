
namespace CarRacingGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.car = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.over = new System.Windows.Forms.Label();
            this.silver1 = new System.Windows.Forms.PictureBox();
            this.bronze2 = new System.Windows.Forms.PictureBox();
            this.silver2 = new System.Windows.Forms.PictureBox();
            this.gold1 = new System.Windows.Forms.PictureBox();
            this.bronze1 = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silver1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bronze2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.silver2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gold1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bronze1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pictureBox6, "pictureBox6");
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pictureBox7, "pictureBox7");
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // car
            // 
            resources.ApplyResources(this.car, "car");
            this.car.Name = "car";
            this.car.TabStop = false;
            // 
            // enemy1
            // 
            resources.ApplyResources(this.enemy1, "enemy1");
            this.enemy1.Name = "enemy1";
            this.enemy1.TabStop = false;
            this.enemy1.Click += new System.EventHandler(this.enemy1_Click);
            // 
            // enemy2
            // 
            resources.ApplyResources(this.enemy2, "enemy2");
            this.enemy2.Name = "enemy2";
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            resources.ApplyResources(this.enemy3, "enemy3");
            this.enemy3.Name = "enemy3";
            this.enemy3.TabStop = false;
            // 
            // over
            // 
            resources.ApplyResources(this.over, "over");
            this.over.ForeColor = System.Drawing.Color.Red;
            this.over.Name = "over";
            this.over.Click += new System.EventHandler(this.label1_Click);
            // 
            // silver1
            // 
            resources.ApplyResources(this.silver1, "silver1");
            this.silver1.Name = "silver1";
            this.silver1.TabStop = false;
            // 
            // bronze2
            // 
            resources.ApplyResources(this.bronze2, "bronze2");
            this.bronze2.Name = "bronze2";
            this.bronze2.TabStop = false;
            // 
            // silver2
            // 
            resources.ApplyResources(this.silver2, "silver2");
            this.silver2.Name = "silver2";
            this.silver2.TabStop = false;
            // 
            // gold1
            // 
            resources.ApplyResources(this.gold1, "gold1");
            this.gold1.Name = "gold1";
            this.gold1.TabStop = false;
            // 
            // bronze1
            // 
            resources.ApplyResources(this.bronze1, "bronze1");
            this.bronze1.Name = "bronze1";
            this.bronze1.TabStop = false;
            // 
            // score
            // 
            resources.ApplyResources(this.score, "score");
            this.score.ForeColor = System.Drawing.Color.GreenYellow;
            this.score.Name = "score";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.score);
            this.Controls.Add(this.bronze2);
            this.Controls.Add(this.silver2);
            this.Controls.Add(this.gold1);
            this.Controls.Add(this.bronze1);
            this.Controls.Add(this.silver1);
            this.Controls.Add(this.over);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silver1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bronze2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.silver2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gold1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bronze1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.Label over;
        private System.Windows.Forms.PictureBox silver1;
        private System.Windows.Forms.PictureBox bronze2;
        private System.Windows.Forms.PictureBox silver2;
        private System.Windows.Forms.PictureBox gold1;
        private System.Windows.Forms.PictureBox bronze1;
        private System.Windows.Forms.Label score;
    }
}

