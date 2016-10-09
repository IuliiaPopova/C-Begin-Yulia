using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ClassYulia
{
    class Program
    {
        static void Main(string[] args)
        {
            
      // Use constructor default
         Doctor doctor1 = new Doctor();  
            doctor1.PrintBio();

      // Use special constructor and give value BIO
      Doctor doctor2 = new Doctor("Petrov", "Sergey","Victorovich");
            doctor2.PrintBio();

      //Give info about quality patients
      Doctor doctor3 = new Doctor(5000);
      doctor3.PrintBio();
        }
    }
}
