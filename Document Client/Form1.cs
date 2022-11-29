using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Data.SqlClient;
namespace Document_Client
{
    public partial class Form1 : Form
    {
        //string connectionString = @"Data Source=103.141.144.49;Initial Catalog=OMS_PROD_DW;Persist Security Info=True;User ID=oms_prod_reader;Password=2AqTtweTMtR4";
        DataTable Document = new DataTable();
        DataView DocSelection = new DataView();
        string Query = "Select * from tmp_DocumentData";
        SqlConnection Connection = new SqlConnection(@"Data Source=103.141.144.49;Initial Catalog=OMS_PROD_DW;Persist Security Info=True;User ID=oms_prod_reader;Password=2AqTtweTMtR4");
        public Form1()
        {
            InitializeComponent();
            
            Connection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("Select * from tmp_DocumentData", Connection.ConnectionString);
            sqlData.Fill(Document);
            DocSelection = new DataView(Document);
            dataGridView1.DataSource = DocSelection;
            Connection.Close();
        }

        

        private void btLoadData_Click(object sender, EventArgs e)
        {
            
            if(tbSelect != null) { Query= "Select "+ tbSelect.Text + "From tmp_DocumentData "; }
            if (tbWhere != null)
            {
                Query += " Where" + tbWhere.Text;
                try
                {
                    DocSelection.RowFilter = tbWhere.Text;
                    
                }
                catch (Exception ex) { }
            }
            //connection.Open();
            //SqlDataAdapter sqlData = new SqlDataAdapter(Query, connection.ConnectionString);
            
            //connection.Close();
        }
        private void btUpdateData_Click(object sender, EventArgs e)
        {
            string selectStatement = "SELECT * FROM tmp_DocumentData";
            System.Data.DataTable dt = new System.Data.DataTable();
            Connection.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter();
            sqlDa.SelectCommand = new SqlCommand(selectStatement, Connection);
            SqlCommandBuilder cb = new SqlCommandBuilder(sqlDa);
            sqlDa.UpdateCommand = cb.GetUpdateCommand();
            sqlDa.Update(Document);
            Connection.Close() ;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}