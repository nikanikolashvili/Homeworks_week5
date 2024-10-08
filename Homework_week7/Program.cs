// See https://aka.ms/new-console-template for more information

// #1

{
    
    Console.Write("Enter the radius of the circle: ");
    double radius = double.Parse(Console.ReadLine());

    
    double largeSquareSide = radius * 2;

   
    double smallSquareSide = Math.Sqrt(2) * radius;

    
    double largeSquareArea = Math.Pow(largeSquareSide, 2);
    double smallSquareArea = Math.Pow(smallSquareSide, 2);

    
    double areaDifference = largeSquareArea - smallSquareArea;

    
   
    Console.WriteLine($"The difference in areas: {areaDifference}");
}


// #2

int[] Jackpot = { 7, 24, 54, 66  };
int[] usernumber = new int[4];

Console.WriteLine("enter your luckjy numbers");
for (int i = 0; i < 4; i++)
{
    Console.Write($"number [{i + 1}]: ");
    usernumber[i] = int.Parse(Console.ReadLine());
}


bool PLM = true;
for(int i = 0; i < 4; i++)
{

    if (usernumber[i] != Jackpot[i])
    {
        PLM = false;    
        break;
    }

}

if (PLM)
{
    Console.WriteLine("congratulate you win the premium progresiv jackpot");
}
else
{
    Console.WriteLine("you lose");
}


// #3

Console.Write ("Win:");
var win = int.Parse(Console.ReadLine());
Console.Write("Draw:");
var Draw = int.Parse(Console.ReadLine());
Console.Write("Lose:");
Console.ReadLine();

int wincount = win * 3;
int score = wincount + Draw;
Console.WriteLine($"you Score is: {score}");


// #4


Console.WriteLine("Enter how many hours have you worked");
int onehourpay = 10;
int overtimepay = 5;
int Weekendpay = 20;
int[] totalhours = new int[7];
int sum = 0;
for (int i = 0; i < totalhours.Length; i++)
{
    totalhours[i] = int.Parse(Console.ReadLine());
}
for (int i = 0;i < 5; i++)
{
    if (totalhours[i] == 8)
    {
        sum += totalhours[i] * onehourpay;

    }
    else if (totalhours[i] > 8 ) { sum += totalhours[i] *(onehourpay + overtimepay);
            }
    else
    {
        sum += totalhours[i] * onehourpay;

    }
}

if (totalhours[5]> 0 || totalhours[6] > 0 )
{

   sum += (totalhours[5] + totalhours[6]) * Weekendpay;
        
}
Console.WriteLine($"$:{sum}");



// #5

Console.WriteLine("giorgis progres");

int[] progres = new int[5];
for (int i = 0; i < progres.Length; i++)
{
    progres[i] = int.Parse(Console.ReadLine());
}
int progrescounter = 0;
    for (int i = 1; i < progres.Length ; i++)
{

    if (progres[i] > progres[i -1])
    {

        progrescounter++;
    }

}	

Console.WriteLine($"Progres days: { progrescounter}");


// #6




List<string> inputedwords = new List<string>();

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Please enter a Words");
    inputedwords.Add(Console.ReadLine()); 
}


Console.WriteLine(" Enter length"); 
int lengthn = int.Parse(Console.ReadLine());


var result = inputedwords.Where(Word => Word.Length >= lengthn);

if (result.Any ())
{
Console.WriteLine(String.Join(" ", result));
}
else
{
    Console.WriteLine("no elements");
}