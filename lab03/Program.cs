
// Part 1: 5 Outputs
Console.WriteLine("    A");
Console.WriteLine("   BCD");
Console.WriteLine("  EFGHI");
Console.WriteLine(" JKLMNOP");
Console.WriteLine("QRSTUVWXYZ");


Console.WriteLine("--------"); // Seperator
// Part 2: 1 Output

Console.WriteLine("    A\n   BCD\n  EFGHI\n JKLMNOP\nQRSTUVWXYZ");


Console.WriteLine("---------"); // Seperator
// Part 3: : All operators

Console.Write("Enter your first integer -> ");
int firstInt = int.Parse(Console.ReadLine());

Console.Write("Enter your second integer -> ");
int secondInt = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum is..........{firstInt + secondInt}");
Console.WriteLine($"Difference is...{firstInt - secondInt}");
Console.WriteLine($"Product is......{firstInt * secondInt}");
Console.WriteLine($"Quotient is.....{firstInt / secondInt}");