using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP
{
    public partial class FormMenu : Form
    {
        MySqlConnection connect;

        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();
        FormFood formFood;
        FormTable formTable;
        FormDrink formDrink;
        form_login formLogin;
        DataTable dtPesanan = new DataTable();

        string namaPegawai = string.Empty;
        public string tableNo;

        public void setTableNo(string num)
        {
            tableNo = num;
        }

        public FormMenu(MySqlConnection conn, string _namaPegawai)
        {
            InitializeComponent();
            connect = conn;
            namaPegawai = _namaPegawai;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            //dtPesanan.Columns.Add("ID");
            //dtPesanan.Columns.Add("Name");
            //dtPesanan.Columns.Add("Price");
            //dtPesanan.Columns.Add("Qty");
            //dtPesanan.Columns.Add("Total");

            hapusForm();
            formTable = new FormTable();
            formTable.convDataTable(dtPesanan);

            formTable = new FormTable(connect, this, dtPesanan, namaPegawai, tableNo);
            formTable.MdiParent = this;
            formTable.Show();


            //formAwal = new FormAwal();
            //formAwal.convDataTable(dtPesanan);

            //lihatPegawai();
            //formAwal = new FormAwal(connect, this, dtPesanan);
            //formAwal.MdiParent = this;
            //formAwal.Show();
        }

        //private void lihatPegawai()
        //{
        //    try
        //    {
        //        string sqlText = "SELECT nama_pegawai FROM PEGAWAI ORDER BY id_pegawai";
        //        adapter = new MySqlDataAdapter(sqlText, connect);
        //        adapter.Fill(dt);

        //    } catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString());
        //    }
        //}

        private void foodToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            hapusForm();
            formFood = new FormFood();
            formFood.convDataTable(dtPesanan);

            formFood = new FormFood(connect, this, dtPesanan, namaPegawai, tableNo);
            formFood.MdiParent = this;
            formFood.Show();
        }

        private void tableNumberMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hapusForm();
            formTable = new FormTable();
            formTable.convDataTable(dtPesanan);

            formTable = new FormTable(connect, this, dtPesanan, namaPegawai, tableNo);
            formTable.MdiParent = this;
            formTable.Show();

        }

        private void drinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hapusForm();
            formDrink = new FormDrink();
            formDrink.convDataTable(dtPesanan);

            formDrink = new FormDrink(connect, this, dtPesanan, namaPegawai, tableNo);
            formDrink.MdiParent = this;
            formDrink.Show();
        }

        private void hapusForm()
        {
            if (this.MdiChildren.Any())
            {
                foreach (Form frm in MdiChildren)
                {
                    frm.Close();
                }
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                //connect.Close();
                //formLogin = new form_login();
                //formLogin.Show();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
