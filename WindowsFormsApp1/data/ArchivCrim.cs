using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criminals

{
    public class ArchivCrim : Criminal
    {
        public bool Rehabilitated { get; set; }
        public DateTime RehabilitationDate { get; set; }

     
        public ArchivCrim(string surname, string firstName, string nickname, double height, string hairColor, string eyeColor,
            string distinguishingFeatures, string nationality, string placeOfBirth, DateTime dateOfBirth, string lastResidence,
            List<string> languages, string criminalProfession, string lastCrime, string dangerLevel, string criminalGroup,
            List<string> possibleIntentions, string photo, bool rehabilitated, DateTime rehabilitationDate)
            : base(surname, firstName, nickname, height, hairColor, eyeColor, distinguishingFeatures, nationality, placeOfBirth,
                   dateOfBirth, lastResidence, languages, criminalProfession, lastCrime, dangerLevel, criminalGroup, possibleIntentions, photo)
        {
            Rehabilitated = rehabilitated;
            RehabilitationDate = rehabilitationDate;
   
        }
    }
}
