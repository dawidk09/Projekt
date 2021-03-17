namespace Projekt
{
    partial class Finalizacja
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
            this.label1 = new System.Windows.Forms.Label();
            this.b_karta = new System.Windows.Forms.Button();
            this.b_gotowka = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.b_namiejscu = new System.Windows.Forms.Button();
            this.b_dowoz = new System.Windows.Forms.Button();
            this.b_nawynos = new System.Windows.Forms.Button();
            this.tb_ulica = new System.Windows.Forms.TextBox();
            this.l_ulica = new System.Windows.Forms.Label();
            this.l_numertelefonu = new System.Windows.Forms.Label();
            this.tb_numer = new System.Windows.Forms.TextBox();
            this.l_miasto = new System.Windows.Forms.Label();
            this.tb_miasto = new System.Windows.Forms.TextBox();
            this.b_gotowe = new System.Windows.Forms.Button();
            this.b_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(284, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sposób zapłaty";
            // 
            // b_karta
            // 
            this.b_karta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.b_karta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_karta.ForeColor = System.Drawing.Color.Black;
            this.b_karta.Location = new System.Drawing.Point(281, 70);
            this.b_karta.Name = "b_karta";
            this.b_karta.Size = new System.Drawing.Size(124, 39);
            this.b_karta.TabIndex = 1;
            this.b_karta.Text = "Karta";
            this.b_karta.UseVisualStyleBackColor = false;
            this.b_karta.Click += new System.EventHandler(this.b_karta_Click);
            // 
            // b_gotowka
            // 
            this.b_gotowka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.b_gotowka.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_gotowka.ForeColor = System.Drawing.Color.Black;
            this.b_gotowka.Location = new System.Drawing.Point(402, 70);
            this.b_gotowka.Name = "b_gotowka";
            this.b_gotowka.Size = new System.Drawing.Size(124, 39);
            this.b_gotowka.TabIndex = 2;
            this.b_gotowka.Text = "Gotówka";
            this.b_gotowka.UseVisualStyleBackColor = false;
            this.b_gotowka.Click += new System.EventHandler(this.b_gotowka_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(346, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Odbiór";
            // 
            // b_namiejscu
            // 
            this.b_namiejscu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.b_namiejscu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_namiejscu.ForeColor = System.Drawing.Color.Black;
            this.b_namiejscu.Location = new System.Drawing.Point(158, 177);
            this.b_namiejscu.Name = "b_namiejscu";
            this.b_namiejscu.Size = new System.Drawing.Size(167, 50);
            this.b_namiejscu.TabIndex = 4;
            this.b_namiejscu.Text = "Na miejscu";
            this.b_namiejscu.UseVisualStyleBackColor = false;
            this.b_namiejscu.Click += new System.EventHandler(this.b_namiejscu_Click);
            // 
            // b_dowoz
            // 
            this.b_dowoz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.b_dowoz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_dowoz.ForeColor = System.Drawing.Color.Black;
            this.b_dowoz.Location = new System.Drawing.Point(504, 177);
            this.b_dowoz.Name = "b_dowoz";
            this.b_dowoz.Size = new System.Drawing.Size(167, 50);
            this.b_dowoz.TabIndex = 6;
            this.b_dowoz.Text = "Dowóz";
            this.b_dowoz.UseVisualStyleBackColor = false;
            this.b_dowoz.Click += new System.EventHandler(this.b_dowoz_Click);
            // 
            // b_nawynos
            // 
            this.b_nawynos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.b_nawynos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_nawynos.ForeColor = System.Drawing.Color.Black;
            this.b_nawynos.Location = new System.Drawing.Point(331, 177);
            this.b_nawynos.Name = "b_nawynos";
            this.b_nawynos.Size = new System.Drawing.Size(167, 50);
            this.b_nawynos.TabIndex = 7;
            this.b_nawynos.Text = "Na wynos";
            this.b_nawynos.UseVisualStyleBackColor = false;
            this.b_nawynos.Click += new System.EventHandler(this.b_nawynos_Click);
            // 
            // tb_ulica
            // 
            this.tb_ulica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tb_ulica.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_ulica.Location = new System.Drawing.Point(29, 307);
            this.tb_ulica.Multiline = true;
            this.tb_ulica.Name = "tb_ulica";
            this.tb_ulica.Size = new System.Drawing.Size(791, 48);
            this.tb_ulica.TabIndex = 8;
            this.tb_ulica.Visible = false;
            // 
            // l_ulica
            // 
            this.l_ulica.AutoSize = true;
            this.l_ulica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.l_ulica.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_ulica.ForeColor = System.Drawing.Color.Black;
            this.l_ulica.Location = new System.Drawing.Point(363, 267);
            this.l_ulica.Name = "l_ulica";
            this.l_ulica.Size = new System.Drawing.Size(88, 37);
            this.l_ulica.TabIndex = 9;
            this.l_ulica.Text = "Ulica";
            this.l_ulica.Visible = false;
            // 
            // l_numertelefonu
            // 
            this.l_numertelefonu.AutoSize = true;
            this.l_numertelefonu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.l_numertelefonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_numertelefonu.ForeColor = System.Drawing.Color.Black;
            this.l_numertelefonu.Location = new System.Drawing.Point(290, 367);
            this.l_numertelefonu.Name = "l_numertelefonu";
            this.l_numertelefonu.Size = new System.Drawing.Size(236, 37);
            this.l_numertelefonu.TabIndex = 11;
            this.l_numertelefonu.Text = "Numer telefonu";
            this.l_numertelefonu.Visible = false;
            // 
            // tb_numer
            // 
            this.tb_numer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tb_numer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_numer.Location = new System.Drawing.Point(29, 407);
            this.tb_numer.Multiline = true;
            this.tb_numer.Name = "tb_numer";
            this.tb_numer.Size = new System.Drawing.Size(791, 48);
            this.tb_numer.TabIndex = 10;
            this.tb_numer.Visible = false;
            // 
            // l_miasto
            // 
            this.l_miasto.AutoSize = true;
            this.l_miasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.l_miasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_miasto.ForeColor = System.Drawing.Color.Black;
            this.l_miasto.Location = new System.Drawing.Point(363, 468);
            this.l_miasto.Name = "l_miasto";
            this.l_miasto.Size = new System.Drawing.Size(111, 37);
            this.l_miasto.TabIndex = 13;
            this.l_miasto.Text = "Miasto";
            this.l_miasto.Visible = false;
            // 
            // tb_miasto
            // 
            this.tb_miasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tb_miasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_miasto.Location = new System.Drawing.Point(29, 508);
            this.tb_miasto.Multiline = true;
            this.tb_miasto.Name = "tb_miasto";
            this.tb_miasto.Size = new System.Drawing.Size(791, 48);
            this.tb_miasto.TabIndex = 12;
            this.tb_miasto.Visible = false;
            // 
            // b_gotowe
            // 
            this.b_gotowe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.b_gotowe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_gotowe.ForeColor = System.Drawing.Color.Black;
            this.b_gotowe.Location = new System.Drawing.Point(667, 64);
            this.b_gotowe.Name = "b_gotowe";
            this.b_gotowe.Size = new System.Drawing.Size(167, 50);
            this.b_gotowe.TabIndex = 14;
            this.b_gotowe.Text = "Gotowe";
            this.b_gotowe.UseVisualStyleBackColor = false;
            this.b_gotowe.Click += new System.EventHandler(this.b_gotowe_Click);
            // 
            // b_reset
            // 
            this.b_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.b_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_reset.ForeColor = System.Drawing.Color.Black;
            this.b_reset.Location = new System.Drawing.Point(667, 9);
            this.b_reset.Name = "b_reset";
            this.b_reset.Size = new System.Drawing.Size(167, 50);
            this.b_reset.TabIndex = 15;
            this.b_reset.Text = "Reset";
            this.b_reset.UseVisualStyleBackColor = false;
            this.b_reset.Click += new System.EventHandler(this.b_reset_Click);
            // 
            // Finalizacja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.b_reset);
            this.Controls.Add(this.b_gotowe);
            this.Controls.Add(this.l_miasto);
            this.Controls.Add(this.tb_miasto);
            this.Controls.Add(this.l_numertelefonu);
            this.Controls.Add(this.tb_numer);
            this.Controls.Add(this.l_ulica);
            this.Controls.Add(this.tb_ulica);
            this.Controls.Add(this.b_nawynos);
            this.Controls.Add(this.b_dowoz);
            this.Controls.Add(this.b_namiejscu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.b_gotowka);
            this.Controls.Add(this.b_karta);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Gray;
            this.Name = "Finalizacja";
            this.Size = new System.Drawing.Size(849, 783);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_karta;
        private System.Windows.Forms.Button b_gotowka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_namiejscu;
        private System.Windows.Forms.Button b_dowoz;
        private System.Windows.Forms.Button b_nawynos;
        private System.Windows.Forms.TextBox tb_ulica;
        private System.Windows.Forms.Label l_ulica;
        private System.Windows.Forms.Label l_numertelefonu;
        private System.Windows.Forms.TextBox tb_numer;
        private System.Windows.Forms.Label l_miasto;
        private System.Windows.Forms.TextBox tb_miasto;
        private System.Windows.Forms.Button b_gotowe;
        private System.Windows.Forms.Button b_reset;
    }
}
