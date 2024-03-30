
namespace MidProjectUI
{
    partial class AdvisorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvisorForm));
            this.clearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.personBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateStudentButton_Click = new Guna.UI2.WinForms.Guna2Button();
            this.showAdvisorBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addStudentButton = new Guna.UI2.WinForms.Guna2Button();
            this.genderComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dateOfBirthPicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.contactTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblfirstName = new System.Windows.Forms.Label();
            this.dgvAdvisors = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.salaryTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.desComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvisors)).BeginInit();
            this.SuspendLayout();
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clearBtn.BackColor = System.Drawing.Color.Transparent;
            this.clearBtn.BorderRadius = 12;
            this.clearBtn.BorderThickness = 3;
            this.clearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearBtn.FillColor = System.Drawing.Color.Black;
            this.clearBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.Ivory;
            this.clearBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clearBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearBtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.clearBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clearBtn.Location = new System.Drawing.Point(963, 894);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.ShadowDecoration.BorderRadius = 26;
            this.clearBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clearBtn.ShadowDecoration.Enabled = true;
            this.clearBtn.Size = new System.Drawing.Size(197, 55);
            this.clearBtn.TabIndex = 108;
            this.clearBtn.Text = "CLEAR";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // personBtn
            // 
            this.personBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.personBtn.BackColor = System.Drawing.Color.Transparent;
            this.personBtn.BorderRadius = 12;
            this.personBtn.BorderThickness = 3;
            this.personBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.personBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.personBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.personBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.personBtn.FillColor = System.Drawing.Color.Black;
            this.personBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personBtn.ForeColor = System.Drawing.Color.Ivory;
            this.personBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.personBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.personBtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.personBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.personBtn.Location = new System.Drawing.Point(755, 894);
            this.personBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.personBtn.Name = "personBtn";
            this.personBtn.ShadowDecoration.BorderRadius = 26;
            this.personBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.personBtn.ShadowDecoration.Enabled = true;
            this.personBtn.Size = new System.Drawing.Size(197, 55);
            this.personBtn.TabIndex = 107;
            this.personBtn.Text = "DISPLAY  PERSON";
            this.personBtn.Click += new System.EventHandler(this.personBtn_Click_1);
            // 
            // updateStudentButton_Click
            // 
            this.updateStudentButton_Click.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.updateStudentButton_Click.BackColor = System.Drawing.Color.Transparent;
            this.updateStudentButton_Click.BorderRadius = 12;
            this.updateStudentButton_Click.BorderThickness = 3;
            this.updateStudentButton_Click.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateStudentButton_Click.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateStudentButton_Click.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateStudentButton_Click.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateStudentButton_Click.FillColor = System.Drawing.Color.Black;
            this.updateStudentButton_Click.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateStudentButton_Click.ForeColor = System.Drawing.Color.Ivory;
            this.updateStudentButton_Click.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.updateStudentButton_Click.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateStudentButton_Click.HoverState.ForeColor = System.Drawing.Color.Black;
            this.updateStudentButton_Click.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updateStudentButton_Click.Location = new System.Drawing.Point(543, 894);
            this.updateStudentButton_Click.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateStudentButton_Click.Name = "updateStudentButton_Click";
            this.updateStudentButton_Click.ShadowDecoration.BorderRadius = 26;
            this.updateStudentButton_Click.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateStudentButton_Click.ShadowDecoration.Enabled = true;
            this.updateStudentButton_Click.Size = new System.Drawing.Size(197, 55);
            this.updateStudentButton_Click.TabIndex = 106;
            this.updateStudentButton_Click.Text = "UPDATE";
            this.updateStudentButton_Click.Click += new System.EventHandler(this.updateStudentButton_Click_Click_1);
            // 
            // showAdvisorBtn
            // 
            this.showAdvisorBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.showAdvisorBtn.BackColor = System.Drawing.Color.Transparent;
            this.showAdvisorBtn.BorderRadius = 12;
            this.showAdvisorBtn.BorderThickness = 3;
            this.showAdvisorBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showAdvisorBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showAdvisorBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showAdvisorBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showAdvisorBtn.FillColor = System.Drawing.Color.Black;
            this.showAdvisorBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAdvisorBtn.ForeColor = System.Drawing.Color.Ivory;
            this.showAdvisorBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.showAdvisorBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showAdvisorBtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.showAdvisorBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.showAdvisorBtn.Location = new System.Drawing.Point(333, 894);
            this.showAdvisorBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showAdvisorBtn.Name = "showAdvisorBtn";
            this.showAdvisorBtn.ShadowDecoration.BorderRadius = 26;
            this.showAdvisorBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showAdvisorBtn.ShadowDecoration.Enabled = true;
            this.showAdvisorBtn.Size = new System.Drawing.Size(197, 55);
            this.showAdvisorBtn.TabIndex = 105;
            this.showAdvisorBtn.Text = "DISPLAY  ADVISOR";
            this.showAdvisorBtn.Click += new System.EventHandler(this.showAdvisorBtn_Click);
            // 
            // addStudentButton
            // 
            this.addStudentButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addStudentButton.BackColor = System.Drawing.Color.Transparent;
            this.addStudentButton.BorderRadius = 12;
            this.addStudentButton.BorderThickness = 3;
            this.addStudentButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addStudentButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addStudentButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addStudentButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addStudentButton.FillColor = System.Drawing.Color.Black;
            this.addStudentButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentButton.ForeColor = System.Drawing.Color.Ivory;
            this.addStudentButton.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addStudentButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addStudentButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.addStudentButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addStudentButton.Location = new System.Drawing.Point(112, 894);
            this.addStudentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.ShadowDecoration.BorderRadius = 26;
            this.addStudentButton.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addStudentButton.ShadowDecoration.Enabled = true;
            this.addStudentButton.Size = new System.Drawing.Size(207, 55);
            this.addStudentButton.TabIndex = 104;
            this.addStudentButton.Text = "ADD";
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click_1);
            // 
            // genderComboBox
            // 
            this.genderComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.genderComboBox.BackColor = System.Drawing.Color.Transparent;
            this.genderComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.genderComboBox.BorderRadius = 12;
            this.genderComboBox.BorderThickness = 2;
            this.genderComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.genderComboBox.DropDownHeight = 40;
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.DropDownWidth = 240;
            this.genderComboBox.FillColor = System.Drawing.Color.Silver;
            this.genderComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.genderComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genderComboBox.ForeColor = System.Drawing.Color.Black;
            this.genderComboBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.genderComboBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.genderComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.genderComboBox.IntegralHeight = false;
            this.genderComboBox.ItemHeight = 30;
            this.genderComboBox.Location = new System.Drawing.Point(179, 387);
            this.genderComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(212, 36);
            this.genderComboBox.TabIndex = 102;
            // 
            // dateOfBirthPicker
            // 
            this.dateOfBirthPicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateOfBirthPicker.BackColor = System.Drawing.Color.Transparent;
            this.dateOfBirthPicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateOfBirthPicker.BorderRadius = 12;
            this.dateOfBirthPicker.BorderThickness = 2;
            this.dateOfBirthPicker.Checked = true;
            this.dateOfBirthPicker.FillColor = System.Drawing.Color.Silver;
            this.dateOfBirthPicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateOfBirthPicker.ForeColor = System.Drawing.Color.Black;
            this.dateOfBirthPicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateOfBirthPicker.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateOfBirthPicker.HoverState.ForeColor = System.Drawing.Color.Black;
            this.dateOfBirthPicker.Location = new System.Drawing.Point(180, 474);
            this.dateOfBirthPicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateOfBirthPicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateOfBirthPicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateOfBirthPicker.Name = "dateOfBirthPicker";
            this.dateOfBirthPicker.Size = new System.Drawing.Size(251, 40);
            this.dateOfBirthPicker.TabIndex = 101;
            this.dateOfBirthPicker.Value = new System.DateTime(2023, 3, 10, 17, 47, 26, 901);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.emailTextBox.Animated = true;
            this.emailTextBox.BackColor = System.Drawing.Color.Transparent;
            this.emailTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.emailTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTextBox.BorderRadius = 12;
            this.emailTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.emailTextBox.BorderThickness = 2;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.DefaultText = "";
            this.emailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.FillColor = System.Drawing.Color.Silver;
            this.emailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.emailTextBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.HoverState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.emailTextBox.Location = new System.Drawing.Point(179, 635);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.emailTextBox.PlaceholderText = "";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.Size = new System.Drawing.Size(212, 33);
            this.emailTextBox.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(185, 598);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 31);
            this.label6.TabIndex = 99;
            this.label6.Text = "Email";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.contactTextBox.Animated = true;
            this.contactTextBox.BackColor = System.Drawing.Color.Transparent;
            this.contactTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contactTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contactTextBox.BorderRadius = 12;
            this.contactTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.contactTextBox.BorderThickness = 2;
            this.contactTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contactTextBox.DefaultText = "";
            this.contactTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.contactTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.contactTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contactTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.contactTextBox.FillColor = System.Drawing.Color.Silver;
            this.contactTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.contactTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contactTextBox.ForeColor = System.Drawing.Color.Black;
            this.contactTextBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.contactTextBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.contactTextBox.HoverState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.contactTextBox.Location = new System.Drawing.Point(180, 556);
            this.contactTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.PasswordChar = '\0';
            this.contactTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.contactTextBox.PlaceholderText = "";
            this.contactTextBox.SelectedText = "";
            this.contactTextBox.Size = new System.Drawing.Size(212, 35);
            this.contactTextBox.TabIndex = 98;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(183, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 28);
            this.label5.TabIndex = 97;
            this.label5.Text = "Contact";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(181, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 28);
            this.label3.TabIndex = 94;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(181, 440);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 28);
            this.label2.TabIndex = 93;
            this.label2.Text = "Date of Birth";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lastNameTextBox.Animated = true;
            this.lastNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.lastNameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lastNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastNameTextBox.BorderRadius = 12;
            this.lastNameTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.lastNameTextBox.BorderThickness = 2;
            this.lastNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lastNameTextBox.DefaultText = "";
            this.lastNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lastNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lastNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lastNameTextBox.FillColor = System.Drawing.Color.Silver;
            this.lastNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lastNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.lastNameTextBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.lastNameTextBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.lastNameTextBox.HoverState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.lastNameTextBox.Location = new System.Drawing.Point(179, 311);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PasswordChar = '\0';
            this.lastNameTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.lastNameTextBox.PlaceholderText = "";
            this.lastNameTextBox.SelectedText = "";
            this.lastNameTextBox.Size = new System.Drawing.Size(212, 37);
            this.lastNameTextBox.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(175, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 91;
            this.label1.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.firstNameTextBox.Animated = true;
            this.firstNameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.firstNameTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.firstNameTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.firstNameTextBox.BorderRadius = 12;
            this.firstNameTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.firstNameTextBox.BorderThickness = 2;
            this.firstNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstNameTextBox.DefaultText = "";
            this.firstNameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstNameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstNameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstNameTextBox.FillColor = System.Drawing.Color.Silver;
            this.firstNameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.firstNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.firstNameTextBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.firstNameTextBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.firstNameTextBox.HoverState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.firstNameTextBox.Location = new System.Drawing.Point(179, 237);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PasswordChar = '\0';
            this.firstNameTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.firstNameTextBox.PlaceholderText = "";
            this.firstNameTextBox.SelectedText = "";
            this.firstNameTextBox.Size = new System.Drawing.Size(213, 35);
            this.firstNameTextBox.TabIndex = 90;
            // 
            // lblfirstName
            // 
            this.lblfirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblfirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblfirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblfirstName.Location = new System.Drawing.Point(181, 200);
            this.lblfirstName.Name = "lblfirstName";
            this.lblfirstName.Size = new System.Drawing.Size(161, 28);
            this.lblfirstName.TabIndex = 89;
            this.lblfirstName.Text = "First Name";
            // 
            // dgvAdvisors
            // 
            this.dgvAdvisors.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver;
            this.dgvAdvisors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdvisors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdvisors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAdvisors.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvAdvisors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdvisors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdvisors.ColumnHeadersHeight = 68;
            this.dgvAdvisors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdvisors.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAdvisors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAdvisors.Location = new System.Drawing.Point(492, 237);
            this.dgvAdvisors.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAdvisors.Name = "dgvAdvisors";
            this.dgvAdvisors.ReadOnly = true;
            this.dgvAdvisors.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdvisors.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAdvisors.RowHeadersVisible = false;
            this.dgvAdvisors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAdvisors.RowTemplate.Height = 47;
            this.dgvAdvisors.Size = new System.Drawing.Size(550, 552);
            this.dgvAdvisors.TabIndex = 103;
            this.dgvAdvisors.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvAdvisors.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAdvisors.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvAdvisors.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            this.dgvAdvisors.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Silver;
            this.dgvAdvisors.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.dgvAdvisors.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAdvisors.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.dgvAdvisors.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAdvisors.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAdvisors.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Silver;
            this.dgvAdvisors.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAdvisors.ThemeStyle.HeaderStyle.Height = 68;
            this.dgvAdvisors.ThemeStyle.ReadOnly = true;
            this.dgvAdvisors.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gray;
            this.dgvAdvisors.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAdvisors.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAdvisors.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAdvisors.ThemeStyle.RowsStyle.Height = 47;
            this.dgvAdvisors.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            this.dgvAdvisors.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Silver;
            this.dgvAdvisors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdvisors_CellContentClick_1);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(183, 675);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 28);
            this.label4.TabIndex = 95;
            this.label4.Text = "Salary";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.salaryTextBox.Animated = true;
            this.salaryTextBox.BackColor = System.Drawing.Color.Transparent;
            this.salaryTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.salaryTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salaryTextBox.BorderRadius = 12;
            this.salaryTextBox.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.salaryTextBox.BorderThickness = 2;
            this.salaryTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.salaryTextBox.DefaultText = "";
            this.salaryTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.salaryTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.salaryTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.salaryTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.salaryTextBox.FillColor = System.Drawing.Color.Silver;
            this.salaryTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.salaryTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.salaryTextBox.ForeColor = System.Drawing.Color.Black;
            this.salaryTextBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.salaryTextBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.salaryTextBox.HoverState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.salaryTextBox.Location = new System.Drawing.Point(179, 710);
            this.salaryTextBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.PasswordChar = '\0';
            this.salaryTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.salaryTextBox.PlaceholderText = "";
            this.salaryTextBox.SelectedText = "";
            this.salaryTextBox.Size = new System.Drawing.Size(212, 30);
            this.salaryTextBox.TabIndex = 96;
            // 
            // desComboBox
            // 
            this.desComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.desComboBox.BackColor = System.Drawing.Color.Transparent;
            this.desComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.desComboBox.BorderRadius = 12;
            this.desComboBox.BorderThickness = 2;
            this.desComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.desComboBox.DropDownHeight = 40;
            this.desComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.desComboBox.DropDownWidth = 240;
            this.desComboBox.FillColor = System.Drawing.Color.Silver;
            this.desComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.desComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.desComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.desComboBox.ForeColor = System.Drawing.Color.Black;
            this.desComboBox.HoverState.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.desComboBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.desComboBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.desComboBox.IntegralHeight = false;
            this.desComboBox.ItemHeight = 30;
            this.desComboBox.Location = new System.Drawing.Point(180, 781);
            this.desComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.desComboBox.Name = "desComboBox";
            this.desComboBox.Size = new System.Drawing.Size(212, 36);
            this.desComboBox.TabIndex = 110;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(181, 746);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 29);
            this.label7.TabIndex = 109;
            this.label7.Text = "Designation";
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.Transparent;
            this.logoutBtn.BorderColor = System.Drawing.Color.Gainsboro;
            this.logoutBtn.BorderRadius = 12;
            this.logoutBtn.BorderThickness = 2;
            this.logoutBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.logoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutBtn.FillColor = System.Drawing.Color.LightGray;
            this.logoutBtn.FocusedColor = System.Drawing.Color.White;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.Black;
            this.logoutBtn.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.logoutBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoutBtn.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.logoutBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.logoutBtn.Location = new System.Drawing.Point(1989, 48);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.PressedDepth = 20;
            this.logoutBtn.ShadowDecoration.BorderRadius = 26;
            this.logoutBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.logoutBtn.ShadowDecoration.Enabled = true;
            this.logoutBtn.Size = new System.Drawing.Size(195, 54);
            this.logoutBtn.TabIndex = 117;
            this.logoutBtn.Text = "Back";
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2Button1.BorderRadius = 12;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.LightGray;
            this.guna2Button1.FocusedColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button1.Location = new System.Drawing.Point(947, 41);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedDepth = 20;
            this.guna2Button1.ShadowDecoration.BorderRadius = 26;
            this.guna2Button1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Button1.ShadowDecoration.Enabled = true;
            this.guna2Button1.Size = new System.Drawing.Size(213, 52);
            this.guna2Button1.TabIndex = 118;
            this.guna2Button1.Text = "Back";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // AdvisorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1254, 990);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.desComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.personBtn);
            this.Controls.Add(this.updateStudentButton_Click);
            this.Controls.Add(this.showAdvisorBtn);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.dateOfBirthPicker);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lblfirstName);
            this.Controls.Add(this.dgvAdvisors);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdvisorForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdvisorForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.AdvisorForm_Load);
            this.Resize += new System.EventHandler(this.AdvisorForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdvisors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button clearBtn;
        private Guna.UI2.WinForms.Guna2Button personBtn;
        private Guna.UI2.WinForms.Guna2Button updateStudentButton_Click;
        private Guna.UI2.WinForms.Guna2Button showAdvisorBtn;
        private Guna.UI2.WinForms.Guna2Button addStudentButton;
        private Guna.UI2.WinForms.Guna2ComboBox genderComboBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateOfBirthPicker;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox contactTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox lastNameTextBox;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox firstNameTextBox;
        private System.Windows.Forms.Label lblfirstName;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAdvisors;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox salaryTextBox;
        private Guna.UI2.WinForms.Guna2ComboBox desComboBox;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button logoutBtn;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}