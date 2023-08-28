Console.WriteLine("Enter a number of the day");
int dayNumber = Convert.ToInt32(Console.ReadLine());

switch (dayNumber)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thurday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("Something wrong");
        break;
}


//1.1 Uzduotis

using System.Globalization;

Console.WriteLine("Enter your age");
int age = Convert.ToInt32(Console.ReadLine());

switch (age)
{
    case <= 18:
        Console.WriteLine("moksleivis");
        break;
    case <= 25:
        Console.WriteLine("studentas");
        break;
    case <= 65:
        Console.WriteLine("darbuotojas");
        break;
    default:
        Console.WriteLine("pensininkas");
        break;
}



//1.2 Uzduotis

Console.WriteLine("Enter the number of the month");
int monthNumber = Convert.ToInt32(Console.ReadLine());
string month = monthNumber switch
{
    1 => "January",
    2 => "February",
    3 => "March",
    4 => "April",
    5 => "May",
    6 => "June",
    7 => "July",
    8 => "August",
    9 => "September",
    10 => "October",
    11 => "November",
    12 => "December",
};
Console.WriteLine(month);
