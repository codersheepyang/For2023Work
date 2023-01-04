using System;
namespace for2023work.设计模式
{
    //应用：消息队列，异步，解耦，消峰
	public class ObserverDesignModel
	{
        public static void Test()
        {
            //前三行可作为配置
            var subject = new PersonalInfoSubject();
            Observcer ho = new HospitalObserver(subject);
            Observcer go = new GymObserver(subject);

            subject.NoticeObservers(1, 2);
        }
	}

	//通过这里的方法好像就知道了具体的观察者类型了，不够抽象
    //这里也可以写各种各样的观察者方法
	public interface Observcer
	{
		public void Update(int height, int weight);
	}

    public class HospitalObserver : Observcer
    {
        public HospitalObserver(Subject subject)
        {
            subject.RegistObserver(this);
        }

        public void Update(int height, int weight)
        {
			Console.WriteLine($"医院得到用户的身高({height}和体重({weight})信息.");
        }
    }

    public class GymObserver : Observcer
    {
        public GymObserver(Subject subject)
        {
            subject.RegistObserver(this);
        }

        public void Update(int height, int weight)
        {
            Console.WriteLine($"健身房得到用户的身高({height}和体重({weight})信息.");
        }
    }

    public interface Subject 
	{
		public void RegistObserver(Observcer o);
		public void RemoveObserver(Observcer o);
		public void NoticeObservers(int height, int weight);
	}

    public class PersonalInfoSubject : Subject
    {
        private List<Observcer> observcers = new List<Observcer>();

        public void NoticeObservers(int height,int weight)
        {
            foreach(var o in observcers)
            {
                o.Update(height, weight);
            }
        }

        public void RegistObserver(Observcer o)
        {
            observcers.Add(o);
        }

        public void RemoveObserver(Observcer o)
        {
            observcers.Remove(o);
        }
    }
}

