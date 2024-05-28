using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Criminals;

namespace WindowsFormsApp1
{
    public partial class Golovna : Form
    {
        public List<Criminal> criminals;
        public Criminal criminal;
        private int currentCriminalIndex = 0;
        private bool searchPerformed = false;


        public Golovna()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            CriminalDatabase database = new CriminalDatabase();
            criminals = CriminalDatabase.criminals;


        }

   
        private void Search_Click(object sender, EventArgs e)
        {
            Golovna form2 = new Golovna();
            Poshuk_Zl form3 = new Poshuk_Zl();
            form2.FormClosed += (s, args) => this.Close();
            form3.Show();
            this.Hide();
            form2.Close();
           
        }

        private void arhiv_Click(object sender, EventArgs e)
        {
            Golovna form2 = new Golovna();
            Archivchik form4 = new Archivchik();
            form2.FormClosed += (s, args) => this.Close();
            form4.Show();
            this.Hide();
            form2.Close();

        }

        private void group_Click(object sender, EventArgs e)
        {
            Golovna form2 = new Golovna();
            Groups form5 = new Groups();
            form2.FormClosed += (s, args) => this.Close();
            form5.Show();
            this.Hide();
            form2.Close();

        }

        private void addict_Click(object sender, EventArgs e)
        {
            Golovna form2 = new Golovna();
            Add_Someone form6 = new Add_Someone();
            form2.FormClosed += (s, args) => this.Close();
            form6.Show();
            this.Hide();
            form2.Close();


        }

