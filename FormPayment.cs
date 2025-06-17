using MySql.Data.MySqlClient;
using System;
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
    public partial class FormPayment : Form
    {
        DataTable dtPesan;
        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        FormMenu parentForm;

        string tableNo = string.Empty;
        string namaPegawai = string.Empty;


        public FormPayment(MySqlConnection conn, DataTable _dtPesan, FormMenu formparent, string _namaPegawai, string _tableNo)
        {
            InitializeComponent();
            this.parentForm = formparent;
            dtPesan = _dtPesan;
            connect = conn;
            namaPegawai = _namaPegawai;
            tableNo = _tableNo;

        }
        public void convDataTable(DataTable _dtPesan)
        {
            dtPesan = _dtPesan;
            dgv_pesanan.DataSource = dtPesan;
        }

        string query;
        double subtotal = 0;
        double ppn;
        double service;
        double kembalian;
        string tanggal = DateTime.Today.ToString("ddMMyy");
        string idnota;
        DataTable dtPromo = new DataTable();
        private void FormPayment_Load(object sender, EventArgs e)
        {
            query = "select ID_PEGAWAI from PEGAWAI where NAMA_PEGAWAI = " + "'" + namaPegawai + "'" + ";";
            command = new MySqlCommand(query, connect);
            string idPegawai = command.ExecuteScalar().ToString();
            lb_staffID.Text = idPegawai;
            lb_tableNo.Text = tableNo;
            numberKey();
            try
            {
                query = "SELECT KODE_PROMO, JUMLAH_DISKON FROM PROMO WHERE KODE_PROMO IS NOT NULL;";
                command = new MySqlCommand(query, connect);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(dtPromo);
                cb_promo.DataSource = dtPromo;
                cb_promo.DisplayMember = "KODE_PROMO";
                cb_promo.ValueMember = "JUMLAH_DISKON";
                cb_promo.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int totalqty = 0;

            foreach (DataGridViewRow row in dgv_pesanan.Rows)
            {
                if (row.IsNewRow) continue;

                int quantity = Convert.ToInt32(row.Cells[3].Value);
                totalqty += quantity;
                int totalperitem = Convert.ToInt32(row.Cells[4].Value);
                subtotal += totalperitem;
            }
            tb_totalqty.Text = totalqty.ToString();
            tb_subtotal.Text = "Rp. " + subtotal.ToString();
            ppn = subtotal * 10 / 100;
            service = subtotal * 5 / 100;
            tb_ppn.Text = "Rp. " + ppn.ToString();
            tb_service.Text = "Rp. " + service.ToString();
            double total = subtotal + ppn + service;
            tb_totalprice.Text = "Rp. " + total.ToString();
            DataTable jumlah = new DataTable();
            query = "SELECT ifnull(count(date(tanggal_transaksi)), 0) as `jumlah_transaksi` from NOTA WHERE date(tanggal_transaksi) = curdate();";
            command = new MySqlCommand(query, connect);
            adapter = new MySqlDataAdapter(command);
            jumlah = new DataTable();
            adapter.Fill(jumlah);
            int count = Convert.ToInt32(jumlah.Rows[0]["jumlah_transaksi"]) + 1;
            string countnumber = count.ToString("000");
            idnota = $"SN{tanggal}{countnumber}";
        }

        bool cekmethod = true;

        private void btn_cash_Click(object sender, EventArgs e)
        {
            btn_one.Enabled = true;
            btn_two.Enabled = true;
            btn_three.Enabled = true;
            btn_four.Enabled = true;
            btn_five.Enabled = true;
            btn_six.Enabled = true;
            btn_seven.Enabled = true;
            btn_eight.Enabled = true;
            btn_nine.Enabled = true;
            btn_zero.Enabled = true;
            btn_zeroo.Enabled = true;
            btn_backspace.Enabled = true;

            btn_cash.Enabled = false;
            btn_credit.Enabled = true;
            btn_debit.Enabled = true;

            cekmethod = true;
            tb_paymentmethod.Text = "Cash";
            tb_pay.Clear();
            rtbamount = "";
            rtb_amount.Clear();
        }


        private void btn_credit_Click(object sender, EventArgs e)
        {
            numberKey();
            btn_cash.Enabled = true;
            btn_credit.Enabled = false;
            btn_debit.Enabled = true;
            tb_paymentmethod.Text = "Credit";
            tb_pay.Text = tb_totalprice.Text;
            cekmethod = false;
            rtbamount = "";
            rtb_amount.Clear();
        }

        private void btn_debit_Click(object sender, EventArgs e)
        {
            numberKey();
            btn_cash.Enabled = true;
            btn_credit.Enabled = true;
            btn_debit.Enabled = false;
            tb_paymentmethod.Text = "Debit";
            tb_pay.Text = tb_totalprice.Text;
            cekmethod = false;
            rtb_amount.Clear();
        }
        private void numberKey()
        {
            btn_one.Enabled = false;
            btn_two.Enabled = false;
            btn_three.Enabled = false;
            btn_four.Enabled = false;
            btn_five.Enabled = false;
            btn_six.Enabled = false;
            btn_seven.Enabled = false;
            btn_eight.Enabled = false;
            btn_nine.Enabled = false;
            btn_zero.Enabled = false;
            btn_zeroo.Enabled = false;
            btn_backspace.Enabled = false;
        }

        double total;
        private void btn_apply_Click(object sender, EventArgs e)
        {
            if (cb_promo.SelectedItem == null)
            {
                MessageBox.Show("Choose Promo First");
            }
            else if (cekmethod == true)
            {
                string selectpromo = cb_promo.Text;
                tb_kodepromo.Text = selectpromo;
                string diskon = selectpromo.Substring(selectpromo.Length - 2);
                double promo = subtotal * Convert.ToDouble(diskon) / 100;
                tb_diskon.Text = "Rp. " + promo.ToString();
                total = subtotal - promo + ppn + service;
                tb_totalprice.Text = "Rp. " + total.ToString();
            }
            else if (cekmethod == false)
            {
                string selectpromo = cb_promo.Text;
                tb_kodepromo.Text = selectpromo;
                string diskon = selectpromo.Substring(selectpromo.Length - 2);
                double promo = subtotal * Convert.ToDouble(diskon) / 100;
                tb_diskon.Text = "Rp. " + promo.ToString();
                total = subtotal - promo + ppn + service;
                tb_totalprice.Text = "Rp. " + total.ToString();
                tb_pay.Clear();
                tb_pay.Text = tb_totalprice.Text;
            }
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            
            string selectpromo = "";
            string diskon = "";
            if (cb_promo.Text == null)
            {
                selectpromo = "0";
            }
            else 
            { 
                selectpromo = cb_promo.Text; 
            }
            diskon = cb_promo.SelectedValue.ToString();
            double promo = subtotal * Convert.ToDouble(diskon) / 100;
            string promoo = Convert.ToString(promo);
            tb_kodepromo.Text = selectpromo;
            string promonya;
            if (tb_kodepromo.Text == "")
            {
                promonya = "null";
                promoo = "null";
            }
            else
            {
                promonya = "'"+tb_kodepromo.Text+"'";
            }

            //diskon = selectpromo.Substring(selectpromo.Length - 2);
            total = subtotal - promo + ppn + service;
            if (selectpromo == "")
            {
                total = subtotal + ppn + service;
            }

            string servicecharge = $"{service}";
            string idpegawai = lb_staffID.Text;
            string waktutransaksi = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string totalmenu = tb_totalqty.Text;
            string pajak = $"{ppn}";
            string totalharga = $"{subtotal}";
            string totalbayar = $"{total}";
            string methodbayar = tb_paymentmethod.Text;
           
            if (tb_paymentmethod.Text == "")
            {
                MessageBox.Show("Choose Payment Method");
            }
            else if (tb_pay.Text == "")
            {
                MessageBox.Show("Insert Amount");
            }
            else
            {
                string input = tb_pay.Text;
                int startIndex = 4;
                double totalpay = Convert.ToDouble(input.Substring(startIndex));

                if (totalpay < total)
                {
                    MessageBox.Show("Insufficient Amount");
                }
                else if (totalpay == total || totalpay > total)
                {
                    kembalian = totalpay - total;
                    MessageBox.Show("Success");
                    query = $"INSERT INTO NOTA(ID_NOTA, KODE_PROMO, ID_PEGAWAI, TANGGAL_TRANSAKSI, NOMOR_MEJA, TOTAL_JUMLAH_MENU, TOTAL_HARGA, DISKON, PAJAK, SERVICE_CHARGE, TOTAL_BAYAR, METHOD_BAYAR, STATUS_BAYAR, STATUS_DEL)" +
                        $"VALUES('{idnota}',{promonya},'{idpegawai}','{waktutransaksi}','{tableNo}','{totalmenu}', '{totalharga}',{promoo}, '{pajak}','{servicecharge}','{totalbayar}', '{methodbayar}','1','0')";
                    command = new MySqlCommand(query, connect);
                    command.ExecuteNonQuery();
                    for (int i = 0; i < dtPesan.Rows.Count; i++)
                    {
                        double hargadetailnota = Convert.ToDouble(dtPesan.Rows[i][4]) / Convert.ToDouble(dtPesan.Rows[i][3]);
                        query = $"insert into DETAIL_NOTA(ID_MENU, ID_NOTA, PESAN_QTY, PESAN_HARGA, STATUS_DEL) VALUES('{dtPesan.Rows[i][0]}','{idnota}', '{dtPesan.Rows[i][3]}', '{hargadetailnota}','1')";
                        command = new MySqlCommand(query, connect);
                        command.ExecuteNonQuery();

                    }
                    //lanjut form struk
                    if (this.MdiChildren.Any())
                    {
                        foreach (Form frm in MdiChildren)
                        {
                            frm.Close();
                        }
                    }
                    FormNota formnota = new FormNota(connect, dtPesan, idnota, idpegawai, selectpromo, waktutransaksi, tableNo, totalmenu, promo, methodbayar, totalharga, pajak, servicecharge, totalbayar, totalpay, kembalian);
                    formnota.MdiParent = parentForm;
                    formnota.Show();
                }
            }
        }
        

        private void btn_one_Click(object sender, EventArgs e)
        {
            UpdateTB_Pay("1");
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            UpdateTB_Pay("2");
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            UpdateTB_Pay("3");
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            UpdateTB_Pay("4");
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            UpdateTB_Pay("5");
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            UpdateTB_Pay("6");
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            UpdateTB_Pay("7");
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            UpdateTB_Pay("8");
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            UpdateTB_Pay("9");
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            UpdateTB_Pay("0");
        }

        private void btn_zeroo_Click(object sender, EventArgs e)
        {
            UpdateTB_Pay("000");
        }


        string rtbamount;

        private void btn_backspace_Click(object sender, EventArgs e)
        {
            if (rtb_amount.Text.Length > 0)
            {
                rtb_amount.Text = rtb_amount.Text.Substring(0, rtb_amount.Text.Length - 1);
                rtbamount = rtb_amount.Text;
                tb_pay.Text = "Rp. " + rtb_amount.Text;
            }
        }
        private void UpdateTB_Pay(string text)
        {
            if (cekmethod == true)
            {
                rtbamount += text;
                rtb_amount.Text = rtbamount;
                tb_pay.Text = "Rp. " + rtb_amount.Text;
            }
        }




        private void cb_promo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btn_apply.Enabled = true;
        }

        private void timer_kasir_Tick(object sender, EventArgs e)
        {
            dateStatus.Text = DateTime.Today.ToLongDateString();

            DateTime today = DateTime.Today;
        }
    }
}
