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
    public partial class ManageProject : Form
    {
        int rowIndex;
        public ManageProject()
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

        private void ManageProject_Load(object sender, EventArgs e)
        {

        }

        private bool insertProject(string description, string title)
        {

            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            
           SqlCommand cmd = new SqlCommand("INSERT INTO Project (Title, Description) " +
               "OUTPUT INSERTED.ID " +
                "VALUES (@Title, @Description)", con);
            cmd.Parameters.AddWithValue("@Description", description);
            cmd.Parameters.AddWithValue("@Title", title);


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

       

        private void showBtn_Click(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM Project ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvAdvisors.DataSource = dt;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string idValueFromGrid = dgvAdvisors.Rows[rowIndex].Cells[0].Value.ToString();
            SqlCommand cm = new SqlCommand("UPDATE Project SET  Project.Description = @Description, Project.Title = @Title  WHERE Project.Id = @Id", con);

            cm.Parameters.AddWithValue("@Description", descritionTxtBox.Text);
            cm.Parameters.AddWithValue("@Id", int.Parse(idValueFromGrid));
            cm.Parameters.AddWithValue("@Title", titleTextBox.Text);

            cm.ExecuteNonQuery();
            MessageBox.Show("rows updated.");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            bool value = true;


            if (Validation.CheckString(descritionTxtBox.Text))
            {

            }
            else
            {
                MessageBox.Show("Description is invalid");
                value = false;
            }
            if (Validation.CheckString(titleTextBox.Text))
            {

            }
            else
            {
                MessageBox.Show("Title is invalid");
                value = false;
            }


            if (value)
            {

                insertProject(descritionTxtBox.Text, titleTextBox.Text);
                MessageBox.Show("Successfully saved");
            }
        }

        private void dgvAdvisors_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = dgvAdvisors.Rows[e.RowIndex];

            rowIndex = e.RowIndex;
            descritionTxtBox.Text = row.Cells["Description"].Value.ToString();
            titleTextBox.Text = row.Cells["Title"].Value.ToString();
          
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
    }
}
