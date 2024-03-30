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
    public partial class GroupEvaluation : Form
    {
        public GroupEvaluation()
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

        private void GroupEvaluation_Load(object sender, EventArgs e)
        {
            EvaluationBoxValue();
            GroupBoxValue();
        }

       

        public void GroupBoxValue()
        {
            var con = Configuration.getInstance().getConnection();
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
            groupIdComboBox.DataSource = dataList;
        }

        public void EvaluationBoxValue()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("Select Id,Name from Evaluation", con);
            SqlDataReader reader = cmd.ExecuteReader();
            // Create list to store retrieved data
            List<object> dataList = new List<object>();
            // Loop through reader and add retrieved data to list
            while (reader.Read())
            {
                // Retrieve data from reader
                object data = reader["Name"];
                // Add data to list
                dataList.Add(data);
            }
            // Close reader and connection
            reader.Close();
            con.Close();
            evaluationIdcomboBox.DataSource = dataList;
        }

        public int GetEvaluation(string Value)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT Id FROM Evaluation WHERE Name = @Enter";
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

        private bool evaluation(int groupId, int evaluationId,int obtMarks, string evaluationDate)
        {



            SqlConnection con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            DateTime gco = Convert.ToDateTime(evaluationDate);
            SqlCommand cmd = new SqlCommand("INSERT INTO GroupEvaluation (GroupId, EvaluationId, ObtainedMarks, EvaluationDate) " +
                "VALUES (@GroupId,@EvaluationId,@ObtainedMarks, @evaluationDate)", con);
            cmd.Parameters.AddWithValue("@GroupId", groupId);
            cmd.Parameters.AddWithValue("@EvaluationId", evaluationId);
            cmd.Parameters.AddWithValue("@ObtainedMarks", obtMarks);
            cmd.Parameters.AddWithValue("@evaluationDate", gco);


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
            int eval = GetEvaluation(evaluationIdcomboBox.Text);
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cm = new SqlCommand("UPDATE GroupEvaluation SET GroupEvaluation.EvaluationDate = @EvaluationDate, GroupEvaluation.ObtainedMarks = @ObtainedMarks WHERE GroupEvaluation.GroupId = @GroupId AND GroupEvaluation.EvaluationId = @EvaluationId", con);

            cm.Parameters.AddWithValue("@GroupId", int.Parse(groupIdComboBox.Text));
            cm.Parameters.AddWithValue("@EvaluationId", eval);
            cm.Parameters.AddWithValue("@ObtainedMarks", int.Parse(obtainedTextBox.Text));
            cm.Parameters.AddWithValue("@EvaluationDate", DateTime.Parse(evaluationDatePicker.Text));

            cm.ExecuteNonQuery();

            MessageBox.Show(" rows updated.");
        }

        private void showBtn_Click(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM GroupEvaluation ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            groupEvaluationDGV.DataSource = dt;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

        }

        public int EvaluationTotal(String name)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "SELECT TotalMarks FROM Evaluation WHERE Name = @Enter";
            SqlCommand command = new SqlCommand(sql, con);
            command.Parameters.AddWithValue("@Enter", name);
            // execute the query and retrieve the results
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            // retrieve the integer data and convert it to int type
            int intValue = reader.GetInt32(0);
            //int userAge = reader.GetInt32(1);

            // use the retrieved integer data as needed
            // Console.WriteLine("User ID: {0}, User Age: {1}", userId, userAge);


            // close the database connection
            reader.Close();
            con.Close();
            return intValue;
        }


        private void addBtn_Click(object sender, EventArgs e)
        {

            bool value = true;
            int eval = GetEvaluation(evaluationIdcomboBox.Text);
            if (Validation.CheckId(obtainedTextBox.Text))
            {
                //Obtained Marks are Valid.
            }
            else
            {
                MessageBox.Show("Obtained Marks are invalid");
                value = false;
                return;
            }
           /* if (EvaluationTotal(int.Parse(obtainedTextBox.Text)) > 50 )
            {
                MessageBox.Show("Please enter correct digits");
                value = false;
            }
            */
            if (value)
            {
                evaluation(int.Parse(groupIdComboBox.Text), eval, int.Parse(obtainedTextBox.Text), evaluationDatePicker.Text);
                MessageBox.Show("Successfully saved");
            }
        }

        private void groupEvaluationDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            // Get the selected row
            DataGridViewRow row = groupEvaluationDGV.Rows[e.RowIndex];

            // Populate the text boxes with the data
            evaluationDatePicker.Text = row.Cells["EvaluationDate"].Value.ToString();
            groupIdComboBox.Text = row.Cells["GroupId"].Value.ToString();
            evaluationIdcomboBox.Text = row.Cells["EvaluationId"].Value.ToString();
            obtainedTextBox.Text = row.Cells["ObtainedMarks"].Value.ToString();
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
