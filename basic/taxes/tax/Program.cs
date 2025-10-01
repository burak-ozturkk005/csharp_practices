using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Please enter your income: ");
double income = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please enter you resident or non-resident: for resident : y non resident: n");
string res = Console.ReadLine();
bool isResident = res.ToLower() == "y";
double taxRate;
if (income < 50000) {
    {
        if (res == "y")
        {
            taxRate = 0.10;
        }
        else
        {
            taxRate = 0.15;
        }
    }
    }else if (income > 50000 && income <= 100000)
    {
        if (res == "y")
            taxRate = 0.20;
        else
        {
            taxRate = 0.25;
        }
    } else
    {
        if (isResident)
        {
            taxRate = 0.30;
        } else
        {
            taxRate = 0.35;
        }

    }
double tax = income * taxRate;
Console.WriteLine("The tax is: $" + tax);