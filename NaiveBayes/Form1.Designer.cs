namespace NaiveBayes
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbDuongDan = new System.Windows.Forms.TextBox();
            this.btTim = new System.Windows.Forms.Button();
            this.nudSoNhom = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btThucHien = new System.Windows.Forms.Button();
            this.pnHinhVe = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKetQua = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNhom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn tệp tin dữ liệu";
            // 
            // tbDuongDan
            // 
            this.tbDuongDan.Location = new System.Drawing.Point(16, 42);
            this.tbDuongDan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDuongDan.Multiline = true;
            this.tbDuongDan.Name = "tbDuongDan";
            this.tbDuongDan.Size = new System.Drawing.Size(610, 26);
            this.tbDuongDan.TabIndex = 1;
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(635, 42);
            this.btTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(94, 28);
            this.btTim.TabIndex = 2;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // nudSoNhom
            // 
            this.nudSoNhom.Location = new System.Drawing.Point(15, 99);
            this.nudSoNhom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudSoNhom.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSoNhom.Name = "nudSoNhom";
            this.nudSoNhom.Size = new System.Drawing.Size(150, 27);
            this.nudSoNhom.TabIndex = 3;
            this.nudSoNhom.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số nhóm";
            // 
            // btThucHien
            // 
            this.btThucHien.Location = new System.Drawing.Point(15, 134);
            this.btThucHien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThucHien.Name = "btThucHien";
            this.btThucHien.Size = new System.Drawing.Size(150, 29);
            this.btThucHien.TabIndex = 5;
            this.btThucHien.Text = "Thực hiện";
            this.btThucHien.UseVisualStyleBackColor = true;
            this.btThucHien.Click += new System.EventHandler(this.btThucHien_Click);
            // 
            // pnHinhVe
            // 
            this.pnHinhVe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnHinhVe.Location = new System.Drawing.Point(736, 15);
            this.pnHinhVe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnHinhVe.Name = "pnHinhVe";
            this.pnHinhVe.Size = new System.Drawing.Size(547, 642);
            this.pnHinhVe.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kết quả thực hiện";
            // 
            // tbKetQua
            // 
            this.tbKetQua.Location = new System.Drawing.Point(15, 192);
            this.tbKetQua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKetQua.Multiline = true;
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.ReadOnly = true;
            this.tbKetQua.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbKetQua.Size = new System.Drawing.Size(713, 465);
            this.tbKetQua.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 671);
            this.Controls.Add(this.tbKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnHinhVe);
            this.Controls.Add(this.btThucHien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudSoNhom);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.tbDuongDan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "NavieBayes";
            ((System.ComponentModel.ISupportInitialize)(this.nudSoNhom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDuongDan;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.NumericUpDown nudSoNhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThucHien;
        private System.Windows.Forms.Panel pnHinhVe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKetQua;
    }
}