        private void label1_Click(object sender, EventArgs e)
        {
            searchPerformed = true;

            criminal = criminals[0];
                string criminalInfo = $"Прізвище: {criminal.Surname}\n" +
                      $"Ім'я: {criminal.FirstName}\n" +
                      $"Прізвисько: {criminal.Nickname}\n" +
                      $"Зріст: {criminal.Height} cm\n" +
                      $"Колір Волосся: {criminal.HairColor}\n" +
                      $"Колір Очей: {criminal.EyeColor}\n" +
                      $"Відмінні особливості: {criminal.DistinguishingFeatures}\n" +
                      $"Національність: {criminal.Nationality}\n" +
                      $"Місце народження: {criminal.PlaceOfBirth}\n" +
                      $"Дата народження: {criminal.DateOfBirth.ToShortDateString()}\n" +
                      $"Останнє місцезнаходження: {criminal.LastResidence}\n" +
                      $"Мови які знає: {string.Join(", ", criminal.Languages)}\n" +
                      $"Кримінальна професія: {criminal.CriminalProfession}\n" +
                      $"Останній злочин: {criminal.LastCrime}\n" +
                      $"Рівень небезпеки: {criminal.DangerLevel}\n" +
                      $"Угрупування: {criminal.CriminalGroup}\n" +
                      $"Де перебуває: {string.Join(", ", criminal.PossibleIntentions)}\n";


                zliy0.Text = criminalInfo;
                pictureBox2.Tag = criminal;
               pictureBox2_Click(sender, e);
        }
       private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Tag != null && pictureBox2.Tag is Criminal)
            {
               
                criminal = (Criminal)pictureBox2.Tag;

                
                pictureBox2.Image = null;

                
                pictureBox2.Load(criminal.Photo);
            }
        }
        private void vihid_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void vpered_Click(object sender, EventArgs e)
        {
            if (!searchPerformed)
                return;

            currentCriminalIndex++;
            if (currentCriminalIndex >= criminals.Count)
            {
                currentCriminalIndex = 0; 
            }
            UpdateCriminalInfo();
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            if (!searchPerformed)
                return;
            currentCriminalIndex--;
            if (currentCriminalIndex < 0)
            {
                currentCriminalIndex = criminals.Count - 1; 
            }
            UpdateCriminalInfo();
        }

        private void UpdateCriminalInfo()
        {
            criminal = criminals[currentCriminalIndex];
            string criminalInfo = $"Прізвище: {criminal.Surname}\n" +
                      $"Ім'я: {criminal.FirstName}\n" +
                      $"Прізвисько: {criminal.Nickname}\n" +
                      $"Зріст: {criminal.Height} cm\n" +
                      $"Колір Волосся: {criminal.HairColor}\n" +
                      $"Колір Очей: {criminal.EyeColor}\n" +
                      $"Відмінні особливості: {criminal.DistinguishingFeatures}\n" +
                      $"Національність: {criminal.Nationality}\n" +
                      $"Місце народження: {criminal.PlaceOfBirth}\n" +
                      $"Дата народження: {criminal.DateOfBirth.ToShortDateString()}\n" +
                      $"Останнє місцезнаходження: {criminal.LastResidence}\n" +
                      $"Мови які знає: {string.Join(", ", criminal.Languages)}\n" +
                      $"Кримінальна професія: {criminal.CriminalProfession}\n" +
                      $"Останній злочин: {criminal.LastCrime}\n" +
                      $"Рівень небезпеки: {criminal.DangerLevel}\n" +
                      $"Угрупування: {criminal.CriminalGroup}\n" +
                      $"Де перебуває: {string.Join(", ", criminal.PossibleIntentions)}\n";

            zliy0.Text = criminalInfo;
            pictureBox2.Tag = criminal;
            pictureBox2_Click(null, null);
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            Criminal selectedCriminal = criminals[currentCriminalIndex];
            string[] newCrimLines = File.ReadAllLines("newCrim.txt");
            using (StreamWriter sw = File.AppendText("ArchivCrim.txt"))
            {
                bool addedNewLine = false;

                foreach (string line in newCrimLines)
                {
                    if (!addedNewLine && !string.IsNullOrWhiteSpace(line))
                    {
                        addedNewLine = true;
                    }

                    if (line.Contains(selectedCriminal.FirstName) && line.Contains(selectedCriminal.Surname))
                    {
                        DialogResult result = MessageBox.Show("Чи був злочинець виправлений? (У разі ні, ліквідований)", "Категорія", MessageBoxButtons.YesNo);
                        bool isReformed = (result == DialogResult.Yes);
                        string date = Microsoft.VisualBasic.Interaction.InputBox("Введіть дату виправлення/ліквідації (ДД.ММ.РРРР)", "Дата виправлення/ліквідації");

                        if (!addedNewLine && !line.EndsWith(Environment.NewLine))
                        {
                            sw.WriteLine();
                            addedNewLine = true;
                        }

                        string additionalInfo = $"{selectedCriminal.Surname}/{selectedCriminal.FirstName}/{selectedCriminal.Nickname}/" +
                            $"{selectedCriminal.Height}/{selectedCriminal.HairColor}/{selectedCriminal.EyeColor}/" +
                            $"{selectedCriminal.DistinguishingFeatures}/{selectedCriminal.Nationality}/{selectedCriminal.PlaceOfBirth}/" +
                            $"{selectedCriminal.DateOfBirth.ToShortDateString()}/{selectedCriminal.LastResidence}/" +
                            $"{string.Join(" ", selectedCriminal.Languages)}/{selectedCriminal.CriminalProfession}/" +
                            $"{selectedCriminal.LastCrime}/{selectedCriminal.DangerLevel}/{selectedCriminal.CriminalGroup}/" +
                            $"{string.Join(" ", selectedCriminal.PossibleIntentions)}/{selectedCriminal.Photo}/{isReformed}/{date}";
                        sw.WriteLine(additionalInfo);

                        var newCrimLinesList = newCrimLines.ToList();
                        newCrimLinesList.Remove(line);
                        newCrimLines = newCrimLinesList.ToArray();
                        File.WriteAllLines("newCrim.txt", newCrimLines);
                        break;
                    }
                }
            }

            currentCriminalIndex++;
            if (currentCriminalIndex >= criminals.Count)
                currentCriminalIndex = 0;

            UpdateCriminalInfo();
        }
    }
}
      

   


 
   

