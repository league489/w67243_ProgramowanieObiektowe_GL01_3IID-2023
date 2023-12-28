using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Uczeń : Osoba 
    {
        public string Szkoła {get;set;}
        public bool MożeWracaćSamDoDomu {get;set;}

        public void SetSchool(string szkoła)
        {
            if (string.IsNullOrEmpty(Szkoła))
                Szkoła = szkoła;
            else
                throw new Exception("Nie można ustawić szkoły");
        }

        public void ChangeSchool(string szkoła)
        {
            Szkoła = szkoła;
        }
        public override string GetFullName() 
        {
            return $"{Imie} {Nazwisko}";
        }
        public override string GetEducationInfo()
        {
            return Szkoła;
        }

        public override bool CanGoAloneToHome() 
        {
            return MożeWracaćSamDoDomu || GetAge() >= 12;
        }

        public void SetCanGoHomeAlone(bool możeWracaćSamDoDomu) 
        {
            MożeWracaćSamDoDomu = możeWracaćSamDoDomu;
        }

        public string Info()
        {
            if (GetAge() >= 12)
                return "Ma wiecej niż 12 lat";
            if (MożeWracaćSamDoDomu)
            {
                return "Ma zgodę";
            }
            else
            {
                return "Nie ma zgody i ma mniej niż 12 lat";
            }
        }

    }
}
