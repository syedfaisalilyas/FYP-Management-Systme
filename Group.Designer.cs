
namespace MidProjectUI
{
    partial class Group
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Group));
            this.groupDatePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.groupDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clearGroupBtn = new Guna.UI2.WinForms.Guna2Button();
            this.showGroupBtn = new Guna.UI2.WinForms.Guna2Button();
            this.updateGroupBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addGroupBtn = new Guna.UI2.WinForms.Guna2Button();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDatePicker
            // 
            this.groupDatePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupDatePicker.BackColor = System.Drawing.Color.Transparent;
            this.groupDatePicker.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupDatePicker.BorderRadius = 12;
            this.groupDatePicker.BorderThickness = 2;
            this.groupDatePicker.Checked = true;
            this.groupDatePicker.FillColor = System.Drawing.Color.Silver;
            this.groupDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupDatePicker.ForeColor = System.Drawing.Color.Black;
            this.groupDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.groupDatePicker.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupDatePicker.HoverState.ForeColor = System.Drawing.Color.Black;
            this.groupDatePicker.Location = new System.Drawing.Point(465, 199);
            this.groupDatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupDatePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.groupDatePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.groupDatePicker.Name = "groupDatePicker";
            this.groupDatePicker.Size = new System.Drawing.Size(370, 55);
            this.groupDatePicker.TabIndex = 108;
            this.groupDatePicker.Value = new System.DateTime(2023, 3, 10, 17, 47, 26, 901);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(499, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 37);
            this.label2.TabIndex = 107;
            this.label2.Text = "Group Created On";
            // 
            // groupDataGridView
            // 
            this.groupDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver;
            this.groupDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.groupDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.groupDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.groupDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.groupDataGridView.ColumnHeadersHeight = 68;
            this.groupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.groupDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.groupDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.groupDataGridView.Location = new System.Drawing.Point(246, 263);
            this.groupDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupDataGridView.Name = "groupDataGridView";
            this.groupDataGridView.ReadOnly = true;
            this.groupDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.groupDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.groupDataGridView.RowHeadersVisible = false;
            this.groupDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.groupDataGridView.RowTemplate.Height = 47;
            this.groupDataGridView.Size = new System.Drawing.Size(792, 452);
            this.groupDataGridView.TabIndex = 109;
            this.groupDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Silver;
            this.groupDataGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            this.groupDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Silver;
            this.groupDataGridView.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.groupDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.groupDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.groupDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.groupDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Silver;
            this.groupDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.groupDataGridView.ThemeStyle.HeaderStyle.Height = 68;
            this.groupDataGridView.ThemeStyle.ReadOnly = true;
            this.groupDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gray;
            this.groupDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.groupDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.groupDataGridView.ThemeStyle.RowsStyle.Height = 47;
            this.groupDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(64)))), ((int)(((byte)(72)))));
            this.groupDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Silver;
            this.groupDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.groupDataGridView_CellContentClick_1);
            // 
            // clearGroupBtn
            // 
            this.clearGroupBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clearGroupBtn.BackColor = System.Drawing.Color.Transparent;
            this.clearGroupBtn.BorderRadius = 12;
            this.clearGroupBtn.BorderThickness = 3;
            this.clearGroupBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearGroupBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearGroupBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearGroupBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearGroupBtn.FillColor = System.Drawing.Color.Black;
            this.clearGroupBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearGroupBtn.ForeColor = System.Drawing.Color.Ivory;
            this.clearGroupBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clearGroupBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.clearGroupBtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.clearGroupBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clearGroupBtn.Location = new System.Drawing.Point(917, 786);
            this.clearGroupBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clearGroupBtn.Name = "clearGroupBtn";
            this.clearGroupBtn.ShadowDecoration.BorderRadius = 26;
            this.clearGroupBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clearGroupBtn.ShadowDecoration.Enabled = true;
            this.clearGroupBtn.Size = new System.Drawing.Size(197, 55);
            this.clearGroupBtn.TabIndex = 117;
            this.clearGroupBtn.Text = "CLEAR";
            this.clearGroupBtn.Click += new System.EventHandler(this.clearGroupBtn_Click);
            // 
            // showGroupBtn
            // 
            this.showGroupBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.showGroupBtn.BackColor = System.Drawing.Color.Transparent;
            this.showGroupBtn.BorderRadius = 12;
            this.showGroupBtn.BorderThickness = 3;
            this.showGroupBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.showGroupBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.showGroupBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.showGroupBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.showGroupBtn.FillColor = System.Drawing.Color.Black;
            this.showGroupBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showGroupBtn.ForeColor = System.Drawing.Color.Ivory;
            this.showGroupBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.showGroupBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showGroupBtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.showGroupBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.showGroupBtn.Location = new System.Drawing.Point(443, 786);
            this.showGroupBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.showGroupBtn.Name = "showGroupBtn";
            this.showGroupBtn.ShadowDecoration.BorderRadius = 26;
            this.showGroupBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showGroupBtn.ShadowDecoration.Enabled = true;
            this.showGroupBtn.Size = new System.Drawing.Size(197, 55);
            this.showGroupBtn.TabIndex = 116;
            this.showGroupBtn.Text = "DISPLAY";
            this.showGroupBtn.Click += new System.EventHandler(this.showGroupBtn_Click_1);
            // 
            // updateGroupBtn
            // 
            this.updateGroupBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.updateGroupBtn.BackColor = System.Drawing.Color.Transparent;
            this.updateGroupBtn.BorderRadius = 12;
            this.updateGroupBtn.BorderThickness = 3;
            this.updateGroupBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateGroupBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateGroupBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateGroupBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateGroupBtn.FillColor = System.Drawing.Color.Black;
            this.updateGroupBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateGroupBtn.ForeColor = System.Drawing.Color.Ivory;
            this.updateGroupBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.updateGroupBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updateGroupBtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.updateGroupBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updateGroupBtn.Location = new System.Drawing.Point(668, 786);
            this.updateGroupBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateGroupBtn.Name = "updateGroupBtn";
            this.updateGroupBtn.ShadowDecoration.BorderRadius = 26;
            this.updateGroupBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updateGroupBtn.ShadowDecoration.Enabled = true;
            this.updateGroupBtn.Size = new System.Drawing.Size(197, 55);
            this.updateGroupBtn.TabIndex = 115;
            this.updateGroupBtn.Text = "UPDATE";
            this.updateGroupBtn.Click += new System.EventHandler(this.updateGroupBtn_Click_1);
            // 
            // addGroupBtn
            // 
            this.addGroupBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addGroupBtn.BackColor = System.Drawing.Color.Transparent;
            this.addGroupBtn.BorderRadius = 12;
            this.addGroupBtn.BorderThickness = 3;
            this.addGroupBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addGroupBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addGroupBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addGroupBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addGroupBtn.FillColor = System.Drawing.Color.Black;
            this.addGroupBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroupBtn.ForeColor = System.Drawing.Color.Ivory;
            this.addGroupBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addGroupBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addGroupBtn.HoverState.ForeColor = System.Drawing.Color.Black;
            this.addGroupBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addGroupBtn.Location = new System.Drawing.Point(190, 786);
            this.addGroupBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addGroupBtn.Name = "addGroupBtn";
            this.addGroupBtn.ShadowDecoration.BorderRadius = 26;
            this.addGroupBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addGroupBtn.ShadowDecoration.Enabled = true;
            this.addGroupBtn.Size = new System.Drawing.Size(207, 55);
            this.addGroupBtn.TabIndex = 114;
            this.addGroupBtn.Text = "ADD";
            this.addGroupBtn.Click += new System.EventHandler(this.addGroupBtn_Click_1);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.logoutBtn.Location = new System.Drawing.Point(1045, 28);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.PressedDepth = 20;
            this.logoutBtn.ShadowDecoration.BorderRadius = 26;
            this.logoutBtn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.logoutBtn.ShadowDecoration.Enabled = true;
            this.logoutBtn.Size = new System.Drawing.Size(165, 54);
            this.logoutBtn.TabIndex = 118;
            this.logoutBtn.Text = "Back";
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1289, 870);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.clearGroupBtn);
            this.Controls.Add(this.showGroupBtn);
            this.Controls.Add(this.updateGroupBtn);
            this.Controls.Add(this.addGroupBtn);
            this.Controls.Add(this.groupDataGridView);
            this.Controls.Add(this.groupDatePicker);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Group";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DISPLAY";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Group_Load);
            this.Resize += new System.EventHandler(this.ManageForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.groupDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker groupDatePicker;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView groupDataGridView;
        private Guna.UI2.WinForms.Guna2Button clearGroupBtn;
        private Guna.UI2.WinForms.Guna2Button showGroupBtn;
        private Guna.UI2.WinForms.Guna2Button updateGroupBtn;
        private Guna.UI2.WinForms.Guna2Button addGroupBtn;
        private Guna.UI2.WinForms.Guna2Button logoutBtn;
    }
}