using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTrainee
{
    class Unit
    {
        private int durationHrs;
        public List<Topic> topics { get; set; } = new List<Topic>();
        public int getDurationHrs()
        {
            return durationHrs;
        }
    }
}
