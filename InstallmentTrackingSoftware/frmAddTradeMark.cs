using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InstallmentTrackingSoftware
{
    public partial class frmAddTradeMark : Form
    {
        public frmAddTradeMark()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NL7UVRU;Initial Catalog=InstallmentTracking;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO TradeMarks VALUES('" + Form1.ProductId + "','" + txtNewTradeMark.Text + "')";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.ExecuteNonQuery();
            Form1.fillProductComboBox(Form1.cmbProduct2, Form1.cmbTradeMark1);
            con.Close();
            this.Close();
        }
    }
}
