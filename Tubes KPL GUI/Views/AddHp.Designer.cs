namespace Views
{
    partial class AddHp
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
            label4 = new Label();
            button1 = new Button();
            label2 = new Label();
            inputHargaBarang = new TextBox();
            label3 = new Label();
            inputJumlahBarang = new TextBox();
            label1 = new Label();
            inputKodeBarang = new TextBox();
            labelNamabarang = new Label();
            buttonBack = new Button();
            inputNamaBarang = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 24);
            label4.Name = "label4";
            label4.Size = new Size(205, 32);
            label4.TabIndex = 43;
            label4.Text = "Add HandPhone";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(27, 403);
            button1.Name = "button1";
            button1.Size = new Size(248, 29);
            button1.TabIndex = 42;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 322);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 41;
            label2.Text = "Harga Barang";
            // 
            // inputHargaBarang
            // 
            inputHargaBarang.Location = new Point(27, 355);
            inputHargaBarang.Name = "inputHargaBarang";
            inputHargaBarang.Size = new Size(248, 27);
            inputHargaBarang.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 239);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 39;
            label3.Text = "Jumlah Barang";
            // 
            // inputJumlahBarang
            // 
            inputJumlahBarang.Location = new Point(27, 272);
            inputJumlahBarang.Name = "inputJumlahBarang";
            inputJumlahBarang.Size = new Size(248, 27);
            inputJumlahBarang.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 160);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 37;
            label1.Text = "Kode Barang";
            // 
            // inputKodeBarang
            // 
            inputKodeBarang.Location = new Point(27, 193);
            inputKodeBarang.Name = "inputKodeBarang";
            inputKodeBarang.Size = new Size(248, 27);
            inputKodeBarang.TabIndex = 36;
            // 
            // labelNamabarang
            // 
            labelNamabarang.AutoSize = true;
            labelNamabarang.Location = new Point(27, 77);
            labelNamabarang.Name = "labelNamabarang";
            labelNamabarang.Size = new Size(100, 20);
            labelNamabarang.TabIndex = 35;
            labelNamabarang.Text = "Nama Barang";
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(256, 29);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(76, 29);
            buttonBack.TabIndex = 34;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // inputNamaBarang
            // 
            inputNamaBarang.Location = new Point(27, 110);
            inputNamaBarang.Name = "inputNamaBarang";
            inputNamaBarang.Size = new Size(248, 27);
            inputNamaBarang.TabIndex = 33;
            // 
            // AddHp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 450);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(inputHargaBarang);
            Controls.Add(label3);
            Controls.Add(inputJumlahBarang);
            Controls.Add(label1);
            Controls.Add(inputKodeBarang);
            Controls.Add(labelNamabarang);
            Controls.Add(buttonBack);
            Controls.Add(inputNamaBarang);
            Name = "AddHp";
            Text = "AddHp";
            Load += AddHp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button button1;
        private Label label2;
        private TextBox inputHargaBarang;
        private Label label3;
        private TextBox inputJumlahBarang;
        private Label label1;
        private TextBox inputKodeBarang;
        private Label labelNamabarang;
        private Button buttonBack;
        private TextBox inputNamaBarang;
    }
}