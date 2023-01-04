using System;
namespace for2023work.设计模式
{
	public class DecoratorModelDesign
	{
		public static void Test()
		{
            Berverage b = new CocaCola();
            CheeseBerverageDecorator cheeseBerverageDecorator = new CheeseBerverageDecorator(b);
            Console.WriteLine($"cheese in the cocacola cost is {cheeseBerverageDecorator.Cost()}");
		}
	}

	public interface Berverage
	{
		double Cost();
	}

    public class CocaCola : Berverage
    {
        public double Cost()
        {
			return 2.5;
        }
    }

    public abstract class BerverageDecorator : Berverage
    {
		public abstract double Cost();
    }

    public class CheeseBerverageDecorator : Berverage
    {
        private Berverage _berverage;
        public CheeseBerverageDecorator(Berverage berverage)
        {
            this._berverage = berverage;
        }
        public double Cost()
        {
            return this._berverage.Cost() + 1;
        }
    }
}

