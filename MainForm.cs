using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyResort
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            activeLine.Location = new Point(btn_Booking.Location.X, btn_Booking.Location.Y);
            changeActiveLineLocation(btn_Booking);
            changeStyleWhenActive(btn_Booking);
        }

        private void changeActiveLineLocation(Button btn)
        {
            activeLine.Location = new Point(btn.Location.X, btn.Location.Y);
        }

        private void changeStyleWhenActive(Button btn)
        {
            Console.WriteLine("\n\n");
            foreach (Control ctr in sidebar.Controls)
            {
                if (ctr.GetType() == typeof(Button))
                {
                    if (ctr.Name == btn.Name)
                    {
                        Console.WriteLine(ctr.Name);
                        Console.WriteLine(btn.Name);
                        ctr.BackColor = Color.FromArgb(255, 255, 104);
                    }
                    else
                    {
                        ctr.BackColor = Color.FromArgb(255, 255, 255);
                    }
                }
            }
        }

        private void addUserControll(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btn_Booking_Click(object sender, EventArgs e)
        {
            changeStyleWhenActive((Button)sender);
            changeActiveLineLocation((Button)sender);
            UserControl_Booking userControl = new UserControl_Booking();
            addUserControll(userControl);
        }

        private void btn_Room_Click(object sender, EventArgs e)
        {
            changeStyleWhenActive((Button)sender);
            changeActiveLineLocation((Button)sender);
            UserControl_Room userControl = new UserControl_Room();
            addUserControll(userControl);
        }

        private void btn_Manager_Click(object sender, EventArgs e)
        {
            changeStyleWhenActive((Button)sender);
            changeActiveLineLocation((Button)sender);
            UserControl_Manager userControl = new UserControl_Manager();
            addUserControll(userControl);
        }

        private void btn_Accountant_Click(object sender, EventArgs e)
        {
            changeStyleWhenActive((Button)sender);
            changeActiveLineLocation((Button)sender);
            UserControl_Accountant userControl = new UserControl_Accountant();
            addUserControll(userControl);
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            changeStyleWhenActive((Button)sender);
            changeActiveLineLocation((Button)sender);
            UserControl_Customer userControl = new UserControl_Customer();
            addUserControll(userControl);
        }
    }
}
