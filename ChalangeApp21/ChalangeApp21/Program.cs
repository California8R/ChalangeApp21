using System;

int[] grades = new int[365];

List<string> dayOfWeeks = new List<string>();
dayOfWeeks.Add("poniedziałek");
dayOfWeeks.Add("wtorek");
dayOfWeeks.Add("środa");
dayOfWeeks.Add("czwartek");
dayOfWeeks.Add("piątek");
dayOfWeeks.Add("sobota");
dayOfWeeks.Add("niedziela");
// Console.WriteLine(dayOfWeeks[0]);

foreach (var day in dayOfWeeks)
{
    // Console.WriteLine(day);
}

int number = 453366;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

//Console.WriteLine(letters[0]);
//Console.WriteLine(letters[1]);
//Console.WriteLine(letters[2]);
//Console.WriteLine(letters[3]);

int c0 = 0;
int c1 = 0;
int c2 = 0;
int c3 = 0;
int c4 = 0;
int c5 = 0;
int c6 = 0;
int c7 = 0;
int c8 = 0;
int c9 = 0;

foreach (char cyfry in letters)
{
    if (cyfry == '0')
    {
        c0++;
    }
    else if (cyfry == '1')
    {
        c1++;
    }
    else if (cyfry == '2')
    {
        c2++;
    }
    else if (cyfry == '3')
    {
        c3++;
    }
    else if (cyfry == '4')
    {
        c4++;
    }
    else if (cyfry == '5')
    {
        c5++;
    }
    else if (cyfry == '6')
    {
        c6++;
    }
    else if (cyfry == '7')
    {
        c7++;
    }
    else if (cyfry == '8')
    {
        c8++;
    }
    else if (cyfry == '9')
    {
        c9++;   
    }
}

Console.WriteLine("0 = "+ c0);
Console.WriteLine("1 = "+ c1);
Console.WriteLine("2 = "+ c2);  
Console.WriteLine("3 = "+ c3);
Console.WriteLine("4 = "+ c4);
Console.WriteLine("5 = "+ c5);
Console.WriteLine("6 = "+ c6);
Console.WriteLine("7 = "+ c7);
Console.WriteLine("8 = "+ c8);
Console.WriteLine("9 = "+ c9);

