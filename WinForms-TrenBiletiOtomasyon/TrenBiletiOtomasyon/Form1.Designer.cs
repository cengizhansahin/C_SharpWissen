namespace TrenBiletiOtomasyon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnOlustur = new Button();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            text_koltukSayisi = new TextBox();
            text_guzergahFiyati = new TextBox();
            text_guzergahAdi = new TextBox();
            groupBox2 = new GroupBox();
            label6 = new Label();
            btnIade = new Button();
            btnSat = new Button();
            rBtnYetiskin = new RadioButton();
            rBtnInrimli = new RadioButton();
            groupBox3 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            text_toplamCiro = new TextBox();
            text_bosKoltukSayisi = new TextBox();
            listBox1 = new ListBox();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnOlustur);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(text_koltukSayisi);
            groupBox1.Controls.Add(text_guzergahFiyati);
            groupBox1.Controls.Add(text_guzergahAdi);
            groupBox1.Location = new Point(12, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 177);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Güzergah Oluşturma";
            // 
            // btnOlustur
            // 
            btnOlustur.BackColor = SystemColors.ActiveCaption;
            btnOlustur.Location = new Point(6, 135);
            btnOlustur.Name = "btnOlustur";
            btnOlustur.Size = new Size(125, 29);
            btnOlustur.TabIndex = 2;
            btnOlustur.Text = "OLUŞTUR";
            btnOlustur.UseVisualStyleBackColor = false;
            btnOlustur.Click += btnOlustur_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 95);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 1;
            label2.Text = "Koltuk Sayısı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 62);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 1;
            label3.Text = "Güzergah Fiyatı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 29);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 1;
            label1.Text = "Güzergah Adı";
            // 
            // text_koltukSayisi
            // 
            text_koltukSayisi.Location = new Point(6, 92);
            text_koltukSayisi.Name = "text_koltukSayisi";
            text_koltukSayisi.Size = new Size(125, 27);
            text_koltukSayisi.TabIndex = 0;
            // 
            // text_guzergahFiyati
            // 
            text_guzergahFiyati.Location = new Point(6, 59);
            text_guzergahFiyati.Name = "text_guzergahFiyati";
            text_guzergahFiyati.Size = new Size(125, 27);
            text_guzergahFiyati.TabIndex = 0;
            // 
            // text_guzergahAdi
            // 
            text_guzergahAdi.Location = new Point(6, 26);
            text_guzergahAdi.Name = "text_guzergahAdi";
            text_guzergahAdi.Size = new Size(125, 27);
            text_guzergahAdi.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnIade);
            groupBox2.Controls.Add(btnSat);
            groupBox2.Controls.Add(rBtnYetiskin);
            groupBox2.Controls.Add(rBtnInrimli);
            groupBox2.Location = new Point(12, 251);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(267, 137);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Bilet Satış";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 28);
            label6.Name = "label6";
            label6.Size = new Size(157, 20);
            label6.TabIndex = 6;
            label6.Text = "(18 Yaşından Küçükler)";
            // 
            // btnIade
            // 
            btnIade.BackColor = SystemColors.ActiveCaption;
            btnIade.Location = new Point(125, 93);
            btnIade.Name = "btnIade";
            btnIade.Size = new Size(94, 29);
            btnIade.TabIndex = 5;
            btnIade.Text = "İADE";
            btnIade.UseVisualStyleBackColor = false;
            btnIade.Click += btnIade_Click;
            // 
            // btnSat
            // 
            btnSat.BackColor = SystemColors.ActiveCaption;
            btnSat.Location = new Point(8, 93);
            btnSat.Name = "btnSat";
            btnSat.Size = new Size(94, 29);
            btnSat.TabIndex = 5;
            btnSat.Text = "SAT";
            btnSat.UseVisualStyleBackColor = false;
            btnSat.Click += btnSat_Click;
            // 
            // rBtnYetiskin
            // 
            rBtnYetiskin.AutoSize = true;
            rBtnYetiskin.Location = new Point(8, 63);
            rBtnYetiskin.Name = "rBtnYetiskin";
            rBtnYetiskin.Size = new Size(79, 24);
            rBtnYetiskin.TabIndex = 4;
            rBtnYetiskin.TabStop = true;
            rBtnYetiskin.Text = "Yetişkin";
            rBtnYetiskin.UseVisualStyleBackColor = true;
            // 
            // rBtnInrimli
            // 
            rBtnInrimli.AutoSize = true;
            rBtnInrimli.Location = new Point(8, 26);
            rBtnInrimli.Name = "rBtnInrimli";
            rBtnInrimli.Size = new Size(85, 24);
            rBtnInrimli.TabIndex = 4;
            rBtnInrimli.TabStop = true;
            rBtnInrimli.Text = "İndirimli";
            rBtnInrimli.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(text_toplamCiro);
            groupBox3.Controls.Add(text_bosKoltukSayisi);
            groupBox3.Location = new Point(12, 438);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(267, 104);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Finans";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(139, 71);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 6;
            label5.Text = "Toplam Ciro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(139, 29);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 6;
            label4.Text = "Boş Koltuk Sayısı";
            // 
            // text_toplamCiro
            // 
            text_toplamCiro.Enabled = false;
            text_toplamCiro.Location = new Point(8, 68);
            text_toplamCiro.Name = "text_toplamCiro";
            text_toplamCiro.Size = new Size(125, 27);
            text_toplamCiro.TabIndex = 5;
            // 
            // text_bosKoltukSayisi
            // 
            text_bosKoltukSayisi.Enabled = false;
            text_bosKoltukSayisi.Location = new Point(8, 26);
            text_bosKoltukSayisi.Name = "text_bosKoltukSayisi";
            text_bosKoltukSayisi.Size = new Size(125, 27);
            text_bosKoltukSayisi.TabIndex = 5;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(19, 26);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(534, 484);
            listBox1.TabIndex = 5;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(listBox1);
            groupBox4.Location = new Point(299, 15);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(559, 527);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Bilet Listesi";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(989, 554);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox text_guzergahFiyati;
        private TextBox text_guzergahAdi;
        private Button btnOlustur;
        private Label label3;
        private TextBox text_koltukSayisi;
        private GroupBox groupBox2;
        private Button btnIade;
        private Button btnSat;
        private RadioButton rBtnInrimli;
        private GroupBox groupBox3;
        private TextBox text_toplamCiro;
        private TextBox text_bosKoltukSayisi;
        private Label label5;
        private Label label4;
        private RadioButton rBtnYetiskin;
        private Label label6;
        private ListBox listBox1;
        private GroupBox groupBox4;
    }
}
