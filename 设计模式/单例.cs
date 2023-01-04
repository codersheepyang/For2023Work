using System;
namespace for2023work.设计模式
{
	public class SingleTon
	{
		private static SingleTon _Instance;
		private static Object o;

		private SingleTon()
		{
		}

		//线程安全-懒汉
		public static SingleTon GetInstance()
		{
			if(_Instance == null)
			{
				lock(o)
				{
					if(_Instance == null)
					{
						_Instance = new SingleTon();
					}
				}
			}

			return _Instance;

        }

		//线程安全(由.net自己实现) - 懒汉
		public static class SingleTon1
		{
			public static SingleTon  INSTANCE = new SingleTon();

		}

        public static SingleTon GetSingleTon1Instance()
        {
            return SingleTon1.INSTANCE;
        }
    }
}

