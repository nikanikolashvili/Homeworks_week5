// See https://aka.ms/new-console-template for more information


using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;

// #1

Console.WriteLine("enter the size");
int array = int.Parse(Console.ReadLine());

int[] size = new int[array];

if (array == 0)
{
    Console.WriteLine(" enter corect number");
}

Console.WriteLine("enter th numbers");

for (int i = 0; i < array; i++) 
{
    Console.WriteLine($"number [{i + 1}]:");
    size[i] = int.Parse(Console.ReadLine());
}

int[] evenNumbers = Array.FindAll(size, num => num % 2 == 0);
int[] oddNumbers = Array.FindAll(size, num => num % 2 != 0);


Console.WriteLine("even number");
foreach (int even in evenNumbers)
{
    Console.WriteLine(even + " ");
      
        
        }

Console.WriteLine();
Console.WriteLine("odd number");
foreach (int odd in oddNumbers)
{
    Console.WriteLine(odd + " ");
}




// #2

Dictionary<string,string> Contacts =new Dictionary<string,string>();
bool running = true;

while (running)
{
    Console.WriteLine("\n1. Add contact");
    Console.WriteLine("2. remove contact");
    Console.WriteLine("3. edit contact");
    Console.WriteLine("4. all contact");
    Console.WriteLine("5. exit");
    Console.Write("plase chose: ");

    switch (Console.ReadLine())
    {
        case "1":
            AddContact(Contacts);
            break;
        case "2":
            DeleteContact(Contacts);
            break;
        case "3":
            UpdateContact(Contacts);
            break;
        case "4":
            DisplayContacts(Contacts);
            break;
        case "5":
            running = false;
            break;

        default:
            Console.WriteLine("error, try again");
            break;


    }




}
static void AddContact(Dictionary<string,string> contacts)
{

    Console.WriteLine("enter contact");
    string name = Console.ReadLine();
    if (contacts.ContainsKey(name))
    {
        Console.WriteLine("thes contact already exist");
    }
    else {

        Console.WriteLine("enter the contacts phone number");
        string phone = Console.ReadLine();
        contacts [name] = phone   ;
        Console.WriteLine("added  Successful");
            
            
            }
}
static void DeleteContact(Dictionary<string, string> contacts)
{
    Console.Write("enter  name to remove: ");
    string name = Console.ReadLine();

    if (contacts.Remove(name))
    {
        Console.WriteLine("remove Successful.");
    }
    else
    {
        Console.WriteLine("error try agein.");
    }
}

static void UpdateContact(Dictionary<string, string> contacts)
{
    Console.WriteLine("enterze number to update");
    string name = Console.ReadLine();
    if (contacts.ContainsKey(name))
    {
        Console.WriteLine("please enter new number");
        string newphone = Console.ReadLine();

        contacts[name] = newphone;
        Console.WriteLine("updatet Successful");

    }
    else
        Console.WriteLine("error 404");



}

static void DisplayContacts(Dictionary<string, string> contacts)
{
    if (contacts.Count == 0)
    {
        Console.WriteLine("error.");
        return;
    }

    Console.WriteLine("\n all contact :");
    foreach (var contact in contacts)
    {
        Console.WriteLine($"name: {contact.Key}, phone: {contact.Value}");
    }
}

// #3

Console.Write("enter size: ");
int n = int.Parse(Console.ReadLine());


int[] numbers = new int[n];


Console.WriteLine("enter number:");
for (int i = 0; i < n; i++)
{
    Console.Write($"number [{i + 1}]: ");
    numbers[i] = int.Parse(Console.ReadLine());
}


var elementCounts = numbers.GroupBy(x => x)
                           .Select(g => new { Element = g.Key, Count = g.Count() })
                           .ToList();


Console.WriteLine("\n quantity:");
foreach (var item in elementCounts)
{
    Console.WriteLine($"number: {item.Element}, quantity: {item.Count}");
}


int totalSum = numbers.Sum();
Console.WriteLine($"\nsum: {totalSum}");



// #4

int[] Participant = { 1, 2, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine(" enter top n Participant");
int N =int.Parse(Console.ReadLine());

if (n < 1 || n > 10)
{
    Console.WriteLine("Please enter an internal number from 1-10");
    return;
}

Console.WriteLine("Top n Participant ");
for (int i = 0; i < N; i++)
{
    Console.WriteLine(i);
}
