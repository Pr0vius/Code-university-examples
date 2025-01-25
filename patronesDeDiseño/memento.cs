using System;
using System.Collections;

namespace Memento
{
  public class Game
  {
    private string Name = "";
    private int Checkpoint;

    public int GetCheckpoint()
    {
      return Checkpoint;
    }
    public void SetCheckpoint(int checkpoint)
    {
      Checkpoint = checkpoint;
    }

    public void SetName(string name)
    {
      Name = name;
    }
    public string GetName()
    {
      return Name;
    }
    public override string ToString()
    {
      return $"Game: {Name} Checkpoint: {Checkpoint}";
    }

  }

  public class Caretaker
  {
    ArrayList mementos = new ArrayList();

    public void addMemento(Memento memento)
    {
      mementos.Add(memento);
    }

    public Memento getMemento(int index)
    {
      var memento = mementos[index] as Memento;
      if (memento == null)
      {
        throw new InvalidOperationException("Memento not found at the given index.");
      }
      return memento;
    }
  }

  public class Memento
  {
    private Game state = new Game();

    public Memento(Game state)
    {
      this.state = state;
    }

    public Game GetState()
    {
      return state;
    }
  }

  public class Originator
  {
    private Game state;

    public void SetState(Game state)
    {
      this.state = state;
    }

    public Game GetState()
    {
      return state;
    }

    public Memento Save()
    {
      return new Memento(state);
    }

    public void GetStateFromMemento(Memento memento)
    {
      state = memento.GetState();
    }
  }
  public class Program
  {
    public static void Main(string[] args)
    {
      string gameName = "Super Mario Bros";

      Game game = new Game();
      game.SetName(gameName);
      game.SetCheckpoint(1);

      Caretaker caretaker = new Caretaker();
      Originator originator = new Originator();

      game = new Game();
      game.SetName(gameName);
      game.SetCheckpoint(2);
      originator.SetState(game);

      game = new Game();
      game.SetName(gameName);
      game.SetCheckpoint(3);
      originator.SetState(game);

      caretaker.addMemento(originator.Save());

      game = new Game();
      game.SetName(gameName);
      game.SetCheckpoint(4);

      originator.SetState(game);
      caretaker.addMemento(originator.Save());

      game = new Game();
      game.SetName(gameName);
      game.SetCheckpoint(5);
      originator.SetState(game);
      caretaker.addMemento(originator.Save()); // ESTADO POSICION 2

      originator.SetState(game);
      originator.GetStateFromMemento(caretaker.getMemento(1));

      game = originator.GetState();
      Console.WriteLine(game.ToString());
    }
  }

}