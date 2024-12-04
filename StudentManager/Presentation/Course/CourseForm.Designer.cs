namespace StudentManager.Presentation.Course
{
    partial class CourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseForm));
            panel1 = new Panel();
            TxtCredit = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label2 = new Label();
            TxtDescription = new TextBox();
            label3 = new Label();
            BtnSave = new Button();
            TxtName = new TextBox();
            label1 = new Label();
            DgvCourseList = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCourseList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(TxtCredit);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(TxtDescription);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(BtnSave);
            panel1.Controls.Add(TxtName);
            panel1.Location = new Point(687, 123);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 346);
            panel1.TabIndex = 17;
            // 
            // TxtCredit
            // 
            TxtCredit.BackColor = Color.WhiteSmoke;
            TxtCredit.BorderStyle = BorderStyle.None;
            TxtCredit.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCredit.Location = new Point(30, 219);
            TxtCredit.Name = "TxtCredit";
            TxtCredit.Size = new Size(276, 19);
            TxtCredit.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 190);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(68, 16);
            label4.TabIndex = 14;
            label4.Text = "Creditos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 116);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(91, 16);
            label5.TabIndex = 12;
            label5.Text = "Descripcion";
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
            // TxtDescription
            // 
            TxtDescription.BackColor = Color.WhiteSmoke;
            TxtDescription.BorderStyle = BorderStyle.None;
            TxtDescription.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDescription.Location = new Point(30, 146);
            TxtDescription.Name = "TxtDescription";
            TxtDescription.Size = new Size(276, 19);
            TxtDescription.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 52);
            label3.Name = "label3";
            label3.Size = new Size(64, 16);
            label3.TabIndex = 9;
            label3.Text = "Nombre";
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
            // TxtName
            // 
            TxtName.BackColor = Color.WhiteSmoke;
            TxtName.BorderStyle = BorderStyle.None;
            TxtName.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtName.Location = new Point(30, 79);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(276, 19);
            TxtName.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(15, 29);
            label1.Name = "label1";
            label1.Size = new Size(200, 23);
            label1.TabIndex = 16;
            label1.Text = "Listado de Cursos";
            // 
            // DgvCourseList
            // 
            DgvCourseList.AllowUserToAddRows = false;
            DgvCourseList.AllowUserToDeleteRows = false;
            DgvCourseList.BackgroundColor = Color.WhiteSmoke;
            DgvCourseList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCourseList.Location = new Point(15, 71);
            DgvCourseList.Name = "DgvCourseList";
            DgvCourseList.RowTemplate.Height = 25;
            DgvCourseList.Size = new Size(638, 457);
            DgvCourseList.TabIndex = 15;
            DgvCourseList.CellClick += DgvCourseList_CellClick;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 556);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(DgvCourseList);
            MaximumSize = new Size(1050, 595);
            MinimumSize = new Size(1050, 595);
            Name = "CourseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cursos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCourseList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label2;
        private TextBox TxtDescription;
        private Label label3;
        private Button BtnSave;
        private TextBox TxtName;
        private Label label1;
        private DataGridView DgvCourseList;
        private TextBox TxtCredit;
        private Label label4;
    }
}