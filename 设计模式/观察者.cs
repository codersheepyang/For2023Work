using System;
namespace for2023work.设计模式
{
	public class ObserverDesignModel
	{
	}

	//通过这里的方法好像就知道了具体的观察者类型了，不够抽象
	public interface Observcer
	{

	}

	public interface Subject
	{
		public void RegistObserver(Observcer o);
		public void RemoveObserver(Observcer o);
		public void NoticeObservers();
	}
}

