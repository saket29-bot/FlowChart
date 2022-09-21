using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTrainee
{
    internal class Trainer
    {
        Organization organization = new Organization();
        public List<Traine> traines = new List<Traine>();
        public string getOrganization()
        {
            return organization.getName();

        }
    }
}
