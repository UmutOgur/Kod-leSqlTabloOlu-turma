using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KodileSqlTabloOlusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T2GKN5C\SQLEXPRESS;Initial Catalog=Dbo_FilmArsiv;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            //string s1, s2, v1, v2;
            //s1 = txtsütun1.Text;
            //s2 = txtsütun2.Text;
            //v1 = txtveri1.Text;
            //v2 = txtveri2.Text;
            try
            {
                baglanti.Open();
                SqlCommand komuttablo = new SqlCommand("CREATE TABLE " + textBox1.Text.ToString() + "(" + txtsütun1.Text.ToString() + " " + txtveri1.Text.ToString() + "," + txtsütun2.Text.ToString() + " " + txtveri2.Text.ToString() + ")", baglanti);
                komuttablo.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Tablo Oluşturuldu");
            }
            catch (Exception)
            {

                MessageBox.Show("Tablo Oluşturulmadı");
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
