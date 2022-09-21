using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TrainerTrainee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Traine t1=new Traine("saket"); 
            Traine t2=new Traine("sushant");
            Traine t3=new Traine("Vinayak");
            Traine t4=new Traine("Faisal");
            List<Traine> tarr=new List<Traine>() { t1,t2,t3,t4};
            Trainer trainer=new Trainer();
            trainer.traines = tarr;
            Training tr=new Training();
            tr.traines = tarr;
            Console.WriteLine(tr.getNumOfTrainees());
            Topic topic1=new Topic("OOps");
            Topic topic2 = new Topic("Initialization");
            List<Topic> topicList=new List<Topic>() { topic1, topic2 };
            Unit u1 = new Unit();
            u1.topics = topicList;
            Unit u2 = new Unit();
            u2.topics = topicList;
            Module module1 = new Module();
            List<Module> moduleList=new List<Module>() { module1 };
            List<Unit> unitList = new List<Unit>() { u1, u2 };
            module1.units = unitList;
            Course c1=new Course();
            c1.modules= moduleList;
            




        }
    }
}
