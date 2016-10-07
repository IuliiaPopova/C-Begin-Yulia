using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassYulia
{
    class Doctor
    {
        public string surname;
        public string name;
        public string middleName;

        public string profession;
        public int cabinetNumber;
        public int patientNumber;

        public void PrintBio()
        {
            Console.WriteLine("Doctor {0} {1} {2} has profession \"{3}\", make appoitment in the cabinet number {4}. He has {5} patients.", surname, name, middleName, profession, cabinetNumber, patientNumber);
        }

        public void GoToWork()
        {
            Console.WriteLine("Doctor {0} {1} {2} goes to work ... ", surname, name, middleName);
            patientNumber = patientNumber + 5;
        }
    }
}
