using System;

// Interfaz Prototype
public abstract class Documento
{
  public string Titulo { get; set; }
  public string Contenido { get; set; }

  // Método para clonar
  public abstract Documento Clonar();

  public void MostrarInformacion()
  {
    Console.WriteLine($"Documento: {Titulo}, Contenido: {Contenido}");
  }
}

// Documento específico: Reporte
public class Reporte : Documento
{
  public string Autor { get; set; }

  public override Documento Clonar()
  {
    // Clonación profunda (Deep Copy)
    return new Reporte
    {
      Titulo = this.Titulo,
      Contenido = this.Contenido,
      Autor = this.Autor
    };
  }
}

// Documento específico: Contrato
public class Contrato : Documento
{
  public string Firmante { get; set; }

  public override Documento Clonar()
  {
    // Clonación profunda (Deep Copy)
    return new Contrato
    {
      Titulo = this.Titulo,
      Contenido = this.Contenido,
      Firmante = this.Firmante
    };
  }
}

// Cliente
class Program
{
  static void Main(string[] args)
  {
    // Crear un documento base
    Reporte reporteOriginal = new Reporte
    {
      Titulo = "Reporte Anual",
      Contenido = "Este es el contenido del reporte anual.",
      Autor = "Departamento de Finanzas"
    };

    // Clonar el documento
    Reporte reporteClonado = (Reporte)reporteOriginal.Clonar();
    reporteClonado.Titulo = "Reporte Clonado"; // Modificar título

    // Crear otro tipo de documento
    Contrato contratoOriginal = new Contrato
    {
      Titulo = "Contrato de Servicio",
      Contenido = "Este es un contrato para servicios.",
      Firmante = "Cliente XYZ"
    };

    // Clonar el contrato
    Contrato contratoClonado = (Contrato)contratoOriginal.Clonar();
    contratoClonado.Firmante = "Cliente ABC"; // Modificar firmante

    // Mostrar información de los documentos
    reporteOriginal.MostrarInformacion();
    reporteClonado.MostrarInformacion();
    contratoOriginal.MostrarInformacion();
    contratoClonado.MostrarInformacion();
  }
}