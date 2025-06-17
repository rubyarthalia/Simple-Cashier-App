using MySql.Data.MySqlClient;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ALP
{
    public partial class FormDrink : Form
    {
        public MySqlConnection connect;
        public SshClient sshClient;
        MySqlCommand command;

        DataTable dtPesan;
        FormMenu parentForm;

        string namaPegawai = string.Empty;

        public int total;
        public int totalQuantity;
        public int[] qty = new int[14];
        string query;
        string tableNo = string.Empty;

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

        private void min(string nama, int index, string ID)
        {
            int price = 0;
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

                FormPayment formPayment = new FormPayment(connect, dtPesan, parentForm, namaPegawai, tableNo);
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


        public FormDrink(MySqlConnection conn, FormMenu parentForm, DataTable _dtpesanan, string _namaPegawai, string _tableNo)
        {
            InitializeComponent();
            this.dtPesan = _dtpesanan;
            connect = conn;
            this.parentForm = parentForm;
            dgv_pesanan.DataSource = dtPesan;
            namaPegawai = _namaPegawai;
            tableNo = _tableNo;
            lb_tableNo.Text = tableNo;
        }
        public FormDrink()
        {
            InitializeComponent();
        }
        public void convDataTable(DataTable _dtPesan)
        {
            dtPesan = _dtPesan;
            dgv_pesanan.DataSource = dtPesan;
        }

        private void FormDrink_Load(object sender, EventArgs e)
        {
            //lb_tableNo.Text = tableNo;
            string query = "select ID_PEGAWAI from PEGAWAI where NAMA_PEGAWAI = " + "'" + namaPegawai + "'" + ";";
            command = new MySqlCommand(query, connect);
            string idPegawai = command.ExecuteScalar().ToString();
            lb_staffID.Text = idPegawai;

            if (dtPesan.Rows.Count != 0)
            {
                hasil();
            }

        }

        private void btn_addAir_Click(object sender, EventArgs e)
        {
            string nama = "Air Mineral";
            int index = 0;
            string ID = "DR01";
            add(nama, index, ID);
        }

        private void btn_minAir_Click(object sender, EventArgs e)
        {
            string nama = "Air Mineral";
            int index = 0;
            string ID = "DR01";
            min(nama, index, ID);
        }

        private void btn_addTehmanis_Click(object sender, EventArgs e)
        {
            string nama = "Es Teh Manis";
            int index = 1;
            string ID = "DR02";
            add(nama, index, ID);
        }

        private void btn_minTehmanis_Click(object sender, EventArgs e)
        {
            string nama = "Es Teh Manis";
            int index = 1;
            string ID = "DR02";
            min(nama, index, ID);
        }

        private void btn_addTehtawar_Click(object sender, EventArgs e)
        {
            string nama = "Es Teh Tawar";
            int index = 2;
            string ID = "DR03";
            add(nama, index, ID);
        }

        private void btn_minTehtawar_Click(object sender, EventArgs e)
        {
            string nama = "Es Teh Tawar";
            int index = 2;
            string ID = "DR03";
            min(nama, index, ID);
        }

        private void btn_addJeruk_Click(object sender, EventArgs e)
        {
            string nama = "Es Jeruk Manis";
            int index = 3;
            string ID = "DR04";
            add(nama, index, ID);
        }

        private void btn_minJeruk_Click(object sender, EventArgs e)
        {
            string nama = "Es Jeruk Manis";
            int index = 3;
            string ID = "DR04";
            min(nama, index, ID);
        }

        private void btn_addJernip_Click(object sender, EventArgs e)
        {
            string nama = "Es Jeruk Nipis";
            int index = 4;
            string ID = "DR05";
            add(nama, index, ID);
        }

        private void btn_minJernip_Click(object sender, EventArgs e)
        {
            string nama = "Es Jeruk Nipis";
            int index = 4;
            string ID = "DR05";
            min(nama, index, ID);
        }

        private void btn_addCendol_Click(object sender, EventArgs e)
        {
            string nama = "Es Cendol";
            int index = 5;
            string ID = "DR06";
            add(nama, index, ID);
        }

        private void btn_minCendol_Click(object sender, EventArgs e)
        {
            string nama = "Es Cendol";
            int index = 5;
            string ID = "DR06";
            min(nama, index, ID);
        }
         
        private void btn_addDegan_Click(object sender, EventArgs e)
        {
            string nama = "Es Degan";
            int index = 6;
            string ID = "DR07";
            add(nama, index, ID);
        }

        private void btn_minDegan_Click(object sender, EventArgs e)
        {
            string nama = "Es Degan";
            int index = 6;
            string ID = "DR07";
            min(nama, index, ID);
        }

        private void btn_addJahe_Click(object sender, EventArgs e)
        {
            string nama = "Wedang Jahe";
            int index = 7;
            string ID = "DR08";
            add(nama, index, ID);
        }

        private void btn_minJahe_Click(object sender, EventArgs e)
        {
            string nama = "Wedang Jahe";
            int index = 7;
            string ID = "DR08";
            min(nama, index, ID);
        }

        private void btn_addTehtarik_Click(object sender, EventArgs e)
        {
            string nama = "Teh Tarik";
            int index = 8;
            string ID = "DR09";
            add(nama, index, ID);
        }

        private void btn_minTehTarik_Click(object sender, EventArgs e)
        {
            string nama = "Teh Tarik";
            int index = 8;
            string ID = "DR09";
            min(nama, index, ID);
        }

        private void btn_addBuah_Click(object sender, EventArgs e)
        {
            string nama = "Es Buah";
            int index = 9;
            string ID = "DR10";
            add(nama, index, ID);
        }

        private void btn_minBuah_Click(object sender, EventArgs e)
        {
            string nama = "Es Buah";
            int index = 9;
            string ID = "DR10";
            min(nama, index, ID);
        }

        private void btn_addAlpukat_Click(object sender, EventArgs e)
        {
            string nama = "Jus Alpukat";
            int index = 10;
            string ID = "DR11";
            add(nama, index, ID);
        }

        private void btn_minAlpukat_Click(object sender, EventArgs e)
        {
            string nama = "Jus Alpukat";
            int index = 10;
            string ID = "DR11";
            min(nama, index, ID);
        }

        private void btn_addSirsak_Click(object sender, EventArgs e)
        {
            string nama = "Jus Sirsak";
            int index = 11;
            string ID = "DR12";
            add(nama, index, ID);
        }

        private void btn_minSirsak_Click(object sender, EventArgs e)
        {
            string nama = "Jus Sirsak";
            int index = 11;
            string ID = "DR12";
            min(nama, index, ID);
        }

        private void btn_addMangga_Click(object sender, EventArgs e)
        {
            string nama = "Jus Mangga";
            int index = 12;
            string ID = "DR13";
            add(nama, index, ID);
        }

        private void btn_minMangga_Click(object sender, EventArgs e)
        {
            string nama = "Jus Mangga";
            int index = 12;
            string ID = "DR13";
            min(nama, index, ID);
        }

        private void btn_addNaga_Click(object sender, EventArgs e)
        {
            string nama = "Jus Buah Naga";
            int index = 13;
            string ID = "DR14";
            add(nama, index, ID);
        }

        private void btn_minNaga_Click(object sender, EventArgs e)
        {
            string nama = "Jus Buah Naga";
            int index = 13;
            string ID = "DR14";
            min(nama, index, ID);
        }

        private void timer_kasir_Tick(object sender, EventArgs e)
        {
            dateStatus.Text = DateTime.Today.ToLongDateString();
        }
    }
}
