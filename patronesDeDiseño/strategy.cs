namespace Strategy
{
  // Definición de la interfaz IStrategy que declara el método Analyze
  interface IStrategy
  {
    void Analyze();
  }

  // Clase abstracta SimpleAnalyzer que implementa la interfaz IStrategy
  public abstract class SimpleAnalyzer : IStrategy
  {
    // Implementación del método Analyze que llama a los métodos abstractos Start, SkipZip y Stop
    public void Analyze()
    {
      Start();
      SkipZip();
      Stop();
    }

    // Métodos abstractos que deben ser implementados por las clases derivadas
    public abstract void Start();
    public abstract void SkipZip();
    public abstract void Stop();
  }

  // Clase abstracta ComplexAnalyzer que implementa la interfaz IStrategy
  public abstract class ComplexAnalyzer : IStrategy
  {
    // Implementación del método Analyze que llama a varios métodos abstractos
    public void Analyze()
    {
      Start();
      AnalyzeMemory();
      AnalyzeKeyloggers();
      AnalyzeRootkits();
      UnzipZip();
      Stop();
    }

    // Métodos abstractos que deben ser implementados por las clases derivadas
    public abstract void Start();
    public abstract void AnalyzeMemory();
    public abstract void AnalyzeKeyloggers();
    public abstract void AnalyzeRootkits();
    public abstract void UnzipZip();
    public abstract void Stop();
  }

  // Clase SimpleAntivirus que hereda de SimpleAnalyzer e implementa los métodos abstractos
  public class SimpleAntivirus : SimpleAnalyzer
  {
    public override void Start()
    {
      Console.WriteLine("SimpleAntivirus: Starting...");
    }

    public override void SkipZip()
    {
      Console.WriteLine("SimpleAntivirus: Skipping ZIP files...");
    }

    public override void Stop()
    {
      Console.WriteLine("SimpleAntivirus: Stopping...");
    }
  }

  // Clase ComplexAntivirus que hereda de ComplexAnalyzer e implementa los métodos abstractos
  public class ComplexAntivirus : ComplexAnalyzer
  {
    public override void Start()
    {
      Console.WriteLine("ComplexAntivirus: Starting...");
    }

    public override void AnalyzeMemory()
    {
      Console.WriteLine("ComplexAntivirus: Analyzing memory...");
    }

    public override void AnalyzeKeyloggers()
    {
      Console.WriteLine("ComplexAntivirus: Analyzing keyloggers...");
    }

    public override void AnalyzeRootkits()
    {
      Console.WriteLine("ComplexAntivirus: Analyzing rootkits...");
    }

    public override void UnzipZip()
    {
      Console.WriteLine("ComplexAntivirus: Unzipping ZIP files...");
    }

    public override void Stop()
    {
      Console.WriteLine("ComplexAntivirus: Stopping...");
    }
  }

  // Clase Context que utiliza una estrategia (IStrategy) para realizar el análisis
  class Context
  {
    private IStrategy _strategy;

    // Constructor que recibe una estrategia y la asigna a la variable privada _strategy
    public Context(IStrategy strategy)
    {
      _strategy = strategy;
    }

    // Método Analyze que llama al método Analyze de la estrategia asignada
    public void Analyze()
    {
      _strategy.Analyze();
    }
  }

  // Clase Program con el método Main que es el punto de entrada de la aplicación
  class Program
  {
    static void Main(string[] args)
    {
      // Creación de un contexto con una estrategia SimpleAntivirus y ejecución del análisis
      Context context = new Context(new SimpleAntivirus());
      context.Analyze();
    }
  }
}