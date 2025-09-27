using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace bai4tttl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool KiemTraNhap(out double a, out double b)
        {
            a = 0; b = 0;

            if (!double.TryParse(txtSo1.Text.Trim(), out a))
            {
                MessageBox.Show("S? 1 không h?p l?!", "L?i",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo1.Focus();
                return false;
            }

            if (!double.TryParse(txtSo2.Text.Trim(), out b))
            {
                MessageBox.Show("S? 2 không h?p l?!", "L?i",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo2.Focus();
                return false;
            }

            return true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radCong_CheckedChanged(object sender, EventArgs e)
        {
            if (radCong.Checked && KiemTraNhap(out double a, out double b))
                txtKQ.Text = (a + b).ToString();
        }

        private void radNhan_CheckedChanged(object sender, EventArgs e)
        {
            if (radNhan.Checked && KiemTraNhap(out double a, out double b))
                txtKQ.Text = (a * b).ToString();
        }

        private void radTru_CheckedChanged(object sender, EventArgs e)
        {
            if (radTru.Checked && KiemTraNhap(out double a, out double b))
                txtKQ.Text = (a - b).ToString();
        }

        private void radChia_CheckedChanged(object sender, EventArgs e)
        {
            if (radChia.Checked && KiemTraNhap(out double a, out double b))
            {
                if (b == 0)
                {
                    MessageBox.Show("Không th? chia cho 0!", "L?i",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSo2.Focus();
                    return;
                }
                txtKQ.Text = (a / b).ToString();
            }
        }
        private void FrmBai4_Load(object sender, EventArgs e)
        {
            txtSo1.Clear();
            txtSo2.Clear();
            txtKQ.Clear();
            radCong.Checked = false;
            radTru.Checked = false;
            radNhan.Checked = false;
            radChia.Checked = false;
            txtSo1.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}

