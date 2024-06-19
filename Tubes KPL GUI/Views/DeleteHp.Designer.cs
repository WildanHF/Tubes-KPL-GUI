namespace Views
{
    partial class DeleteHp
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
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            inputNamaBarang = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(21, 153);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 19;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(217, 41);
            label2.TabIndex = 18;
            label2.Text = "Delete Barang";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 73);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 17;
            label1.Text = "Nama Barang";
            // 
            // button1
            // 
            button1.Location = new Point(420, 22);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // inputNamaBarang
            // 
            inputNamaBarang.Location = new Point(21, 108);
            inputNamaBarang.Name = "inputNamaBarang";
            inputNamaBarang.Size = new Size(452, 27);
            inputNamaBarang.TabIndex = 15;
            inputNamaBarang.TextChanged += inputNamaBarang_TextChanged;
            // 
            // DeleteHp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 203);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(inputNamaBarang);
            Name = "DeleteHp";
            Text = "DeleteHp";
            Load += DeleteHp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox inputNamaBarang;
    }
}