using System;
namespace for2023work.面向对象
{
	public class Animal
	{
		private int _weight { get; set; } = 40;
		public void Eat()
		{

		}
		public virtual void ShowMyWeight()
		{
			Console.WriteLine($"我的体重是:{this._weight}");
		}
	}
}

