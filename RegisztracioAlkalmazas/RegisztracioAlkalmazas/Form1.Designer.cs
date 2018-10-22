namespace RegisztracioAlkalmazas
{
    partial class FormMain
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
            this.lblNev = new System.Windows.Forms.Label();
            this.lblSzulDat = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.dtpSzulDatum = new System.Windows.Forms.DateTimePicker();
            this.lblNem = new System.Windows.Forms.Label();
            this.rbFerfi = new System.Windows.Forms.RadioButton();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.lblKedvencHobbi = new System.Windows.Forms.Label();
            this.lbHobbik = new System.Windows.Forms.ListBox();
            this.lblUjHobbi = new System.Windows.Forms.Label();
            this.tbUjHobbi = new System.Windows.Forms.TextBox();
            this.btnUjHobbiAd = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnBetoltes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNev
            // 
            this.lblNev.AutoSize = true;
            this.lblNev.Location = new System.Drawing.Point(12, 15);
            this.lblNev.Name = "lblNev";
            this.lblNev.Size = new System.Drawing.Size(40, 20);
            this.lblNev.TabIndex = 0;
            this.lblNev.Text = "Név:";
            // 
            // lblSzulDat
            // 
            this.lblSzulDat.AutoSize = true;
            this.lblSzulDat.Location = new System.Drawing.Point(12, 59);
            this.lblSzulDat.Name = "lblSzulDat";
            this.lblSzulDat.Size = new System.Drawing.Size(97, 20);
            this.lblSzulDat.TabIndex = 1;
            this.lblSzulDat.Text = "Szül. dátum:";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(115, 12);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(200, 26);
            this.tbNev.TabIndex = 2;
            // 
            // dtpSzulDatum
            // 
            this.dtpSzulDatum.Location = new System.Drawing.Point(115, 54);
            this.dtpSzulDatum.Name = "dtpSzulDatum";
            this.dtpSzulDatum.Size = new System.Drawing.Size(200, 26);
            this.dtpSzulDatum.TabIndex = 3;
            // 
            // lblNem
            // 
            this.lblNem.AutoSize = true;
            this.lblNem.Location = new System.Drawing.Point(12, 103);
            this.lblNem.Name = "lblNem";
            this.lblNem.Size = new System.Drawing.Size(46, 20);
            this.lblNem.TabIndex = 4;
            this.lblNem.Text = "Nem:";
            // 
            // rbFerfi
            // 
            this.rbFerfi.AutoSize = true;
            this.rbFerfi.Location = new System.Drawing.Point(115, 101);
            this.rbFerfi.Name = "rbFerfi";
            this.rbFerfi.Size = new System.Drawing.Size(44, 24);
            this.rbFerfi.TabIndex = 5;
            this.rbFerfi.TabStop = true;
            this.rbFerfi.Text = "F";
            this.rbFerfi.UseVisualStyleBackColor = true;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(180, 101);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(45, 24);
            this.rbNo.TabIndex = 6;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "N";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // lblKedvencHobbi
            // 
            this.lblKedvencHobbi.AutoSize = true;
            this.lblKedvencHobbi.Location = new System.Drawing.Point(332, 15);
            this.lblKedvencHobbi.Name = "lblKedvencHobbi";
            this.lblKedvencHobbi.Size = new System.Drawing.Size(117, 20);
            this.lblKedvencHobbi.TabIndex = 7;
            this.lblKedvencHobbi.Text = "Kedvenc hobbi:";
            // 
            // lbHobbik
            // 
            this.lbHobbik.FormattingEnabled = true;
            this.lbHobbik.ItemHeight = 20;
            this.lbHobbik.Location = new System.Drawing.Point(349, 41);
            this.lbHobbik.Name = "lbHobbik";
            this.lbHobbik.Size = new System.Drawing.Size(117, 144);
            this.lbHobbik.TabIndex = 8;
            // 
            // lblUjHobbi
            // 
            this.lblUjHobbi.AutoSize = true;
            this.lblUjHobbi.Location = new System.Drawing.Point(264, 208);
            this.lblUjHobbi.Name = "lblUjHobbi";
            this.lblUjHobbi.Size = new System.Drawing.Size(71, 20);
            this.lblUjHobbi.TabIndex = 9;
            this.lblUjHobbi.Text = "Új hobbi:";
            // 
            // tbUjHobbi
            // 
            this.tbUjHobbi.Location = new System.Drawing.Point(341, 205);
            this.tbUjHobbi.Name = "tbUjHobbi";
            this.tbUjHobbi.Size = new System.Drawing.Size(125, 26);
            this.tbUjHobbi.TabIndex = 10;
            // 
            // btnUjHobbiAd
            // 
            this.btnUjHobbiAd.AutoSize = true;
            this.btnUjHobbiAd.Location = new System.Drawing.Point(366, 237);
            this.btnUjHobbiAd.Name = "btnUjHobbiAd";
            this.btnUjHobbiAd.Size = new System.Drawing.Size(83, 30);
            this.btnUjHobbiAd.TabIndex = 11;
            this.btnUjHobbiAd.Text = "Hozzáad";
            this.btnUjHobbiAd.UseVisualStyleBackColor = true;
            this.btnUjHobbiAd.Click += new System.EventHandler(this.btnUjHobbiAd_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.AutoSize = true;
            this.btnMentes.Location = new System.Drawing.Point(229, 338);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(75, 30);
            this.btnMentes.TabIndex = 12;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // btnBetoltes
            // 
            this.btnBetoltes.AutoSize = true;
            this.btnBetoltes.Location = new System.Drawing.Point(366, 338);
            this.btnBetoltes.Name = "btnBetoltes";
            this.btnBetoltes.Size = new System.Drawing.Size(78, 30);
            this.btnBetoltes.TabIndex = 13;
            this.btnBetoltes.Text = "Betöltés";
            this.btnBetoltes.UseVisualStyleBackColor = true;
            this.btnBetoltes.Click += new System.EventHandler(this.btnBetoltes_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 444);
            this.Controls.Add(this.btnBetoltes);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnUjHobbiAd);
            this.Controls.Add(this.tbUjHobbi);
            this.Controls.Add(this.lblUjHobbi);
            this.Controls.Add(this.lbHobbik);
            this.Controls.Add(this.lblKedvencHobbi);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.rbFerfi);
            this.Controls.Add(this.lblNem);
            this.Controls.Add(this.dtpSzulDatum);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.lblSzulDat);
            this.Controls.Add(this.lblNev);
            this.Name = "FormMain";
            this.Text = "Regisztráció Alkalmazás";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNev;
        private System.Windows.Forms.Label lblSzulDat;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.DateTimePicker dtpSzulDatum;
        private System.Windows.Forms.Label lblNem;
        private System.Windows.Forms.RadioButton rbFerfi;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.Label lblKedvencHobbi;
        private System.Windows.Forms.ListBox lbHobbik;
        private System.Windows.Forms.Label lblUjHobbi;
        private System.Windows.Forms.TextBox tbUjHobbi;
        private System.Windows.Forms.Button btnUjHobbiAd;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnBetoltes;
    }
}

