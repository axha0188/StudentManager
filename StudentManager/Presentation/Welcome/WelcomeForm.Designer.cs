namespace StudentManager.Presentation.Welcome
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            BtnNextMain = new Button();
            welcomeImg = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)welcomeImg).BeginInit();
            SuspendLayout();
            // 
            // BtnNextMain
            // 
            BtnNextMain.BackColor = Color.WhiteSmoke;
            BtnNextMain.FlatAppearance.BorderSize = 0;
            BtnNextMain.FlatStyle = FlatStyle.Flat;
            BtnNextMain.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnNextMain.Location = new Point(278, 487);
            BtnNextMain.Name = "BtnNextMain";
            BtnNextMain.Size = new Size(248, 53);
            BtnNextMain.TabIndex = 0;
            BtnNextMain.Text = "Siguiente";
            BtnNextMain.UseVisualStyleBackColor = false;
            BtnNextMain.Click += BtnNextMain_Click;
            // 
            // welcomeImg
            // 
            welcomeImg.Image = (Image)resources.GetObject("welcomeImg.Image");
            welcomeImg.InitialImage = null;
            welcomeImg.Location = new Point(214, 44);
            welcomeImg.Name = "welcomeImg";
            welcomeImg.Size = new Size(363, 373);
            welcomeImg.SizeMode = PictureBoxSizeMode.StretchImage;
            welcomeImg.TabIndex = 1;
            welcomeImg.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(200, 437);
            label1.Name = "label1";
            label1.Size = new Size(394, 23);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido a Gestor de Estudiantes";
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 588);
            Controls.Add(label1);
            Controls.Add(welcomeImg);
            Controls.Add(BtnNextMain);
            MaximizeBox = false;
            MaximumSize = new Size(816, 627);
            MinimumSize = new Size(816, 627);
            Name = "WelcomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestor de Estudiantes";
            ((System.ComponentModel.ISupportInitialize)welcomeImg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnNextMain;
        private PictureBox welcomeImg;
        private Label label1;
    }
}