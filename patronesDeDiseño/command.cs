using System;
using System.Collections.Generic;

// Interfaz Command
public interface ICommand
{
  void Execute();
}

// Comando Concreto
public class LightOnCommand : ICommand
{
  private Light _light;

  public LightOnCommand(Light light)
  {
    _light = light;
  }

  public void Execute()
  {
    _light.On();
  }
}

// Comando Concreto
public class LightOffCommand : ICommand
{
  private Light _light;

  public LightOffCommand(Light light)
  {
    _light = light;
  }

  public void Execute()
  {
    _light.Off();
  }
}

// Receptor
public class Light
{
  public void On()
  {
    Console.WriteLine("La luz está encendida");
  }

  public void Off()
  {
    Console.WriteLine("La luz está apagada");
  }
}

// Invocador
public class RemoteControl
{
  private ICommand _command;

  public void SetCommand(ICommand command)
  {
    _command = command;
  }

  public void PressButton()
  {
    _command.Execute();
  }
}

// Cliente
public class Program
{
  public static void Main(string[] args)
  {
    // Receptor
    Light livingRoomLight = new Light();

    // Comandos Concretos
    ICommand lightOn = new LightOnCommand(livingRoomLight);
    ICommand lightOff = new LightOffCommand(livingRoomLight);

    // Invocador
    RemoteControl remote = new RemoteControl();

    // Encender la luz
    remote.SetCommand(lightOn);
    remote.PressButton();

    // Apagar la luz
    remote.SetCommand(lightOff);
    remote.PressButton();
  }
}