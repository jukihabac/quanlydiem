﻿using quanlydiem.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlydiem
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            ConnectionDB connectionDB = new ConnectionDB();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public bool kiemTraForm(String nameForm)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.Name.Equals(nameForm))
                {
                    f.Activate();
                    return true;
                }
            }
            return false;
        }

        private void đăngXuâtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn đăng xuất không ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if (!kiemTraForm("frm_DangNhap"))
                {
                    this.Hide();
                    frm_DangNhap frmDangNhap = new frm_DangNhap();
                    frmDangNhap.Show();
                }
            }
        }

        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_DoiMatKhau"] == null)
            {
                frm_DoiMatKhau frmDoiMatKhau = new frm_DoiMatKhau();
                frmDoiMatKhau.MdiParent = this;
                frmDoiMatKhau.Show();
            }
            else
            {
                Application.OpenForms["frm_DoiMatKhau"].Activate();
            }
        }
    }
}
