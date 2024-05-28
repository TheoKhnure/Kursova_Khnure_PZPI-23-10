using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Poshuk_Zl : Form
    {
        public List<ArchivCrim> acriminals;
        private List<Criminal> criminals;

        private string criminal;
        private int currentCriminalIndex;
       


        public Poshuk_Zl()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            criminals = CriminalDatabase.criminals ?? new List<Criminal>();

            currentCriminalIndex = -1;
            UpdateCriminalInfo();

            Archivcriminals archive = new Archivcriminals();
            acriminals = acriminals = Archivcriminals.acriminals ?? new List<ArchivCrim>();

        }

        private void back_Click(object sender, EventArgs e)
        {

            Poshuk_Zl form3 = new Poshuk_Zl();
            Golovna form2 = new Golovna();
            form3.FormClosed += (s, args) => this.Close();
            form2.Show();
            this.Hide();
            form3.Close();
        }
        private void UpdateCriminalInfo()
        {

            if (currentCriminalIndex >= 0 && currentCriminalIndex < criminals.Count)
            {
                Criminal criminal = criminals[currentCriminalIndex];
                label2.Text = $"Прізвище: {criminal.Surname}\n" +
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

                pictureBox1.Image = Image.FromFile(criminal.Photo);
            }
            else if (currentCriminalIndex >= criminals.Count && currentCriminalIndex < criminals.Count + acriminals.Count)
            {
                ArchivCrim archivCriminal = acriminals[currentCriminalIndex - criminals.Count];
                label2.Text = $"Прізвище: {archivCriminal.Surname}\n" +
                              $"Ім'я: {archivCriminal.FirstName}\n" +
                              $"Прізвисько: {archivCriminal.Nickname}\n" +
                              $"Зріст: {archivCriminal.Height} см\n" +
                              $"Колір Волосся: {archivCriminal.HairColor}\n" +
                              $"Колір Очей: {archivCriminal.EyeColor}\n" +
                              $"Відмінні особливості: {archivCriminal.DistinguishingFeatures}\n" +
                              $"Національність: {archivCriminal.Nationality}\n" +
                              $"Місце народження: {archivCriminal.PlaceOfBirth}\n" +
                              $"Дата народження: {archivCriminal.DateOfBirth.ToShortDateString()}\n" +
                              $"Останнє місцезнаходження: {archivCriminal.LastResidence}\n" +
                              $"Мови які знає: {string.Join(", ", archivCriminal.Languages)}\n" +
                              $"Кримінальна професія: {archivCriminal.CriminalProfession}\n" +
                              $"Останній злочин: {archivCriminal.LastCrime}\n" +
                              $"Рівень небезпеки: {archivCriminal.DangerLevel}\n" +
                              $"Угрупування: {archivCriminal.CriminalGroup}\n" +
                              $"Де перебуває: {string.Join(", ", archivCriminal.PossibleIntentions)}\n" +
                              $"Виправлений/Ліквідований: {(archivCriminal.Rehabilitated ? "Виправлений" : "Ліквідований")}\n" +
                              $"Дата виправлення/ліквідації: {archivCriminal.RehabilitationDate.ToShortDateString()}";

                pictureBox1.Image = Image.FromFile(archivCriminal.Photo);
            }

        }
        private void poshuk_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ArchivCriminalMatchesSearch(ArchivCrim acriminal, string searchText)
        {
            string searchTextLower = searchText.ToLower();
            return acriminal.Surname.ToLower().Contains(searchTextLower) ||
                   acriminal.FirstName.ToLower().Contains(searchTextLower) ||
                   acriminal.Nickname.ToLower().Contains(searchTextLower) ||
                   acriminal.Height.ToString().Contains(searchText) ||
                   acriminal.HairColor.ToLower().Contains(searchTextLower) ||
                   acriminal.EyeColor.ToLower().Contains(searchTextLower) ||
                   acriminal.DistinguishingFeatures.ToLower().Contains(searchTextLower) ||
                   acriminal.Nationality.ToLower().Contains(searchTextLower) ||
                   acriminal.PlaceOfBirth.ToLower().Contains(searchTextLower) ||
                   acriminal.DateOfBirth.ToShortDateString().Contains(searchText) ||
                   acriminal.LastResidence.ToLower().Contains(searchTextLower) ||
                   string.Join(", ", acriminal.Languages).ToLower().Contains(searchTextLower) ||
                   acriminal.CriminalProfession.ToLower().Contains(searchTextLower) ||
                   acriminal.LastCrime.ToLower().Contains(searchTextLower) ||
                   acriminal.DangerLevel.ToLower().Contains(searchTextLower) ||
                   acriminal.CriminalGroup.ToLower().Contains(searchTextLower) ||
                   acriminal.Rehabilitated.ToString().ToLower().Contains(searchTextLower) ||
                   acriminal.RehabilitationDate.ToShortDateString().Contains(searchText);
        }


        private bool CriminalMatchesSearch(Criminal criminal, string searchText)
        {
            string searchTextLower = searchText.ToLower();
            return criminal.Surname.ToLower().Contains(searchTextLower) ||
                   criminal.FirstName.ToLower().Contains(searchTextLower) ||
                   criminal.Nickname.ToLower().Contains(searchTextLower) ||
                   criminal.Height.ToString().Contains(searchText) ||
                   criminal.HairColor.ToLower().Contains(searchTextLower) ||
                   criminal.EyeColor.ToLower().Contains(searchTextLower) ||
                   criminal.DistinguishingFeatures.ToLower().Contains(searchTextLower) ||
                   criminal.Nationality.ToLower().Contains(searchTextLower) ||
                   criminal.PlaceOfBirth.ToLower().Contains(searchTextLower) ||
                   criminal.DateOfBirth.ToShortDateString().Contains(searchText) ||
                   criminal.LastResidence.ToLower().Contains(searchTextLower) ||
                   string.Join(", ", criminal.Languages).ToLower().Contains(searchTextLower) ||
                   criminal.CriminalProfession.ToLower().Contains(searchTextLower) ||
                   criminal.LastCrime.ToLower().Contains(searchTextLower) ||
                   criminal.DangerLevel.ToLower().Contains(searchTextLower) ||
                   criminal.CriminalGroup.ToLower().Contains(searchTextLower) ||
                   string.Join(", ", criminal.PossibleIntentions).ToLower().Contains(searchTextLower);
        }
        private void PerformSearch()
        {
            ClearCriminalInfo();

            List<int> searchResults = new List<int>();
            string searchText = poshuk.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(searchText))
            {
                string[] searchTerms = searchText.Split(' '); 

                for (int i = 0; i < criminals.Count; i++)
                {
                    bool match = true;
                    foreach (string term in searchTerms)
                    {
                        if (!CriminalMatchesSearch(criminals[i], term))
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                    {
                        searchResults.Add(i);
                    }
                }

                for (int i = 0; i < acriminals.Count; i++)
                {
                    bool match = true;
                    foreach (string term in searchTerms)
                    {
                        if (!ArchivCriminalMatchesSearch(acriminals[i], term))
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                    {
                        searchResults.Add(i + criminals.Count);
                    }
                }

                if (searchResults.Count > 0)
                {
                    currentCriminalIndex = searchResults[0];
                    UpdateCriminalInfo();

                    for (int i = 1; i < searchResults.Count; i++)
                    {
                        if (i == 0)
                        {
                            UpdateAdditionalCriminalInfo(label2, pictureBox1, searchResults[i]);
                        }
                        else if (i == 1)
                        {
                            UpdateAdditionalCriminalInfo(label3, pictureBox2, searchResults[i]);
                        }
                        else if (i == 2)
                        {
                            UpdateAdditionalCriminalInfo(label4, pictureBox3, searchResults[i]);
                        }
                        else if (i == 3) 
                        {
                            UpdateAdditionalCriminalInfo(label5, pictureBox4, searchResults[i]);
                        }
                        else if (i == 4) 
                        {
                            UpdateAdditionalCriminalInfo(label6, pictureBox5, searchResults[i]);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Збігів не знайдено.");
                }
            }
            else
            {
                currentCriminalIndex = 0;
                UpdateCriminalInfo();
            }
        }


        private void ClearCriminalInfo()
        {
            label2.Text = string.Empty;
            pictureBox1.Image = null;
            label3.Text = string.Empty;
            pictureBox2.Image = null;
            label4.Text = string.Empty;
            pictureBox3.Image = null;
            label5.Text = string.Empty;
            pictureBox4.Image = null;
            label6.Text = string.Empty;
            pictureBox5.Image = null;

        }
        private void UpdateAdditionalCriminalInfo(Label label, PictureBox pictureBox, int index)
        {
            if (index >= 0 && index < criminals.Count)
            {
                Criminal criminal = criminals[index];

                label.Text = $"Прізвище: {criminal.Surname}\n" +
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

                pictureBox.Image = Image.FromFile(criminal.Photo);
            }
            else if (index >= criminals.Count && index < criminals.Count + acriminals.Count)
            {
                ArchivCrim archivCriminal = acriminals[index - criminals.Count];

                label.Text = $"Прізвище: {archivCriminal.Surname}\n" +
                             $"Ім'я: {archivCriminal.FirstName}\n" +
                             $"Прізвисько: {archivCriminal.Nickname}\n" +
                             $"Зріст: {archivCriminal.Height} см\n" +
                             $"Колір Волосся: {archivCriminal.HairColor}\n" +
                             $"Колір Очей: {archivCriminal.EyeColor}\n" +
                             $"Відмінні особливості: {archivCriminal.DistinguishingFeatures}\n" +
                             $"Національність: {archivCriminal.Nationality}\n" +
                             $"Місце народження: {archivCriminal.PlaceOfBirth}\n" +
                             $"Дата народження: {archivCriminal.DateOfBirth.ToShortDateString()}\n" +
                             $"Останнє місцезнаходження: {archivCriminal.LastResidence}\n" +
                             $"Мови які знає: {string.Join(", ", archivCriminal.Languages)}\n" +
                             $"Кримінальна професія: {archivCriminal.CriminalProfession}\n" +
                             $"Останній злочин: {archivCriminal.LastCrime}\n" +
                             $"Рівень небезпеки: {archivCriminal.DangerLevel}\n" +
                             $"Угрупування: {archivCriminal.CriminalGroup}\n" +
                             $"Де перебуває: {string.Join(", ", archivCriminal.PossibleIntentions)}\n" +
                             $"Виправлений/Ліквідований: {(archivCriminal.Rehabilitated ? "Виправлений" : "Ліквідований")}\n" +
                             $"Дата виправлення/ліквідації: {archivCriminal.RehabilitationDate.ToShortDateString()}";

                pictureBox.Image = Image.FromFile(archivCriminal.Photo);
            }
        }
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformSearch();
                poshuk.Clear();
            } 
           
        }

        private void poshuk12_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

      

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        

        private void buttonchik_Click(object sender, EventArgs e)
        {
            SaveSearchResultsToFile();
        }

        private void SaveSearchResultsToFile()
        {
            
            if (currentCriminalIndex >= 0)
            {
               
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text File|*.txt";
                saveFileDialog.Title = "Save Search Results";
                saveFileDialog.ShowDialog();

                
                if (saveFileDialog.FileName != "")
                {
                    try
                    {
                    
                        using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, true, Encoding.UTF8))
                        {
                         
                            sw.WriteLine($"Результати пошуку по запросу: {poshuk.Text}");
                            sw.WriteLine("---------------------------------------");

                            if (currentCriminalIndex < criminals.Count)
                            {
                                Criminal criminal = criminals[currentCriminalIndex];
                                SaveCriminalInfo(sw, criminal);
                            }
                            else if (currentCriminalIndex < criminals.Count + acriminals.Count)
                            {
                                ArchivCrim archivCriminal = acriminals[currentCriminalIndex - criminals.Count];
                                SaveArchivCriminalInfo(sw, archivCriminal);
                            }

                
                            SaveAdditionalCriminalInfo(sw);
                        }

                        MessageBox.Show("Результати було збережено.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Помилка: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Немає результатів для збереження");
            }
        }

        private void SaveAdditionalCriminalInfo(StreamWriter sw)
        {
            if (!string.IsNullOrEmpty(label3.Text))
            {
                sw.WriteLine($"Додаткова інформація:");
                sw.WriteLine(label3.Text);
                sw.WriteLine("---------------------------------------");
            }

            if (!string.IsNullOrEmpty(label4.Text))
            {
                sw.WriteLine($"Додаткова інформація:");
                sw.WriteLine(label4.Text);
                sw.WriteLine("---------------------------------------");
            }

            if (!string.IsNullOrEmpty(label5.Text))
            {
                sw.WriteLine($"Додаткова інформація:");
                sw.WriteLine(label5.Text);
                sw.WriteLine("---------------------------------------");
            }

            if (!string.IsNullOrEmpty(label6.Text))
            {
                sw.WriteLine($"Додаткова інформація:");
                sw.WriteLine(label6.Text);
                sw.WriteLine("---------------------------------------");
            }
        }


        private void SaveCriminalInfo(StreamWriter sw, Criminal criminal)
        {
            sw.WriteLine($"Прізвище: {criminal.Surname}");
            sw.WriteLine($"Ім'я: {criminal.FirstName}");
            sw.WriteLine($"Прізвисько: {criminal.Nickname}");
            sw.WriteLine($"Зріст: {criminal.Height} cm");
            sw.WriteLine($"Колір Волосся: {criminal.HairColor}");
            sw.WriteLine($"Колір Очей: {criminal.EyeColor}");
            sw.WriteLine($"Відмінні особливості: {criminal.DistinguishingFeatures}");
            sw.WriteLine($"Національність: {criminal.Nationality}");
            sw.WriteLine($"Місце народження: {criminal.PlaceOfBirth}");
            sw.WriteLine($"Дата народження: {criminal.DateOfBirth.ToShortDateString()}");
            sw.WriteLine($"Останнє місцезнаходження: {criminal.LastResidence}");
            sw.WriteLine($"Мови які знає: {string.Join(", ", criminal.Languages)}");
            sw.WriteLine($"Кримінальна професія: {criminal.CriminalProfession}");
            sw.WriteLine($"Останній злочин: {criminal.LastCrime}");
            sw.WriteLine($"Рівень небезпеки: {criminal.DangerLevel}");
            sw.WriteLine($"Угрупування: {criminal.CriminalGroup}");
            sw.WriteLine($"Де перебуває: {string.Join(", ", criminal.PossibleIntentions)}");
            sw.WriteLine("---------------------------------------");
        }

        private void SaveArchivCriminalInfo(StreamWriter sw, ArchivCrim archivCriminal)
        {
            sw.WriteLine($"Прізвище: {archivCriminal.Surname}");
            sw.WriteLine($"Ім'я: {archivCriminal.FirstName}");
            sw.WriteLine($"Прізвисько: {archivCriminal.Nickname}");
            sw.WriteLine($"Зріст: {archivCriminal.Height} см");
            sw.WriteLine($"Колір Волосся: {archivCriminal.HairColor}");
            sw.WriteLine($"Колір Очей: {archivCriminal.EyeColor}");
            sw.WriteLine($"Відмінні особливості: {archivCriminal.DistinguishingFeatures}");
            sw.WriteLine($"Національність: {archivCriminal.Nationality}");
            sw.WriteLine($"Місце народження: {archivCriminal.PlaceOfBirth}");
            sw.WriteLine($"Дата народження: {archivCriminal.DateOfBirth.ToShortDateString()}");
            sw.WriteLine($"Останнє місцезнаходження: {archivCriminal.LastResidence}");
            sw.WriteLine($"Мови які знає: {string.Join(", ", archivCriminal.Languages)}");
            sw.WriteLine($"Кримінальна професія: {archivCriminal.CriminalProfession}");
            sw.WriteLine($"Останній злочин: {archivCriminal.LastCrime}");
            sw.WriteLine($"Рівень небезпеки: {archivCriminal.DangerLevel}");
            sw.WriteLine($"Угрупування: {archivCriminal.CriminalGroup}");
            sw.WriteLine($"Де перебуває: {string.Join(", ", archivCriminal.PossibleIntentions)}");
            sw.WriteLine($"Виправлений/Ліквідований: {(archivCriminal.Rehabilitated ? "Виправлений" : "Ліквідований")}");
            sw.WriteLine($"Дата виправлення/ліквідації: {archivCriminal.RehabilitationDate.ToShortDateString()}");
            sw.WriteLine("---------------------------------------");
        }

        
    }
}
