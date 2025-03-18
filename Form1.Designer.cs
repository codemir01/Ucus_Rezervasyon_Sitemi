namespace Proje18._03v2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            grpBoxUcus = new GroupBox();
            mskedTarih = new MaskedTextBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            grpBoxYolcu = new GroupBox();
            textBox1 = new TextBox();
            button1 = new Button();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            listBox1 = new ListBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            grpBoxUcus.SuspendLayout();
            grpBoxYolcu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grpBoxUcus
            // 
            grpBoxUcus.Controls.Add(mskedTarih);
            grpBoxUcus.Controls.Add(label3);
            grpBoxUcus.Controls.Add(comboBox2);
            grpBoxUcus.Controls.Add(comboBox1);
            grpBoxUcus.Controls.Add(label2);
            grpBoxUcus.Controls.Add(label1);
            grpBoxUcus.Location = new Point(43, 168);
            grpBoxUcus.Name = "grpBoxUcus";
            grpBoxUcus.Size = new Size(380, 289);
            grpBoxUcus.TabIndex = 0;
            grpBoxUcus.TabStop = false;
            grpBoxUcus.Text = "Uçuş Bilgileri";
            // 
            // mskedTarih
            // 
            mskedTarih.Location = new Point(148, 157);
            mskedTarih.Mask = "00/00/0000";
            mskedTarih.Name = "mskedTarih";
            mskedTarih.Size = new Size(84, 33);
            mskedTarih.TabIndex = 5;
            mskedTarih.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 157);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 4;
            label3.Text = "Tarih:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Antep", "Urfa", "Diyarbakır", "Mardin" });
            comboBox2.Location = new Point(148, 114);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(149, 33);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Adana", "Ankara", "Mersin", "İzmir" });
            comboBox1.Location = new Point(148, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(149, 33);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 114);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 1;
            label2.Text = "Nereye:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 74);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 0;
            label1.Text = "Nereden:";
            // 
            // grpBoxYolcu
            // 
            grpBoxYolcu.Controls.Add(textBox1);
            grpBoxYolcu.Controls.Add(button1);
            grpBoxYolcu.Controls.Add(maskedTextBox3);
            grpBoxYolcu.Controls.Add(maskedTextBox2);
            grpBoxYolcu.Controls.Add(label6);
            grpBoxYolcu.Controls.Add(label5);
            grpBoxYolcu.Controls.Add(label4);
            grpBoxYolcu.Location = new Point(463, 168);
            grpBoxYolcu.Name = "grpBoxYolcu";
            grpBoxYolcu.Size = new Size(419, 289);
            grpBoxYolcu.TabIndex = 1;
            grpBoxYolcu.TabStop = false;
            grpBoxYolcu.Text = "Yolcu Bilgileri";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(153, 33);
            textBox1.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Location = new Point(204, 210);
            button1.Name = "button1";
            button1.Size = new Size(149, 48);
            button1.TabIndex = 7;
            button1.Text = "KAYDET";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(204, 157);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(149, 33);
            maskedTextBox3.TabIndex = 6;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(204, 117);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(149, 33);
            maskedTextBox2.TabIndex = 5;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 79);
            label6.Name = "label6";
            label6.Size = new Size(151, 25);
            label6.TabIndex = 3;
            label6.Text = "Yolcu Ad Soyad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(116, 157);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 2;
            label5.Text = "Telefon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(163, 117);
            label4.Name = "label4";
            label4.Size = new Size(37, 25);
            label4.TabIndex = 1;
            label4.Text = "Tc:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(40, 481);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(839, 104);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(43, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(839, 118);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(597, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Script MT Bold", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(62, 39);
            label7.Name = "label7";
            label7.Size = new Size(425, 42);
            label7.TabIndex = 0;
            label7.Text = "ÖZBAY HAVA YOLLARI";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1027, 651);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(grpBoxYolcu);
            Controls.Add(grpBoxUcus);
            Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Ucak Rezervasyon";
            grpBoxUcus.ResumeLayout(false);
            grpBoxUcus.PerformLayout();
            grpBoxYolcu.ResumeLayout(false);
            grpBoxYolcu.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxUcus;
        private GroupBox grpBoxYolcu;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private MaskedTextBox mskedTarih;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button button1;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox2;
        private ListBox listBox1;
        private Panel panel1;
        private Label label7;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}
