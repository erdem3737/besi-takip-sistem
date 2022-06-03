using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Besin_Ön_Takip
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti;
        OleDbCommand sorgu;
        OleDbDataReader veri;
        public void Baglanti()
        {
            try
            {
                baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bilgi.mdb");
                baglanti.Open();
            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message);
            }
        }
        private void btEkle_Click(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=bilgi.mdb");
            baglanti.Open();

            OleDbCommand sorgu = new OleDbCommand();
            sorgu.CommandText = "insert into veri (m_a,m_b,m_m) values ('" +tbMalzemeAdi.Text + "','" + cbBirim.Text + "','" + tbMarkasi.Text +"')";
            sorgu.Connection = baglanti;
            sorgu.ExecuteNonQuery();
            baglanti.Close();
            tbMalzemeAdi.Text = "";
            cbBirim.Text = "";
            tbMarkasi.Text = "";
            gvMalzemeler.Refresh();
            verilerigetir();
            MessageBox.Show("KAYDINIZ EKLENMİŞTİR", "BİLGİLENDİRME", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void verilerigetir()
        {
            OleDbCommand sorgu = new OleDbCommand("select * from veri", baglanti);
            OleDbDataAdapter veri = new OleDbDataAdapter(sorgu);
            DataTable dt = new DataTable();
            veri.Fill(dt);
            gvMalzemeler.DataSource = dt;
            gvMalzemeler.Update();
            gvMalzemeler.Refresh();
        }

        private void cbBirim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bilgiDataSet.veri' table. You can move, or remove it, as needed.
            this.veriTableAdapter.Fill(this.bilgiDataSet.veri);

        }
    }
}
