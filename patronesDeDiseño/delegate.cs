using System;
namespace Delegate
{
  public delegate void Operation(string message);

  public class Processor
  {
    private readonly Operation _operation;

    // Constructor que recibe un delegate para realizar la operación
    public Processor(Operation operation)
    {
      _operation = operation;
    }

    // Método para procesar una tarea
    public void ProcessTask(string task)
    {
      Console.WriteLine($"Iniciando tarea: {task}");
      _operation($"Tarea '{task}' completada.");
    }
  }

  // Clase principal
  class Program
  {
    // Métodos que serán usados como delegates
    public static void NotifyViaEmail(string message)
    {
      Console.WriteLine($"Enviando notificación por email: {message}");
    }

    public static void NotifyViaSMS(string message)
    {
      Console.WriteLine($"Enviando notificación por SMS: {message}");
    }

    static void Main(string[] args)
    {
      // Crear procesador con notificación por email
      Processor emailProcessor = new Processor(NotifyViaEmail);
      emailProcessor.ProcessTask("Importar datos");

      // Crear procesador con notificación por SMS
      Processor smsProcessor = new Processor(NotifyViaSMS);
      smsProcessor.ProcessTask("Exportar reporte");
    }
  }
}