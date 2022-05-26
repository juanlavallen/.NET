/***** Variables and Data Types *****/

// Defining variables of type string
string country = "Argentina";
string region  = "LATAM";
Console.WriteLine($"Country: {country} - Region {region}");

// Defining variables of type int
int quantity = 10;
int price    = 20;
Console.WriteLine($"Quantity: {quantity} - Price: {price}");

// Defining a variable of type float
float population = 45897978f;
Console.WriteLine($"Population: {population}");

// Defining a varible of type bool
bool activated = true;
Console.WriteLine($"Activated: {activated}");

/***** Conditionals *****/

int age = 19;

if(age > 18 && age != 18) {
    Console.WriteLine("Access allowed");
} else if (age == 18) {
    Console.WriteLine("Access allowed with identification");
} else {
    Console.WriteLine("Access not allowed");
}