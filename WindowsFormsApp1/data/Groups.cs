using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criminals
{
    public class Groups
    {
        public List<groupCrim> grcriminals;

        public Groups()
        {
            grcriminals = new List<groupCrim>();
            Groups.ReadCriminalsFromFile("newCrim.txt", grcriminals);
            Groups.ReadCriminalsFromFile("ArchivCrim.txt", grcriminals);
        }

        private static void ReadCriminalsFromFile(string fileName, List<groupCrim> grcriminals)
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
                    string criminalGroup = data[15];
                    string criminalProfession = data[12];

                    bool IsLeader = false;

                    if (criminalProfession == "Лідер кримінальної організації")
                    {
                        IsLeader = true;
                    }

                    if (criminalGroup != "Злочинець одинак")
                    {
                        groupCrim criminal = new groupCrim(firstName, surname, nickname, criminalGroup, IsLeader);
                        grcriminals.Add(criminal);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Помилка: " + ex.Message);
            }
        }
    }
}
