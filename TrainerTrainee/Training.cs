using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTrainee
{
    class Training
    {
        Trainer trainer = new Trainer();
        Course course = new Course();
        public List<Traine> traines = new List<Traine>();


        public int getNumOfTrainees()
        {
            return traines.Count;
        }
        public string getTrainingOrganizationName()
        {
            return (trainer.getOrganization());

        }
        public int getTrainingDuration()
        {
            int totalhrs = 0;
            List<Module> m = course.getModules();
            foreach (Module module in m)
            {
                List<Unit> units = module.getUnits();
                foreach (Unit unit in units)
                {
                    totalhrs += unit.getDurationHrs();
                }
            }
            return totalhrs;

        }
    }
}
