using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Doctor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int YearOfPractice { get; set; }
        public bool MorningTime { get; set; } = false;
        public bool NoonTime { get; set; } = false;
        public bool NightTime { get; set; } = false;

        public string MorningTimeHuman { get; set; }
        public string NoonTimeHuman { get; set; }
        public string EveningTimeHuman { get; set; }
    }
}
