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
using Renci.SshNet;

namespace ALP
{
    public partial class form_login : Form
    {
        public MySqlConnection connect;
        public SshClient sshClient;

        FormMenu formMenu;

        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();

        MySqlDataReader reader;

        string tableNo = string.Empty;
        public form_login()
        {
            InitializeComponent();
        }

        public void connMySQL_SSH()
        {
            try
            {
                string lokasi_id_rsa = "C:/TEMP/id_rsa";
                var key = new PrivateKeyFile(lokasi_id_rsa, "isb_mantap");
                var method = new PrivateKeyAuthenticationMethod("indramar", key);
                ConnectionInfo connInfo = new ConnectionInfo("indramaryati.xyz",64000,"indramar",method);

                sshClient = new SshClient(connInfo);
                sshClient.Connect();

                if (sshClient.IsConnected)
                {
                    ForwardedPortLocal forwardedPortLocal = new ForwardedPortLocal("127.0.0.1",3306,"127.0.0.1",3306);
                    sshClient.AddForwardedPort(forwardedPortLocal);
                    forwardedPortLocal.Start();
                                                                                                                                                                                               
                    connect = new MySqlConnection("SERVER=127.0.0.1;PORT=3306;UID=indramar_group5;PASSWORD=SQWwhrDwW3h*;DATABASE=indramar_20232_dbd_5");
                    if (connect.State == ConnectionState.Closed)
                    {
                        MessageBox.Show("Connected to mySQL");
                        connect.Open();
                    } else if (connect.State == ConnectionState.Open)
                    {
                        MessageBox.Show("Connection to mySQL still OPEN!");
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                bool ada = false;
                string sqlText = "SELECT nama_pegawai, substring(id_pegawai,1,4) FROM PEGAWAI WHERE username = '" + tb_user.Text 
                    + "' AND password=md5('" + tb_pwd.Text + "')";
                command = new MySqlCommand(sqlText, connect);
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    if (reader.GetValue(1).ToString() == "CASH")
                    {
                        MessageBox.Show("Welcome " + reader.GetValue(0));
                        ada = true;
                    }
                    else
                    {
                        MessageBox.Show("Tidak Terdaftar dalam Sistem Kasir");
                        tb_user.Clear();
                        tb_pwd.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Username / Password SALAH!");
                    tb_user.Clear();
                    tb_pwd.Clear();
                    reader.Close();
                }

                if (ada)
                {
                    string nama = tb_user.Text;
                    FormMenu fMenu = new FormMenu(connect, nama);
                    reader.Close();
                    fMenu.ShowDialog();
                    //fMenu.Show();
                    //this.Hide();
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void form_login_Load(object sender, EventArgs e)
        {
            connMySQL_SSH();
        }

        private void form_login_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                connect.Close();
                sshClient.Disconnect();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
