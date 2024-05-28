using Criminals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Add_Someone : Form
    {
         public List<ArchivCrim> acriminals;
        private List<Criminal> criminals;
        public Add_Someone()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
        }

        private void back_Click(object sender, EventArgs e)
        {
            Add_Someone form6 = new Add_Someone();
            Golovna form2 = new Golovna();
            form6.FormClosed += (s, args) => this.Close();
            form2.Show();
            this.Hide();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (!AreAllFieldsFilled())
            {
                MessageBox.Show("Не всі дані заповнені.");
                return;
            }

            string filePath = "newCrim.txt";

            try
            {
              
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine();
                    writer.Write(textBox1.Text + "/");
                    writer.Write(textBox2.Text + "/");
                    writer.Write(textBox3.Text + "/");
                    writer.Write(textBox4.Text + "/");
                    writer.Write(comboBox1.Text + "/");
                    writer.Write(comboBox2.Text + "/");
                    writer.Write(textBox5.Text + "/");
                    writer.Write(textBox6.Text + "/");
                    writer.Write(textBox7.Text + "/");
                    writer.Write(dateTimePicker1.Value.ToShortDateString() + "/");
                    writer.Write(textBox8.Text + "/");
                    writer.Write(textBox9.Text + "/");
                    writer.Write(textBox10.Text + "/");
                    writer.Write(textBox11.Text + "/");

                    if (radioButton1.Checked)
                    {
                        writer.Write(radioButton1.Text + "/");
                    }
                    else if (radioButton2.Checked)
                    {
                        writer.Write(radioButton2.Text + "/");
                    }
                    else if (radioButton3.Checked)
                    {
                        writer.Write(radioButton3.Text + "/");
                    }
                    
                    writer.Write(textBox12.Text + "/");
                    writer.Write(textBox13.Text + "/");

                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";
                    openFileDialog.Title = "Виберіть фото злочинця";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            string sourceImagePath = openFileDialog.FileName;
                            string debugFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory);
                            if (!Directory.Exists(debugFolderPath))
                            {
                                Directory.CreateDirectory(debugFolderPath);
                            }

                            string destinationImagePath = Path.Combine(debugFolderPath, Path.GetFileName(sourceImagePath));
                            File.Copy(sourceImagePath, destinationImagePath, true);

                            string fileNameWithExtension = Path.GetFileName(sourceImagePath);
                            writer.Write(fileNameWithExtension);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Помилка: " + ex.Message);
                        }
                    }

                }

             
                MessageBox.Show("Дані записані в базу!");
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Виникла помилка: " + ex.Message);
            }
        }
        private bool AreAllFieldsFilled()
        {
            if (string.IsNullOrWhiteSpace(comboBox1.Text) || string.IsNullOrWhiteSpace(comboBox2.Text))
                return false;

            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
                return false;

            for (int i = 2; i <= 14; i++)
            {
                string textBoxName = "textbox" + i.ToString();
                Control[] controls = this.Controls.Find(textBoxName, true);

                if (controls.Length > 0 && controls[0] is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)controls[0];
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                        return false;
                }
            }

            return true;
        }

        private void textbezProb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textsProb_KeyPress(object sender, KeyPressEventArgs e)
        {           
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textbox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textbox4_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox4.Text))
            {
                int height;
                if (!int.TryParse(textBox4.Text, out height))
                {
                    MessageBox.Show("Значення росту повинно бути числом.");
                    textBox4.Focus();
                }
                else if (height < 100 || height > 200)
                {
                    MessageBox.Show("Значення росту не є правильним.");
                    textBox4.Focus();
                }
            }
        }

      

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = sender as DateTimePicker;

            DateTime minDate = DateTime.Today.AddYears(-80);
            if (dtp.Value < minDate)
            {
                MessageBox.Show("Дата не є дійсною");
                dtp.Value = minDate;
                return;
            }

            DateTime eighteenYearsAgo = DateTime.Today.AddYears(-18);
            if (dtp.Value > eighteenYearsAgo)
            {
                MessageBox.Show("Злочинцю не може бути менше 18 років");
                dtp.Value = eighteenYearsAgo;
                return;
            }

            if (dtp.Value > DateTime.Today)
            {
                MessageBox.Show("Дата не є дійсною.");
                dtp.Value = DateTime.Today;
                return;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                MessageBox.Show("Введіть ім'я, прізвище або прізвисько для пошуку.");
                return;
            }

            string filePath = "newCrim.txt";

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                bool found = false; 

                foreach (string line in lines)
                {
                    string[] data = line.Split('/');

                    
                    if (data[0].Equals(searchQuery, StringComparison.OrdinalIgnoreCase) || // Ім'я
                        data[1].Equals(searchQuery, StringComparison.OrdinalIgnoreCase) || // Прізвище
                        data[2].Equals(searchQuery, StringComparison.OrdinalIgnoreCase))   // Прізвисько
                    {
                      
                        DisplayDataInTextBoxes(data);
                        found = true; 
                        break; 
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Не знайдено відповідних даних.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            UpdateDataInFile("newCrim.txt");
        }

        private void ReadDataFromFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] data = line.Split('/');

                  
                    DisplayDataInTextBoxes(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void DisplayDataInTextBoxes(string[] data)
        {
           
            textBox1.Text = data[0];
            textBox2.Text = data[1];
            textBox3.Text = data[2];
            textBox4.Text = data[3];
            comboBox1.Text = data[4];
            comboBox2.Text = data[5];
            textBox5.Text = data[6];
            textBox6.Text = data[7];
            textBox7.Text = data[8];
            dateTimePicker1.Value = DateTime.Parse(data[9]);
            textBox8.Text = data[10];
            textBox9.Text = data[11];
            textBox10.Text = data[12];
            textBox11.Text = data[13];
            if (data[14] == radioButton1.Text)
            {
                radioButton1.Checked = true;
            }
            else if (data[14] == radioButton2.Text)
            {
                radioButton2.Checked = true;
            }
            else if (data[14] == radioButton3.Text)
            {
                radioButton3.Checked = true;
            }
            textBox12.Text = data[15];
            textBox13.Text = data[16];
           
        }
        private void UpdateDataInFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] data = lines[i].Split('/');

                  
                    if (data[0] == textBox1.Text)
                    {
                        
                        data[0] = textBox1.Text;
                        data[1] = textBox2.Text;
                        data[2] = textBox3.Text;
                        data[3] = textBox4.Text;
                        data[4] = comboBox1.Text;
                        data[5] = comboBox2.Text;
                        data[6] = textBox5.Text;
                        data[7] = textBox6.Text;
                        data[8] = textBox7.Text;
                        data[9] = dateTimePicker1.Value.ToShortDateString();
                        data[10] = textBox8.Text;
                        data[11] = textBox9.Text;
                        data[12] = textBox10.Text;
                        data[13] = textBox11.Text;

                        if (radioButton1.Checked)
                        {
                            data[14] = radioButton1.Text;
                        }
                        else if (radioButton2.Checked)
                        {
                            data[14] = radioButton2.Text;
                        }
                        else if (radioButton3.Checked)
                        {
                            data[14] = radioButton3.Text;
                        }

                        data[15] = textBox12.Text;
                        data[16] = textBox13.Text;

                       
                        lines[i] = string.Join("/", data);

                        break; 
                    }
                }

                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Дані оновлено успішно.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();

          
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

          
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

           
            dateTimePicker1.Value = DateTime.Today.AddYears(-20);
        }
    }
}
    
 

