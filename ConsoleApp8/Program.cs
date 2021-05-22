using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Runner runner = new Runner();
            Doctor doctor = new Doctor()
            {
                Name = "Hakuna",
                Surname = "Matata",
                YearOfPractice = 20
            };
            Doctor doctor2 = new Doctor()
            {
                Name = "Sun",
                Surname = "Glass",
                YearOfPractice = 12
            };
            Doctor doctor3 = new Doctor()
            {
                Name = "Mon",
                Surname = "Day",
                YearOfPractice = 2
            };
            Doctor doctor4 = new Doctor()
            {
                Name = "Jack",
                Surname = "Tata",
                YearOfPractice = 6
            };
            Doctor doctor5 = new Doctor()
            {
                Name = "Michelle",
                Surname = "Fancy",
                YearOfPractice = 18
            };
            Doctor doctor6 = new Doctor()
            {
                Name = "Leader",
                Surname = "Meeting",
                YearOfPractice = 30
            };

            Pediatre pediatre = new Pediatre()
            {
                doctors = new List<Doctor>()
            };
            pediatre.doctors.Add(doctor);
            pediatre.doctors.Add(doctor2);

            Stramatology stramatology = new Stramatology()
            {
                doctors = new List<Doctor>()
            }; 
            stramatology.doctors.Add(doctor3);
            stramatology.doctors.Add(doctor4);

            Tramvatology tramvatology = new Tramvatology()
            {
                doctors = new List<Doctor>()
            };
            tramvatology.doctors.Add(doctor5);
            tramvatology.doctors.Add(doctor6);

            

            while (true)
            {
                Console.Clear();
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Surname: ");
                string surname = Console.ReadLine();

                Console.Write("Enter Email: ");
                string email = Console.ReadLine();

                Console.Write("Enter Phone: ");
                string phone = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("1 For Tramvatology");
                Console.WriteLine("2 For Pediatre");
                Console.WriteLine("3 For Stramatology");
                string choose = Console.ReadLine();
                try
                {
                    runner.ChoosenPart(ref pediatre, ref stramatology, ref tramvatology, choose, name, surname, phone, email);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Thread.Sleep(3000);
                }
            }
        }
    }
}
