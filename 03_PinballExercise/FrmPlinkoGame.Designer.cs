namespace _03_PinballExercise
{
    partial class FrmPlinkoGame
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlinkoGame));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtResult01 = new System.Windows.Forms.TextBox();
            this.TxtResult02 = new System.Windows.Forms.TextBox();
            this.TxtResult03 = new System.Windows.Forms.TextBox();
            this.TxtResult06 = new System.Windows.Forms.TextBox();
            this.TxtResult05 = new System.Windows.Forms.TextBox();
            this.TxtResult04 = new System.Windows.Forms.TextBox();
            this.TxtResult09 = new System.Windows.Forms.TextBox();
            this.TxtResult08 = new System.Windows.Forms.TextBox();
            this.TxtResult07 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnPlay
            // 
            this.BtnPlay.Location = new System.Drawing.Point(364, 135);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(90, 31);
            this.BtnPlay.TabIndex = 1;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plinko Game";
            // 
            // TxtResult01
            // 
            this.TxtResult01.Location = new System.Drawing.Point(35, 263);
            this.TxtResult01.Name = "TxtResult01";
            this.TxtResult01.Size = new System.Drawing.Size(27, 20);
            this.TxtResult01.TabIndex = 3;
            // 
            // TxtResult02
            // 
            this.TxtResult02.Location = new System.Drawing.Point(68, 263);
            this.TxtResult02.Name = "TxtResult02";
            this.TxtResult02.Size = new System.Drawing.Size(27, 20);
            this.TxtResult02.TabIndex = 4;
            // 
            // TxtResult03
            // 
            this.TxtResult03.Location = new System.Drawing.Point(101, 263);
            this.TxtResult03.Name = "TxtResult03";
            this.TxtResult03.Size = new System.Drawing.Size(27, 20);
            this.TxtResult03.TabIndex = 5;
            // 
            // TxtResult06
            // 
            this.TxtResult06.Location = new System.Drawing.Point(200, 263);
            this.TxtResult06.Name = "TxtResult06";
            this.TxtResult06.Size = new System.Drawing.Size(27, 20);
            this.TxtResult06.TabIndex = 8;
            // 
            // TxtResult05
            // 
            this.TxtResult05.Location = new System.Drawing.Point(167, 263);
            this.TxtResult05.Name = "TxtResult05";
            this.TxtResult05.Size = new System.Drawing.Size(27, 20);
            this.TxtResult05.TabIndex = 7;
            // 
            // TxtResult04
            // 
            this.TxtResult04.Location = new System.Drawing.Point(134, 263);
            this.TxtResult04.Name = "TxtResult04";
            this.TxtResult04.Size = new System.Drawing.Size(27, 20);
            this.TxtResult04.TabIndex = 6;
            // 
            // TxtResult09
            // 
            this.TxtResult09.Location = new System.Drawing.Point(299, 263);
            this.TxtResult09.Name = "TxtResult09";
            this.TxtResult09.Size = new System.Drawing.Size(27, 20);
            this.TxtResult09.TabIndex = 11;
            // 
            // TxtResult08
            // 
            this.TxtResult08.Location = new System.Drawing.Point(266, 263);
            this.TxtResult08.Name = "TxtResult08";
            this.TxtResult08.Size = new System.Drawing.Size(27, 20);
            this.TxtResult08.TabIndex = 10;
            // 
            // TxtResult07
            // 
            this.TxtResult07.Location = new System.Drawing.Point(233, 263);
            this.TxtResult07.Name = "TxtResult07";
            this.TxtResult07.Size = new System.Drawing.Size(27, 20);
            this.TxtResult07.TabIndex = 9;
            // 
            // FrmPlinkoGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 311);
            this.Controls.Add(this.TxtResult09);
            this.Controls.Add(this.TxtResult08);
            this.Controls.Add(this.TxtResult07);
            this.Controls.Add(this.TxtResult06);
            this.Controls.Add(this.TxtResult05);
            this.Controls.Add(this.TxtResult04);
            this.Controls.Add(this.TxtResult03);
            this.Controls.Add(this.TxtResult02);
            this.Controls.Add(this.TxtResult01);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmPlinkoGame";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtResult01;
        private System.Windows.Forms.TextBox TxtResult02;
        private System.Windows.Forms.TextBox TxtResult03;
        private System.Windows.Forms.TextBox TxtResult06;
        private System.Windows.Forms.TextBox TxtResult05;
        private System.Windows.Forms.TextBox TxtResult04;
        private System.Windows.Forms.TextBox TxtResult09;
        private System.Windows.Forms.TextBox TxtResult08;
        private System.Windows.Forms.TextBox TxtResult07;
    }
}

