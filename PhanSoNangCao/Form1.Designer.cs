namespace PhanSoNangCao
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
            this.PhanSo1 = new System.Windows.Forms.Label();
            this.Ketqua = new System.Windows.Forms.Label();
            this.PhanSo2 = new System.Windows.Forms.Label();
            this.maukq = new System.Windows.Forms.TextBox();
            this.tukq = new System.Windows.Forms.TextBox();
            this.line1 = new System.Windows.Forms.Label();
            this.linesum = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PhepTinh = new System.Windows.Forms.TextBox();
            this.mau2 = new System.Windows.Forms.NumericUpDown();
            this.mau1 = new System.Windows.Forms.NumericUpDown();
            this.tu1 = new System.Windows.Forms.NumericUpDown();
            this.tu2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mau2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mau1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tu2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PhanSo1
            // 
            this.PhanSo1.AutoSize = true;
            this.PhanSo1.Location = new System.Drawing.Point(74, 58);
            this.PhanSo1.Name = "PhanSo1";
            this.PhanSo1.Size = new System.Drawing.Size(74, 16);
            this.PhanSo1.TabIndex = 0;
            this.PhanSo1.Text = "Phân Số 1: ";
            // 
            // Ketqua
            // 
            this.Ketqua.AutoSize = true;
            this.Ketqua.Location = new System.Drawing.Point(32, 68);
            this.Ketqua.Name = "Ketqua";
            this.Ketqua.Size = new System.Drawing.Size(57, 16);
            this.Ketqua.TabIndex = 1;
            this.Ketqua.Text = "Kết Quả:";
            // 
            // PhanSo2
            // 
            this.PhanSo2.AutoSize = true;
            this.PhanSo2.Location = new System.Drawing.Point(77, 303);
            this.PhanSo2.Name = "PhanSo2";
            this.PhanSo2.Size = new System.Drawing.Size(74, 16);
            this.PhanSo2.TabIndex = 2;
            this.PhanSo2.Text = "Phân Số 2: ";
            // 
            // maukq
            // 
            this.maukq.Location = new System.Drawing.Point(93, 87);
            this.maukq.Name = "maukq";
            this.maukq.Size = new System.Drawing.Size(56, 22);
            this.maukq.TabIndex = 4;
            this.maukq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tukq
            // 
            this.tukq.Location = new System.Drawing.Point(93, 40);
            this.tukq.Name = "tukq";
            this.tukq.Size = new System.Drawing.Size(56, 22);
            this.tukq.TabIndex = 5;
            this.tukq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // line1
            // 
            this.line1.AutoSize = true;
            this.line1.Location = new System.Drawing.Point(151, 59);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(83, 16);
            this.line1.TabIndex = 9;
            this.line1.Text = "-------------------";
            // 
            // linesum
            // 
            this.linesum.AutoSize = true;
            this.linesum.Location = new System.Drawing.Point(90, 68);
            this.linesum.Name = "linesum";
            this.linesum.Size = new System.Drawing.Size(63, 16);
            this.linesum.TabIndex = 11;
            this.linesum.Text = "--------------";
            // 
            // Input
            // 
            this.Input.Controls.Add(this.label2);
            this.Input.Controls.Add(this.PhepTinh);
            this.Input.Controls.Add(this.mau2);
            this.Input.Controls.Add(this.mau1);
            this.Input.Controls.Add(this.tu1);
            this.Input.Controls.Add(this.tu2);
            this.Input.Controls.Add(this.label1);
            this.Input.Controls.Add(this.line1);
            this.Input.Controls.Add(this.PhanSo2);
            this.Input.Controls.Add(this.PhanSo1);
            this.Input.Location = new System.Drawing.Point(12, 4);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(370, 423);
            this.Input.TabIndex = 12;
            this.Input.TabStop = false;
            this.Input.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Operator:";
            // 
            // PhepTinh
            // 
            this.PhepTinh.HideSelection = false;
            this.PhepTinh.Location = new System.Drawing.Point(143, 178);
            this.PhepTinh.Name = "PhepTinh";
            this.PhepTinh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PhepTinh.Size = new System.Drawing.Size(88, 22);
            this.PhepTinh.TabIndex = 18;
            this.PhepTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
           
            this.PhepTinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhepTinh_KeyPress);
            // 
            // mau2
            // 
            this.mau2.Location = new System.Drawing.Point(162, 322);
            this.mau2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mau2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.mau2.Name = "mau2";
            this.mau2.Size = new System.Drawing.Size(64, 22);
            this.mau2.TabIndex = 17;
            this.mau2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mau2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mau2_KeyPress);
            // 
            // mau1
            // 
            this.mau1.Location = new System.Drawing.Point(160, 79);
            this.mau1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mau1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.mau1.Name = "mau1";
            this.mau1.Size = new System.Drawing.Size(64, 22);
            this.mau1.TabIndex = 14;
            this.mau1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mau1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mau1_KeyPress);
            // 
            // tu1
            // 
            this.tu1.Location = new System.Drawing.Point(160, 36);
            this.tu1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tu1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.tu1.Name = "tu1";
            this.tu1.Size = new System.Drawing.Size(64, 22);
            this.tu1.TabIndex = 13;
            this.tu1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tu1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu1_KeyPress);
            // 
            // tu2
            // 
            this.tu2.Location = new System.Drawing.Point(162, 278);
            this.tu2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tu2.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.tu2.Name = "tu2";
            this.tu2.Size = new System.Drawing.Size(64, 22);
            this.tu2.TabIndex = 16;
            this.tu2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tu2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tu2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "------------------";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Location = new System.Drawing.Point(473, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 59);
            this.button1.TabIndex = 13;
            this.button1.Text = "CLOSE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linesum);
            this.groupBox1.Controls.Add(this.tukq);
            this.groupBox1.Controls.Add(this.maukq);
            this.groupBox1.Controls.Add(this.Ketqua);
            this.groupBox1.Location = new System.Drawing.Point(496, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 159);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Input.ResumeLayout(false);
            this.Input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mau2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mau1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tu2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PhanSo1;
        private System.Windows.Forms.Label Ketqua;
        private System.Windows.Forms.Label PhanSo2;
        private System.Windows.Forms.TextBox maukq;
        private System.Windows.Forms.TextBox tukq;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Label linesum;
        private System.Windows.Forms.GroupBox Input;
        private System.Windows.Forms.NumericUpDown mau2;
        private System.Windows.Forms.NumericUpDown mau1;
        private System.Windows.Forms.NumericUpDown tu2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tu1;
        private System.Windows.Forms.TextBox PhepTinh;
    }
}

