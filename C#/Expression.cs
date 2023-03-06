using System;


namespace StudyForever.C
{
	public class Expression
	{
		public Expression()
		{
		}

        //表达式lambda创建表达式树
        System.Linq.Expressions.Expression<Func<int, bool>> _expression01 = (a) => a > 5;
    }
}

