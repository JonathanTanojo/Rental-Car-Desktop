using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SAA_Rental_Car
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuerry;
        string connectString = "server=localhost;uid=root;pwd=;database=datasql;";
        string tanggalawalpeminjaman;
        string tanggalakhirpeminjaman;
        private void FormLogin_Load(object sender, EventArgs e)
        {
            DataTable pilihan = new DataTable();
            sqlConnect = new MySqlConnection(connectString);
            sqlQuerry = "SELECT kategori as `Supir/NonSupir` FROM danlainlain ORDER BY `Supir/NonSupir` desc";
            sqlCommand = new MySqlCommand(sqlQuerry, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(pilihan);

            cboxpilihan.DataSource = pilihan;
            cboxpilihan.DisplayMember = "Supir/NonSupir";
            cboxpilihan.ValueMember = "Supir/NonSupir";

            DataTable namakota = new DataTable();
            sqlConnect = new MySqlConnection(connectString);
            sqlQuerry = "SELECT nama_kota as `Nama Kota` FROM nama_kota";
            sqlCommand = new MySqlCommand(sqlQuerry, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(namakota);

            cboxkota.DataSource = namakota;
            cboxkota.DisplayMember = "Nama Kota";
            cboxkota.ValueMember = "Nama Kota";

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboxpilihan.Text == "Supir")
                {
                    FormAwal formawal = new FormAwal();
                    sqlQuerry = "INSERT INTO `history_peminjaman` VALUES ('"+ label7.Text+"','"+label8.Text+"','"+dtptanggalawal.Value.ToString("yyyy-MM-dd")+"','"+dtptanggalakhir.Value.ToString("yyyy-MM-dd")+"','"+cboxpilihan.Text+"','"+cboxkota.Text+ "','0')";
                    sqlConnect = new MySqlConnection(connectString);
                    sqlCommand = new MySqlCommand(sqlQuerry, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);

                    sqlConnect.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    
                    FormSupir formSupir = new FormSupir();
                    this.Hide();
                    formSupir.labelkotapeminjam.Text = cboxkota.Text;
                    formSupir.labeltanggalawal.Text = dtptanggalawal.Text;
                    formSupir.labeltanggalakhir.Text = dtptanggalakhir.Text;
                    formSupir.ShowDialog();
                    this.Close();
                }
                else
                {
                    FormAwal formawal = new FormAwal();
                    sqlQuerry = "INSERT INTO `history_peminjaman` VALUES ('" + label7.Text + "','" + label8.Text + "','" + dtptanggalawal.Value.ToString("yyyy-MM-dd") + "','" + dtptanggalakhir.Value.ToString("yyyy-MM-dd") + "','" + cboxpilihan.Text + "','" + cboxkota.Text + "','0')";
                    sqlConnect = new MySqlConnection(connectString);
                    sqlCommand = new MySqlCommand(sqlQuerry, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);

                    sqlConnect.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    FormNonSupir formNonSupir = new FormNonSupir();
                    this.Hide();
                    formNonSupir.labelkotapeminjam.Text = cboxkota.Text;
                    formNonSupir.labeltanggalawal.Text = dtptanggalawal.Text;
                    formNonSupir.labeltanggalakhir.Text = dtptanggalakhir.Text;
                    formNonSupir.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                sqlConnect.Close();
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dtptanggalawal_ValueChanged(object sender, EventArgs e)
        {
            tanggalawalpeminjaman = dtptanggalawal.Text;
            
        }

        private void dtptanggalakhir_ValueChanged(object sender, EventArgs e)
        {
            tanggalakhirpeminjaman = dtptanggalakhir.Text;
            
        }
    }
}
