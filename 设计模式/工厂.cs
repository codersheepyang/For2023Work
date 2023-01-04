using System;
namespace for2023work.设计模式
{
	public class Factor
	{
		public Factor()
		{

		}

		//工厂方法
		public abstract class FactorMethod
		{
			public abstract void FactoryMethodImp();
			public void DoSomething()
			{
				FactoryMethodImp();
			}
        }

		//将实例化延迟到子类
        public class FactorMethod1 : FactorMethod
        {
            public override void FactoryMethodImp()
            {
				Console.WriteLine("FactorMethod1 imp");
            }
        }

    }
}

