namespace Views
{
    partial class CariHp
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
            label6 = new Label();
            hargaBarangDisplay = new TextBox();
            stokBarangDisplay = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            kodeBarangDisplay = new TextBox();
            namaBarangDisplay = new TextBox();
            cariBTN = new Button();
            namaBarangInput = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 379);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 25;
            label6.Text = "Harga Barang";
            // 
            // hargaBarangDisplay
            // 
            hargaBarangDisplay.Location = new Point(177, 372);
            hargaBarangDisplay.Name = "hargaBarangDisplay";
            hargaBarangDisplay.Size = new Size(149, 27);
            hargaBarangDisplay.TabIndex = 24;
            // 
            // stokBarangDisplay
            // 
            stokBarangDisplay.Location = new Point(177, 319);
            stokBarangDisplay.Name = "stokBarangDisplay";
            stokBarangDisplay.Size = new Size(149, 27);
            stokBarangDisplay.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 326);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 22;
            label5.Text = "Stok Barang";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 270);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 21;
            label4.Text = "Kode Barang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 218);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 20;
            label3.Text = "Nama Barang";
            // 
            // kodeBarangDisplay
            // 
            kodeBarangDisplay.Location = new Point(177, 263);
            kodeBarangDisplay.Name = "kodeBarangDisplay";
            kodeBarangDisplay.Size = new Size(149, 27);
            kodeBarangDisplay.TabIndex = 19;
            // 
            // namaBarangDisplay
            // 
            namaBarangDisplay.Location = new Point(177, 215);
            namaBarangDisplay.Name = "namaBarangDisplay";
            namaBarangDisplay.Size = new Size(149, 27);
            namaBarangDisplay.TabIndex = 18;
            // 
            // cariBTN
            // 
            cariBTN.Location = new Point(630, 135);
            cariBTN.Name = "cariBTN";
            cariBTN.Size = new Size(94, 29);
            cariBTN.TabIndex = 17;
            cariBTN.Text = "CARI";
            cariBTN.UseVisualStyleBackColor = true;
            cariBTN.Click += cariBTN_Click;
            // 
            // namaBarangInput
            // 
            namaBarangInput.Location = new Point(283, 137);
            namaBarangInput.Name = "namaBarangInput";
            namaBarangInput.Size = new Size(341, 27);
            namaBarangInput.TabIndex = 16;
            namaBarangInput.TextChanged += namaBarangInput_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(49, 128);
            label2.Name = "label2";
            label2.Size = new Size(228, 35);
            label2.TabIndex = 15;
            label2.Text = "Ketik Nama Barang";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(49, 51);
            label1.Name = "label1";
            label1.Size = new Size(191, 46);
            label1.TabIndex = 14;
            label1.Text = "Cari Barang";
            // 
            // button1
            // 
            button1.Location = new Point(657, 51);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CariHp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(hargaBarangDisplay);
            Controls.Add(stokBarangDisplay);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(kodeBarangDisplay);
            Controls.Add(namaBarangDisplay);
            Controls.Add(cariBTN);
            Controls.Add(namaBarangInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "CariHp";
            Text = "CariHp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox hargaBarangDisplay;
        private TextBox stokBarangDisplay;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox kodeBarangDisplay;
        private TextBox namaBarangDisplay;
        private Button cariBTN;
        private TextBox namaBarangInput;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}