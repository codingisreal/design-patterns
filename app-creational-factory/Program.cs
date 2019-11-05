using System;

namespace app_creational_factory
{
    public interface ICarMaker
    {
        string Info();
    }
    public class CarMaker
    {
        public string name;
        public string origin;
    }

    public class Porsche : CarMaker, ICarMaker
    {
        public Porsche()
        {
            this.name = "Porsche";
            this.origin = "Germany";
        }
        public string Info()
        {
            return String.Format("I am {0} and my origin is {1}", this.name, this.origin);
        }
    }

    public class Mercedes : CarMaker, ICarMaker
    {
        public Mercedes()
        {
            this.name = "Mercedes";
            this.origin = "Germany";
        }

        public string Info()
        {
            return String.Format("I am {0} and my origin is {1}", this.name, this.origin);
        }
    }

    public abstract class CarFactory
    {
        public abstract ICarMaker GetMaker();
        public string CarMakerInfo(CarMaker carMaker)
        {
            return String.Format("The car maker comes from {0}", carMaker.origin);
        }
    }

    public class PorscheFactory : CarFactory
    {
        public override ICarMaker GetMaker()
        {
            return new Porsche();
        }
    }

    public class MercedesFactory : CarFactory
    {
        public override ICarMaker GetMaker()
        {
            return new Mercedes();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var porscheFactory = new PorscheFactory();
            var mercedesFactory = new MercedesFactory();
            ICarMaker porsche = porscheFactory.GetMaker();
            ICarMaker mercedes = mercedesFactory.GetMaker();

            Console.WriteLine(porsche.Info());
            Console.WriteLine(mercedes.Info());
            //Console.WriteLine(porsche.C());
            //Console.WriteLine(porscheFactory.CarMakerInfo(porsche));
            Console.Read();
        }
    }
}
