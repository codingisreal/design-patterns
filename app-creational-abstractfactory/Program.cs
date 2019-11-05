using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_creational_abstractfactory
{
    public interface IMotorbike
    {
        string Info();
    }

    public class Adv : IMotorbike
    {
        public string Info()
        {
            return "Ready for Adventure !";
        }
    }

    public class SportsBike : IMotorbike
    {
        public string Info()
        {
            return "Ready to Race !";
        }
    }

    interface MotorbikeFactory
    {
        IMotorbike GetMotorbike();
    }

    public class AdvFactory
    {
        public IMotorbike GetMotorbike()
        {
            return new Adv();
        }
    }

    public class SportsBikeFactory
    {
        public IMotorbike GetMotorbike()
        {
            return new SportsBike();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IMotorbike motorbike;

            AdvFactory _advFactory = new AdvFactory();
            motorbike = _advFactory.GetMotorbike();
            Console.WriteLine(motorbike.Info());            

            SportsBikeFactory _sportsBikeFactory = new SportsBikeFactory();
            motorbike = _sportsBikeFactory.GetMotorbike();
            Console.WriteLine(motorbike.Info());
            Console.Read();
        }
    }
}
