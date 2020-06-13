namespace KvadroUserApplication
{
    partial class UserRightsManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRightsManagement));
            this.label7 = new System.Windows.Forms.Label();
            this.AddAccessListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UserAccessListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AuthorizationButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(722, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 26);
            this.label7.TabIndex = 29;
            this.label7.Text = "Добавить права";
            // 
            // AddAccessListBox
            // 
            this.AddAccessListBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAccessListBox.FormattingEnabled = true;
            this.AddAccessListBox.HorizontalScrollbar = true;
            this.AddAccessListBox.ItemHeight = 19;
            this.AddAccessListBox.Location = new System.Drawing.Point(567, 119);
            this.AddAccessListBox.Name = "AddAccessListBox";
            this.AddAccessListBox.Size = new System.Drawing.Size(465, 327);
            this.AddAccessListBox.TabIndex = 28;
            this.AddAccessListBox.DoubleClick += new System.EventHandler(this.AccessListBoxes_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(167, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "Текущие права";
            // 
            // UserAccessListBox
            // 
            this.UserAccessListBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserAccessListBox.FormattingEnabled = true;
            this.UserAccessListBox.HorizontalScrollbar = true;
            this.UserAccessListBox.ItemHeight = 19;
            this.UserAccessListBox.Location = new System.Drawing.Point(7, 119);
            this.UserAccessListBox.Name = "UserAccessListBox";
            this.UserAccessListBox.Size = new System.Drawing.Size(465, 327);
            this.UserAccessListBox.TabIndex = 26;
            this.UserAccessListBox.DoubleClick += new System.EventHandler(this.AccessListBoxes_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(238)))), ((int)(((byte)(153)))));
            this.panel1.Controls.Add(this.HeaderLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 75);
            this.panel1.TabIndex = 30;
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderLabel.Font = new System.Drawing.Font("Calibri", 24F);
            this.HeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(1039, 46);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Изменение прав доступа пользователя ";
            this.HeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1039, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "для добавления или удаления соответствующего права дважды кликните на него";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthorizationButton
            // 
            this.AuthorizationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.AuthorizationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AuthorizationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorizationButton.ForeColor = System.Drawing.Color.Black;
            this.AuthorizationButton.Location = new System.Drawing.Point(701, 452);
            this.AuthorizationButton.Name = "AuthorizationButton";
            this.AuthorizationButton.Size = new System.Drawing.Size(331, 45);
            this.AuthorizationButton.TabIndex = 31;
            this.AuthorizationButton.Text = "Закрыть";
            this.AuthorizationButton.UseVisualStyleBackColor = false;
            this.AuthorizationButton.Click += new System.EventHandler(this.AuthorizationButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(491, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // UserRightsManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1039, 503);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AuthorizationButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddAccessListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserAccessListBox);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1055, 542);
            this.MinimumSize = new System.Drawing.Size(1055, 542);
            this.Name = "UserRightsManagement";
            this.Text = "Управление правами пользователя ";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox AddAccessListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox UserAccessListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AuthorizationButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}