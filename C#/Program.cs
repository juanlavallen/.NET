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

// Defining a array of type string
string[] arrayString1 = new string[10];
string[] arrayString2 = new string[] { "Mike Tyson", "Lionel Messi", "Eminem" }; // Array Initialization
string[] arrayString3 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" }; // Implicitly typed array

// Defining a list 
List<int> collectionTypeInt1 = new List<int>();
List<int> collectionTypeInt2 = new List<int>() { 10, 20, 30, 40 };

collectionTypeInt1.Add(50); // Adding an element to the list
collectionTypeInt2.Remove(10); // Removing an element from a list

/***** Loops *****/

foreach (int item in collectionTypeInt2) {
    Console.WriteLine(item);
}

string[] users = new string[5] { "juandev_07", "pepe02", "strider_88", "rabbit", "_brian1_" };
for (int i = 0; i < users.Length; i++) {
    Console.WriteLine($"Index: {i} - Value: {users[i]}"); 
}

int j = 0;
do {
    Console.WriteLine(j);
    j++;
} while (4 > j);