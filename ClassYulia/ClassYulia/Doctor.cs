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
        public int salary;

        //Constructor of Class (default)
        public Doctor()
        {
            salary = 10000;
        }
        
        //Constructor with 3 parameters
        public Doctor(string surname, string name, string middlename)
        {
            this.surname = surname;
            this.name = name;
            this.middleName = middlename;
            salary = 10000;
        }

        // Constructor with one parameter - quality disinfection patients
        public Doctor(int patientNumberParameter)
        {
            patientNumber = patientNumberParameter;
            surname = "A";
            name = "B";
            middleName = "C";
            salary = 10000;
        }

        public void PrintBio()
        {
            Console.WriteLine("Doctor {0} {1} {2} has profession \"{3}\", make appoitment in the cabinet number {4}. He has {5} patients.He  sent salary {6}\n", surname, name, middleName, profession, cabinetNumber, patientNumber, salary);
        }

        public void GoToWork()
        {
            Console.WriteLine("Doctor {0} {1} {2} goes to work ... ", surname, name, middleName);
            patientNumber = patientNumber + 5;
        }
    }
}
