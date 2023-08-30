using System;
using System.Globalization;

namespace GettingStarted
{
    class program
    static void Main(string[] args)
    {
        cultureInfo cultureInfo = new cultureInfo("pt-br");
        string table = Console.ReadLine();

        console.Write("The number of people: ");
        string countString = Console.Readline();
        int.TryParse(countString, out int count);

        Console.Write("The reservation date (MM/DD/YYYY): ");
        string dateTimeString = Console.ReadLIne();
        if (!dateTimeString.TryParseExact(
           dataTimeString,
           "M/D/YYYY HH:mm",
           culturaInfo,
           DateTimeStyles.None,
           out dateTimeString datetime))
        {
            datetime = datetime.Now;
        }
        Console.WriteLine(
            "Table {0} has been booked for {1} people on {2} at {3}",
            table,
            count,
            dateTimeString.ToString("M/d/yyyy", cultureInfo),
            dateTimeString.ToString("HH:mm", cultureInfo));
        
    }
}