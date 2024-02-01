using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppKasir
{
    public partial class FormMenuUtama : Form
    {
        public static FormMenuUtama menu;
        MenuStrip mnstrip;
        Form1 frmLogin;

        void frmLogin_fromClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin = null;
        }
        FormMasterKasir frmKasir;
        void frmKasir_fromClosed(object sender, FormClosedEventArgs e)
        {
            frmKasir = null;
        }
        FormMasterBarang frmBarang;
        void frmBarang_fromClosed(object sender, FormClosedEventArgs e)
        {
            frmBarang = null;
        }
        void MenuTerkunci()
        {
            menuLogin.Enabled = true;
            menuLogout.Enabled = false;
            menuMaster.Enabled = false;
            menu = this;
        }
        public FormMenuUtama()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {
            MenuTerkunci();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuLogin_Click(object sender, EventArgs e)
        {
            if (frmLogin == null)
            {
                frmLogin = new Form1();
                frmLogin.FormClosed += new FormClosedEventHandler(frmLogin_fromClosed);
                frmLogin.ShowDialog();
            }
            else
            {
                frmLogin.Activate();
            }
            //frmLogin = new Form1();
            //frmLogin.Show();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            MenuTerkunci();
        }

        private void kasirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmKasir == null)
            {
                frmKasir = new FormMasterKasir();
                frmKasir.FormClosed += new FormClosedEventHandler(frmKasir_fromClosed);
                frmKasir.ShowDialog();
            }
            else
            {
                frmKasir.Activate();
            }
        }

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmBarang == null)
            {
                frmBarang = new FormMasterBarang();
                frmBarang.FormClosed += new FormClosedEventHandler(frmBarang_fromClosed);
                frmBarang.ShowDialog();
            }
            else
            {
                frmBarang.Activate();
            }
        }
    }
}
