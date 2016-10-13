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
        public string Surname { get; set;}
        public string Name { get; set; }
        public string MiddleName { get; set; }

        public string Profession;
        public int CabinetNumber;

        public int cabinetNumber
        {
            get { return CabinetNumber;}
            set
            {//in clinical cabinet 100
                if (value > 100)
                    value = 100;
                CabinetNumber = value;
            }
        }
        public int PatientNumber { get; set; }

        public static int Salary { get; set; }
       
        
        // static constructor
        static Doctor()
        {
            Salary = 20000;
        }

        //Constructor of Class (default)
        public Doctor()
        {
            
        }
        
        //Constructor with 3 parameters
        public Doctor(string surname, string name, string middlename)
        {
            Surname = surname;
            Name = name;
            MiddleName = middlename;
            
        }

        // Constructor with one parameter - quality disinfection patients
        public Doctor(int patientNumberParameter)
        {
            PatientNumber = patientNumberParameter;
            Surname = "A";
            Name = "B";
            MiddleName = "C";
            CabinetNumber = 3;

        }

        public void PrintBio()
        {
            Console.WriteLine("Doctor {0} {1} {2} has profession \"{3}\", make appoitment in the cabinet number {4}. He has {5} patients.He  sent salary {6}\n", Surname, Name, MiddleName, Profession, CabinetNumber, PatientNumber, Salary);
        }

        public void GoToWork()
        {
            Console.WriteLine("Doctor {0} {1} {2} goes to work ... ", Surname, Name, MiddleName);
            PatientNumber = PatientNumber + 5;
        }

        //static method. Displays info about Class on the Console
        public static void PrintClassInfo()
        {
            Console.WriteLine("Class Doctor intoduces busness idea in Programm \"Doctor\". One static constructor  defind in the Class,.....");
        }
    }
}
