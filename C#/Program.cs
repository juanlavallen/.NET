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

int key = 2;

switch (key) {
    case 1:
        Console.WriteLine("Incorrect key");
        break;
    case 2:
        Console.WriteLine("Correct key");
        break;
    case 3:
        Console.WriteLine("Incorrect key");
        break;
    default: 
        Console.WriteLine("Key not found");
        break;
}

/***** Arrays *****/

// Defining a array of type int
int[] arrayInt1 = new int[5];
int[] arrayInt2 = new int[] { 10, 20, 30, 40, 50 }; // Array Initialization
int[] arrayInt3 = { 10, 20, 30, 40, 50 }; // Implicitly typed array
