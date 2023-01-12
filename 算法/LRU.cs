using System;
namespace for2023work.算法
{
	public class LRU
	{
		private List<string> _personalNames = new List<string>();
		
		public LRU()
		{
		}

		public void AddName(string name)
		{
			if(string.IsNullOrEmpty(name))
			{
				return;
			}

			_personalNames.Add(name);
		}

		//用hash列表存，可以是O(1)
		//O(n)、S(0)
		public bool GetName(string name)
		{
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }

			var personalName = _personalNames.FirstOrDefault(p => p.Equals(name)); 
			if (personalName == null) return false;

			_personalNames.Remove(personalName);
			_personalNames.Add(personalName);
			return true;
        }

		public void ShowLastestPersonalNames()
		{
			Console.WriteLine(string.Join(",",_personalNames));
		}
	}
}

