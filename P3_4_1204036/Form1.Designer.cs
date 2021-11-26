namespace P3_4_1204036
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.cbJK = new System.Windows.Forms.ComboBox();
            this.dtTglLahir = new System.Windows.Forms.DateTimePicker();
            this.BoxButton = new System.Windows.Forms.GroupBox();
            this.cbPiano = new System.Windows.Forms.CheckBox();
            this.cbDrum = new System.Windows.Forms.CheckBox();
            this.cbVokal = new System.Windows.Forms.CheckBox();
            this.cbKomposer = new System.Windows.Forms.CheckBox();
            this.cbKonduktor = new System.Windows.Forms.CheckBox();
            this.cbSaxophone = new System.Windows.Forms.CheckBox();
            this.cbGitar = new System.Windows.Forms.CheckBox();
            this.cbBiola = new System.Windows.Forms.CheckBox();
            this.RadioButton = new System.Windows.Forms.GroupBox();
            this.rbJadwal4 = new System.Windows.Forms.RadioButton();
            this.rbJadwal3 = new System.Windows.Forms.RadioButton();
            this.rbJadwal1 = new System.Windows.Forms.RadioButton();
            this.rbJadwal2 = new System.Windows.Forms.RadioButton();
            this.tampilkan = new System.Windows.Forms.Button();
            this.selesai = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxButton.SuspendLayout();
            this.RadioButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(212, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama                    :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(212, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Kelamin        :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(212, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tanggal Lahir        :";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(343, 127);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(200, 20);
            this.txtNama.TabIndex = 3;
            // 
            // cbJK
            // 
            this.cbJK.FormattingEnabled = true;
            this.cbJK.Items.AddRange(new object[] {
            "Laki - Laki",
            "Perempuan"});
            this.cbJK.Location = new System.Drawing.Point(343, 165);
            this.cbJK.Name = "cbJK";
            this.cbJK.Size = new System.Drawing.Size(200, 21);
            this.cbJK.TabIndex = 4;
            // 
            // dtTglLahir
            // 
            this.dtTglLahir.Location = new System.Drawing.Point(343, 205);
            this.dtTglLahir.Name = "dtTglLahir";
            this.dtTglLahir.Size = new System.Drawing.Size(200, 20);
            this.dtTglLahir.TabIndex = 5;
            // 
            // BoxButton
            // 
            this.BoxButton.BackColor = System.Drawing.Color.Transparent;
            this.BoxButton.Controls.Add(this.cbPiano);
            this.BoxButton.Controls.Add(this.cbDrum);
            this.BoxButton.Controls.Add(this.cbVokal);
            this.BoxButton.Controls.Add(this.cbKomposer);
            this.BoxButton.Controls.Add(this.cbKonduktor);
            this.BoxButton.Controls.Add(this.cbSaxophone);
            this.BoxButton.Controls.Add(this.cbGitar);
            this.BoxButton.Controls.Add(this.cbBiola);
            this.BoxButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BoxButton.Location = new System.Drawing.Point(54, 265);
            this.BoxButton.Name = "BoxButton";
            this.BoxButton.Size = new System.Drawing.Size(257, 183);
            this.BoxButton.TabIndex = 6;
            this.BoxButton.TabStop = false;
            this.BoxButton.Text = "Pilihan Kelas";
            // 
            // cbPiano
            // 
            this.cbPiano.AutoSize = true;
            this.cbPiano.Location = new System.Drawing.Point(146, 44);
            this.cbPiano.Name = "cbPiano";
            this.cbPiano.Size = new System.Drawing.Size(53, 17);
            this.cbPiano.TabIndex = 7;
            this.cbPiano.Text = "Piano";
            this.cbPiano.UseVisualStyleBackColor = true;
            // 
            // cbDrum
            // 
            this.cbDrum.AutoSize = true;
            this.cbDrum.Location = new System.Drawing.Point(146, 67);
            this.cbDrum.Name = "cbDrum";
            this.cbDrum.Size = new System.Drawing.Size(51, 17);
            this.cbDrum.TabIndex = 6;
            this.cbDrum.Text = "Drum";
            this.cbDrum.UseVisualStyleBackColor = true;
            // 
            // cbVokal
            // 
            this.cbVokal.AutoSize = true;
            this.cbVokal.Location = new System.Drawing.Point(146, 90);
            this.cbVokal.Name = "cbVokal";
            this.cbVokal.Size = new System.Drawing.Size(53, 17);
            this.cbVokal.TabIndex = 5;
            this.cbVokal.Text = "Vokal";
            this.cbVokal.UseVisualStyleBackColor = true;
            // 
            // cbKomposer
            // 
            this.cbKomposer.AutoSize = true;
            this.cbKomposer.Location = new System.Drawing.Point(146, 113);
            this.cbKomposer.Name = "cbKomposer";
            this.cbKomposer.Size = new System.Drawing.Size(73, 17);
            this.cbKomposer.TabIndex = 4;
            this.cbKomposer.Text = "Komposer";
            this.cbKomposer.UseVisualStyleBackColor = true;
            // 
            // cbKonduktor
            // 
            this.cbKonduktor.AutoSize = true;
            this.cbKonduktor.Location = new System.Drawing.Point(22, 113);
            this.cbKonduktor.Name = "cbKonduktor";
            this.cbKonduktor.Size = new System.Drawing.Size(75, 17);
            this.cbKonduktor.TabIndex = 3;
            this.cbKonduktor.Text = "Konduktor";
            this.cbKonduktor.UseVisualStyleBackColor = true;
            // 
            // cbSaxophone
            // 
            this.cbSaxophone.AutoSize = true;
            this.cbSaxophone.Location = new System.Drawing.Point(22, 90);
            this.cbSaxophone.Name = "cbSaxophone";
            this.cbSaxophone.Size = new System.Drawing.Size(80, 17);
            this.cbSaxophone.TabIndex = 2;
            this.cbSaxophone.Text = "Saxophone";
            this.cbSaxophone.UseVisualStyleBackColor = true;
            // 
            // cbGitar
            // 
            this.cbGitar.AutoSize = true;
            this.cbGitar.Location = new System.Drawing.Point(22, 67);
            this.cbGitar.Name = "cbGitar";
            this.cbGitar.Size = new System.Drawing.Size(48, 17);
            this.cbGitar.TabIndex = 1;
            this.cbGitar.Text = "Gitar";
            this.cbGitar.UseVisualStyleBackColor = true;
            // 
            // cbBiola
            // 
            this.cbBiola.AutoSize = true;
            this.cbBiola.Location = new System.Drawing.Point(22, 43);
            this.cbBiola.Name = "cbBiola";
            this.cbBiola.Size = new System.Drawing.Size(49, 17);
            this.cbBiola.TabIndex = 0;
            this.cbBiola.Text = "Biola";
            this.cbBiola.UseVisualStyleBackColor = true;
            // 
            // RadioButton
            // 
            this.RadioButton.BackColor = System.Drawing.Color.Transparent;
            this.RadioButton.Controls.Add(this.rbJadwal4);
            this.RadioButton.Controls.Add(this.rbJadwal3);
            this.RadioButton.Controls.Add(this.rbJadwal1);
            this.RadioButton.Controls.Add(this.rbJadwal2);
            this.RadioButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RadioButton.Location = new System.Drawing.Point(412, 265);
            this.RadioButton.Name = "RadioButton";
            this.RadioButton.Size = new System.Drawing.Size(273, 183);
            this.RadioButton.TabIndex = 7;
            this.RadioButton.TabStop = false;
            this.RadioButton.Text = "Pilihan Jadwal";
            // 
            // rbJadwal4
            // 
            this.rbJadwal4.AutoSize = true;
            this.rbJadwal4.Location = new System.Drawing.Point(12, 145);
            this.rbJadwal4.Name = "rbJadwal4";
            this.rbJadwal4.Size = new System.Drawing.Size(129, 17);
            this.rbJadwal4.TabIndex = 3;
            this.rbJadwal4.TabStop = true;
            this.rbJadwal4.Text = "Minggu, 13.00 - 17.00";
            this.rbJadwal4.UseVisualStyleBackColor = true;
            // 
            // rbJadwal3
            // 
            this.rbJadwal3.AutoSize = true;
            this.rbJadwal3.Location = new System.Drawing.Point(12, 112);
            this.rbJadwal3.Name = "rbJadwal3";
            this.rbJadwal3.Size = new System.Drawing.Size(169, 17);
            this.rbJadwal3.TabIndex = 2;
            this.rbJadwal3.TabStop = true;
            this.rbJadwal3.Text = "Sabtu & Minggu, 09.00 - 11.00";
            this.rbJadwal3.UseMnemonic = false;
            this.rbJadwal3.UseVisualStyleBackColor = true;
            // 
            // rbJadwal1
            // 
            this.rbJadwal1.AutoSize = true;
            this.rbJadwal1.Location = new System.Drawing.Point(12, 42);
            this.rbJadwal1.Name = "rbJadwal1";
            this.rbJadwal1.Size = new System.Drawing.Size(159, 17);
            this.rbJadwal1.TabIndex = 0;
            this.rbJadwal1.TabStop = true;
            this.rbJadwal1.Text = "Senin & Rabu, 14.00 - 16.00";
            this.rbJadwal1.UseMnemonic = false;
            this.rbJadwal1.UseVisualStyleBackColor = true;
            // 
            // rbJadwal2
            // 
            this.rbJadwal2.AutoSize = true;
            this.rbJadwal2.Location = new System.Drawing.Point(12, 79);
            this.rbJadwal2.Name = "rbJadwal2";
            this.rbJadwal2.Size = new System.Drawing.Size(166, 17);
            this.rbJadwal2.TabIndex = 1;
            this.rbJadwal2.TabStop = true;
            this.rbJadwal2.Text = "Selasa & Kamis, 14.00 - 16.00";
            this.rbJadwal2.UseMnemonic = false;
            this.rbJadwal2.UseVisualStyleBackColor = true;
            // 
            // tampilkan
            // 
            this.tampilkan.Location = new System.Drawing.Point(279, 478);
            this.tampilkan.Name = "tampilkan";
            this.tampilkan.Size = new System.Drawing.Size(75, 23);
            this.tampilkan.TabIndex = 8;
            this.tampilkan.Text = "&Tampilkan";
            this.tampilkan.UseVisualStyleBackColor = true;
            this.tampilkan.Click += new System.EventHandler(this.tampilkan_Click);
            // 
            // selesai
            // 
            this.selesai.Location = new System.Drawing.Point(375, 478);
            this.selesai.Name = "selesai";
            this.selesai.Size = new System.Drawing.Size(75, 23);
            this.selesai.TabIndex = 9;
            this.selesai.Text = "&Selesai";
            this.selesai.UseVisualStyleBackColor = true;
            this.selesai.Click += new System.EventHandler(this.selesai_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(151, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(454, 57);
            this.label4.TabIndex = 10;
            this.label4.Text = "FORM PENDAFTARAN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 513);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selesai);
            this.Controls.Add(this.tampilkan);
            this.Controls.Add(this.RadioButton);
            this.Controls.Add(this.BoxButton);
            this.Controls.Add(this.dtTglLahir);
            this.Controls.Add(this.cbJK);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " Astra Music School";
            this.BoxButton.ResumeLayout(false);
            this.BoxButton.PerformLayout();
            this.RadioButton.ResumeLayout(false);
            this.RadioButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.ComboBox cbJK;
        private System.Windows.Forms.DateTimePicker dtTglLahir;
        private System.Windows.Forms.GroupBox BoxButton;
        private System.Windows.Forms.CheckBox cbPiano;
        private System.Windows.Forms.CheckBox cbDrum;
        private System.Windows.Forms.CheckBox cbVokal;
        private System.Windows.Forms.CheckBox cbKomposer;
        private System.Windows.Forms.CheckBox cbKonduktor;
        private System.Windows.Forms.CheckBox cbSaxophone;
        private System.Windows.Forms.CheckBox cbGitar;
        private System.Windows.Forms.CheckBox cbBiola;
        private System.Windows.Forms.GroupBox RadioButton;
        private System.Windows.Forms.RadioButton rbJadwal4;
        private System.Windows.Forms.RadioButton rbJadwal3;
        private System.Windows.Forms.RadioButton rbJadwal1;
        private System.Windows.Forms.RadioButton rbJadwal2;
        private System.Windows.Forms.Button tampilkan;
        private System.Windows.Forms.Button selesai;
        private System.Windows.Forms.Label label4;
    }
}

