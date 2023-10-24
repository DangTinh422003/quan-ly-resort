namespace QuanLyResort
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
            this.sidebar = new System.Windows.Forms.Panel();
            this.activeLine = new System.Windows.Forms.Panel();
            this.btn_Accountant = new System.Windows.Forms.Button();
            this.btn_Manager = new System.Windows.Forms.Button();
            this.btn_Room = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_Booking = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.userControl_Booking1 = new QuanLyResort.UserControl_Booking();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sidebar.Controls.Add(this.activeLine);
            this.sidebar.Controls.Add(this.btn_Accountant);
            this.sidebar.Controls.Add(this.btn_Manager);
            this.sidebar.Controls.Add(this.btn_Room);
            this.sidebar.Controls.Add(this.btn_Customer);
            this.sidebar.Controls.Add(this.btn_Booking);
            this.sidebar.Controls.Add(this.pictureBox1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(242, 673);
            this.sidebar.TabIndex = 2;
            // 
            // activeLine
            // 
            this.activeLine.BackColor = System.Drawing.Color.Yellow;
            this.activeLine.Location = new System.Drawing.Point(0, 107);
            this.activeLine.Name = "activeLine";
            this.activeLine.Size = new System.Drawing.Size(12, 69);
            this.activeLine.TabIndex = 6;
            // 
            // btn_Accountant
            // 
            this.btn_Accountant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Accountant.FlatAppearance.BorderSize = 0;
            this.btn_Accountant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Accountant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Accountant.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Accountant.Image = ((System.Drawing.Image)(resources.GetObject("btn_Accountant.Image")));
            this.btn_Accountant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Accountant.Location = new System.Drawing.Point(2, 314);
            this.btn_Accountant.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Accountant.Name = "btn_Accountant";
            this.btn_Accountant.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_Accountant.Size = new System.Drawing.Size(242, 69);
            this.btn_Accountant.TabIndex = 5;
            this.btn_Accountant.Text = "Accountant";
            this.btn_Accountant.UseVisualStyleBackColor = true;
            this.btn_Accountant.Click += new System.EventHandler(this.btn_Accountant_Click);
            // 
            // btn_Manager
            // 
            this.btn_Manager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Manager.FlatAppearance.BorderSize = 0;
            this.btn_Manager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Manager.Image = ((System.Drawing.Image)(resources.GetObject("btn_Manager.Image")));
            this.btn_Manager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Manager.Location = new System.Drawing.Point(2, 245);
            this.btn_Manager.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Manager.Name = "btn_Manager";
            this.btn_Manager.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_Manager.Size = new System.Drawing.Size(242, 69);
            this.btn_Manager.TabIndex = 4;
            this.btn_Manager.Text = "Manager";
            this.btn_Manager.UseVisualStyleBackColor = true;
            this.btn_Manager.Click += new System.EventHandler(this.btn_Manager_Click);
            // 
            // btn_Room
            // 
            this.btn_Room.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Room.FlatAppearance.BorderSize = 0;
            this.btn_Room.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Room.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Room.Image = ((System.Drawing.Image)(resources.GetObject("btn_Room.Image")));
            this.btn_Room.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Room.Location = new System.Drawing.Point(2, 176);
            this.btn_Room.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Room.Name = "btn_Room";
            this.btn_Room.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_Room.Size = new System.Drawing.Size(242, 69);
            this.btn_Room.TabIndex = 3;
            this.btn_Room.Text = "Room";
            this.btn_Room.UseVisualStyleBackColor = true;
            this.btn_Room.Click += new System.EventHandler(this.btn_Room_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Customer.FlatAppearance.BorderSize = 0;
            this.btn_Customer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.Image = ((System.Drawing.Image)(resources.GetObject("btn_Customer.Image")));
            this.btn_Customer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Customer.Location = new System.Drawing.Point(2, 383);
            this.btn_Customer.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_Customer.Size = new System.Drawing.Size(242, 69);
            this.btn_Customer.TabIndex = 2;
            this.btn_Customer.Text = "Customer";
            this.btn_Customer.UseVisualStyleBackColor = true;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_Booking
            // 
            this.btn_Booking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Booking.FlatAppearance.BorderSize = 0;
            this.btn_Booking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Booking.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Booking.Image = ((System.Drawing.Image)(resources.GetObject("btn_Booking.Image")));
            this.btn_Booking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Booking.Location = new System.Drawing.Point(0, 107);
            this.btn_Booking.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Booking.Name = "btn_Booking";
            this.btn_Booking.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btn_Booking.Size = new System.Drawing.Size(242, 69);
            this.btn_Booking.TabIndex = 1;
            this.btn_Booking.Text = "Booking";
            this.btn_Booking.UseVisualStyleBackColor = true;
            this.btn_Booking.Click += new System.EventHandler(this.btn_Booking_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(242, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 64);
            this.panel1.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(394, 17);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 35);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.WordWrap = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.userControl_Booking1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(242, 64);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1040, 609);
            this.mainPanel.TabIndex = 4;
            // 
            // userControl_Booking1
            // 
            this.userControl_Booking1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl_Booking1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl_Booking1.Location = new System.Drawing.Point(0, 0);
            this.userControl_Booking1.Name = "userControl_Booking1";
            this.userControl_Booking1.Size = new System.Drawing.Size(1040, 609);
            this.userControl_Booking1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 673);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidebar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 720);
            this.MinimumSize = new System.Drawing.Size(1300, 720);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doan Gia\'s Resort";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Booking;
        private System.Windows.Forms.Button btn_Accountant;
        private System.Windows.Forms.Button btn_Manager;
        private System.Windows.Forms.Button btn_Room;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel activeLine;
        private System.Windows.Forms.Panel mainPanel;
        private UserControl_Booking userControl_Booking1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

