using System;
namespace StudyForever.算法.DynamicProgramming
{
	public class 最大子序列和
	{
		public 最大子序列和()
		{
		}

        public static int Do(int[] nums)
        {
            int maxValue = nums[0];
            int lastValue = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                lastValue = Math.Max(lastValue + nums[i], nums[i]);
                if(lastValue > maxValue)
                {
                    maxValue = lastValue;
                }
            }

            return maxValue;
        }
    }
}

