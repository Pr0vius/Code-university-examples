namespace Observer {
  using System;
  using System.Collections.Generic;

  // Subject interface
  public interface ISubject
  {
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
  }

  // Observer interface
  public interface IObserver
  {
    void Update(ISubject subject);
  }

  // Concrete Subject
  public class ConcreteSubject : ISubject
  {
    private List<IObserver> _observers = new List<IObserver>();
    private int _state;

    public int State
    {
      get { return _state; }
      set
      {
        _state = value;
        Notify();
      }
    }

    public void Attach(IObserver observer)
    {
      _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
      _observers.Remove(observer);
    }

    public void Notify()
    {
      foreach (var observer in _observers)
      {
        observer.Update(this);
      }
    }
  }

  // Concrete Observer
  public class ConcreteObserver : IObserver
  {
    private string _name;

    public ConcreteObserver(string name)
    {
      _name = name;
    }

    public void Update(ISubject subject)
    {
      if (subject is ConcreteSubject concreteSubject)
      {
        Console.WriteLine($"Observer {_name} has been notified. New state is {concreteSubject.State}");
      }
    }
  }

  // Example usage
  public class Program
  {
    public static void Main(string[] args)
    {
      ConcreteSubject subject = new ConcreteSubject();

      ConcreteObserver observer1 = new ConcreteObserver("Observer 1");
      ConcreteObserver observer2 = new ConcreteObserver("Observer 2");

      subject.Attach(observer1);
      subject.Attach(observer2);

      subject.State = 5;
      subject.State = 10;

      subject.Detach(observer1);

      subject.State = 15;
    }
  }


}