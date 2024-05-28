using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Criminals;


namespace WindowsFormsApp1
{
    public partial class Groups : Form
    {
        public List<groupCrim> grcriminals;
        public Criminal grcriminal;
        private int currentCriminalIndex = 0;
        public Groups()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Criminals.Groups groups = new Criminals.Groups();
            grcriminals =groups.grcriminals;
        }

       
        private void back_Click(object sender, EventArgs e)
        {
            Groups form5 = new Groups();
            Golovna form2 = new Golovna();
            form5.FormClosed += (s, args) => this.Close();
            form2.Show();
            this.Hide();
            form5.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label2.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";

            var groupedCriminals = grcriminals.GroupBy(crim => crim.GroupName);
            foreach (var group in groupedCriminals)
            {
                string groupHeaderText = $"{group.Key}\n";

                string leadersText = "Лідер:\n";
                string membersText = "Учасники:\n";

                foreach (var crim in group)
                {
                    string memberInfo = $"{crim.FirstName} {crim.LastName} ({crim.Nickname})";
                    if (crim.IsLeader)
                    {
                        leadersText += $"{memberInfo}{(crim.IsArchived ? " !Архівовано" : "")}\n";
                    }
                    else
                    {
                        membersText += $"{memberInfo}{(crim.IsArchived ? " !Архівовано" : "")}\n";
                    }
                }

                string groupText = $"{groupHeaderText}{leadersText}{membersText}";

                if (label3.Text == "")
                {
                    label3.Text = groupText;
                }
                else if (label4.Text == "")
                {
                    label4.Text = groupText;
                }
                else if (label5.Text == "")
                {
                    label5.Text = groupText;
                }
                else if (label6.Text == "")
                {
                    label6.Text = groupText;
                }
                else if (label2.Text == "")
                {
                    label2.Text = groupText;
                }
                else if (label7.Text == "")
                {
                    label7.Text = groupText;
                }
                else if (label8.Text == "")
                {
                    label8.Text = groupText;
                }
                else if (label9.Text == "")
                {
                    label9.Text = groupText;
                }
            }
        }
    }
    
}
