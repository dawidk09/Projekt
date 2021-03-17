namespace Projekt
{
    partial class oNas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oNas));
            this.b_sprawdz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_menu_lewe = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_kwota = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu_lewe)).BeginInit();
            this.SuspendLayout();
            // 
            // b_sprawdz
            // 
            this.b_sprawdz.BackColor = System.Drawing.Color.Red;
            this.b_sprawdz.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_sprawdz.Location = new System.Drawing.Point(531, 142);
            this.b_sprawdz.Name = "b_sprawdz";
            this.b_sprawdz.Size = new System.Drawing.Size(198, 45);
            this.b_sprawdz.TabIndex = 2;
            this.b_sprawdz.Text = "SPRAWDŹ";
            this.b_sprawdz.UseVisualStyleBackColor = false;
            this.b_sprawdz.Click += new System.EventHandler(this.b_sprawdz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(134, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Promocje";
            // 
            // pb_menu_lewe
            // 
            this.pb_menu_lewe.Image = ((System.Drawing.Image)(resources.GetObject("pb_menu_lewe.Image")));
            this.pb_menu_lewe.Location = new System.Drawing.Point(3, -51);
            this.pb_menu_lewe.Name = "pb_menu_lewe";
            this.pb_menu_lewe.Size = new System.Drawing.Size(408, 831);
            this.pb_menu_lewe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_menu_lewe.TabIndex = 4;
            this.pb_menu_lewe.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(54, 142);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 467);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Przy zakupach za minimum 50 zł otrzymasz 10% zniżki !!! ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(457, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sprawdź ile zarobiliśmy";
            // 
            // tb_kwota
            // 
            this.tb_kwota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tb_kwota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_kwota.Location = new System.Drawing.Point(457, 193);
            this.tb_kwota.Multiline = true;
            this.tb_kwota.Name = "tb_kwota";
            this.tb_kwota.Size = new System.Drawing.Size(351, 61);
            this.tb_kwota.TabIndex = 8;
            this.tb_kwota.Visible = false;
            // 
            // oNas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.tb_kwota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_menu_lewe);
            this.Controls.Add(this.b_sprawdz);
            this.Name = "oNas";
            this.Size = new System.Drawing.Size(849, 783);
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu_lewe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b_sprawdz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_menu_lewe;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_kwota;
    }
}
