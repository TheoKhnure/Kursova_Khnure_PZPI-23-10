using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Criminals;

namespace WindowsFormsApp1
{
    public partial class Archivchik : Form
    {
        public List<ArchivCrim> acriminals;
        private List<Criminal> criminals;
        public Criminal acriminal;
        private int currentCriminalIndex = -1;
        private bool searchPerformed = false;


        public Archivchik()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            currentCriminalIndex = 0;
            Archivcriminals archive = new Archivcriminals();
            acriminals = Archivcriminals.acriminals;
        }


        private void back_Click(object sender, EventArgs e)
        {
            Archivchik form4 = new Archivchik();
            Golovna form2 = new Golovna();
            form4.FormClosed += (s, args) => this.Close();
            form2.Show();
            this.Hide();
            form4.Close();
        }

        private void DisplayCriminals()
        {
            if (acriminals.Count == 0)
                return;

            searchPerformed = true;
            currentCriminalIndex = 0;
            UpdateCriminalInfo();
           
            vpered.Enabled = true;
            nazad.Enabled = true;
        }

        private void UpdateCriminalInfo()
        {
            if (acriminals.Count == 0 || currentCriminalIndex == -1)
                return;

            var criminal = acriminals[currentCriminalIndex];
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
                       $"Де перебуває: {string.Join(", ", criminal.PossibleIntentions)}\n" +
                       $"Виправлений/Ліквідований: {(criminal.Rehabilitated ? "Виправлений" : "Ліквідований")}\n" +
                       $"Дата виправлення/ліквідації: {criminal.RehabilitationDate.ToShortDateString()}";
            label2.Text = criminalInfo;
            pictureBox1.Tag = criminal;
            pictureBox1.ImageLocation = criminal.Photo;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Tag != null && pictureBox1.Tag is Criminal)
            {
                var criminal = (Criminal)pictureBox1.Tag;
                pictureBox1.Image = null;
                pictureBox1.Load(criminal.Photo);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            vpered.Enabled = false;
            nazad.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DisplayCriminals();
        }

        private void vpered_Click(object sender, EventArgs e)
        {
            if (!searchPerformed)
                return;

            currentCriminalIndex++;
            if (currentCriminalIndex >= acriminals.Count)
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
                currentCriminalIndex = acriminals.Count - 1;
            }
            UpdateCriminalInfo();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Criminal selectedCriminal = acriminals[currentCriminalIndex];
            string[] newCrimLines = File.ReadAllLines("newCrim.txt");
            List<string> archivedLines = new List<string>();

            bool foundEmptyLine = false; 

            foreach (string line in File.ReadAllLines("ArchivCrim.txt"))
            {
                if (line.Contains(selectedCriminal.FirstName) && line.Contains(selectedCriminal.Surname))
                {
                    string[] parts = line.Split('/');

                    string lastTwoParts = string.Join("/", parts.Skip(parts.Length - 2));
                    string withoutLastTwoParts = string.Join("/", parts.Take(parts.Length - 2));
                    string additionalInfo = $"{withoutLastTwoParts}/true/{lastTwoParts}";

              
                    if (newCrimLines.Length > 0 && !foundEmptyLine && newCrimLines[newCrimLines.Length - 1] == "")
                    {
                        newCrimLines[newCrimLines.Length - 1] += additionalInfo;
                        foundEmptyLine = true;
                    }
                    else
                    {
                        newCrimLines = newCrimLines.Concat(new string[] { additionalInfo }).ToArray();
                    }
                }
                else
                {
                    archivedLines.Add(line);
                }
            }

            
            if (newCrimLines.Length > 0 && !foundEmptyLine && newCrimLines[newCrimLines.Length - 1] != "")
            {
                newCrimLines = newCrimLines.Concat(new string[] { "" }).ToArray();
            }

            File.WriteAllLines("newCrim.txt", newCrimLines);
            File.WriteAllLines("ArchivCrim.txt", archivedLines.ToArray());

            currentCriminalIndex++;
            if (currentCriminalIndex >= acriminals.Count)
                currentCriminalIndex = 0;

            UpdateCriminalInfo();
        }
    }
}
