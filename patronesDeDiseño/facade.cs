using System;
namespace Facade
{
  // Subsistema: Gestión de asientos
  public class SeatManager
  {
    public bool CheckSeatAvailability(int seatNumber)
    {
      Console.WriteLine($"Verificando disponibilidad del asiento {seatNumber}.");
      return true; // Simula que el asiento está disponible
    }

    public void ReserveSeat(int seatNumber)
    {
      Console.WriteLine($"Reservando asiento {seatNumber}.");
    }
  }

  // Subsistema: Proyección de películas
  public class MoviePlayer
  {
    public void PlayMovie(string movieName)
    {
      Console.WriteLine($"Reproduciendo la película: {movieName}.");
    }
  }

  // Subsistema: Procesamiento de pagos
  public class PaymentProcessor
  {
    public bool ProcessPayment(string paymentMethod, double amount)
    {
      Console.WriteLine($"Procesando pago de {amount:C} usando {paymentMethod}.");
      return true; // Simula que el pago fue exitoso
    }
  }

  // Clase Facade
  public class CinemaFacade
  {
    private readonly SeatManager _seatManager;
    private readonly MoviePlayer _moviePlayer;
    private readonly PaymentProcessor _paymentProcessor;

    public CinemaFacade()
    {
      _seatManager = new SeatManager();
      _moviePlayer = new MoviePlayer();
      _paymentProcessor = new PaymentProcessor();
    }

    public void BookTicket(string movieName, int seatNumber, string paymentMethod, double amount)
    {
      Console.WriteLine("Iniciando proceso de reserva de entradas...");

      if (!_seatManager.CheckSeatAvailability(seatNumber))
      {
        Console.WriteLine("El asiento no está disponible.");
        return;
      }

      if (!_paymentProcessor.ProcessPayment(paymentMethod, amount))
      {
        Console.WriteLine("El pago no se pudo procesar.");
        return;
      }

      _seatManager.ReserveSeat(seatNumber);
      _moviePlayer.PlayMovie(movieName);

      Console.WriteLine("Entrada reservada exitosamente.");
    }
  }

  // Cliente
  class Program
  {
    static void Main(string[] args)
    {
      CinemaFacade cinema = new CinemaFacade();

      // Reservar una entrada de manera simplificada
      cinema.BookTicket("Inception", 10, "Tarjeta de Crédito", 12.99);
    }
  }
}