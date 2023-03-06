using System;
namespace StudyForever.算法
{
	public class 求密
	{
		public static int Do(int x,int n)
		{
			if (n == 0) return 1;
			var t = Do(x, n / 2);
			if (n % 2 == 1) return x * t * t;
			return t * t;
		}
	}
}

