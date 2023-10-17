using System;

using dummyyy.Interfaces;
namespace dummyyy.Classes
{
    internal class Singer : ISinger
    {
        public string SingerName { get; set; }
        public string SingerSurname { get; set; }


        public Singer(string name, string surname)
        {
            this.SingerName = name;
            this.SingerSurname = surname;
        }
    }
}
