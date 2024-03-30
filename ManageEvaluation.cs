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

namespace MidProjectUI
{
    public partial class ManageEvaluation : Form
    {
        int rowIndex;
        public ManageEvaluation()
        {
            InitializeComponent();
            this.Resize += ManageForm_Resize;
        }
        private void ManageForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private bool insertEvaluation(string name, int totalMarks, int weightage)
        {

            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("INSERT INTO Evaluation (Name, TotalMarks, TotalWeightage) " +
                 "OUTPUT INSERTED.ID " +
                 "VALUES (@Name,@TotalMarks, @TotalWeightage)", con);

            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@TotalMarks", totalMarks);
            cmd.Parameters.AddWithValue("@TotalWeightage", weightage);


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






        private void dgvEvaluation_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            int totalMarks, weightage;
            // Get the selected row
            DataGridViewRow row = dgvEvaluation.Rows[e.RowIndex];

            // Populate the text boxes with the data
            rowIndex = e.RowIndex;
            nameTxtBox.Text = row.Cells["Name"].Value.ToString();
            /*id = Convert.ToInt32(row.Cells["Id"].Value);
            idTxtBox.Text = id.ToString();*/
            totalMarks = Convert.ToInt32(row.Cells["TotalMarks"].Value);
            totalmarksTextBox.Text = totalMarks.ToString();
            weightage = Convert.ToInt32(row.Cells["TotalWeightage"].Value);
            weightadeTxtBox.Text = weightage.ToString();
        }

  
    

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }

       
  

        private void dgvEvaluation_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void showEvalBtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM Evaluation ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEvaluation.DataSource = dt;
        }

        private void addEvalBtn_Click(object sender, EventArgs e)
        {
            bool value = true;


            if (Validation.CheckFirstName(nameTxtBox.Text))
            {

            }
            else
            {
                MessageBox.Show("Name invalid");
                value = false;
            }
            if (Validation.CheckId(totalmarksTextBox.Text))
            {

            }
            else
            {
                MessageBox.Show("Total Marks are invalid");
                value = false;
            }
            if (Validation.CheckId(weightadeTxtBox.Text))
            {

            }
            else
            {
                MessageBox.Show("Total Weightage is invalid");
                value = false;
            }


            if (value)
            {

                insertEvaluation(nameTxtBox.Text, int.Parse(totalmarksTextBox.Text), int.Parse(weightadeTxtBox.Text));
                MessageBox.Show("Successfully saved");
            }
        }

        private void updateEvalBtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string idValueFromGrid = dgvEvaluation.Rows[rowIndex].Cells[0].Value.ToString();
            SqlCommand cm = new SqlCommand("UPDATE Evaluation SET  Evaluation.Name = @Name, Evaluation.TotalMarks= @TotalMarks, Evaluation.TotalWeightage= @TotalWeightage  WHERE Evaluation.Id = @Id", con);

            cm.Parameters.AddWithValue("@Name", nameTxtBox.Text);
            cm.Parameters.AddWithValue("@TotalMarks", int.Parse(totalmarksTextBox.Text));
            cm.Parameters.AddWithValue("@TotalWeightage", int.Parse(weightadeTxtBox.Text));
            cm.Parameters.AddWithValue("@Id", int.Parse(idValueFromGrid));

            cm.ExecuteNonQuery();
            MessageBox.Show("rows updated.");
        }

        private void clearBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void GroupDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEvaluation.ScrollBars = ScrollBars.Both;
            int totalMarks, weightage;
            DataGridViewRow row = dgvEvaluation.Rows[e.RowIndex];

            rowIndex = e.RowIndex;
            nameTxtBox.Text = row.Cells["Name"].Value.ToString();

            totalMarks = Convert.ToInt32(row.Cells["TotalMarks"].Value);
            totalmarksTextBox.Text = totalMarks.ToString();
            weightage = Convert.ToInt32(row.Cells["TotalWeightage"].Value);
            weightadeTxtBox.Text = weightage.ToString();
        }
    }
}