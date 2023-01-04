using System;
namespace for2023work.面向对象
{
	public class Cat:Animal
	{
		public Cat()
		{
		}
		//编译时多态
		public override void ShowMyWeight()
		{
			Console.WriteLine("60");
		}
    }
}

