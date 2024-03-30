using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Presentation;

namespace MidProjectUI
{
    public partial class PDFs : Form
    {
        public PDFs()
        {
            InitializeComponent();
        }

        private void PDFs_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            GenerateStudentReport();

        }
        private void GenerateStudentReport()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Students.pdf";
            bool errorMessage = false;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);


                    }
                    catch (Exception ex)
                    {
                        errorMessage = true;
                        MessageBox.Show("Unable to write data in disk" + ex.Message);
                    }
                }
                if (!errorMessage)
                {
                    // Create new PDF document
                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(sfd.FileName, FileMode.Create));
                    document.Open();


                    document = TitlePage(ref document);
                    document = GetStudents(ref document);

                    // Close PDF document and writer
                    document.Close();
                    writer.Close();
                }
            }
        }
        private Document TitlePage(ref Document document)
        {
            // Set page size, margins, author, date, title, header
            document.SetPageSize(PageSize.A4);
            document.SetMargins(30, 30, 30, 30);
            document.AddAuthor("Faisal Ilyas");
            document.AddCreationDate();
            document.AddTitle("PDF Report");
            document.AddHeader("Title", "FYP Management System");



            // Adding title page
            document.NewPage();
            Paragraph title = new Paragraph("FYP Management System");
            title.SpacingBefore = 50f;
            title.SpacingAfter = 50f;
            title.Font.Size = 28;
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            string imageURL = "C:\\Users\\PMLS\\Desktop\\2022-CS-63\\MidProjectUI\\Resources\\uet_logo.png";
            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(imageURL);
            jpg.ScaleToFit(140f, 120f);
            jpg.SpacingBefore = 10f;
            jpg.SpacingAfter = 1f;
            jpg.Alignment = Element.ALIGN_CENTER;

            document.Add(jpg);


            Paragraph session = new Paragraph("Session: 2022 - 2026");
            session.SpacingBefore = 10f;
            session.SpacingAfter = 50f;
            session.Alignment = Element.ALIGN_CENTER;
            document.Add(session);


            Paragraph submittedParagraph = new Paragraph("Submitted By:");
            submittedParagraph.SpacingBefore = 10f;
            submittedParagraph.Font.Size = 16;
            submittedParagraph.Alignment = Element.ALIGN_CENTER;
            document.Add(submittedParagraph);


            Paragraph nameParagraph = new Paragraph("Faisal Ilyas        2022-CS-63");
            nameParagraph.SpacingBefore = 10f;
            nameParagraph.SpacingAfter = 80f;
            nameParagraph.Font.Size = 14;
            nameParagraph.Alignment = Element.ALIGN_CENTER;
            document.Add(nameParagraph);


            Paragraph submittedToParagraph = new Paragraph("Submitted To:");
            submittedToParagraph.SpacingBefore = 10f;
            submittedToParagraph.Font.Size = 16;
            submittedToParagraph.Alignment = Element.ALIGN_CENTER;
            document.Add(submittedToParagraph);


            Paragraph teacherParagraph = new Paragraph("Sir Nazeef Ul Haq");
            teacherParagraph.SpacingBefore = 10f;
            teacherParagraph.SpacingAfter = 50f;
            teacherParagraph.Font.Size = 14;
            teacherParagraph.Alignment = Element.ALIGN_CENTER;
            document.Add(teacherParagraph);

            Paragraph departmentParagraph = new Paragraph("Department of Computer Science");
            departmentParagraph.SpacingBefore = 80f;
            departmentParagraph.SpacingAfter = 10f;
            departmentParagraph.Font.Size = 18;
            departmentParagraph.Alignment = Element.ALIGN_CENTER;
            document.Add(departmentParagraph);

            Paragraph uetParagraph = new Paragraph("University of Engineering And Technology, Lahore");
            uetParagraph.SpacingBefore = 10f;
            uetParagraph.SpacingAfter = 10f;
            uetParagraph.Font.Size = 24;
            uetParagraph.Alignment = Element.ALIGN_CENTER;
            document.Add(uetParagraph);

            return document;
        }
        private Document GetStudents(ref Document document)
        {
            try
            {
                document.NewPage();
                Paragraph title = new Paragraph("All Students");
                title.SpacingBefore = 20f;
                title.SpacingAfter = 20f;
                title.Font.Size = 20;
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);

                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select S.RegistrationNo AS [Registration No], (FirstName + ' ' + LastName) AS Name,L.Value AS Gender,(SELECT FORMAT(DateOfBirth, 'dd-MM-yyyy')) AS [DoB],Contact,Email from Person P JOIN Student S ON S.Id=P.Id JOIN Lookup L ON L.Id=P.Gender", con);
                SqlDataReader reader = cmd.ExecuteReader();

                PdfPTable table = new PdfPTable(reader.FieldCount);
                table.WidthPercentage = 100;
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(reader.GetName(i)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.BackgroundColor = new BaseColor(128, 128, 128);
                    table.AddCell(cell);
                }

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(reader[i].ToString()));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }
                reader.Close();
                document.Add(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return document;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            GenerateAdvisorReport();

        }
        private void GenerateAdvisorReport()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Advisors.pdf";
            bool errorMessage = false;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);


                    }
                    catch (Exception ex)
                    {
                        errorMessage = true;
                        MessageBox.Show("Unable to write data in disk" + ex.Message);
                    }
                }
                if (!errorMessage)
                {
                    // Create new PDF document
                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(sfd.FileName, FileMode.Create));
                    document.Open();


                    document = TitlePage(ref document);
                    document = GetAdvisors(ref document);

                    // Close PDF document and writer
                    document.Close();
                    writer.Close();
                }
            }
        }
        private Document GetAdvisors(ref Document document)
        {
            try
            {
                document.NewPage();
                Paragraph title = new Paragraph("All Advisors");
                title.SpacingBefore = 20f;
                title.SpacingAfter = 20f;
                title.Font.Size = 20;
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);

                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select (FirstName + ' ' + LastName) AS Name, L1.Value AS Designation,A.Salary,L.Value AS Gender,(SELECT FORMAT(DateOfBirth, 'dd-MM-yyyy')) AS [DoB],Contact,Email from Person P JOIN Advisor A ON A.Id=P.Id JOIN Lookup L ON L.Id=P.Gender JOIN Lookup L1 ON L1.Id=A.Designation", con);
                SqlDataReader reader = cmd.ExecuteReader();

                PdfPTable table = new PdfPTable(reader.FieldCount);
                table.WidthPercentage = 100;
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(reader.GetName(i)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.BackgroundColor = new BaseColor(128, 128, 128);
                    table.AddCell(cell);
                }

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(reader[i].ToString()));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }
                reader.Close();
                document.Add(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return document;
        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            GenerateProjectAdvisoryBoardReport();

        }

        private void GenerateProjectAdvisoryBoardReport()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "AdvisoryBoard.pdf";
            bool errorMessage = false;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);


                    }
                    catch (Exception ex)
                    {
                        errorMessage = true;
                        MessageBox.Show("Unable to write data in disk" + ex.Message);
                    }
                }
                if (!errorMessage)
                {
                    // Create new PDF document
                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(sfd.FileName, FileMode.Create));
                    document.Open();


                    document = TitlePage(ref document);
                    document = GetProjectAndAdvisoryBoard(ref document);

                    // Close PDF document and writer
                    document.Close();
                    writer.Close();
                }
            }
        }
        private Document GetProjectAndAdvisoryBoard(ref Document document)
        {
            try
            {
                document.NewPage();
                Paragraph title = new Paragraph("Project Title Along Advisory Board");
                title.SpacingBefore = 20f;
                title.SpacingAfter = 20f;
                title.Font.Size = 20;
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);

                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT MAX(P.Title) Title,MAX(P.Description) AS [Project Description], MAX(CASE WHEN L.Value='Main Advisor' THEN CONCAT(Person.FirstName,' ',Person.LastName) END) AS [Main Advisor], MAX(CASE WHEN L.Value='Co-Advisor' THEN CONCAT(Person.FirstName,' ',Person.LastName) END) AS [Co Advisor], MAX(CASE WHEN L.Value='Industry Advisor' THEN CONCAT(Person.FirstName,' ',Person.LastName) END) AS [Industry Advisor] FROM  ProjectAdvisor PA INNER JOIN Advisor A ON PA.AdvisorId = A.Id JOIN Project P ON P.Id=PA.ProjectId JOIN Person ON Person.Id=A.Id JOIN Lookup L ON L.Id=PA.AdvisorRole GROUP BY PA.ProjectId", con);
                SqlDataReader reader = cmd.ExecuteReader();

                PdfPTable table = new PdfPTable(reader.FieldCount);
                table.WidthPercentage = 100;
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(reader.GetName(i)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.BackgroundColor = new BaseColor(128, 128, 128);
                    table.AddCell(cell);
                }

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(reader[i].ToString()));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }
                reader.Close();
                document.Add(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return document;
        }


        private void guna2Button6_Click(object sender, EventArgs e)
        {
            GenerateMarkSheetReport();

        }
        private void GenerateMarkSheetReport()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Mark_Sheet.pdf";
            bool errorMessage = false;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);


                    }
                    catch (Exception ex)
                    {
                        errorMessage = true;
                        MessageBox.Show("Unable to write data in disk" + ex.Message);
                    }
                }
                if (!errorMessage)
                {
                    // Create new PDF document
                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(sfd.FileName, FileMode.Create));
                    document.Open();


                    document = TitlePage(ref document);
                    document = MarkSheet(ref document);

                    // Close PDF document and writer
                    document.Close();
                    writer.Close();
                }
            }
        }
        private List<int> GetEvaluationIds()
        {
            List<int> evaluationIds = new List<int>();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id FROM Evaluation ORDER BY Id ASC", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                evaluationIds.Add(int.Parse(reader["Id"].ToString()));
            }
            reader.Close();

            return evaluationIds;
        }

        private List<string> GetEvaluationTitle()
        {
            List<string> evaluationTitles = new List<string>();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT CONCAT(Name,CHAR(13),TotalMarks) AS name FROM Evaluation ORDER BY Id ASC", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                evaluationTitles.Add(reader["name"].ToString());
            }
            reader.Close();

            return evaluationTitles;
        }
        private Document MarkSheet(ref Document document)
        {
            try
            {
                List<int> evaluationIds = GetEvaluationIds();
                List<string> evaluationTitle = GetEvaluationTitle();
                if (evaluationIds.Count > 0)
                {
                    //MAX(CASE WHEN L.Value = 'Main Advisor' THEN CONCAT(Person.FirstName, ' ', Person.LastName) END) AS[Main Advisor]
                    string query = "";
                    int idx = 0;
                    foreach (int evaluationId in evaluationIds)
                    {
                        query += ",MAX(CASE WHEN E.Id=" + evaluationId + " THEN GE.ObtainedMarks END) AS [" + evaluationTitle[idx] + "]";
                        idx++;
                    }
                    document.NewPage();

                    Paragraph title = new Paragraph("Mark Sheet");
                    title.SpacingBefore = 20f;
                    title.SpacingAfter = 20f;
                    title.Font.Size = 20;
                    title.Alignment = Element.ALIGN_CENTER;
                    document.Add(title);

                    var con = Configuration.getInstance().getConnection();
                    SqlCommand cmd = new SqlCommand("SELECT S.RegistrationNo AS [Reg No],MAX(CONCAT(P.FirstName,' ',P.LastName)) AS [Student Name],MAX(Pr.Title) AS [Project Title] " + query + ",SUM((GE.ObtainedMarks*E.TotalWeightage)/E.TotalMarks) AS [Total Marks] FROM GroupEvaluation AS GE JOIN Evaluation AS E ON GE.EvaluationId=E.Id JOIN GroupStudent AS GS ON GS.GroupId=GE.GroupId JOIN Student AS S ON S.Id=GS.StudentId JOIN Person AS P ON P.Id=S.Id JOIN GroupProject AS GP ON GP.GroupId=GE.GroupId JOIN Project AS Pr ON Pr.Id=GP.ProjectId WHERE GS.Status IN (SELECT Id FROM Lookup WHERE Value='Active') GROUP BY GE.GroupId,Pr.Id,S.Id,S.RegistrationNo ORDER BY GE.GroupId,Pr.Id,S.RegistrationNo", con);
                    SqlDataReader reader = cmd.ExecuteReader();


                    PdfPTable table = new PdfPTable(reader.FieldCount);
                    table.WidthPercentage = 100;
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(reader.GetName(i)));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        cell.BackgroundColor = new BaseColor(128, 128, 128);
                        table.AddCell(cell);
                    }



                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(reader[i].ToString()));
                            cell.HorizontalAlignment = Element.ALIGN_CENTER;
                            table.AddCell(cell);
                        }
                    }
                    reader.Close();
                    document.Add(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return document;
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            GenerateEvaluationReport();
        }
        private void GenerateEvaluationReport()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Evaluations.pdf";
            bool errorMessage = false;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);


                    }
                    catch (Exception ex)
                    {
                        errorMessage = true;
                        MessageBox.Show("Unable to write data in disk" + ex.Message);
                    }
                }
                if (!errorMessage)
                {
                    // Create new PDF document
                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(sfd.FileName, FileMode.Create));
                    document.Open();


                    document = TitlePage(ref document);
                    document = GetEvaluations(ref document);

                    // Close PDF document and writer
                    document.Close();
                    writer.Close();
                }
            }
        }
        private Document GetEvaluations(ref Document document)
        {
            try
            {
                document.NewPage();
                Paragraph title = new Paragraph("Evaluations");
                title.SpacingBefore = 20f;
                title.SpacingAfter = 20f;
                title.Font.Size = 20;
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);

                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("Select Name AS [Evaluation Title],TotalMarks AS [Total Marks],TotalWeightage AS [Total Weightage] from Evaluation E", con);
                SqlDataReader reader = cmd.ExecuteReader();

                PdfPTable table = new PdfPTable(reader.FieldCount);
                table.WidthPercentage = 100;
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(reader.GetName(i)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.BackgroundColor = new BaseColor(128, 128, 128);
                    table.AddCell(cell);
                }

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(reader[i].ToString()));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }
                reader.Close();
                document.Add(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return document;
        }

        private void GenerateGroupsReport()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf";
            sfd.FileName = "Groups.pdf";
            bool errorMessage = false;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);


                    }
                    catch (Exception ex)
                    {
                        errorMessage = true;
                        MessageBox.Show("Unable to write data in disk" + ex.Message);
                    }
                }
                if (!errorMessage)
                {
                    // Create new PDF document
                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(sfd.FileName, FileMode.Create));
                    document.Open();


                    document = TitlePage(ref document);
                    document = DisplayGroups(ref document);

                    // Close PDF document and writer
                    document.Close();
                    writer.Close();
                }
            }
        }
        private Document DisplayGroups(ref Document document)
        {
            try
            {
                document.NewPage();
                Paragraph title = new Paragraph("Groups With Their Project and Students");
                title.SpacingBefore = 20f;
                title.SpacingAfter = 20f;
                title.Font.Size = 20;
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);

                var con = Configuration.getInstance().getConnection();
                SqlCommand cmd = new SqlCommand("SELECT CONCAT('G-',G.Id) AS [Group],Pr.Title AS [Project],STRING_AGG((CASE WHEN L.Value='Active' THEN S.RegistrationNo ELSE CONCAT(S.RegistrationNo,'(In-Active)') END), CHAR(13)) AS [Students] FROM [Group] G JOIN GroupStudent GS ON G.Id=GS.GroupId JOIN GroupProject GP ON GP.GroupId=G.Id JOIN Project Pr ON Pr.Id=GP.ProjectId JOIN Student S ON S.Id=GS.StudentId JOIN Person P ON P.Id=S.Id JOIN Lookup L ON L.Id=GS.Status GROUP BY G.Id,Pr.Title ORDER BY G.Id ASC", con);
                SqlDataReader reader = cmd.ExecuteReader();

                PdfPTable table = new PdfPTable(reader.FieldCount);
                table.WidthPercentage = 100;
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(reader.GetName(i)));
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.BackgroundColor = new BaseColor(128, 128, 128);
                    table.AddCell(cell);
                }

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(reader[i].ToString()));
                        cell.HorizontalAlignment = Element.ALIGN_CENTER;
                        table.AddCell(cell);
                    }
                }
                reader.Close();
                document.Add(table);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return document;
        }


        private void guna2Button4_Click(object sender, EventArgs e)
        {
            GenerateGroupsReport();

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
}
