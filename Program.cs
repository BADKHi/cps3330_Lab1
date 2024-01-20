// See https://aka.ms/new-console-template for more information
using static System.Console;
Console.WriteLine("Hello, World!");
Console.WriteLine("Mekhi Wood-Brock");
Console.WriteLine("Version: {0}", Environment.Version.ToString());
string text = System.IO.File.ReadAllText("text.txt");
Console.WriteLine(text);
#region Working with single-dimensional arrays

string[] names; // This can reference any size array of strings.

// Allocate memory for four strings in an array.
names = new string[4];
    




    //Adding a commit for changes 
// Store items at these index positions.
names[0] = "Walt";
names[1] = "Jesse";
names[2] = "Jimmy";
names[3] = "Kim";

Console.WriteLine("Mekhi Wood-Brock");
Console.WriteLine("Version: {0}", Environment.Version.ToString());

// Alternative syntax for creating and initializing an array.
string[] names2 = { "Walt", "Jesse", "Jimmy", "Kim" };

// Loop through the names.
for (int i = 0; i < names2.Length; i++)
{
  // Output the item at index position i.
  WriteLine($"{names2[i]} is at position {i}.");
}

#endregion

#region Working with multi-dimensional arrays

string[,] grid1 = // Two dimensional array.
{
  { "Apple", "Banana", "Grape", "Dragon Fruit" },
  { "Avocado", "Blueberry", "Cherry", "Durian" },
  { "Apricot", "Blackberry", "Coconut", "Date" }
};

WriteLine($"1st dimension, lower bound: {grid1.GetLowerBound(0)}");
WriteLine($"1st dimension, upper bound: {grid1.GetUpperBound(0)}");
WriteLine($"2nd dimension, lower bound: {grid1.GetLowerBound(1)}");
WriteLine($"2nd dimension, upper bound: {grid1.GetUpperBound(1)}");

for (int row = 0; row <= grid1.GetUpperBound(0); row++)
{
  for (int col = 0; col <= grid1.GetUpperBound(1); col++)
  {
    WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
  }
}

#endregion

#region Working with jagged arrays

string[][] jagged = // An array of string arrays.
{
  new[] { "Apple", "Banana", "Grape" },
  new[] { "Avocado", "Blueberry", "Cherry", "Durian" },
  new[] { "Apricot", "Blackberry" }
};

WriteLine("Upper bound of the array of arrays is: {0}",
  jagged.GetUpperBound(0));

for (int array = 0; array <= jagged.GetUpperBound(0); array++)
{
  WriteLine("Upper bound of array {0} is: {1}",
    arg0: array,
    arg1: jagged[array].GetUpperBound(0));
}

for (int row = 0; row <= jagged.GetUpperBound(0); row++)
{
  for (int col = 0; col <= jagged[row].GetUpperBound(0); col++)
  {
    WriteLine($"Row {row}, Column {col}: {jagged[row][col]}");
  }
}

#endregion

#region List pattern matching with arrays

int[] sequentialNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int[] oneTwoNumbers = { 1, 2 };
int[] oneTwoTenNumbers = { 1, 2, 10 };
int[] oneTwoThreeTenNumbers = { 1, 2, 3, 10 };
int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
int[] fibonacciNumbers = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 };
int[] emptyNumbers = { }; // Or use Array.Empty<int>()
int[] threeNumbers = { 9, 7, 5 };
int[] sixNumbers = { 9, 7, 5, 4, 2, 10 };

WriteLine($"{nameof(sequentialNumbers)}: {CheckSwitch(sequentialNumbers)}");
WriteLine($"{nameof(oneTwoNumbers)}: {CheckSwitch(oneTwoNumbers)}");
WriteLine($"{nameof(oneTwoTenNumbers)}: {CheckSwitch(oneTwoTenNumbers)}");
WriteLine($"{nameof(oneTwoThreeTenNumbers)}: {CheckSwitch(oneTwoThreeTenNumbers)}");
WriteLine($"{nameof(primeNumbers)}: {CheckSwitch(primeNumbers)}");
WriteLine($"{nameof(fibonacciNumbers)}: {CheckSwitch(fibonacciNumbers)}");
WriteLine($"{nameof(emptyNumbers)}: {CheckSwitch(emptyNumbers)}");
WriteLine($"{nameof(threeNumbers)}: {CheckSwitch(threeNumbers)}");
WriteLine($"{nameof(sixNumbers)}: {CheckSwitch(sixNumbers)}");

static string CheckSwitch(int[] values) => values switch
{
  [] => "Empty array",
  [1, 2, _, 10] => "Contains 1, 2, any single number, 10.",
  [1, 2, .., 10] => "Contains 1, 2, any range including empty, 10.",
  [1, 2] => "Contains 1 then 2.",
  [int item1, int item2, int item3] =>
    $"Contains {item1} then {item2} then {item3}.",
  [0, _] => "Starts with 0, then one other number.",
  [0, ..] => "Starts with 0, then any range of numbers.",
  [2, .. int[] others] => $"Starts with 2, then {others.Length} more numbers.",
  [..] => "Any items in any order.",
};

#endregion

