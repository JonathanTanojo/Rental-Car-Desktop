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
    public partial class FormAwal : Form
    {
        public FormAwal()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuerry;
        string connectString = "server=localhost;uid=root;pwd=;database=datasql;";
        string username;
        string password;
        string simpanpassword;
        
        bool show = false;
        private void lLogin_Click(object sender, EventArgs e)
        {
            try
            {
                username = tboxnamalengkap.Text;
                password = tboxpassword.Text;

                DataTable totalmember = new DataTable();
                sqlConnect = new MySqlConnection(connectString);
                sqlQuerry = "SELECT P_ID AS `ID`,P_NAMA AS `Nama`,P_NO_TELPON AS `No Telpon`,P_ALAMAT AS `Alamat`,P_GMAIL AS `gmail`,P_PASSWORD AS `Password`,P_TANGGAL_LAHIR as `Lahir`,P_TEMPAT as `Kota`,P_JENIS_KELAMIN AS `Jenis Kelamin` FROM peminjam WHERE P_NAMA = '"+username+"';";
                sqlCommand = new MySqlCommand(sqlQuerry, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(totalmember);
                simpanpassword = totalmember.Rows[0]["Password"].ToString();
                
                if (simpanpassword == password)
                {
                    FormLogin formLogin = new FormLogin();
                    formLogin.label7.Text = totalmember.Rows[0]["ID"].ToString();
                    formLogin.label8.Text = totalmember.Rows[0]["Nama"].ToString();
                    this.Hide();
                    formLogin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Password Salah");
                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Masukan Terlebih dahulu Nama dan Password");
            }
            

        }

        private void lSignUp_Click(object sender, EventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();
            this.Hide();
            formSignUp.ShowDialog();
            this.Show();
        }

        private void FomAwal_Load(object sender, EventArgs e)
        {
            tboxpassword.PasswordChar = '*';
            btnShow.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnShow.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnShow.BackColor = Color.Transparent;
            pbox1.Image = SAA_Rental_Car.Properties.Resources.Contoh_1;
            pbox2.Image = SAA_Rental_Car.Properties.Resources.Contoh_2;
            pbox3.Image = SAA_Rental_Car.Properties.Resources.Contoh_3;
            pbox4.Image = SAA_Rental_Car.Properties.Resources.Contoh_4;
            label1.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            pboxWallpaper.Image = SAA_Rental_Car.Properties.Resources.Wallpaper_2;
                

        }

        private void tboxpassword_TextChanged_1(object sender, EventArgs e)
        {
            if (show == true)
            {
                tboxpassword.PasswordChar = '\0';
            }
            else if (show == false)
            {
                tboxpassword.PasswordChar = '*';
            }

        }

        private void tboxusername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (tboxpassword.PasswordChar == '*')
            {
                tboxpassword.PasswordChar = '\0';
                show = true;

            }
            else if (tboxpassword.PasswordChar == '\0')
            {
                tboxpassword.PasswordChar = '*';
                show = false;
            }
        }

        private void tboxpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                lLogin_Click(sender, e);
            }
        }
    }
}
