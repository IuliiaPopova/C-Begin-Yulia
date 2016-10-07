using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassYulia
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor();
            doctor1.surname = "Ivanov";
            doctor1.name = "Petr";
            doctor1.middleName = "Alexeevich";
            doctor1.profession = "terapevt";
            doctor1.cabinetNumber = 15;
            doctor1.patientNumber = 0;
             
            Doctor doctor2 = new Doctor();
            doctor2.surname = "Limonov";
            doctor2.name = "Viktor";
            doctor2.middleName = "Sergeevich";
            doctor2.profession = "oftolmolog";
            doctor2.cabinetNumber = 7;
            doctor2.patientNumber = 0;

            doctor1.PrintBio();
            doctor1.GoToWork();
            doctor1.GoToWork();
            doctor1.PrintBio();

            doctor2.PrintBio();
            doctor2.GoToWork();
            doctor2.PrintBio();
        }
    }
}
