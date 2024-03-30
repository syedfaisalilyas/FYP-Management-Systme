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
    public partial class ProjectAdvisor : Form
    {
        public ProjectAdvisor()
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

        private void GroupAdvisor_Load(object sender, EventArgs e)
        {
            
            ProjectBoxValue();
            AdvisorBoxValue();
            AdvisorRoleBoxValue();
        }

        public int GetProject(string Value)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT id FROM Project WHERE Title = @Enter";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@Enter", Value);
            // execute the query and retrieve the results
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            // retrieve the integer data and convert it to int type
            int intValue = reader.GetInt32(0);
            //int userAge = reader.GetInt32(1);

            // use the retrieved integer data as needed
            // Console.WriteLine("User ID: {0}, User Age: {1}", userId, userAge);


            // close the database connection
            con.Close();
            return intValue;
        }
       /* public int GetAdvisor(string Value)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            
            string sql = "SELECT Advisor.Id  FROM Advisor JOIN Person ON Advisor.Id = Person.Id; WHERE FirstName = @Enter";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@Enter", Value);
            // execute the query and retrieve the results
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            // retrieve the integer data and convert it to int type
            int intValue = reader.GetInt32(0);
            //int userAge = reader.GetInt32(1);

            // use the retrieved integer data as needed
            // Console.WriteLine("User ID: {0}, User Age: {1}", userId, userAge);


            // close the database connection
            con.Close();
            return intValue;
        }*/
        public int GetAdvisorRole(string Value)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT id FROM Lookup WHERE Value = @Enter And  Category = 'ADVISOR_ROLE'";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@Enter", Value);
            // execute the query and retrieve the results
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            // retrieve the integer data and convert it to int type
            int intValue = reader.GetInt32(0);
            //int userAge = reader.GetInt32(1);

            // use the retrieved integer data as needed
            // Console.WriteLine("User ID: {0}, User Age: {1}", userId, userAge);


            // close the database connection
            con.Close();
            return intValue;
        }
        public void AdvisorBoxValue()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT Id from Advisor", con);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            List<object> dataList = new List<object>();
            // Loop through reader and add retrieved data to list
            while (reader.Read())
            {
                // Retrieve data from reader
                object data = reader["Id"];
                // Add data to list
                dataList.Add(data);
            }
            // Close reader and connection
            reader.Close();
            con.Close();
            advisorIdComboBox.DataSource = dataList;
        }

        public void ProjectBoxValue()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Id,Title from Project", con);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            List<object> dataList = new List<object>();
            // Loop through reader and add retrieved data to list
            while (reader.Read())
            {
                // Retrieve data from reader
                object data = reader["Title"];
                // Add data to list
                dataList.Add(data);
            }
            // Close reader and connection
            reader.Close();
            con.Close();
            projectIdcomboBox.DataSource = dataList;
        }

        public void AdvisorRoleBoxValue()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Id,Value from Lookup where Category = 'ADVISOR_ROLE'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            List<object> dataList = new List<object>();
            // Loop through reader and add retrieved data to list
            while (reader.Read())
            {
                // Retrieve data from reader
                object data = reader["Value"];
                // Add data to list
                dataList.Add(data);
            }
            // Close reader and connection
            reader.Close();
            con.Close();
            advisorRoleComboBox.DataSource = dataList;
        }

        private bool CheckProjectALreadyExistForAdvisor(int Project)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=ProjectA;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM ProjectAdvisor WHERE ProjectId= @ProjectId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProjectId", Project);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public bool availableProject(int projectName)
        {
            int m = GetProject(projectIdcomboBox.Text);
            bool status = false;
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Count(ProjectId) from GroupProject where ProjectId = @studentid", con);
            cmd.Parameters.AddWithValue("@studentid", m);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                // MessageBox.Show("hello");
                int count = reader.GetInt32(0);
                if (count == 0)
                {
                    //MessageBox.Show("loo");
                    status = true;
                }
                else
                {
                    MessageBox.Show("Not available");
                }
                //   MessageBox.Show("HH");
            }
            // Create list to store retrieved data

            // Close reader and connection
            reader.Close();
            con.Close();
            return status;
        }

        private bool assignAdvisor(int advisorId, int projectId, int advisorRole, string assignDate)
        {



            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DateTime gco = Convert.ToDateTime(assignDate);
            SqlCommand cmd = new SqlCommand("INSERT INTO ProjectAdvisor (AdvisorId, ProjectId, AdvisorRole, AssignmentDate) " +
                "VALUES (@AdvisorId,@ProjectId,@AdvisorRole, @assignDate)", con);
            cmd.Parameters.AddWithValue("@AdvisorId", advisorId);
            cmd.Parameters.AddWithValue("@ProjectId", projectId);
            cmd.Parameters.AddWithValue("@AdvisorRole", advisorRole);
            cmd.Parameters.AddWithValue("@assignDate", gco);


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

        private void addBtn_Click(object sender, EventArgs e)
        {


            bool value = true;
            int project = GetProject(projectIdcomboBox.Text);
            int adRole = GetAdvisorRole(advisorRoleComboBox.Text);

            if (CheckProjectALreadyExistForAdvisor(project))
            {
                MessageBox.Show("This Project already assigned to an advisor.");
                return;
            }
            if (availableProject(project))
            {
                MessageBox.Show("This Project already assigned to an advisor.");
                return;
            }
            if (value)
            {

                assignAdvisor(int.Parse(advisorIdComboBox.Text), project, adRole, assigmentDatePicker.Text);
                MessageBox.Show("Successfully saved");
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT  MAX(P.Title) Title, MAX(CASE WHEN PA.AdvisorRole = 11 THEN CONCAT(Person.FirstName,' ',Person.LastName) END) AS MainAdvisor, MAX(CASE WHEN PA.AdvisorRole = 12 THEN CONCAT(Person.FirstName,' ',Person.LastName) END) AS CoAdvisor, MAX(CASE WHEN PA.AdvisorRole = 14 THEN CONCAT(Person.FirstName,' ',Person.LastName) END) AS IndustryAdvisor FROM  ProjectAdvisor PA INNER JOIN Advisor A ON PA.AdvisorId = A.Id JOIN Project P ON P.Id=PA.ProjectId JOIN Person ON Person.Id=A.Id GROUP BY PA.ProjectId", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            advisorGroupDGV.DataSource = dt.DefaultView;
       

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

            int project = GetProject(projectIdcomboBox.Text);
            int adRole = GetAdvisorRole(advisorRoleComboBox.Text);

            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cm = new SqlCommand("UPDATE ProjectAdvisor SET ProjectAdvisor.AdvisorRole= @AdvisorRole, ProjectAdvisor.AssignmentDate = @AssignmentDate WHERE ProjectAdvisor.AdvisorId= @AdvisorId AND ProjectAdvisor.ProjectId = @ProjectId ", con);

            cm.Parameters.AddWithValue("@AdvisorId", int.Parse(advisorIdComboBox.Text));
            cm.Parameters.AddWithValue("@ProjectId", project);
            cm.Parameters.AddWithValue("@AdvisorRole", adRole);
            cm.Parameters.AddWithValue("@AssignmentDate", DateTime.Parse(assigmentDatePicker.Text));

            cm.ExecuteNonQuery();

            MessageBox.Show(" rows updated.");
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

        }

        private void advisorGroupDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = advisorGroupDGV.Rows[e.RowIndex];
                assigmentDatePicker.Text = row.Cells["AssignmentDate"].Value.ToString();
                advisorIdComboBox.Text = row.Cells["AdvisorId"].Value.ToString();
                projectIdcomboBox.Text = row.Cells["ProjectId"].Value.ToString();
                advisorRoleComboBox.Text = row.Cells["AdvisorRole"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
