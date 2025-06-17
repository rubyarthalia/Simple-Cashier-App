using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ALP
{
    public partial class FormFood : Form
    {
        public MySqlConnection connect;
        public SshClient sshClient;
        MySqlCommand command;
        DataTable dtPesan;
        FormMenu parentForm;
        FormTable formTable;

        string tableNo = string.Empty;
        string namaPegawai = string.Empty;

        public int totalQuantity;
        public double total;
        public int[] qty = new int[16];
        string query;

        public FormFood()
        {
            InitializeComponent();
        }
        
        public FormFood(MySqlConnection conn, FormMenu parentForm, DataTable _dtpesanan, string _namaPegawai, string _tableNo)
        {
            InitializeComponent();
            this.dtPesan = _dtpesanan;
            connect = conn;
            this.parentForm = parentForm;
            dgv_pesanan.DataSource = dtPesan;
            namaPegawai = _namaPegawai;
            tableNo = _tableNo;
        }

        //public void updateNoTable(string _tableNo)
        //{
        //    MessageBox.Show(_tableNo);
        //    tableNo = _tableNo;
        //    lb_tableNo.Text = _tableNo;
        //}

        public void convDataTable(DataTable _dtPesan)
        {
            dtPesan = _dtPesan;
            dgv_pesanan.DataSource = dtPesan;
        }

        private void FormFood_Load(object sender, EventArgs e)
        {
            string query = "select ID_PEGAWAI from PEGAWAI where NAMA_PEGAWAI = " + "'" + namaPegawai + "'" +";";
            command = new MySqlCommand(query, connect);
            string idPegawai = command.ExecuteScalar().ToString();
            lb_staffID.Text = idPegawai;

            if (dtPesan.Rows.Count != 0)
            {
                hasil();
            }

            lb_tableNo.Text = tableNo;
            //FormTable formTable = new FormTable(this);
            //updateNoTable(tableNo);
        }

        private void add(string nama, int index, string ID)
        {
            string query = $"select HARGA from MENU where NAMA_MENU = '{nama}';";
            command = new MySqlCommand(query, connect);
            int price = Convert.ToInt32(command.ExecuteScalar());

            qty[index] += 1;
            int totalPrice = qty[index] * price;
            bool cek = false;

            for (int i = 0; i < dtPesan.Rows.Count; i++)
            {
                if (dtPesan.Rows[i][1].ToString() == nama)
                {
                    cek = true;
                    break;
                }
            }

            bool rowUpdated = false;

            if (cek)
            {
                for (int i = 0; i < dtPesan.Rows.Count; i++)
                {
                    if (dtPesan.Rows[i][1].ToString() == nama)
                    {
                        dtPesan.Rows[i][3] = qty[index];
                        dtPesan.Rows[i][4] = totalPrice;
                        AlterDatabase(ID, tableNo, price, qty[index]);
                        rowUpdated = true;
                        break;
                    }
                }
                if (!rowUpdated)
                {
                    dtPesan.Rows.Add(ID, nama, price, qty[index], totalPrice);
                    insertkeDatabase(ID, tableNo, price, qty[index]);
                }
            }
            else
            {
                dtPesan.Rows.Add(ID, nama, price, qty[index], totalPrice);
                insertkeDatabase(ID, tableNo, price, qty[index]);
            }

            hasil();
        }

        private void min (string nama, int index, string ID)
        {
            int price = 0 ;
            if (qty[index] > 1)
            {
                qty[index] -= 1;
                string query = $"select HARGA from MENU where NAMA_MENU = '{nama}';";
                command = new MySqlCommand(query, connect);
                price = Convert.ToInt32(command.ExecuteScalar());

                int totalPrice = qty[index] * price;

                for (int i = 0; i < dtPesan.Rows.Count; i++)
                {
                    if (dtPesan.Rows[i][1].ToString() == nama)
                    {
                        dtPesan.Rows[i][3] = qty[index].ToString();
                        dtPesan.Rows[i][4] = totalPrice.ToString();
                    }
                }
                AlterDatabase(ID, tableNo, price, qty[index]);
                hasil();
            }
            else if (qty[index] == 1)
            {
                qty[index] = 0;
                for (int i = 0; i < dtPesan.Rows.Count; i++)
                {
                    if (dtPesan.Rows[i][1].ToString() == nama)
                    {
                        dtPesan.Rows.RemoveAt(i);
                    }
                }
                hasil();
                deletediDatabase(ID, tableNo, price, qty[index]);
            }
            else
            {

            }
        }

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

        private void insertkeDatabase(string id_menu, string nomor_meja, int harga, int pesan_qty)
        {
            int nomor = Convert.ToInt32(nomor_meja);
            query = $"insert into CART_DETAIL_NOTA values ('{nomor}','{id_menu}', '{pesan_qty}', '{harga}', '0')";
            command = new MySqlCommand(query, connect);
            command.ExecuteNonQuery();
        }

        private void AlterDatabase(string id_menu, string nomor_meja, int harga, int pesan_qty)
        {
            int nomor = Convert.ToInt32(nomor_meja);
            query = $"update CART_DETAIL_NOTA set PESAN_QTY = '{pesan_qty}' where ID_MENU = '{id_menu}' AND NOMOR_MEJA = {nomor};";
            command = new MySqlCommand(query, connect);
            command.ExecuteNonQuery();
        }

        private void deletediDatabase(string id_menu, string nomor_meja, int harga, int pesan_qty)
        {
            int nomor = Convert.ToInt32(nomor_meja);
            query = $"delete from CART_DETAIL_NOTA where ID_MENU = '{id_menu}' AND NOMOR_MEJA = {nomor};";
            command = new MySqlCommand(query, connect);
            command.ExecuteNonQuery();
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

                FormPayment formPayment = new FormPayment(connect, dtPesan,parentForm, namaPegawai,tableNo);
                formPayment.convDataTable(dtPesan);

                query = $"delete from CART_DETAIL_NOTA where NOMOR_MEJA = '{lb_tableNo.Text}';";
                command = new MySqlCommand(query, connect);
                command.ExecuteNonQuery();

                formPayment.MdiParent = parentForm;
                formPayment.Show();
            }
            else
            {

            }
        }

        private void btn_addNasgor_Click(object sender, EventArgs e)
        {
            string nama = "Nasi Goreng";
            int index = 0;
            string ID = "FD01";
            add(nama, index, ID);
        }
        private void btn_minNasgor_Click(object sender, EventArgs e)
        {
            string nama = "Nasi Goreng";
            int index = 0;
            string ID = "FD01";
            min(nama, index, ID);
        }

        private void btn_addMiegor_Click(object sender, EventArgs e)
        {
            string nama = "Mie Goreng";
            int index = 1;
            string ID = "FD02";
            add(nama, index, ID);
        }

        private void btn_minMiegor_Click(object sender, EventArgs e)
        {
            string nama = "Mie Goreng";
            int index = 1;
            string ID = "FD02";
            min(nama, index, ID);
        }

        private void btn_addBatagor_Click(object sender, EventArgs e)
        {
            string nama = "Batagor";
            int index = 2;
            string ID = "FD03";
            add(nama, index, ID);
        }

        private void btn_minBatagor_Click(object sender, EventArgs e)
        {
            string nama = "Batagor";
            int index = 2;
            string ID = "FD03";
            min(nama, index, ID);
        }

        private void btn_addGadogado_Click(object sender, EventArgs e)
        {
            string nama = "Gado-Gado";
            int index = 3;
            string ID = "FD04";
            add(nama, index, ID);
        }

        private void btn_minGadogado_Click(object sender, EventArgs e)
        {
            string nama = "Gado-Gado";
            int index = 3;
            string ID = "FD04";
            min(nama, index, ID);
        }

        private void btn_addPecel_Click(object sender, EventArgs e)
        {
            string nama = "Nasi Pecel";
            int index = 4;
            string ID = "FD05";
            add(nama, index, ID);
        }

        private void btn_minPecel_Click(object sender, EventArgs e)
        {
            string nama = "Nasi Pecel";
            int index = 4;
            string ID = "FD05";
            min(nama, index, ID);
        }

        private void btn_addSoto_Click(object sender, EventArgs e)
        {
            string nama = "Soto Mie";
            int index = 5;
            string ID = "FD06";
            add(nama, index, ID);
        }

        private void btn_minSoto_Click(object sender, EventArgs e)
        {
            string nama = "Soto Mie";
            int index = 5;
            string ID = "FD06";
            min(nama, index, ID);
        }

        private void btn_addRawon_Click(object sender, EventArgs e)
        {
            string nama = "Nasi Rawon";
            int index = 6;
            string ID = "FD07";
            add(nama, index, ID);
        }

        private void btn_minRawon_Click(object sender, EventArgs e)
        {
            string nama = "Nasi Rawon";
            int index = 6;
            string ID = "FD07";
            min(nama, index, ID);
        }

        private void btn_addSopbun_Click(object sender, EventArgs e)
        {
            string nama = "Sop Buntut";
            int index = 7;
            string ID = "FD08";
            add(nama, index, ID);
        }

        private void btn_minSopbun_Click(object sender, EventArgs e)
        {
            string nama = "Sop Buntut";
            int index = 7;
            string ID = "FD08";
            min(nama, index, ID);
        }

        private void btn_addSate_Click(object sender, EventArgs e)
        {
            string nama = "Sate Ayam";
            int index = 8;
            string ID = "FD09";
            add(nama, index, ID);
        }

        private void btn_minSate_Click(object sender, EventArgs e)
        {
            string nama = "Sate Ayam";
            int index = 8;
            string ID = "FD09";
            min(nama, index, ID);
        }

        private void btn_addNascam_Click(object sender, EventArgs e)
        {
            string nama = "Nasi Campur";
            int index = 9;
            string ID = "FD10";
            add(nama, index, ID);
        }

        private void btn_minNascam_Click(object sender, EventArgs e)
        {
            string nama = "Nasi Campur";
            int index = 9;
            string ID = "FD10";
            min(nama, index, ID);
        }

        private void btn_addAygor_Click(object sender, EventArgs e)
        {
            string nama = "Ayam Goreng";
            int index = 10;
            string ID = "FD11";
            add(nama, index, ID);
        }

        private void btn_minAygor_Click(object sender, EventArgs e)
        {
            string nama = "Ayam Goreng";
            int index = 10;
            string ID = "FD11";
            min(nama, index, ID);
        }

        private void btn_addAypen_Click(object sender, EventArgs e)
        {
            string nama = "Ayam Penyet";
            int index = 11;
            string ID = "FD12";
            add(nama, index, ID);
        }

        private void btn_minAypen_Click(object sender, EventArgs e)
        {
            string nama = "Ayam Penyet";
            int index = 11;
            string ID = "FD12";
            min(nama, index, ID);
        }

        private void btn_addEmpal_Click(object sender, EventArgs e)
        {
            string nama = "Empal Penyet";
            int index = 12;
            string ID = "FD13";
            add(nama, index, ID);
        }

        private void btn_minEmpal_Click(object sender, EventArgs e)
        {
            string nama = "Empal Penyet";
            int index = 12;
            string ID = "FD13";
            min(nama, index, ID);
        }

        private void btn_addBakwan_Click(object sender, EventArgs e)
        {
            string nama = "Bakwan Penyet";
            int index = 13;
            string ID = "FD14";
            add(nama, index, ID);
        }

        private void btn_minBakwan_Click(object sender, EventArgs e)
        {
            string nama = "Bakwan Penyet";
            int index = 13;
            string ID = "FD14";
            min(nama, index, ID);
        }

        private void btn_addBakso_Click(object sender, EventArgs e)
        {
            string nama = "Bakso Sapi";
            int index = 14;
            string ID = "FD15";
            add(nama, index, ID);
        }

        private void btn_minBakso_Click(object sender, EventArgs e)
        {
            string nama = "Bakso Sapi";
            int index = 14;
            string ID = "FD15";
            min(nama, index, ID);
        }

        private void btn_addNasi_Click(object sender, EventArgs e)
        {
            string nama = "Nasi Putih";
            int index = 15;
            string ID = "FD16";
            add(nama, index, ID);
        }

        private void btn_minNasi_Click(object sender, EventArgs e)
        {
            string nama = "Nasi Putih";
            int index = 15;
            string ID = "FD16";
            min(nama, index, ID);
        }

        private void timer_kasir_Tick(object sender, EventArgs e)
        {
            dateStatus.Text = DateTime.Today.ToLongDateString();
        }
    }
}
