using MySql.Data.MySqlClient;
using Renci.SshNet;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP
{
    public partial class FormTable : Form
    {
        public MySqlConnection connect;
        public SshClient sshClient;
        DataTable dtPesan;
        FormMenu parentForm;
        FormPayment formPayment;
        FormFood formFood;

        MySqlCommand command;
        string namaPegawai = string.Empty;
        public string tableNo;

        public FormTable()
        {
            InitializeComponent();
        }

        public FormTable(FormFood _formFood)
        {
            InitializeComponent();
            formFood = _formFood;
        }
        public FormTable(MySqlConnection conn, FormMenu parentForm, DataTable _dtpesanan, string _namaPegawai, string _noTable)
        {
            InitializeComponent();
            this.dtPesan = _dtpesanan;
            connect = conn;
            this.parentForm = parentForm;
            dgv_pesanan.DataSource = dtPesan;
            namaPegawai = _namaPegawai;
            tableNo = _noTable;
            lb_tableNo.Text = tableNo;
        }
        public void convDataTable(DataTable _dtPesan)
        {
            dtPesan = _dtPesan;
            dgv_pesanan.DataSource = dtPesan;
        }

        private void FormTable_Load(object sender, EventArgs e)
        {
            string query = "select ID_PEGAWAI from PEGAWAI where NAMA_PEGAWAI = " + "'" + namaPegawai + "'" + ";";
            command = new MySqlCommand(query, connect);
            string idPegawai = command.ExecuteScalar().ToString();
            lb_staffID.Text = idPegawai;
            if (dtPesan.Rows.Count != 0)
            {
                hasil();
            }
        }

        public int total;
        public int totalQuantity;
        private void hasil()
        {
            total = 0;
            totalQuantity = 0;
            for (int i = 0; i < dtPesan.Rows.Count; i++)
            {
                total += Convert.ToInt32(dtPesan.Rows[i][4]);
                totalQuantity += Convert.ToInt32(dtPesan.Rows[i][3]);
            }
            tb_totalP.Text = "Rp " + total.ToString("N");
            tb_totalQ.Text = totalQuantity.ToString();
        }

        private void btn_00_Click(object sender, EventArgs e)
        {
            tableNo = "00";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_01_Click(object sender, EventArgs e)
        {
            tableNo = "01";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_02_Click(object sender, EventArgs e)
        {
            tableNo = "02";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_03_Click(object sender, EventArgs e)
        {
            tableNo = "03";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_04_Click(object sender, EventArgs e)
        {
            tableNo = "04";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_05_Click(object sender, EventArgs e)
        {
            tableNo = "05";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_06_Click(object sender, EventArgs e)
        {
            tableNo = "06";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_07_Click(object sender, EventArgs e)
        {
            tableNo = "07";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_08_Click(object sender, EventArgs e)
        {
            tableNo = "08";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_09_Click(object sender, EventArgs e)
        {
            tableNo = "09";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_10_Click(object sender, EventArgs e)
        {
            tableNo = "10";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_11_Click(object sender, EventArgs e)
        {
            tableNo = "11";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_12_Click(object sender, EventArgs e)
        {
            tableNo = "12";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_13_Click(object sender, EventArgs e)
        {
            tableNo = "13";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_14_Click(object sender, EventArgs e)
        {
            tableNo = "14";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_15_Click(object sender, EventArgs e)
        {
            tableNo = "15";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_16_Click(object sender, EventArgs e)
        {
            tableNo = "16";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_17_Click(object sender, EventArgs e)
        {
            tableNo = "17";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_18_Click(object sender, EventArgs e)
        {
            tableNo = "18";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_19_Click(object sender, EventArgs e)
        {
            tableNo = "19";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_20_Click(object sender, EventArgs e)
        {
            tableNo = "20";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_21_Click(object sender, EventArgs e)
        {
            tableNo = "21";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_22_Click(object sender, EventArgs e)
        {
            tableNo = "22";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_23_Click(object sender, EventArgs e)
        {
            tableNo = "23";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void btn_24_Click(object sender, EventArgs e)
        {
            tableNo = "24";
            lb_tableNo.Text = tableNo;
            dapetinNoTable();
        }

        private void dapetinNoTable()
        {
            dtPesan.Rows.Clear();
            parentForm.setTableNo(tableNo);
            string cmd = "SELECT c.ID_MENU as ID, m.NAMA_MENU as Name, c.PESAN_HARGA as Price, c.PESAN_QTY as Qty, (c.PESAN_HARGA*c.PESAN_QTY) as Total " +
                "FROM CART_DETAIL_NOTA c, MENU m " +
                "WHERE c.ID_MENU = m.ID_MENU AND " +
                "c.NOMOR_MEJA = '" + tableNo + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, connect);
            adapter.Fill(dtPesan);
            dgv_pesanan.DataSource = dtPesan;
            dgv_pesanan.Refresh();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (dtPesan.Rows.Count != 0 && tableNo != "")
            {
                if (this.MdiChildren.Any())
                {
                    foreach (Form frm in MdiChildren)
                    {
                        frm.Close();
                    }
                }

                FormPayment formPayment = new FormPayment(connect, dtPesan, parentForm, namaPegawai, tableNo);
                formPayment.convDataTable(dtPesan);

                string query = $"delete from CART_DETAIL_NOTA where NOMOR_MEJA = '{lb_tableNo.Text}';";
                command = new MySqlCommand(query, connect);
                command.ExecuteNonQuery();

                formPayment.MdiParent = parentForm;
                formPayment.Show();
            }
            else
            {

            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            dateStatus.Text = DateTime.Today.ToLongDateString();
        }
    }
}
