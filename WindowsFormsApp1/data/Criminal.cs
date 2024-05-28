using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criminals
{
    public class Criminal
    {
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Nickname { get; set; }
        public double Height { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string DistinguishingFeatures { get; set; }
        public string Nationality { get; set; }
        public string PlaceOfBirth { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string LastResidence { get; set; }
        public List<string> Languages { get; set; }
        public string CriminalProfession { get; set; }
        public string LastCrime { get; set; }
        public string DangerLevel { get; set; }
        public string CriminalGroup { get; set; }
        public List<string> PossibleIntentions { get; set; }
        public string Photo { get; set; }


        public Criminal(string surname, string firstName, string nickname, double height, string hairColor, string eyeColor,
            string distinguishingFeatures, string nationality, string placeOfBirth, DateTime dateOfBirth, string lastResidence,
            List<string> languages, string criminalProfession, string lastCrime, string dangerLevel, string criminalGroup,
            List<string> possibleIntentions, string photo)
        {

            Surname = surname;
            FirstName = firstName;
            Nickname = nickname;
            Height = height;
            HairColor = hairColor;
            EyeColor = eyeColor;
            DistinguishingFeatures = distinguishingFeatures;
            Nationality = nationality;
            PlaceOfBirth = placeOfBirth;
            DateOfBirth = dateOfBirth;
            LastResidence = lastResidence;
            Languages = languages;
            CriminalProfession = criminalProfession;
            LastCrime = lastCrime;
            DangerLevel = dangerLevel;
            CriminalGroup = criminalGroup;
            PossibleIntentions = possibleIntentions;
            Photo = photo;
        }
    }

}
