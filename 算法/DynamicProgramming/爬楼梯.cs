using System;
namespace StudyForever.算法.DynamicProgramming
{
	public class 爬楼梯
	{
		public 爬楼梯()
		{
		}

		//运用递归简单的做法
		//leetcode超时不给过
		public static int SampleDo(int n)
		{
			//这里为什么n == 0 返回1呢，因为题目有个前提，就是n是正整数，那么说明如果n传的是0的话，一定说明已经走了一步了，需要把这一步给加上
			if (n == 0 || n == 1) return 1;

			return SampleDo(n - 1) + SampleDo(n - 2);
		}

		//运动动态规划的做法
		public static int Do(int n)
		{
			int[] dp = new int[n + 1];
			dp[0] = 0;
			dp[1] = 1;
			dp[2] = 2;
			for(int i = 3; i < n + 1; i++)
			{
				dp[i] = dp[i - 1] + dp[i - 2];
			}
			return dp[n];
		}
	}
}

