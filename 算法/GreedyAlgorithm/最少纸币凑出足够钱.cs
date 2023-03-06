using System;
namespace StudyForever.算法.GreedyAlgorithm
{
	public class 最少纸币凑出足够钱
	{
		public 最少纸币凑出足够钱()
		{
		}


		public static int Do(Dictionary<int, int> moneys, int target)
		{
			if (moneys == null
				|| target == 0) return -1;

			int current = 0;
			int qty = 0;

			var moneysByDesc = moneys.Keys.ToList().OrderByDescending(k => k).ToList();// o(n)
			for (int i = 0; i < moneysByDesc.Count(); i++)//o(n2)
			{
				var amount = moneysByDesc[i];
				var remainingQty = moneys[amount];
				while(remainingQty-- > 0)
				{
					int tempCurrent = current;
					tempCurrent += amount;

					if (tempCurrent == target) return ++qty;
					else if (tempCurrent < target)
					{
						qty++;
						current = tempCurrent;
					}
					else break;
				}
			}

			return -1;
		}

		//和我的代码相比思路是差不多的，区别在拿钱的时候，我是一张一张拿的，而作者的思路是看一下可以拿几张，这样就少了一个内部循环
		public static int OptimizedDo(int target)
		{
			int[] moneys = { 1, 5, 10, 50, 100 };
			int[] qtys = { 5, 2, 2, 3, 5 };
			int current = target;
			int qty = 0;
			for(int i = moneys.Length - 1; i >= 0; i--)
			{
				var money = moneys[i];
				var getQtyNumber = Math.Min(current / money, qtys[i]);
                current = current - getQtyNumber * money;
				qty += getQtyNumber;
            }

			if (current > 0) return -1;
			return qty;
		}
    }
}

