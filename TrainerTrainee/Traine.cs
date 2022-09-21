using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTrainee
{
    class Traine
    {
        string name;
        public Traine(string name)
        {
            this.name = name;
            List<Training> training = new List<Training>();
        }

        public string getname()
        {
            return name;
        }

    }
}
