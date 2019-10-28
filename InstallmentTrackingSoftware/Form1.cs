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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection();
        public static Object ProductId, TradeMarkId, Price, CustomerId, SalesId, StateInstallment, InstId, AmountMounth;
        public static ComboBox cmbProduct1, cmbProduct2, cmbCustomer1, cmbTradeMark1, cmbModel1;
        DataTable dt = new DataTable();

        private void tabPage_Click(object sender, EventArgs e)
        {
            // Müşteri tabına tıklandığında
            if (tabControl1.SelectedIndex == 1)
            {
                cmbCustomer.Items.Clear();
                cmbCustomer.Text = "";
                cmbCustomer.SelectedText = "-- Lütfen Seçiniz --";
                grpMusteri.Visible = false;

                // Müşteri Combox'ı doldur.
                fillCustomer(cmbCustomer);
            }
            // Yeni Ürün tabına tıklandığında
            else if(tabControl1.SelectedIndex == 2)
            {
                if (cmbNewProducts.Text == "")
                {
                    cmbNewProducts.SelectedText = "-- Lütfen Seçiniz --";
                    cmbNewTradeMark.SelectedText = "-- Lütfen Seçiniz --";
                    cmbNewModel.SelectedText = "-- Lütfen Seçiniz --";
                }
                grpMusteri.Visible = false;
            }
        }

        // Satış tabında Devam Et Butonunun Yaptığı İşlevler
        private void button1_Click(object sender, EventArgs e)
        {
            grpMusteri.Visible = true;
            if(cmbInstallment.Text == "")
            {
                cmbInstallment.SelectedText = "-- Lütfen Seçiniz --";
            }

            // Müşteri bilgilerini textboxlara çekmek için
            dt = fillDataTable("SELECT Id, NameSurname, Adress FROM Customers WHERE NameSurname = '" + cmbSelectCustomer.SelectedItem.ToString() + "'");
            foreach (DataRow dr in dt.Rows)
            {
                txtCustomerNameSurname.Text = dr["NameSurname"].ToString();
                rtxtCutomerAddress.Text = dr["Adress"].ToString();
                CustomerId = dr["Id"];
            }

        }

        // Form1 yüklendiğinde
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTradeMark.SelectedText = "-- Lütfen Ürün Seçiniz --";
            cmbModel.SelectedText = "-- Lütfen Marka Seçiniz --";
            cmbProducts.SelectedText = "-- Lütfen Seçiniz --";
            cmbSelectCustomer.SelectedText = "-- Lütfen Seçiniz --";

            cmbProduct1 = cmbProducts;
            cmbProduct2 = cmbNewProducts;
            cmbCustomer1 = cmbSelectCustomer;
            cmbTradeMark1 = cmbNewTradeMark;
            cmbModel1 = cmbNewModel;
            // Satış tabında müşteri combobox'ını doldfurmak için
            fillCustomer(cmbCustomer1);

            // Satış ve Yeni Ekle tablarında ürün combobox'ını doldurmak için

            ProductsFill(cmbProduct1, cmbProduct2);
        }

        public static void fillCustomer(ComboBox cmb)
        {
            cmb.Items.Clear();
            DataTable dt = new DataTable();
            dt = fillDataTable("SELECT NameSurname FROM Customers");
            foreach (DataRow dr in dt.Rows)
            {
                cmb.Items.Add(dr["NameSurname"].ToString());
            }
        }

        public static void ProductsFill(ComboBox cmb1, ComboBox cmb2)
        {
            cmb1.Items.Clear();
            cmb2.Items.Clear();
            DataTable dt = new DataTable();
            dt = fillDataTable("SELECT Product FROM Products");
            foreach (DataRow dr in dt.Rows)
            {
                cmb1.Items.Add(dr["Product"].ToString());
                cmb2.Items.Add(dr["Product"].ToString());
            }
        }

        // Müşteri tabında müşteri combobox'ından seçim yapıldığında
        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenCon();

            // Daha sonra müşteriye ait bilgileri getirebilmek müşteri Id'sini al
            String queryCustomerId = "SELECT Id FROM Customers WHERE NameSurname = '" + cmbCustomer.SelectedItem.ToString() + "'";
            SqlDataAdapter daCustomerId = new SqlDataAdapter(queryCustomerId, con);
            CustomerId = daCustomerId.SelectCommand.ExecuteScalar();
            CloseCon();

            // Müşteri id'sine göre ilgili müşterinin tüm alışveriş bilgilerini DataGridView'e doldurmak için.
            dt = fillDataTable("SELECT Id, Product, TradeMark, Model, SumAmount, AdvancePayment, RemainingAmount, Installment FROM Sales WHERE CustomerId = '" + CustomerId + "'");

            dataGridView2.DataSource = null; // GridView'da veriler tekrarlanmaması için her müşteri seçiminde sıfırlama ve yenileme
            dataGridView2.Refresh();
            dataGridView1.DataSource = null; // GridView'da veriler tekrarlanmaması için her müşteri seçiminde sıfırlama ve yenileme
            dataGridView1.Refresh();
            dataGridView1.AutoGenerateColumns = false; // Tablodan sadece istenilen verileri getirmek için
            dataGridView1.DataSource = dt; // GridView'e verileri çekme işlemi
        }

        // Yeni müşteri ekleme formunu açar 
        private void button7_Click(object sender, EventArgs e)
        {
            frmMusteriEkle fMusteriEkle = new frmMusteriEkle();
            fMusteriEkle.Show();
        }

        // Yeni Ekle tabında yeni bir Marka ve/veya Model eklemek için önce hangi ürüne ait olduğu seçilmelidir. 
        // Ürün combobox'ında seçim yapıldıktan sonraki işlemler.
        private void cmbNewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.Visible = true;
            cmbNewTradeMark.Visible = true;
            button4.Visible = true;

            cmbNewTradeMark.Items.Clear();

            fillProductComboBox(cmbNewProducts, cmbNewTradeMark);
        }

        // Yeni marka ekleme formunu açar 
        private void button4_Click(object sender, EventArgs e)
        {
            frmAddTradeMark fTradeMark = new frmAddTradeMark();
            fTradeMark.Show();
        }

        // Yeni Ekle tabında yeni bir Model eklemek için önce hangi ürüne ait olduğu seçilmelidir. 
        // Marka combobox'ında seçim yapıldıktan sonraki işlemler..
        private void cmbNewTradeMark_SelectedIndexChanged(object sender, EventArgs e)
        {
            label10.Visible = true;
            cmbNewModel.Visible = true;
            button5.Visible = true;
            cmbNewModel.Items.Clear();

            fillTradeMarkComboBox(cmbNewTradeMark, cmbNewModel);
        }

        // Yeni ürün ekleme formunu açar.
        private void button3_Click(object sender, EventArgs e)
        {
            frmAddProduct fProduct = new frmAddProduct();
            fProduct.Show();
        }

        // Satış tabında ürün seçildikten sonraki işlemler..
        private void cmbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTradeMark.Text = "";
            cmbTradeMark.SelectedText = "-- Lütfen Seçiniz --";
            cmbModel.Text = "";
            cmbModel.SelectedText = "-- Lütfen Seçiniz --";
            cmbTradeMark.Items.Clear();
            cmbModel.Items.Clear();

            fillProductComboBox(cmbProducts, cmbTradeMark);
        }

        // Yeni marka ekleme formunu açar.
        private void button5_Click(object sender, EventArgs e)
        {
            frmAddModel fModel = new frmAddModel();
            fModel.Show();
        }

        // Müşterinin satın aldığı ürünlerin listesinde tıklanılan ürüne ait taksit tablosunu görmek için yapılan işlevler..
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dataGridView1.CurrentRow;
            SalesId = currentRow.Cells["Id"].Value.ToString(); // Tıklanılan satırdaki satışın Id'si..
            
            // İlgili satışa ait verilerin veritabanından getirilmesi 
            OpenCon();
            dt = fillDataTable("SELECT Id,Date, Amount, State FROM Installment WHERE SalesId = '" + SalesId + "'");
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = dt; // Getirilen verilerin gridview'e dökülmesi
            CloseCon();
        }

        // Taksit tablosunda seçilen ay taksidinin ödenme durumunu güncelleme işlemleri..
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.ColumnIndex == 0) // Güncelleme butonuna tıklandıysa
            {
                if (MessageBox.Show("Ödeme bilgisi güncellemek istediğinizden emin misiniz?", "Ödeme Onayı", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {// Açılan mesaj box onaylandı ise
                    DataGridViewRow currentRow = dataGridView2.CurrentRow; // Seçili satırı alma
                    Object InstallmentId = currentRow.Cells["InstallmentId"].Value.ToString(); // Güncelleme işleminde kullanılması için seçili satırdaki verinin Id'sini almak
                    
                    // Taksit tablosunda ilgili taksitin ödenme durumunu güncellemek için gereken veriler..
                    dt = fillDataTable("SELECT SalesId,State,Amount FROM Installment WHERE Id = '" + InstallmentId + "'");
                    foreach (DataRow dr in dt.Rows)
                    {
                        StateInstallment = dr["State"];
                        InstId = dr["SalesId"];
                        AmountMounth = dr["Amount"];
                    }

                    OpenCon();
                    String queryRemining = "SELECT RemainingAmount FROM Sales WHERE Id = '" + InstId + "'"; // Satış tablosundaki kalan tutar verisini güncellemek için..
                    SqlDataAdapter daRemaining = new SqlDataAdapter(queryRemining, con);
                    Object Remaining = daRemaining.SelectCommand.ExecuteScalar();
                    float remaining = Convert.ToInt32(Remaining) - Convert.ToInt32(AmountMounth); // Ödendi olarak güncellenmişse kalan tutarı azaltma işlemi
                    float remainingPlus = Convert.ToInt32(Remaining) + Convert.ToInt32(AmountMounth); // Ödenmedi olarak güncellenmişse kalan tutarı arttırma işlemi

                    String query, queryUpdate;

                    if ((bool)StateInstallment == false) // Şu an ki ödenme durumu false ise (Ödenmemişse)
                    {
                        query = "UPDATE Installment SET State = 1 WHERE State = 0 AND Id = '" + InstallmentId + "' ";
                        queryUpdate = "UPDATE Sales SET RemainingAmount  = '" + remaining + "' WHERE Id = '" + InstId + "'";
                    }
                    else // Şu an ki ödenme durumu true ise (Ödenmişse)
                    {
                        query = "UPDATE Installment SET State = 0 WHERE State = 1 AND Id = '" + InstallmentId + "' ";
                        queryUpdate = "UPDATE Sales SET RemainingAmount  = '" + remainingPlus + "' WHERE Id = '" + InstId + "'";
                    }

                    // Ödenme durumunu ödenmiş olarak güncelle.
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    da.SelectCommand.ExecuteNonQuery();

                    // Ödenme durumunu ödenmemiş olarak güncelle.
                    SqlDataAdapter daUpdate = new SqlDataAdapter(queryUpdate, con);
                    daUpdate.SelectCommand.ExecuteNonQuery();
                    CloseCon();
                }
                else
                {
                    MessageBox.Show("Güncelleme işleminiz iptal edildi.");
                }
            }
        }

        // Satış tabında marka seçildikten sonra model seçme işlemi
        private void cmbTradeMark_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbModel.Text = "";
            cmbModel.SelectedText = "-- Lütfen Seçiniz --";
            cmbModel.Items.Clear();

            fillTradeMarkComboBox(cmbTradeMark, cmbModel);
        }

        // Satış tabında kaydet butonuna basıldıktan sonra veritabanına kaydetme işlemleri..
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dtm = DateTime.Now; // Bugünün tarihi
            int RemainingAmount = Convert.ToInt32(Price) - Convert.ToInt32(txtAdvancePayment.Text); // Peşinattan sonra kalan tutar
            int installment = Convert.ToInt32(cmbInstallment.SelectedItem.ToString());
            float amount = RemainingAmount / installment; // Seçilen taksit seçeneğine göre aylık taksit ücreti

            // Verileri satış tablosuna kaydetme
            OpenCon();
            String querySales = "INSERT INTO Sales VALUES('" + CustomerId + "','" + cmbProducts.SelectedItem.ToString() + "','" + cmbTradeMark.SelectedItem.ToString() + 
                                                     "','" + cmbModel.SelectedItem.ToString() + "','" + Price + "','" + Convert.ToInt32(txtAdvancePayment.Text) + 
                                                     "','" + RemainingAmount + "','" + installment + "')";
            SqlDataAdapter daSales = new SqlDataAdapter(querySales, con);
            daSales.SelectCommand.ExecuteNonQuery();

            // En son eklenen satışın Id'si.. (Satışa ait taksit bilgilerini oluşturmak için)
            String query = "SELECT TOP 1 Id FROM Sales ORDER BY Id DESC";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SalesId = da.SelectCommand.ExecuteScalar();
            
            for (int i = 0; i < installment; i++)// Kaç taksit istenmişse taksit tablosunda o kadar kayıt oluşturmak için döngü
            {
                dtm = dtm.AddMonths(1); // Taksitlerin bir sonraki ay başlaması için.. Bu fonk. her döngüde bir sonraki ayın alınmasını sağlıyor.

                // Taksit tablosuna kayıtların eklenmesi
                String queryInstallment = "INSERT INTO Installment VALUES('" + SalesId + "', 0 , '" + amount + "', '" + dtm.ToString("y") + "')";
                SqlDataAdapter daInstallment = new SqlDataAdapter(queryInstallment, con);
                daInstallment.SelectCommand.ExecuteNonQuery();
            }
            CloseCon();
        }

        // Model seçildikten toplam tutarı kullancıya göstermek için..
        private void cmbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            // İlgili modelin fiyatını almak
            OpenCon();
            String query = "SELECT Price FROM Models WHERE ProductId = '" + ProductId + "' AND TradeMarkId = '" + TradeMarkId + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            Price = da.SelectCommand.ExecuteScalar();

            label14.Text = Price.ToString();
            CloseCon();
        }

        // DataTable'ları doldurmak için.. (Aynı işlemleri her yerde tekrar tekrar yazmamak için)
        public static DataTable fillDataTable(String q)
        {
            OpenCon();
            String query = q;
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da.Fill(dt);
            CloseCon();

            return dt;
        }

        // Ürün combobox'larını doldurmak için fonk
        public static void fillProductComboBox(ComboBox cmb1, ComboBox cmb2)
        {
            // Seçilen ürüne ait markaları getirebilmek için ÜrünId..
            OpenCon();
            String query = "SELECT Id FROM Products WHERE Product = '" + cmb1.SelectedItem.ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            ProductId = da.SelectCommand.ExecuteScalar();
            CloseCon();

            // Marka combobox'ını doldur.
            DataTable dt = new DataTable();
            dt = fillDataTable("SELECT TradeMark FROM TradeMarks WHERE ProductId = '" + ProductId + "'");
            foreach (DataRow dr in dt.Rows)
            {
                cmb2.Items.Add(dr["TradeMark"].ToString());
            }
        }

        // Ürün combobox'larını doldurmak için fonk
        public static void fillTradeMarkComboBox(ComboBox cmb1, ComboBox cmb2)
        {
            // Model seçebilmek için ait olduğu marka değerini bulma..
            OpenCon();
            String query = "SELECT Id FROM TradeMarks WHERE TradeMark = '" + cmb1.SelectedItem.ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            TradeMarkId = da.SelectCommand.ExecuteScalar();
            CloseCon();

            // Model combobox'ını doldurmak için
            DataTable dt = new DataTable();
            dt = fillDataTable("SELECT Model FROM Models WHERE TradeMarkId = '" + TradeMarkId + "' AND ProductId = '" + ProductId + "'");
            foreach (DataRow dr in dt.Rows)
            {
                cmb2.Items.Add(dr["Model"].ToString());
            }
        }

        // Veri tabanına bağlanma cümlesi
        public static string GetConnectionString()
        {
            string connectionString = @"Data Source=DESKTOP-NL7UVRU;Initial Catalog=InstallmentTracking;Integrated Security=True";
            return connectionString;
        }

        // Bağlantıyı başlatma
        public static void OpenCon()
        {
            con.Close();
            try
            {
                con.ConnectionString = GetConnectionString();
                con.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show("Veritabanı bağlantısı başlatılamadı!" + Environment.NewLine + e);
            }
        }

        // Bağlantıyı sonlandırma
        public static void CloseCon()
        {
            con.Close();
            con.Dispose();
        }
        
    }
}
