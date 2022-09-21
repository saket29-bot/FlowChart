using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTrainee
{
    class Course
    {
        public List<Module> modules { get; set; } = new List<Module>();
        public List<Module> getModules()
        {
            return modules;
        }
    }
}
