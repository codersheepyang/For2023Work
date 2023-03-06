using System;
namespace for2023work
{
	public class OldProgram
	{
		//c# 9 before
		private List<int> ints01 => new List<int>();
		//C# 9 later
		private List<int> ints02 => new();


		
        public void Main()
		{
			

        }

		public void Test(Action<int, string> action)
		{

		}
	}
}

