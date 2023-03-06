using System;
namespace StudyForever.算法.DynamicProgramming
{
	public class 八个1相加
	{
		public 八个1相加()
		{
		}

		public static int Do()
		{
			int[] dp = new int[9];
			dp[0] = 0;

			for(int i = 1; i < dp.Length; i++)
			{
				dp[i] = dp[i - 1] + 1;
			}

			return dp[8];
		}
	}
}

