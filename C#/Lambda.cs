using System;
namespace StudyForever.C
{
	public class Lambda
	{
		public Lambda()
		{
		}

		//表达式lambda
		static Func<int, bool> _lambda01 => (a) => a  > 2;

		//语句lambda
		static Action<int, int> _lambda02 => (a, b) =>
		{
			var c = a + b;
			Console.WriteLine(c);
		};

		//c# 9.0以上：使用弃元指定不使用的输入参数
		static Func<int, int, int> _lambda03 => (_, b) => b + 42;

		//异步lambda
		static Action _lambda04 => async () => 
		{
			await Task.Delay(1000);
			System.Console.WriteLine("_lambda04 completed!");
		};

		//元祖lambda
		static Func<(int,int),(int,int)> _lambda05 =>  
			(a) => (a.Item1 + a.Item2,a.Item1 - a.Item2);

		// C# 10可以将属性添加到 Lambda 表达式及其参数
		// static Func<string?,int?> _lambda08 = [ProvidesNullCheck] (s) => 
		// (s is not null) ? int.Parse(s) : null;

		// static Func<string,string,string> _lambda09 = 
		// ([DisallowNull] string a, [DisallowNull] string b) => a + b;

		//Program.main call Test()
		public static void Test()
		{
			
			
		}
		public static void lambda07()
		{
			//不申明委托类型的lambda表达式,同时指定返回值类型
			var lambda07 = object (bool a) => a ? 1 : "two";
			System.Console.WriteLine(lambda07(false));
		}

		public static void lambda06()
		{
			//不申明委托类型的lambda表达式
			var lambda06 = (string s) => int.Parse(s);
			lambda06("6");
		}

    }
}

