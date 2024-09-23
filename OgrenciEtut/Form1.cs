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
using System.IO;

namespace OgrenciEtut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-32Q9FH5;Initial Catalog=DbEtut;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        void derslistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLDERSLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbders.ValueMember = "DERSID";
            cmbders.DisplayMember = "DERSAD";
            cmbders.DataSource = dt;
        }

        void ogretmenderslistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBLDERSLER", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbogretmenders.ValueMember = "DERSID";
            cmbogretmenders.DisplayMember = "DERSAD";
            cmbogretmenders.DataSource = dt;
        }

        void etutlistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("Execute Etut", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void ogrencitemizle()
        {
            txtogrenciad.Text = "";
            txtogrencisoyad.Text = "";
            txtogrencisınıf.Text = "";
            mskogrencitelefon.Text = "";
            txtogrencimail.Text = "";
            txtogrenciad.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            derslistesi();
            etutlistesi();
            ogretmenderslistesi();


        }

        private void cmbders_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select OGRTID,AD+' '+SOYAD as 'ADSOYAD' From TBLOGRETMEN where BRANSID=" + cmbders.SelectedValue, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbogretmen.ValueMember = "OGRTID";
            cmbogretmen.DisplayMember = "ADSOYAD";
            cmbogretmen.DataSource = dt;

        }

        private void btnetutolustur_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLETUT (DERSID,OGRETMENID,TARIH,SAAT) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbders.SelectedValue);
            komut.Parameters.AddWithValue("@p2", cmbogretmen.SelectedValue);
            komut.Parameters.AddWithValue("@p3", msktarih.Text);
            komut.Parameters.AddWithValue("@p4", msksaat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtetutid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnetutdetay_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update TBLETUT set OGRENCIID=@p1,DURUM=@p2 where ID=@p3", baglanti);
            komut.Parameters.AddWithValue("@p1", txtetutogrenci.Text);
            komut.Parameters.AddWithValue("@p2", "True");
            komut.Parameters.AddWithValue("@p3", txtetutid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Verildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnresim_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPEG Files (*.jpg;*.jpeg)|*.jpg;*.jpeg|PNG Files (*.png)|*.png";
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;

        }

        private void btnogrenciekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLOGRENCI (AD,SOYAD,FOTOGRAF,SINIF,TELEFON,MAIL) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtogrenciad.Text);
            komut.Parameters.AddWithValue("@p2", txtogrencisoyad.Text);
            komut.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@p4", txtogrencisınıf.Text);
            komut.Parameters.AddWithValue("@p5", mskogrencitelefon.Text);
            komut.Parameters.AddWithValue("@p6", txtogrencimail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ogrencitemizle();
        }

        private void btnogretmenekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLOGRETMEN (AD,SOYAD,BRANSID) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtogretmenad.Text);
            komut.Parameters.AddWithValue("@p2", txtogretmensoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbogretmenders.SelectedValue);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğretmen Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            derslistesi();
            ogretmenderslistesi();
            txtogretmenad.Text = "";
            txtogretmensoyad.Text = "";

        }

        private void btndersekle_Click(object sender, EventArgs e)
        {

            bool dersvarmıyokmu;
            string dersadi = txtders.Text.ToUpper();

            baglanti.Open();
            SqlCommand kontrol = new SqlCommand("Select * From TBLDERSLER where DERSAD=@p1", baglanti);
            kontrol.Parameters.AddWithValue("@p1", dersadi);
            SqlDataReader dr = kontrol.ExecuteReader();
            if (dr.Read())
            {
                dersvarmıyokmu = true;
            }
            else
            {
                dersvarmıyokmu = false;
            }

            baglanti.Close();

            if (dersvarmıyokmu == false)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into TBLDERSLER (DERSAD) values (@p1)", baglanti);
                komut.Parameters.AddWithValue("@p1", dersadi);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ders Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                derslistesi();
                ogretmenderslistesi();
                txtders.Text = "";
            }
            else
            {
                MessageBox.Show("Ders Zaten Mevcut", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
    }
}
