using Criminals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Criminals
{
    public class Archivcriminals
    {
        public static List<ArchivCrim> acriminals { get; set; } = new List<ArchivCrim>();

        public Archivcriminals()
        {
            ReadArchivCriminalsFromFile("ArchivCrim.txt");
        }

        public static void ReadArchivCriminalsFromFile(string fileName)
        {
            try
            {
                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    string[] data = line.Split('/');

                    string firstName = data[0];
                    string surname = data[1];
                    string nickname = data[2];
                    double height = Convert.ToDouble(data[3]);
                    string hairColor = data[4];
                    string eyeColor = data[5];
                    string distinguishingFeatures = data[6];
                    string nationality = data[7];
                    string placeOfBirth = data[8];
                    DateTime dateOfBirth = DateTime.Parse(data[9]);
                    string lastResidence = data[10];
                    List<string> languages = new List<string>(data[11].Split(','));
                    string criminalProfession = data[12];
                    string lastCrime = data[13];
                    string dangerLevel = data[14];
                    string criminalGroup = data[15];
                    List<string> possibleIntentions = new List<string>(data[16].Split(','));
                    string photo = data[17];
                    bool rehabilitated = Convert.ToBoolean(data[18]);
                    DateTime rehabilitationDate = DateTime.Parse(data[19]);

                    ArchivCrim archivCriminal = new ArchivCrim(firstName, surname, nickname, height, hairColor, eyeColor,
                                                  distinguishingFeatures, nationality, placeOfBirth, dateOfBirth,
                                                  lastResidence, languages, criminalProfession, lastCrime,
                                                  dangerLevel, criminalGroup, possibleIntentions, photo, rehabilitated, rehabilitationDate);

                    acriminals.Add(archivCriminal);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }
        }
    }
}
