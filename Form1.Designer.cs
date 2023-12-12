namespace responsijunpromaul
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnInsert = new Button();
            tbNama = new TextBox();
            cbDep = new ComboBox();
            dgvData = new DataGridView();
            btnDelete = new Button();
            btnEdit = new Button();
            btnLoad = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(12, 206);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // tbNama
            // 
            tbNama.Location = new Point(132, 92);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(188, 23);
            tbNama.TabIndex = 1;
            // 
            // cbDep
            // 
            cbDep.FormattingEnabled = true;
            cbDep.Items.AddRange(new object[] { "HR", "Engineer", "Developer", "Product Manager", "Finance" });
            cbDep.Location = new Point(132, 151);
            cbDep.Name = "cbDep";
            cbDep.Size = new Size(188, 23);
            cbDep.TabIndex = 2;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 246);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(496, 165);
            dgvData.TabIndex = 3;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(245, 206);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(132, 206);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(410, 206);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(98, 23);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "LOAD DATA";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 7;
            label1.Text = "Nama Karyawan : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 154);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 8;
            label2.Text = "Dep. Karyawan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 29);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 9;
            label3.Text = "Logo";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(14, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 50);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(373, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(138, 144);
            panel1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 10);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 12;
            label4.Text = "ID Departemen:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 32);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 13;
            label5.Text = "HR : HR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 54);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 14;
            label6.Text = "ENG : Engineer";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 76);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 15;
            label7.Text = "DEV : Developer";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 98);
            label8.Name = "label8";
            label8.Size = new Size(126, 15);
            label8.TabIndex = 16;
            label8.Text = "PM : Product Manager";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(8, 120);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 17;
            label9.Text = "FIN: Finance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 423);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLoad);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(dgvData);
            Controls.Add(cbDep);
            Controls.Add(tbNama);
            Controls.Add(btnInsert);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Responsi Junpro Maulana Anjari A";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsert;
        private TextBox tbNama;
        private ComboBox cbDep;
        private DataGridView dgvData;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnLoad;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}
