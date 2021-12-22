// See https://aka.ms/new-console-template for more information

using WorkLogger.Models;

Console.WriteLine("Hello, World!");

var shift = new Shift();
shift.Start();
Thread.Sleep(50000);
shift.End();
shift.SetMessage("Test!");
Console.WriteLine(shift.ToString());