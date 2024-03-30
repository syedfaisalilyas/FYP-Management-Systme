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
    public partial class StudentGroup : Form
    {
        private int groupId;
        private int projectId;
        private string projectTitle;
        private bool isEditing = false;
        public StudentGroup()
        {
            InitializeComponent();
            this.Resize += ManageForm_Resize;
            this.groupId = groupId;
            groupNameDisplayTextBlock.Text = "G-" + groupId;

            // Set default values
            projectId = 0;
            projectTitleTextBlock.Text = "Not Assigned";

            InitializeDataGridView();
            GetStudentsOfGroup();
            StudentToComboBox();
            ProjectToComboBox(excludeAssigned: true); // Update the combo box on initialization

        }
        private void InitializeDataGridView()
        {
            DataGridViewButtonColumn statusColumn = new DataGridViewButtonColumn();
            statusColumn.HeaderText = "Status";
            statusColumn.Name = "statusColumn";
            // statusColumn.Text = "Active";
            statusColumn.UseColumnTextForButtonValue = true;
            groupDetailsStudentDataGrid.Columns.Add(statusColumn);
        }
        public StudentGroup(int groupId, string projectTitle)
        {
            InitializeComponent();
            isEditing = true;
            this.groupId = groupId;
            this.projectTitle = projectTitle;
            projectId = 0;
            groupNameDisplayTextBlock.Text = "G-" + groupId;

            if (string.IsNullOrEmpty(projectTitle))
            {
                projectTitleTextBlock.Text = "Not Assigned";
            }
            else
            {
                projectTitleTextBlock.Text = projectTitle;
            }

            // Load active students for the selected group
            LoadActiveStudents();
            InitializeDataGridView();
            GetStudentsOfGroup();
            StudentToComboBox();
            ProjectToComboBox(excludeAssigned: true); // Update the combo box on initialization

        }
        public StudentGroup(int groupId)
        {
            InitializeComponent();
            this.groupId = groupId;
            groupNameDisplayTextBlock.Text = "G-" + groupId;

            // Set default values
            projectId = 0;
            projectTitleTextBlock.Text = "Not Assigned";

            InitializeDataGridView();
            GetStudentsOfGroup();
            StudentToComboBox();
            ProjectToComboBox(excludeAssigned: true); // Update the combo box on initialization
        }
        private void LoadActiveStudents()
        {
            try
            {
                var con = Configuration.getInstance1().getConnection1();
                SqlCommand cmd = new SqlCommand("SELECT CONCAT(P.FirstName ,' ',P.LastName) AS Name, S.RegistrationNo FROM GroupStudent AS GS JOIN Lookup AS L ON GS.Status = L.Id JOIN Student AS S ON S.Id = GS.StudentId JOIN Person AS P ON P.Id = S.Id WHERE GS.GroupId = @GroupId AND GS.Status = @Status", con);
                cmd.Parameters.AddWithValue("@GroupId", groupId);
                cmd.Parameters.AddWithValue("@Status", 3);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                groupDetailsStudentDataGrid.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentGroup_Load(object sender, EventArgs e)
        {
            /*var con1 = Configuration.getInstance().getConnection();

            string query = "Select Id FROM Lookup WHERE Category = 'STATUS'";
            string query1 = "Select Id FROM Student";
            string query2 = "Select Id FROM [Group]";
            SqlCommand command = new SqlCommand(query, con1);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int statusCode = reader.GetInt32(0);
                statusComboBox.Items.Add(statusCode);
            }
            reader.Close();
            command = new SqlCommand(query1, con1);
            SqlDataReader reader1 = command.ExecuteReader();
            while (reader1.Read())
            {
                int studentCode = reader1.GetInt32(0);
                studentIdcomboBox.Items.Add(studentCode);
            }
            reader1.Close();
            command = new SqlCommand(query2, con1);
            SqlDataReader reader2 = command.ExecuteReader();
            while (reader2.Read())
            {
                int groupCode = reader2.GetInt32(0);
                groupIdComboBox.Items.Add(groupCode);
            }
            reader2.Close();

            *//*StatusBoxValue();
            GroupIdValue();
            StudentIdValue();*//*
*/
            StatusBoxValue();
            GroupBoxValue();
            StudentBoxValue();

        }

        public void GroupBoxValue()
        {
            /*var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Id from [Group]", con);
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
            groupIdComboBox.DataSource = dataList;*/
        }

        public void StudentBoxValue()
        {
           /* var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT Id from Student", con);
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
            studentIdcomboBox.DataSource = dataList;*/
        }

        public void StatusBoxValue()
        {
            /*var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Id,Value from Lookup where Category = 'STATUS'", con);
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
            statusComboBox.DataSource = dataList;*/
        }
        public int GetStatusId(string Value)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT id FROM Lookup WHERE Value = @Enter And  Category = 'STATUS'";
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

        /* public void StatusBoxValue()
         {
             var con = Configuration.getInstance().getConnection();
             if (con.State == ConnectionState.Closed)
             {
                 con.Open();
             }
             SqlCommand cmd = new SqlCommand("Select Id,Value from Lookup where Category = 'STATUS'", con);
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
             statusComboBox.DataSource = dataList;
         }

         public void GroupIdValue()
         {
             var con = Configuration.getInstance().getConnection();
             if (con.State == ConnectionState.Closed)
             {
                 con.Open();
             }
             SqlCommand cmd = new SqlCommand("Select Id FROM [Group]", con);
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
             groupIdComboBox.DataSource = dataList;
         }

         public void StudentIdValue()
         {
             var con = Configuration.getInstance().getConnection();
             if (con.State == ConnectionState.Closed)
             {
                 con.Open();
             }
             SqlCommand cmd = new SqlCommand("Select Id,RegistrationNo from Student", con);
             SqlDataReader reader = cmd.ExecuteReader();
             // Create list to store retrieved data
             List<object> dataList = new List<object>();
             // Loop through reader and add retrieved data to list
             while (reader.Read())
             {
                 // Retrieve data from reader
                 object data = reader["RegistrationNo"];
                 // Add data to list
                 dataList.Add(data);
             }
             // Close reader and connection
             reader.Close();
             con.Close();
             studentIdcomboBox.DataSource = dataList;
         }
 */

        private bool CheckStudentAlreadyExistInGroup(string Student)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=ProjectA;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM GroupStudent WHERE StudentId = @StudentId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StudentId", Student);
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        private int CheckSTudentCountInGroup(int groupId)
        {
            string connectionString = @"Data Source=(local);Initial Catalog=ProjectA;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM GroupStudent  WHERE GroupId = @GroupId AND STATUS = 3 ";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@GroupId", groupId);
                int count = (int)command.ExecuteScalar();
                return count;
            }
        }

        private bool insertStudentInGroup(int groupId, int studentId, int status, string assignDate)
        {



            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DateTime gco = Convert.ToDateTime(assignDate);
            SqlCommand cmd = new SqlCommand("INSERT INTO GroupStudent (GroupId, StudentId, Status, AssignmentDate) " +
                "VALUES (@GroupId,@StudentId,@Status, @assignDate)", con);
            cmd.Parameters.AddWithValue("@GroupId", groupId);
            cmd.Parameters.AddWithValue("@StudentId", studentId);
            cmd.Parameters.AddWithValue("@Status", status);
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


       

        private void updateBtn_Click(object sender, EventArgs e)
        {
            /*int status = GetStatusId(statusComboBox.Text);
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            
                // Get group ID and inactive status
                int groupId = int.Parse(groupIdComboBox.Text);
               
                // Update all group student IDs with inactive status
                SqlCommand cm = new SqlCommand("UPDATE GroupStudent SET Status = @Status WHERE GroupId = @GroupId AND StudentId = @StudentId ", con);
                cm.Parameters.AddWithValue("@GroupId", groupId);
                cm.Parameters.AddWithValue("@StudentId", int.Parse(studentIdcomboBox.Text));
                cm.Parameters.AddWithValue("@Status", status);
                var rowsAffected = cm.ExecuteNonQuery();
                MessageBox.Show(rowsAffected.ToString() + " rows updated.");
           
         
            con.Close();*/
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM GroupStudent WHERE STATUS = 3 ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            groupDetailsStudentDataGrid.DataSource = dt;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

        }

      


        private void addBtn_Click(object sender, EventArgs e)
        {
           /* bool value = true;
            int status = GetStatusId(statusComboBox.Text);
            if (statusComboBox.Text == "Active")
            {

            }
            else
            {
                MessageBox.Show("Student is InACtive. You can't add in group");
                value = false;
            }
            if (CheckStudentAlreadyExistInGroup(studentIdcomboBox.Text))
            {
                MessageBox.Show("Student already exists in group");
                return;
            }
            if (CheckSTudentCountInGroup(int.Parse(groupIdComboBox.Text)) == 3)
            {
                MessageBox.Show("Group has already 3 members.");
                return;
            }
           
            if (value)
            {

                insertStudentInGroup(int.Parse(groupIdComboBox.Text), int.Parse(studentIdcomboBox.Text), status, assignmentDatePicker.Text);
                MessageBox.Show("Successfully saved");

            }*/
        }

        private void studentGroupDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

           /* // Get the selected row
            DataGridViewRow row = groupDetailsStudentDataGrid.Rows[e.RowIndex];

            // Populate the text boxes with the data
            assignmentDatePicker.Text = row.Cells["AssignmentDate"].Value.ToString();
            groupIdComboBox.Text = row.Cells["GroupId"].Value.ToString();
            studentIdcomboBox.Text = row.Cells["StudentId"].Value.ToString();
            statusComboBox.Text = row.Cells["Status"].Value.ToString();*/
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
        private void ProjectToComboBox(bool excludeAssigned = false)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Title FROM Project", con);

            if (excludeAssigned)
            {
                cmd.CommandText += " WHERE Id NOT IN (SELECT ProjectId FROM GroupProject WHERE GroupId != @GroupId)";
                cmd.Parameters.AddWithValue("@GroupId", groupId);
            }

            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataSet dt = new DataSet();
            d.Fill(dt);
            projectComboBox.DataSource = dt.Tables[0].DefaultView;
            projectComboBox.DisplayMember = "Title";
        }
        private void StudentToComboBox()
        {
            var con = Configuration.getInstance().getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT s.RegistrationNo FROM Student s LEFT JOIN (SELECT * FROM GroupStudent GS1 WHERE GS1.AssignmentDate = ( SELECT MAX(GS2.AssignmentDate) FROM GroupStudent GS2 WHERE GS2.StudentId = GS1.StudentId)) recent ON s.Id = recent.StudentID WHERE recent.Status = 4 OR recent.GroupID IS NULL", con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                studentComboBox.DataSource = dataSet.Tables[0].DefaultView;
                studentComboBox.DisplayMember = "RegistrationNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in student combo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void assignProjectBtn_Click(object sender, EventArgs e)
        {
            if (projectComboBox.Text == string.Empty)
            {
                MessageBox.Show("You need To First Select a project to assign to this group", "Error", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GetProjectId(projectComboBox.Text);
            if (projectTitleTextBlock.Text == "Not Assigned" && !isEditing)
            {
                try
                {
                    var con = Configuration.getInstance1().getConnection1();
                    SqlCommand cmd = new SqlCommand("INSERT INTO GroupProject VALUES (@ProjectId, @GroupId, @Date)", con);
                    cmd.Parameters.AddWithValue("@ProjectId", projectId);
                    cmd.Parameters.AddWithValue("@GroupId", groupId);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);

                    cmd.ExecuteNonQuery();
                    GetCurrentProjectAssigned();
                    ProjectToComboBox();
                    projectComboBox.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            else if (isEditing || projectTitleTextBlock.Text == "Not Assigned")
            {
                try
                {
                    var con = Configuration.getInstance1().getConnection1();
                    SqlCommand cmd = new SqlCommand("UPDATE GroupProject SET ProjectId=@ProjectId,AssignmentDate=@Date WHERE GroupId=@GroupId", con);
                    cmd.Parameters.AddWithValue("@ProjectId", projectId);
                    cmd.Parameters.AddWithValue("@GroupId", groupId);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    GetCurrentProjectAssigned();
                    ProjectToComboBox();
                    projectComboBox.Text = string.Empty;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }



            MessageBox.Show("Project Assigned Successfully", "Success", System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        private void GetProjectId(string title)
        {
            var con = Configuration.getInstance1().getConnection1();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Id FROM Project WHERE Title=@title", con);
                cmd.Parameters.AddWithValue("@title", title);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    projectId = int.Parse(reader["Id"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in get project: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void GetCurrentProjectAssigned()
        {
            var con = Configuration.getInstance1().getConnection1();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Title FROM Project AS P,GroupProject AS GP WHERE  P.Id=GP.ProjectId AND GP.GroupId=@GroupId", con);
                cmd.Parameters.AddWithValue("@GroupId", groupId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    projectTitleTextBlock.Text = reader["Title"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in get current project assigned: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        private int StudentIdFromDataBase()
        {
            int id = 0;
            var con = Configuration.getInstance1().getConnection1();
            SqlCommand cmd = new SqlCommand("SELECT Id FROM Student AS S WHERE S.RegistrationNo=@RegNo", con);
            cmd.Parameters.AddWithValue("@RegNo", studentComboBox.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                id = int.Parse(reader["Id"].ToString());
            }
            reader.Close();
            return id;
        }
        private void GetStudentsOfGroup()
        {
            var con = Configuration.getInstance1().getConnection1();
            if (con == null) return;

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT CONCAT(P.FirstName ,' ',P.LastName) AS Name, S.RegistrationNo FROM GroupStudent AS GS JOIN Lookup AS L ON GS.Status = L.Id JOIN Student AS S ON S.Id = GS.StudentId JOIN Person AS P ON P.Id = S.Id WHERE GS.GroupId = @GroupId AND GS.Status = @Status", con);
                cmd.Parameters.AddWithValue("@GroupId", groupId);
                cmd.Parameters.AddWithValue("@Status", 3);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                groupDetailsStudentDataGrid.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            int stuId;
            if (studentComboBox.Text != string.Empty)
            {
                var con = Configuration.getInstance1().getConnection1();
                stuId = StudentIdFromDataBase();
                try
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM GroupStudent WHERE StudentId=@StudentId AND GroupId=@GroupId; INSERT INTO GroupStudent VALUES (@GroupId, @StudentId,@Status,@Date)", con);
                    cmd.Parameters.AddWithValue("@StudentId", stuId);
                    cmd.Parameters.AddWithValue("@GroupId", groupId);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Status", 3);
                    cmd.ExecuteNonQuery();
                    studentComboBox.Text = string.Empty;

                    // Refresh the grid
                    GetStudentsOfGroup();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void ManageForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
