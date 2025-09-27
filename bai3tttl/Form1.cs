using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace bai3tttl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool IsPrime(int n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            int limit = (int)Math.Sqrt(n);
            for (int i = 3; i <= limit; i += 2)
                if (n % i == 0) return false;
            return true;
        }
        private void FrmBai3_Load(object sender, EventArgs e)
        {
            txtSo.Clear();
            cboSo.Items.Clear();
            lstTinh.Items.Clear();
            txtSo.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstTinh.Items.Clear();
            if (cboSo.SelectedItem == null) return;
            int so = int.Parse(cboSo.SelectedItem.ToString());

            for (int i = 1; i <= so; i++)
            {
                if (so % i == 0)
                    lstTinh.Items.Add(i);
            }
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (lstTinh.Items.Count == 0)
            {
                MessageBox.Show("Chưa có ước số. Vui lòng chọn số trong ComboBox.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int tong = 0;
            foreach (var item in lstTinh.Items)
                tong += int.Parse(item.ToString());

            MessageBox.Show("Tổng các ước số = " + tong, "Kết quả",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                Application.Exit();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string text = txtSo.Text.Trim();
            if (!int.TryParse(text, out int so) || so < 1)
            {
                MessageBox.Show("Vui lòng nhập số nguyên dương (>=1).", "Lỗi nhập",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo.SelectAll();
                txtSo.Focus();
                return;
            }

            string sSo = so.ToString();
            if (cboSo.Items.Contains(sSo))
            {
                MessageBox.Show("Số này đã tồn tại trong danh sách.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSo.Clear();
                txtSo.Focus();
                return;
            }

            cboSo.Items.Add(sSo);
            cboSo.SelectedItem = sSo; // chọn số vừa thêm
            txtSo.Clear();
            txtSo.Focus();
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            if (lstTinh.Items.Count == 0)
            {
                MessageBox.Show("Chưa có ước số. Vui lòng chọn số trong ComboBox.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int dem = 0;
            foreach (var item in lstTinh.Items)
            {
                int v = int.Parse(item.ToString());
                if (v % 2 == 0) dem++;
            }

            MessageBox.Show("Số lượng ước số chẵn = " + dem, "Kết quả",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNguyenTo_Click(object sender, EventArgs e)
        {
            if (lstTinh.Items.Count == 0)
            {
                MessageBox.Show("Chưa có ước số. Vui lòng chọn số trong ComboBox.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int dem = 0;
            foreach (var item in lstTinh.Items)
            {
                int v = int.Parse(item.ToString());
                if (IsPrime(v)) dem++;
            }

            MessageBox.Show("Số lượng ước số nguyên tố = " + dem, "Kết quả",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
