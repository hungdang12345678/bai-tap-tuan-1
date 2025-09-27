namespace bai3tttl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.lstTinh = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboSo = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnChan = new System.Windows.Forms.Button();
            this.btnNguyenTo = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.cboSo);
            this.groupBox1.Controls.Add(this.txtSo);
            this.groupBox1.Location = new System.Drawing.Point(64, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(6, 32);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(100, 22);
            this.txtSo.TabIndex = 1;
            // 
            // lstTinh
            // 
            this.lstTinh.FormattingEnabled = true;
            this.lstTinh.ItemHeight = 16;
            this.lstTinh.Location = new System.Drawing.Point(15, 21);
            this.lstTinh.Name = "lstTinh";
            this.lstTinh.Size = new System.Drawing.Size(198, 84);
            this.lstTinh.TabIndex = 2;
            this.lstTinh.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstTinh);
            this.groupBox2.Location = new System.Drawing.Point(448, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 116);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // cboSo
            // 
            this.cboSo.FormattingEnabled = true;
            this.cboSo.Location = new System.Drawing.Point(6, 60);
            this.cboSo.Name = "cboSo";
            this.cboSo.Size = new System.Drawing.Size(200, 24);
            this.cboSo.TabIndex = 4;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(112, 21);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(84, 33);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(448, 185);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(231, 29);
            this.btnTong.TabIndex = 4;
            this.btnTong.Text = "Tổng các ước số";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnChan
            // 
            this.btnChan.Location = new System.Drawing.Point(448, 234);
            this.btnChan.Name = "btnChan";
            this.btnChan.Size = new System.Drawing.Size(231, 29);
            this.btnChan.TabIndex = 5;
            this.btnChan.Text = "Số lượng các ước số chẵn";
            this.btnChan.UseVisualStyleBackColor = true;
            this.btnChan.Click += new System.EventHandler(this.btnChan_Click);
            // 
            // btnNguyenTo
            // 
            this.btnNguyenTo.Location = new System.Drawing.Point(448, 280);
            this.btnNguyenTo.Name = "btnNguyenTo";
            this.btnNguyenTo.Size = new System.Drawing.Size(231, 29);
            this.btnNguyenTo.TabIndex = 6;
            this.btnNguyenTo.Text = "Số lượng các ước số nguyên tố";
            this.btnNguyenTo.UseVisualStyleBackColor = true;
            this.btnNguyenTo.Click += new System.EventHandler(this.btnNguyenTo_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(294, 280);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(89, 29);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnNguyenTo);
            this.Controls.Add(this.btnChan);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Bai3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.ListBox lstTinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.ComboBox cboSo;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnChan;
        private System.Windows.Forms.Button btnNguyenTo;
        private System.Windows.Forms.Button btnThoat;
    }
}

