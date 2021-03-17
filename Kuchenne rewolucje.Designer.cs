namespace Projekt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_szary_gorny = new System.Windows.Forms.Panel();
            this.l_nazwa_firmy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_start = new System.Windows.Forms.PictureBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.b_potrawy = new System.Windows.Forms.Button();
            this.b_napoje = new System.Windows.Forms.Button();
            this.b_twojaKarta = new System.Windows.Forms.Button();
            this.b_oNas = new System.Windows.Forms.Button();
            this.panel_do_guzika2 = new System.Windows.Forms.Panel();
            this.panel_do_guzika3 = new System.Windows.Forms.Panel();
            this.panel_do_guzika4 = new System.Windows.Forms.Panel();
            this.panel_do_guzika5 = new System.Windows.Forms.Panel();
            this.b_start = new System.Windows.Forms.Button();
            this.panel_do_guzika1 = new System.Windows.Forms.Panel();
            this.panel_szary_lewy = new System.Windows.Forms.Panel();
            this.oNas1 = new Projekt.oNas();
            this.kartaUserControl1 = new Projekt.kartaUserControl();
            this.potrawyUserControl = new Projekt.potrawyUserControl();
            this.napojeUserControl = new Projekt.napojeUserControl();
            this.panel_szary_gorny.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.panel_szary_lewy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_szary_gorny
            // 
            this.panel_szary_gorny.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_szary_gorny.Controls.Add(this.l_nazwa_firmy);
            this.panel_szary_gorny.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_szary_gorny.Location = new System.Drawing.Point(200, 0);
            this.panel_szary_gorny.Name = "panel_szary_gorny";
            this.panel_szary_gorny.Size = new System.Drawing.Size(916, 45);
            this.panel_szary_gorny.TabIndex = 1;
            // 
            // l_nazwa_firmy
            // 
            this.l_nazwa_firmy.AutoSize = true;
            this.l_nazwa_firmy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_nazwa_firmy.ForeColor = System.Drawing.Color.Silver;
            this.l_nazwa_firmy.Location = new System.Drawing.Point(359, 9);
            this.l_nazwa_firmy.Name = "l_nazwa_firmy";
            this.l_nazwa_firmy.Size = new System.Drawing.Size(138, 25);
            this.l_nazwa_firmy.TabIndex = 0;
            this.l_nazwa_firmy.Text = "Restauracja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(336, 667);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(625, 108);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zapraszamy !";
            // 
            // pb_start
            // 
            this.pb_start.Image = ((System.Drawing.Image)(resources.GetObject("pb_start.Image")));
            this.pb_start.Location = new System.Drawing.Point(206, 51);
            this.pb_start.Name = "pb_start";
            this.pb_start.Size = new System.Drawing.Size(900, 577);
            this.pb_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_start.TabIndex = 4;
            this.pb_start.TabStop = false;
            // 
            // pb_logo
            // 
            this.pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo.Image")));
            this.pb_logo.Location = new System.Drawing.Point(27, 12);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(125, 81);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 2;
            this.pb_logo.TabStop = false;
            // 
            // b_potrawy
            // 
            this.b_potrawy.FlatAppearance.BorderSize = 0;
            this.b_potrawy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_potrawy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_potrawy.ForeColor = System.Drawing.Color.Silver;
            this.b_potrawy.Location = new System.Drawing.Point(3, 188);
            this.b_potrawy.Name = "b_potrawy";
            this.b_potrawy.Size = new System.Drawing.Size(197, 44);
            this.b_potrawy.TabIndex = 3;
            this.b_potrawy.Text = "Potrawy";
            this.b_potrawy.UseVisualStyleBackColor = true;
            this.b_potrawy.Click += new System.EventHandler(this.b_potrawy_Click);
            // 
            // b_napoje
            // 
            this.b_napoje.FlatAppearance.BorderSize = 0;
            this.b_napoje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_napoje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_napoje.ForeColor = System.Drawing.Color.Silver;
            this.b_napoje.Location = new System.Drawing.Point(3, 238);
            this.b_napoje.Name = "b_napoje";
            this.b_napoje.Size = new System.Drawing.Size(197, 44);
            this.b_napoje.TabIndex = 4;
            this.b_napoje.Text = "Napoje";
            this.b_napoje.UseVisualStyleBackColor = true;
            this.b_napoje.Click += new System.EventHandler(this.b_napoje_Click);
            // 
            // b_twojaKarta
            // 
            this.b_twojaKarta.FlatAppearance.BorderSize = 0;
            this.b_twojaKarta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_twojaKarta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_twojaKarta.ForeColor = System.Drawing.Color.Silver;
            this.b_twojaKarta.Location = new System.Drawing.Point(3, 288);
            this.b_twojaKarta.Name = "b_twojaKarta";
            this.b_twojaKarta.Size = new System.Drawing.Size(197, 44);
            this.b_twojaKarta.TabIndex = 5;
            this.b_twojaKarta.Text = "Twoja karta";
            this.b_twojaKarta.UseVisualStyleBackColor = true;
            this.b_twojaKarta.Click += new System.EventHandler(this.b_twojaKarta_Click);
            // 
            // b_oNas
            // 
            this.b_oNas.FlatAppearance.BorderSize = 0;
            this.b_oNas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_oNas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_oNas.ForeColor = System.Drawing.Color.Silver;
            this.b_oNas.Location = new System.Drawing.Point(3, 338);
            this.b_oNas.Name = "b_oNas";
            this.b_oNas.Size = new System.Drawing.Size(197, 44);
            this.b_oNas.TabIndex = 6;
            this.b_oNas.Text = "O nas";
            this.b_oNas.UseVisualStyleBackColor = true;
            this.b_oNas.Click += new System.EventHandler(this.b_oNas_Click);
            // 
            // panel_do_guzika2
            // 
            this.panel_do_guzika2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_do_guzika2.Location = new System.Drawing.Point(3, 188);
            this.panel_do_guzika2.Name = "panel_do_guzika2";
            this.panel_do_guzika2.Size = new System.Drawing.Size(10, 46);
            this.panel_do_guzika2.TabIndex = 8;
            // 
            // panel_do_guzika3
            // 
            this.panel_do_guzika3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_do_guzika3.Location = new System.Drawing.Point(3, 238);
            this.panel_do_guzika3.Name = "panel_do_guzika3";
            this.panel_do_guzika3.Size = new System.Drawing.Size(10, 46);
            this.panel_do_guzika3.TabIndex = 9;
            // 
            // panel_do_guzika4
            // 
            this.panel_do_guzika4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_do_guzika4.Location = new System.Drawing.Point(3, 288);
            this.panel_do_guzika4.Name = "panel_do_guzika4";
            this.panel_do_guzika4.Size = new System.Drawing.Size(10, 46);
            this.panel_do_guzika4.TabIndex = 10;
            // 
            // panel_do_guzika5
            // 
            this.panel_do_guzika5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_do_guzika5.Location = new System.Drawing.Point(3, 338);
            this.panel_do_guzika5.Name = "panel_do_guzika5";
            this.panel_do_guzika5.Size = new System.Drawing.Size(10, 46);
            this.panel_do_guzika5.TabIndex = 11;
            // 
            // b_start
            // 
            this.b_start.FlatAppearance.BorderSize = 0;
            this.b_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_start.ForeColor = System.Drawing.Color.Silver;
            this.b_start.Location = new System.Drawing.Point(3, 138);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(197, 44);
            this.b_start.TabIndex = 13;
            this.b_start.Text = "Start";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // panel_do_guzika1
            // 
            this.panel_do_guzika1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel_do_guzika1.Location = new System.Drawing.Point(3, 138);
            this.panel_do_guzika1.Name = "panel_do_guzika1";
            this.panel_do_guzika1.Size = new System.Drawing.Size(10, 46);
            this.panel_do_guzika1.TabIndex = 9;
            // 
            // panel_szary_lewy
            // 
            this.panel_szary_lewy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_szary_lewy.Controls.Add(this.panel_do_guzika1);
            this.panel_szary_lewy.Controls.Add(this.b_start);
            this.panel_szary_lewy.Controls.Add(this.panel_do_guzika5);
            this.panel_szary_lewy.Controls.Add(this.panel_do_guzika4);
            this.panel_szary_lewy.Controls.Add(this.panel_do_guzika3);
            this.panel_szary_lewy.Controls.Add(this.panel_do_guzika2);
            this.panel_szary_lewy.Controls.Add(this.b_oNas);
            this.panel_szary_lewy.Controls.Add(this.b_twojaKarta);
            this.panel_szary_lewy.Controls.Add(this.b_napoje);
            this.panel_szary_lewy.Controls.Add(this.b_potrawy);
            this.panel_szary_lewy.Controls.Add(this.pb_logo);
            this.panel_szary_lewy.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_szary_lewy.Location = new System.Drawing.Point(0, 0);
            this.panel_szary_lewy.Name = "panel_szary_lewy";
            this.panel_szary_lewy.Size = new System.Drawing.Size(200, 863);
            this.panel_szary_lewy.TabIndex = 0;
            // 
            // oNas1
            // 
            this.oNas1.BackColor = System.Drawing.Color.Silver;
            this.oNas1.Location = new System.Drawing.Point(200, 51);
            this.oNas1.Name = "oNas1";
            this.oNas1.Size = new System.Drawing.Size(849, 783);
            this.oNas1.TabIndex = 8;
            this.oNas1.Visible = false;
            // 
            // kartaUserControl1
            // 
            this.kartaUserControl1.BackColor = System.Drawing.Color.Silver;
            this.kartaUserControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kartaUserControl1.Location = new System.Drawing.Point(206, 51);
            this.kartaUserControl1.Name = "kartaUserControl1";
            this.kartaUserControl1.Size = new System.Drawing.Size(849, 783);
            this.kartaUserControl1.TabIndex = 7;
            this.kartaUserControl1.Visible = false;
            // 
            // potrawyUserControl
            // 
            this.potrawyUserControl.BackColor = System.Drawing.Color.Silver;
            this.potrawyUserControl.Location = new System.Drawing.Point(206, 51);
            this.potrawyUserControl.Name = "potrawyUserControl";
            this.potrawyUserControl.Size = new System.Drawing.Size(849, 783);
            this.potrawyUserControl.TabIndex = 6;
            this.potrawyUserControl.Visible = false;
            // 
            // napojeUserControl
            // 
            this.napojeUserControl.AutoScroll = true;
            this.napojeUserControl.BackColor = System.Drawing.Color.Silver;
            this.napojeUserControl.Location = new System.Drawing.Point(200, 51);
            this.napojeUserControl.Name = "napojeUserControl";
            this.napojeUserControl.Size = new System.Drawing.Size(849, 783);
            this.napojeUserControl.TabIndex = 5;
            this.napojeUserControl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1116, 863);
            this.Controls.Add(this.oNas1);
            this.Controls.Add(this.kartaUserControl1);
            this.Controls.Add(this.potrawyUserControl);
            this.Controls.Add(this.napojeUserControl);
            this.Controls.Add(this.pb_start);
            this.Controls.Add(this.panel_szary_gorny);
            this.Controls.Add(this.panel_szary_lewy);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Kuchenne rewolucje";
            this.panel_szary_gorny.ResumeLayout(false);
            this.panel_szary_gorny.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.panel_szary_lewy.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_szary_gorny;
        private System.Windows.Forms.Label l_nazwa_firmy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_start;
        private napojeUserControl napojeUserControl;
        private potrawyUserControl potrawyUserControl;
        private kartaUserControl kartaUserControl1;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Button b_potrawy;
        private System.Windows.Forms.Button b_napoje;
        private System.Windows.Forms.Button b_twojaKarta;
        private System.Windows.Forms.Button b_oNas;
        private System.Windows.Forms.Panel panel_do_guzika2;
        private System.Windows.Forms.Panel panel_do_guzika3;
        private System.Windows.Forms.Panel panel_do_guzika4;
        private System.Windows.Forms.Panel panel_do_guzika5;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Panel panel_do_guzika1;
        private System.Windows.Forms.Panel panel_szary_lewy;
        private oNas oNas1;
    }
}

