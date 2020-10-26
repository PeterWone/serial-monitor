using System;
using System.IO.Ports;
using System.Threading;

namespace serial_monitor
{
  class Program
  {
    static void Main(string[] args)
    {
      var serial = new SerialPort(args[0], int.Parse(args[1]));
      Console.CancelKeyPress += delegate
      {
        serial.Close();
        serial.Dispose();
      };
      serial.DataReceived += (object sender, SerialDataReceivedEventArgs e) => Console.Write(serial.ReadExisting());
      serial.Open();
      Console.WriteLine($"Monitoring {args[0]} at {args[1]}");
      while (true) Thread.Sleep(20);
    }
  }
}
