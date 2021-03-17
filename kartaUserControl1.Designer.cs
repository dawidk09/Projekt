namespace Projekt
{
    partial class kartaUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kartaUserControl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_podsumowanie = new System.Windows.Forms.TextBox();
            this.tb_podsumowanie_ilosc = new System.Windows.Forms.TextBox();
            this.b_podsumuj = new System.Windows.Forms.Button();
            this.tb_suma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.b_wyczysc_zamowienie = new System.Windows.Forms.Button();
            this.b_zamow = new System.Windows.Forms.Button();
            this.finalizacja1 = new Projekt.Finalizacja();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(217, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(284, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Twoje zamówienie";
            // 
            // tb_podsumowanie
            // 
            this.tb_podsumowanie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tb_podsumowanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_podsumowanie.Location = new System.Drawing.Point(271, 171);
            this.tb_podsumowanie.Multiline = true;
            this.tb_podsumowanie.Name = "tb_podsumowanie";
            this.tb_podsumowanie.ReadOnly = true;
            this.tb_podsumowanie.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_podsumowanie.Size = new System.Drawing.Size(246, 458);
            this.tb_podsumowanie.TabIndex = 2;
            // 
            // tb_podsumowanie_ilosc
            // 
            this.tb_podsumowanie_ilosc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tb_podsumowanie_ilosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_podsumowanie_ilosc.Location = new System.Drawing.Point(523, 171);
            this.tb_podsumowanie_ilosc.Multiline = true;
            this.tb_podsumowanie_ilosc.Name = "tb_podsumowanie_ilosc";
            this.tb_podsumowanie_ilosc.ReadOnly = true;
            this.tb_podsumowanie_ilosc.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_podsumowanie_ilosc.Size = new System.Drawing.Size(60, 458);
            this.tb_podsumowanie_ilosc.TabIndex = 4;
            // 
            // b_podsumuj
            // 
            this.b_podsumuj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.b_podsumuj.Location = new System.Drawing.Point(648, 538);
            this.b_podsumuj.Name = "b_podsumuj";
            this.b_podsumuj.Size = new System.Drawing.Size(133, 41);
            this.b_podsumuj.TabIndex = 5;
            this.b_podsumuj.Text = "Wyświetl";
            this.b_podsumuj.UseVisualStyleBackColor = false;
            this.b_podsumuj.Click += new System.EventHandler(this.b_podsumuj_Click);
            // 
            // tb_suma
            // 
            this.tb_suma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tb_suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_suma.Location = new System.Drawing.Point(432, 635);
            this.tb_suma.Multiline = true;
            this.tb_suma.Name = "tb_suma";
            this.tb_suma.ReadOnly = true;
            this.tb_suma.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_suma.Size = new System.Drawing.Size(151, 42);
            this.tb_suma.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(331, 642);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "W sumie";
            // 
            // b_wyczysc_zamowienie
            // 
            this.b_wyczysc_zamowienie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.b_wyczysc_zamowienie.Location = new System.Drawing.Point(648, 585);
            this.b_wyczysc_zamowienie.Name = "b_wyczysc_zamowienie";
            this.b_wyczysc_zamowienie.Size = new System.Drawing.Size(133, 44);
            this.b_wyczysc_zamowienie.TabIndex = 8;
            this.b_wyczysc_zamowienie.Text = "Wyczyść zamówienie";
            this.b_wyczysc_zamowienie.UseVisualStyleBackColor = false;
            this.b_wyczysc_zamowienie.Click += new System.EventHandler(this.b_wyczysc_zamowienie_Click);
            // 
            // b_zamow
            // 
            this.b_zamow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.b_zamow.Location = new System.Drawing.Point(648, 635);
            this.b_zamow.Name = "b_zamow";
            this.b_zamow.Size = new System.Drawing.Size(133, 41);
            this.b_zamow.TabIndex = 9;
            this.b_zamow.Text = "Zamów";
            this.b_zamow.UseVisualStyleBackColor = false;
            this.b_zamow.Click += new System.EventHandler(this.b_zamow_Click);
            // 
            // finalizacja1
            // 
            this.finalizacja1.BackColor = System.Drawing.Color.Silver;
            this.finalizacja1.ForeColor = System.Drawing.Color.Gray;
            this.finalizacja1.Location = new System.Drawing.Point(-3, 0);
            this.finalizacja1.Name = "finalizacja1";
            this.finalizacja1.Size = new System.Drawing.Size(849, 783);
            this.finalizacja1.TabIndex = 10;
            this.finalizacja1.Visible = false;
            // 
            // kartaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.finalizacja1);
            this.Controls.Add(this.b_zamow);
            this.Controls.Add(this.b_wyczysc_zamowienie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_suma);
            this.Controls.Add(this.b_podsumuj);
            this.Controls.Add(this.tb_podsumowanie_ilosc);
            this.Controls.Add(this.tb_podsumowanie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "kartaUserControl";
            this.Size = new System.Drawing.Size(849, 783);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_podsumowanie;
        private System.Windows.Forms.TextBox tb_podsumowanie_ilosc;
        private System.Windows.Forms.Button b_podsumuj;
        private System.Windows.Forms.TextBox tb_suma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_wyczysc_zamowienie;
        private System.Windows.Forms.Button b_zamow;
        private Finalizacja finalizacja1;
    }
}
