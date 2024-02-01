using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace AppKasir
{
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        Koneksi Konn = new Koneksi();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection conn = Konn.GetConn();
            {
                conn.Open();
                cmd = new SqlCommand("select * from TBL_KASIR where KodeKasir='" + textBox1.Text + "' and PasswordKasir='" + textBox2.Text + "'", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    FormMenuUtama.menu.menuLogin.Enabled = false;
                    FormMenuUtama.menu.menuLogout.Enabled = true;
                    FormMenuUtama.menu.menuMaster.Enabled = true;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("salah Password");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';

        }
    }
}