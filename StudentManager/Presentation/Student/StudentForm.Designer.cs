namespace StudentManager.Presentation.Student
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            DgvStudentsList = new DataGridView();
            BtnSave = new Button();
            label1 = new Label();
            TxtFullName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            DtpDateOfBirth = new DateTimePicker();
            label5 = new Label();
            TxtEmail = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)DgvStudentsList).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // DgvStudentsList
            // 
            DgvStudentsList.AllowUserToAddRows = false;
            DgvStudentsList.AllowUserToDeleteRows = false;
            DgvStudentsList.BackgroundColor = Color.WhiteSmoke;
            DgvStudentsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvStudentsList.Location = new Point(12, 71);
            DgvStudentsList.Name = "DgvStudentsList";
            DgvStudentsList.RowTemplate.Height = 25;
            DgvStudentsList.Size = new Size(638, 457);
            DgvStudentsList.TabIndex = 0;
            DgvStudentsList.CellClick += DgvStudentsList_CellClick;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.WhiteSmoke;
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSave.Image = (Image)resources.GetObject("BtnSave.Image");
            BtnSave.ImageAlign = ContentAlignment.MiddleRight;
            BtnSave.Location = new Point(30, 261);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(276, 46);
            BtnSave.TabIndex = 5;
            BtnSave.Text = "Guardar";
            BtnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(255, 23);
            label1.TabIndex = 6;
            label1.Text = "Listado de Estudiantes";
            // 
            // TxtFullName
            // 
            TxtFullName.BackColor = Color.WhiteSmoke;
            TxtFullName.BorderStyle = BorderStyle.None;
            TxtFullName.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtFullName.Location = new Point(30, 79);
            TxtFullName.Name = "TxtFullName";
            TxtFullName.Size = new Size(276, 19);
            TxtFullName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 14);
            label2.Name = "label2";
            label2.Size = new Size(127, 23);
            label2.TabIndex = 8;
            label2.Text = "Formulario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 52);
            label3.Name = "label3";
            label3.Size = new Size(154, 16);
            label3.TabIndex = 9;
            label3.Text = "Nombres Completos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 112);
            label4.Name = "label4";
            label4.Size = new Size(158, 16);
            label4.TabIndex = 10;
            label4.Text = "Fecha de nacimiento";
            // 
            // DtpDateOfBirth
            // 
            DtpDateOfBirth.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            DtpDateOfBirth.Location = new Point(30, 141);
            DtpDateOfBirth.Name = "DtpDateOfBirth";
            DtpDateOfBirth.Size = new Size(276, 23);
            DtpDateOfBirth.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 186);
            label5.Name = "label5";
            label5.Size = new Size(141, 16);
            label5.TabIndex = 12;
            label5.Text = "Correo electrónico";
            // 
            // TxtEmail
            // 
            TxtEmail.BackColor = Color.WhiteSmoke;
            TxtEmail.BorderStyle = BorderStyle.None;
            TxtEmail.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEmail.Location = new Point(30, 222);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(276, 19);
            TxtEmail.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TxtEmail);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(DtpDateOfBirth);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(BtnSave);
            panel1.Controls.Add(TxtFullName);
            panel1.Location = new Point(684, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 346);
            panel1.TabIndex = 14;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1034, 556);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(DgvStudentsList);
            MaximizeBox = false;
            MaximumSize = new Size(1050, 595);
            MinimumSize = new Size(1050, 595);
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estudiantes";
            ((System.ComponentModel.ISupportInitialize)DgvStudentsList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvStudentsList;
        private Button BtnSave;
        private Label label1;
        private TextBox TxtFullName;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker DtpDateOfBirth;
        private Label label5;
        private TextBox TxtEmail;
        private Panel panel1;
    }
}