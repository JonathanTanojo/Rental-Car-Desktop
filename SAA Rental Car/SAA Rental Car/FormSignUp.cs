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
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuerry;
        string connectString = "server=localhost;uid=root;pwd=;database=datasql;";
        string p = "P";
        string idnama;
        bool show = false; 
        //false = mati
        //true = nyala

        private void lSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (tboxNamaLengkap.Text != "" && tboxPassword.Text != "" && tboxKota.Text != "" && tboxEmail.Text != "" && dtTanggalLahir.Text != "" && cboxJenisKelamin.Text != "" && tboxNoTelepon.Text != "" && tboxAlamat.Text != "")
                {
                    idnama = p + tboxNamaLengkap.Text.Substring(0, 1).ToUpper() + tboxNamaLengkap.Text.Substring(1, 1).ToUpper();

                    DataTable idgenerate = new DataTable();
                    sqlConnect = new MySqlConnection(connectString);
                    sqlQuerry = "SELECT P_ID as `ID` FROM peminjam WHERE P_ID like '" + idnama + "%'";
                    sqlCommand = new MySqlCommand(sqlQuerry, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(idgenerate);
                    int counter = idgenerate.Rows.Count + 1;

                    if (idgenerate.Rows.Count >= 10)
                    {
                        idnama += "0";
                        idnama += counter.ToString();

                    }
                    else if (idgenerate.Rows.Count > 100)
                    {

                        idnama += counter.ToString();
                    }
                    else
                    {
                        idnama += "00";
                        idnama += counter.ToString();
                    }

                    sqlQuerry = "INSERT INTO peminjam VALUES('" + idnama.ToString() + "','" + tboxNamaLengkap.Text.ToString() + "','" + tboxNoTelepon.Text.ToString() + "','" + tboxAlamat.Text.ToString() + "','" + tboxEmail.Text.ToString() + "','" + tboxPassword.Text.ToString() + "','" + dtTanggalLahir.Value.ToString("yyyy-MM-dd") + "','" + tboxKota.Text + "','" + cboxJenisKelamin.Text + "','0')";
                    sqlConnect = new MySqlConnection(connectString);
                    sqlCommand = new MySqlCommand(sqlQuerry, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);


                    sqlConnect.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    MessageBox.Show("Data Sudah tersimpan");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data masih ada yang kosong");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sqlConnect.Close();
            }
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            DataTable jeniskelamin= new DataTable();
            sqlConnect = new MySqlConnection(connectString);
            sqlQuerry = "SELECT jenis_kelamin as `Jenis Kelamin`FROM danlainlain order by jenis_kelamin asc;";
            sqlCommand = new MySqlCommand(sqlQuerry, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(jeniskelamin);

            cboxJenisKelamin.DataSource = jeniskelamin;
            cboxJenisKelamin.DisplayMember = "Jenis Kelamin";
            cboxJenisKelamin.ValueMember = "Jenis Kelamin";
            tboxPassword.PasswordChar = '*';
        }

        private void tboxPassword_TextChanged(object sender, EventArgs e)
        {
            if (show == true)
            {
                tboxPassword.PasswordChar = '\0';
            }
            else if (show == false)
            {
                tboxPassword.PasswordChar = '*';
            }
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            
            if (tboxPassword.PasswordChar == '*')
            {
                tboxPassword.PasswordChar = '\0';
                show = true;

            }
            else if(tboxPassword.PasswordChar == '\0')
            {
                tboxPassword.PasswordChar = '*';
                show = false;
            }
        }

        private void tboxNamaLengkap_TextChanged(object sender, EventArgs e)
        {

        }

        private void lback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
