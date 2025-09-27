using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2tttl
{
    public partial class FrmBai2 : Form
    {
        public FrmBai2()
        {
            InitializeComponent();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            string hoten = this.txtHoTen.Text.Trim();

            if (this.rad1.Checked == true)   // chữ thường
                this.txtKQ.Text = hoten.ToLower();

            if (this.rad2.Checked == true)   // chữ in hoa
                this.txtKQ.Text = hoten.ToUpper();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtHoTen.Clear();
            this.txtKQ.Clear();
            this.rad1.Checked = true;   // 
            this.txtHoTen.Focus();      // 
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
    }

