using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MidProjectUI
{
    public partial class Group : Form
    {
        int rowIndex;
        public Group()
        {
            InitializeComponent();
            this.Resize += ManageForm_Resize;
        }

     

        private bool insertGroup( String groupCreatedOn)
        {



            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DateTime gco = Convert.ToDateTime(groupCreatedOn);
           
            SqlCommand cmd = new SqlCommand("INSERT INTO [Group] (Created_On) " +
                 "OUTPUT INSERTED.ID " +
                 "VALUES (@groupCreatedOn)", con);
           
            cmd.Parameters.AddWithValue("@groupCreatedOn", gco);


            try
            {
               
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return false;
            }

          

        }

       
       

      

        private void groupDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            // Get the selected row
            DataGridViewRow row = groupDataGridView.Rows[e.RowIndex];

            // Populate the text boxes with the data
            rowIndex = e.RowIndex;
            groupDatePicker.Text = row.Cells["Created_On"].Value.ToString();
            /* id = Convert.ToInt32(row.Cells["Id"].Value);
             idTxtbox.Text = id.ToString();*/
        }

        private void showGroupBtn_Click_1(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Group] ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            groupDataGridView.DataSource = dt;
        }

        private void updateGroupBtn_Click_1(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string idValueFromGrid = groupDataGridView.Rows[rowIndex].Cells[0].Value.ToString();
            SqlCommand cm = new SqlCommand("UPDATE [Group] SET [Group].Created_On = @Created_On WHERE [Group].Id = @Id", con);

            cm.Parameters.AddWithValue("@Id", int.Parse(idValueFromGrid));
            cm.Parameters.AddWithValue("@Created_On", DateTime.Parse(groupDatePicker.Text));

            var rowsAffected1 = cm.ExecuteNonQuery();

            MessageBox.Show(" rows updated.");
        }

        private void addGroupBtn_Click_1(object sender, EventArgs e)
        {
            insertGroup(groupDatePicker.Text);
            MessageBox.Show("Successfully saved");
        }

        private void clearGroupBtn_Click(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void Group_Load(object sender, EventArgs e)
        {
          
        }

        private void ManageForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
