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
    public partial class frmAddModel : Form
    {
        public frmAddModel()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-NL7UVRU;Initial Catalog=InstallmentTracking;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO Models VALUES('" + Form1.ProductId + "','" + Form1.TradeMarkId + "','" + txtNewModel.Text + "','" + Convert.ToInt32(txtPrice.Text) + "')";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.ExecuteNonQuery();
            Form1.fillTradeMarkComboBox(Form1.cmbTradeMark1, Form1.cmbModel1);
            con.Close();
            this.Close();
        }

        private void frmAddModel_Load(object sender, EventArgs e)
        {

        }
    }
}
