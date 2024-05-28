using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

       

     
        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void Login_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Vhid_Click(object sender, EventArgs e)
        {
            string polzov = Login.Text; 
            string password = Password.Text; 
            string expectedLogin = "Detective.Steve.Jobs";
            string expectedPassword = "Y1St2Job4";

            if (polzov == expectedLogin && password == expectedPassword)
            {
                Golovna form2 = new Golovna();
                form2.FormClosed += (s, args) => this.Close(); 
                form2.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Введений логін або пароль неправильні.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
