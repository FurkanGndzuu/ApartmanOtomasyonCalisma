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
    public partial class BinaGiderleri : Form
    {
        public BinaGiderleri()
        {
            InitializeComponent();
        }
        SqlHelper sqlHelper=new SqlHelper();
        private void btnGiderEkle_Click(object sender, EventArgs e)
        {
            int para = Convert.ToInt32(txtGiderMiktari.Text);
            DateTime yeni = dateTarihPicker.Value;

            string Giderler = "";
            foreach(Control item in groupBox1.Controls)
            {
                if(item is CheckBox && ((CheckBox)item).Checked)
                {
                    Giderler+=" , "+item.Text;
                }
            }

            Giderler = Giderler.Remove(0, 1);

            SqlParameter p1 = new SqlParameter("GiderCesid", Giderler);

            SqlParameter p2 = new SqlParameter("Para", para);

            SqlParameter p3 = new SqlParameter("Tarih", yeni);

            sqlHelper.executeProc("binaGiderProc", p1, p2, p3);
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BinaGiderleri_Load(object sender, EventArgs e)
        {
            DataTable dt =sqlHelper.getTable("select *from BinaGiderVerileri");

            foreach(DataRow dr in dt.Rows)
            {
                listBox1.Items.Add(dr[3].ToString());
                listBox2.Items.Add(dr[1].ToString());
                listBox3.Items.Add(dr[2].ToString());
            }

        }
    }
}
