using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public abstract class Osoba
    {
        public string Imie;
        public string Nazwisko;
        public string Pesel;

        public void SetFirstName(string imie)
        {
            this.Imie = imie;
        }
        public void SetLastName(string nazwisko)
        {
            this.Nazwisko = nazwisko;
        }
        public void SetPesel(string pesel)
        {
            this.Pesel = pesel;
        }
        public int GetAge()
        {
            int Age = DateTime.Now.Year - PeselHelper.GetBirthDay(Pesel).Year;
            return Age;
        }

        public string GetGender()
        {
            if (Convert.ToInt32(Pesel.Substring(9)) % 2 == 0)
            {
                string Gender = "Kobieta";
                return Gender;
            }
            else
            {

                string Gender = "Mężczyzna";
                return Gender;
            }

        }
        public abstract string GetEducationInfo();
        public abstract string GetFullName();
        public abstract bool CanGoAloneToHome();
    }
}
