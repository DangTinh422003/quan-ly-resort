namespace QuanLyResort
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.formLogin = new System.Windows.Forms.Panel();
            this.forrm = new System.Windows.Forms.Panel();
            this.groupUsername = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.formLogin.SuspendLayout();
            this.forrm.SuspendLayout();
            this.groupUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // formLogin
            // 
            this.formLogin.Controls.Add(this.forrm);
            this.formLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.formLogin.Location = new System.Drawing.Point(0, 0);
            this.formLogin.Name = "formLogin";
            this.formLogin.Size = new System.Drawing.Size(779, 673);
            this.formLogin.TabIndex = 0;
            // 
            // forrm
            // 
            this.forrm.Controls.Add(this.groupUsername);
            this.forrm.Controls.Add(this.label1);
            this.forrm.Controls.Add(this.mainTitle);
            this.forrm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forrm.Location = new System.Drawing.Point(0, 0);
            this.forrm.Name = "forrm";
            this.forrm.Size = new System.Drawing.Size(779, 673);
            this.forrm.TabIndex = 0;
            // 
            // groupUsername
            // 
            this.groupUsername.Controls.Add(this.panel1);
            this.groupUsername.Controls.Add(this.label2);
            this.groupUsername.Location = new System.Drawing.Point(94, 269);
            this.groupUsername.Name = "groupUsername";
            this.groupUsername.Size = new System.Drawing.Size(600, 110);
            this.groupUsername.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 53);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Doan Gia Resort";
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Microsoft New Tai Lue", 46.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.Location = new System.Drawing.Point(77, 69);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(246, 101);
            this.mainTitle.TabIndex = 0;
            this.mainTitle.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(779, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(503, 673);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 673);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.formLogin);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 720);
            this.MinimumSize = new System.Drawing.Size(1300, 720);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.formLogin.ResumeLayout(false);
            this.forrm.ResumeLayout(false);
            this.forrm.PerformLayout();
            this.groupUsername.ResumeLayout(false);
            this.groupUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel formLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel forrm;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel groupUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}