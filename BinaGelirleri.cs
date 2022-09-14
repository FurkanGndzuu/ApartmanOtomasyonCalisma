using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApartmanOtomasyonCalisma
{
    public partial class BinaGelirleri : Form
    {
        public BinaGelirleri()
        {
            InitializeComponent();
        }

        SqlHelper sqlHelper =new SqlHelper();   

        private void btnGelirEkle_Click(object sender, EventArgs e)
        {
            int daireNo=Convert.ToInt32(cmbDaireNo.Text);
            int para = Convert.ToInt32(txtParaMiktari.Text);
            DateTime yeni = dateTarihPicker.Value;

            SqlParameter p1 = new SqlParameter("DaireNo",daireNo);
            SqlParameter p2 = new SqlParameter("Para", para);
            SqlParameter p3 = new SqlParameter("Tarih", yeni);

            sqlHelper.executeProc("aidatGelirProc", p1, p2, p3);



        }

        private void BinaGelirleri_Load(object sender, EventArgs e)
        {
            DataTable dt = sqlHelper.getTable("Select *from BinaGelirVerileri");

            foreach(DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr["DaireNo"].ToString());
                listBox2.Items.Add(dr["Para"].ToString());
                listBox3.Items.Add(dr["Tarih"].ToString());

            }

        }
    }
}
