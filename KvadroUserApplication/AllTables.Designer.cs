namespace KvadroUserApplication
{
    partial class AllTables
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllTables));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.AddRecordButton = new System.Windows.Forms.Button();
            this.EditRecordButton = new System.Windows.Forms.Button();
            this.DeleteRecordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1244, 426);
            this.dataGridView1.TabIndex = 10;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.CloseButton.Location = new System.Drawing.Point(1149, 445);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(107, 44);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(161)))), ((int)(((byte)(47)))));
            this.ExportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.ExportButton.ForeColor = System.Drawing.Color.Black;
            this.ExportButton.Location = new System.Drawing.Point(546, 445);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(249, 45);
            this.ExportButton.TabIndex = 11;
            this.ExportButton.Text = "Экспортировать в MS Excel";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.AddRecordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRecordButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.AddRecordButton.ForeColor = System.Drawing.Color.Black;
            this.AddRecordButton.Location = new System.Drawing.Point(12, 445);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(172, 45);
            this.AddRecordButton.TabIndex = 11;
            this.AddRecordButton.Text = "Добавить";
            this.AddRecordButton.UseVisualStyleBackColor = false;
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
            // 
            // EditRecordButton
            // 
            this.EditRecordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.EditRecordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditRecordButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.EditRecordButton.ForeColor = System.Drawing.Color.Black;
            this.EditRecordButton.Location = new System.Drawing.Point(190, 445);
            this.EditRecordButton.Name = "EditRecordButton";
            this.EditRecordButton.Size = new System.Drawing.Size(172, 45);
            this.EditRecordButton.TabIndex = 11;
            this.EditRecordButton.Text = "Изменить";
            this.EditRecordButton.UseVisualStyleBackColor = false;
            this.EditRecordButton.Click += new System.EventHandler(this.EditRecordButton_Click);
            // 
            // DeleteRecordButton
            // 
            this.DeleteRecordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(232)))), ((int)(((byte)(120)))));
            this.DeleteRecordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteRecordButton.Font = new System.Drawing.Font("Calibri", 14F);
            this.DeleteRecordButton.ForeColor = System.Drawing.Color.Black;
            this.DeleteRecordButton.Location = new System.Drawing.Point(368, 445);
            this.DeleteRecordButton.Name = "DeleteRecordButton";
            this.DeleteRecordButton.Size = new System.Drawing.Size(172, 45);
            this.DeleteRecordButton.TabIndex = 11;
            this.DeleteRecordButton.Text = "Удалить";
            this.DeleteRecordButton.UseVisualStyleBackColor = false;
            this.DeleteRecordButton.Click += new System.EventHandler(this.DeleteRecordButton_Click);
            // 
            // AllTables
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(238)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1268, 498);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DeleteRecordButton);
            this.Controls.Add(this.EditRecordButton);
            this.Controls.Add(this.AddRecordButton);
            this.Controls.Add(this.ExportButton);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1284, 537);
            this.MinimumSize = new System.Drawing.Size(1284, 537);
            this.Name = "AllTables";
            this.Text = "AllTables";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button AddRecordButton;
        private System.Windows.Forms.Button EditRecordButton;
        private System.Windows.Forms.Button DeleteRecordButton;
    }
}