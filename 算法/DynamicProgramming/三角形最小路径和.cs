using System;
namespace StudyForever.算法.DynamicProgramming
{
	public class 三角形最小路径和
	{
		public 三角形最小路径和()
		{
		}
		public static int Do(List<List<int>> lists)
		{
			var n = lists.Count;
			List<int> lastRowList = lists[n - 1];
			for(int i = n - 2; i >= 0; i--)
			{
				var currentRow = lists[i];
				for(int j = 0; j < currentRow.Count; j++)
				{
					currentRow[j] = Math.Min(lastRowList[j],lastRowList[j + 1]) + currentRow[j];
				}
				//暂时不用实现了，有一些缺陷
				//.......
			}

			return 0;
		}

		public static int OptimizedDo(List<List<int>> triangle)
		{
			var n = triangle.Count;
			List<int> lastRowList = triangle[n - 1];

			//这里开辟新的二维数组做存储可以保证在计算新的最小路径和时可以取到最后一行的计算过的最小路径和
			int[,] dp = new int[n,n];

			for(int i = 0; i < lastRowList.Count; i++)
			{
				dp[n - 1,i] = lastRowList[i];
			}

			for(int i = n - 2; i >= 0; i--)
			{
				var currentRow = triangle[i];
				for(int j = 0; j < i + 1; j++)
				{
					dp[i,j] = Math.Min(dp[i + 1,j],dp[i + 1, j + 1]) + currentRow[j];
				}
			}

			return dp[0,0];
		}
	}
}

