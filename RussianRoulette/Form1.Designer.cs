using System.Windows.Forms;

namespace RussianRoulette
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
            this.ShootHead = new System.Windows.Forms.Button();
            this.Spin = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.ShootAway = new System.Windows.Forms.Button();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.LoadGunPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoadGunPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ShootHead
            // 
            this.ShootHead.Location = new System.Drawing.Point(5, 250);
            this.ShootHead.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.ShootHead.Name = "ShootHead";
            this.ShootHead.Size = new System.Drawing.Size(112, 25);
            this.ShootHead.TabIndex = 0;
            this.ShootHead.Text = "Shoot At Head";
            this.ShootHead.UseVisualStyleBackColor = true;
            this.ShootHead.Click += new System.EventHandler(this.ShootHead_Click);
            // 
            // Spin
            // 
            this.Spin.Location = new System.Drawing.Point(5, 212);
            this.Spin.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(112, 26);
            this.Spin.TabIndex = 1;
            this.Spin.Text = "Spin";
            this.Spin.UseVisualStyleBackColor = true;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(5, 174);
            this.Load.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(112, 26);
            this.Load.TabIndex = 2;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // ShootAway
            // 
            this.ShootAway.Location = new System.Drawing.Point(5, 287);
            this.ShootAway.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.ShootAway.Name = "ShootAway";
            this.ShootAway.Size = new System.Drawing.Size(112, 26);
            this.ShootAway.TabIndex = 3;
            this.ShootAway.Text = "Shoot Away";
            this.ShootAway.UseVisualStyleBackColor = true;
            this.ShootAway.Click += new System.EventHandler(this.ShootAway_Click);
            // 
            // PlayAgain
            // 
            this.PlayAgain.Location = new System.Drawing.Point(5, 1);
            this.PlayAgain.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(112, 40);
            this.PlayAgain.TabIndex = 7;
            this.PlayAgain.Text = "Play Again";
            this.PlayAgain.UseVisualStyleBackColor = true;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // LoadGunPicture
            // 
            this.LoadGunPicture.Image = global::RussianRoulette.Properties.Resources.z1;
            this.LoadGunPicture.Location = new System.Drawing.Point(1070, 166);
            this.LoadGunPicture.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.LoadGunPicture.Name = "LoadGunPicture";
            this.LoadGunPicture.Size = new System.Drawing.Size(181, 134);
            this.LoadGunPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoadGunPicture.TabIndex = 10;
            this.LoadGunPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RussianRoulette.Resource1._09;
            this.ClientSize = new System.Drawing.Size(1288, 505);
            this.Controls.Add(this.LoadGunPicture);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.ShootAway);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.ShootHead);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.LoadGunPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShootHead;
        private System.Windows.Forms.Button Spin;
        private new System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button ShootAway;
        private object form1;

        public object GetForm1()
        {
            return form1;
        }

        private void SetForm1(object value)
        {
            form1 = value;
        }

        public Form1(Button load)
        {
            Load = load;
        }
        private Button PlayAgain;
        private PictureBox LoadGunPicture;
    }
}

