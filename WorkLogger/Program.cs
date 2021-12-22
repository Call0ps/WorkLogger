using WorkLogger.Models;

Console.WriteLine("Hello, World!");
// TODO: Container class.
// TODO: Read json file.
// TODO: Export to excel/csv/whatever.
var shift = new Shift();
shift.Start();
Thread.Sleep(50000);
shift.End();
shift.SetMessage("Test!");
Console.WriteLine(shift.ToString());