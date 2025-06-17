using MySql.Data.MySqlClient;
using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALP
{
    public partial class FormNota : Form
    {
        public MySqlConnection connect;
        public SshClient sshClient;
        MySqlCommand command;
        DataTable dtPesan;
        FormMenu parentForm;
        string idnota;
        string idpegawai;
        string tableNo = string.Empty;
        string kodepromo;
        string waktutransaksi;
        string totalquantity;
        double diskon;
        double totalcash;
        string paymentmethod;
        string subtotal;
        string ppn;
        string servicecharge;
        string total;
        double kembalian;


        public FormNota(MySqlConnection conn, DataTable _dtPesan, string idNota, string idpegawai, string kodepromo, string waktutransaksi, string nomormerja, string totalmenu,
            double diskon, string method, string subtotal, string ppn, string service, string total, double totalcash, double kembalian)
        {
            connect = conn;
            dtPesan = _dtPesan;
            this.idnota = idNota;
            this.idpegawai = idpegawai;
            tableNo = nomormerja;
            this.kodepromo = kodepromo;
            this.waktutransaksi = waktutransaksi;
            this.diskon = diskon;
            totalquantity = totalmenu;
            paymentmethod = method;
            this.subtotal = subtotal;
            this.ppn = ppn;
            servicecharge = service;
            this.total = total;
            this.totalcash = totalcash;
            this.kembalian = kembalian;

            InitializeComponent();

        }

        private void FormNota_Load(object sender, EventArgs e)
        {
            
            if(string.IsNullOrWhiteSpace(kodepromo))
            {
                lb_kodepromo.Text = "-";
                lb_diskon.Text = "0";
            }
            else
            {
                lb_kodepromo.Text = kodepromo;
                string promo = Convert.ToString(diskon);
                lb_diskon.Text = NumberFormatter.FormatNumber(Convert.ToDouble(promo));
            }
            lb_nomeja.Text = tableNo;
            lb_idpegawai.Text = idpegawai;
            dineinatautakeaway(tableNo);
            lb_subtotal.Text = NumberFormatter.FormatNumber(Convert.ToDouble(subtotal));
            lb_ppn.Text = NumberFormatter.FormatNumber(Convert.ToDouble(ppn));
            lb_srvcharge.Text = NumberFormatter.FormatNumber(Convert.ToDouble(servicecharge));
            lb_paymentmethod.Text = paymentmethod.ToUpper();
            lb_nostruk.Text = idnota;
            lb_tglwaktu.Text = waktutransaksi;
            lb_total.Text = NumberFormatter.FormatNumber(Convert.ToDouble(total));
            lb_quantity.Text = totalquantity;
            totalmethod(paymentmethod);
            dgv_daftarpesan.DataSource = dtPesan;
            dgv_daftarpesan.Columns["ID"].Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateStatus.Text = DateTime.Now.ToLongDateString();
        }
        private void dineinatautakeaway(string nomormeja)
        {
            if (nomormeja == "00")
            {
                lb_makandimana.Text = "Take Away";
            }
            else
            {
                lb_makandimana.Text = "Dine In";
            }
        }
        public  static class NumberFormatter
        {
            public static string FormatNumber(double number)
            {
                CultureInfo culture = new CultureInfo("id-ID");
                return number.ToString("N0", culture);
            }

        }
        private void totalmethod(string methodbayar)
        {
            if(methodbayar == "Cash")
            {
                string bayar = Convert.ToString(totalcash);
                lb_bayar.Text = NumberFormatter.FormatNumber(Convert.ToDouble(bayar));
                lb_kembalian.Text = NumberFormatter.FormatNumber(Convert.ToDouble(kembalian));
            }
            else
            {
                lb_bayar.Text = NumberFormatter.FormatNumber(Convert.ToDouble(total));
                lb_kembalian.Text = "0";
            }
        }
    }
}
