using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Runner
    {

        public void ChoosenPart(ref Pediatre p, ref Stramatology s, ref Tramvatology t, string choose, string name, string surname, string phone, string mail)
        {
            Console.Clear();
            if (Convert.ToInt32(choose) == 1)
            {
                t.doctors.ForEach(d =>
                {
                    Console.WriteLine($"dr {d.Name}");
                });
                Console.Write("Write Name of Dr: ");
                string chs = Console.ReadLine();
                var doctor = t.doctors.First(d => d.Name == chs);
                ChooseTimeReserve(ref doctor, name, surname, mail, phone);
            }
            else if (Convert.ToInt32(choose) == 2)
            {
                s.doctors.ForEach(d =>
                {
                    Console.WriteLine($"dr {d.Name}");
                });
                Console.Write("Write Name of Dr: ");
                string chs = Console.ReadLine();
                var doctor = s.doctors.First(d => d.Name == chs);
                ChooseTimeReserve(ref doctor, name, surname, mail, phone);
            }
            else if (Convert.ToInt32(choose) == 3)
            {
                p.doctors.ForEach(d =>
                {
                    Console.WriteLine($"dr {d.Name}");
                });
                Console.Write("Write Name of Dr: ");
                string chs = Console.ReadLine();
                var doctor = p.doctors.First(d => d.Name == chs);
                ChooseTimeReserve(ref doctor, name, surname, mail, phone);
            }
            else
            {
                throw new Exception("Invalid choose");
            }
        }
  
        public void ChooseTimeReserve(ref Doctor doctor, string name, string surname, string email, string phone)
        {
            Console.Clear();
            Console.WriteLine("1. 09:00 - 11:00");
            Console.WriteLine("2. 12:00 - 14:00");
            Console.WriteLine("3. 15:00 - 17:00");
            string ch = Console.ReadLine();
            if (Convert.ToInt32(ch) == 1)
            {
                Console.Clear();
                if (doctor.MorningTime == false && doctor.MorningTimeHuman == null)
                {
                    doctor.MorningTime = true;
                    doctor.MorningTimeHuman = $"{name} was reserved Morning time of {doctor.Name}";
                }
                else
                {
                    throw new Exception(doctor.MorningTimeHuman);
                }
            }
            else if (Convert.ToInt32(ch) == 2)
            {
                Console.Clear();
                if (doctor.NoonTime == false && doctor.MorningTimeHuman == null)
                {
                    doctor.NoonTime = true;
                    doctor.NoonTimeHuman = $"{name} was reserved Noon time of {doctor.Name}";
                }
                else
                {
                    throw new Exception(doctor.NoonTimeHuman);
                }
            }
            else if (Convert.ToInt32(ch) == 3 && doctor.MorningTimeHuman == null)
            {
                Console.Clear();
                if (doctor.NightTime == false)
                {
                    doctor.NightTime = true;
                    doctor.EveningTimeHuman = $"{name} was reserved Evening time of {doctor.Name}";
                }
                else
                {
                    throw new Exception(doctor.EveningTimeHuman);
                }
            }
        }
    }
}
