namespace StudentManager.Presentation.Main
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            welcomeImg = new PictureBox();
            BtnNextStudent = new Button();
            BtnNextCourse = new Button();
            BtnNextEnrollment = new Button();
            BtnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)welcomeImg).BeginInit();
            SuspendLayout();
            // 
            // welcomeImg
            // 
            welcomeImg.Image = (Image)resources.GetObject("welcomeImg.Image");
            welcomeImg.InitialImage = null;
            welcomeImg.Location = new Point(211, 41);
            welcomeImg.Name = "welcomeImg";
            welcomeImg.Size = new Size(363, 373);
            welcomeImg.SizeMode = PictureBoxSizeMode.StretchImage;
            welcomeImg.TabIndex = 2;
            welcomeImg.TabStop = false;
            // 
            // BtnNextStudent
            // 
            BtnNextStudent.BackColor = Color.WhiteSmoke;
            BtnNextStudent.FlatAppearance.BorderSize = 0;
            BtnNextStudent.FlatStyle = FlatStyle.Flat;
            BtnNextStudent.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnNextStudent.Image = (Image)resources.GetObject("BtnNextStudent.Image");
            BtnNextStudent.ImageAlign = ContentAlignment.MiddleLeft;
            BtnNextStudent.Location = new Point(100, 468);
            BtnNextStudent.Name = "BtnNextStudent";
            BtnNextStudent.Size = new Size(169, 60);
            BtnNextStudent.TabIndex = 4;
            BtnNextStudent.Text = "Estudiantes";
            BtnNextStudent.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnNextStudent.UseVisualStyleBackColor = false;
            BtnNextStudent.Click += BtnNextStudent_Click;
            // 
            // BtnNextCourse
            // 
            BtnNextCourse.BackColor = Color.WhiteSmoke;
            BtnNextCourse.FlatAppearance.BorderSize = 0;
            BtnNextCourse.FlatStyle = FlatStyle.Flat;
            BtnNextCourse.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnNextCourse.Image = (Image)resources.GetObject("BtnNextCourse.Image");
            BtnNextCourse.ImageAlign = ContentAlignment.MiddleLeft;
            BtnNextCourse.Location = new Point(324, 468);
            BtnNextCourse.Name = "BtnNextCourse";
            BtnNextCourse.Size = new Size(162, 60);
            BtnNextCourse.TabIndex = 5;
            BtnNextCourse.Text = "Cursos";
            BtnNextCourse.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnNextCourse.UseVisualStyleBackColor = false;
            BtnNextCourse.Click += BtnNextCourse_Click;
            // 
            // BtnNextEnrollment
            // 
            BtnNextEnrollment.BackColor = Color.WhiteSmoke;
            BtnNextEnrollment.FlatAppearance.BorderSize = 0;
            BtnNextEnrollment.FlatStyle = FlatStyle.Flat;
            BtnNextEnrollment.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnNextEnrollment.Image = (Image)resources.GetObject("BtnNextEnrollment.Image");
            BtnNextEnrollment.ImageAlign = ContentAlignment.MiddleLeft;
            BtnNextEnrollment.Location = new Point(535, 468);
            BtnNextEnrollment.Name = "BtnNextEnrollment";
            BtnNextEnrollment.Size = new Size(172, 60);
            BtnNextEnrollment.TabIndex = 6;
            BtnNextEnrollment.Text = "Inscripciones";
            BtnNextEnrollment.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnNextEnrollment.UseVisualStyleBackColor = false;
            // 
            // BtnExit
            // 
            BtnExit.BackColor = Color.White;
            BtnExit.FlatAppearance.BorderSize = 0;
            BtnExit.FlatStyle = FlatStyle.Flat;
            BtnExit.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnExit.Image = (Image)resources.GetObject("BtnExit.Image");
            BtnExit.ImageAlign = ContentAlignment.TopCenter;
            BtnExit.Location = new Point(732, 12);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(56, 60);
            BtnExit.TabIndex = 7;
            BtnExit.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnExit.UseVisualStyleBackColor = false;
            BtnExit.Click += BtnExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 588);
            Controls.Add(BtnExit);
            Controls.Add(BtnNextEnrollment);
            Controls.Add(BtnNextCourse);
            Controls.Add(BtnNextStudent);
            Controls.Add(welcomeImg);
            MaximizeBox = false;
            MaximumSize = new Size(816, 627);
            MinimumSize = new Size(816, 627);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de Estudiantes";
            ((System.ComponentModel.ISupportInitialize)welcomeImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox welcomeImg;
        private Button BtnNextStudent;
        private Button BtnNextCourse;
        private Button BtnNextEnrollment;
        private Button BtnExit;
    }
}