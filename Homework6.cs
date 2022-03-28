/**       
 *--------------------------------------------------------------------
 * 	        File name: Homework6.cs
 * 	        Project name: Homework6
 *--------------------------------------------------------------------
 *          Author’s name:	 Caleb Mintz			
 *          Course-Section: CSCI-1250-201
 *          Creation Date:	 03.27.2022		
 * -------------------------------------------------------------------
 */

Console.Clear();
int inputErrorCatcher = 0;
// Method 1 Call - ShowCharacter
Console.WriteLine("====================================Method 1 - Show Character======================================");
ShowCharacter("New York",2);

// Method 2 Call - CalculateRetail
Console.WriteLine("====================================Method 2 - Calculate Retail====================================");
double wholesalePrice = 0;
double markupPercentage = 0;
do{
    try{
        Console.Write("Please enter the wholesale price of item x: $");
        wholesalePrice = double.Parse(Console.ReadLine());
        inputErrorCatcher = 0;
    }catch{
        ErrorMessage();
        inputErrorCatcher = 1;
    }
}while(inputErrorCatcher == 1);
inputErrorCatcher = 0;
do{
    try{
        Console.Write("Please enter the markup percentage of item x: ");
        markupPercentage = double.Parse(Console.ReadLine()) / 100;
        inputErrorCatcher = 0;
    }catch{
        ErrorMessage();
        inputErrorCatcher = 1;
    }
}while(inputErrorCatcher == 1);
Console.WriteLine("Total cost of item x is ${0}.",(CalculateRetail(wholesalePrice,markupPercentage)).ToString("0.00"));

// Method 3 Call - Celsius
Console.WriteLine("====================================Method 3 - Celsius=============================================");
for(int i = 80; i < 101; i++) Console.WriteLine("Farenheit temperature: {0}F = Celsius temperature: {1}C.",i,Celsius(i).ToString("0.00"));

// Method 4 Call- IsPrime
Console.WriteLine("====================================Method 4 - Is Prime============================================");
inputErrorCatcher = 0;
int number = 0;
do{
    try{
    Console.Write("Enter a number to calculate if prime or composite: ");
    number = int.Parse(Console.ReadLine());
    inputErrorCatcher = 0;
    }catch{
        ErrorMessage();
        inputErrorCatcher = 1;
    }
}while(inputErrorCatcher == 1);
if(IsPrime(number)) Console.WriteLine("{0} is a prime number.",number);
else Console.WriteLine("{0} is not a prime number.",number);

// Method 1 Declaration
static void ShowCharacter(string myString, int position){
    Console.WriteLine(myString[position-1]);
}

// Method 2 Declaration
static double CalculateRetail(double wholesalePrice, double markupPercentage) => (wholesalePrice * markupPercentage) + wholesalePrice;

// Method 3 Declaration
static double Celsius(int farenheit) => (farenheit - 32) * 5 / 9.0;

// Method 4 Declaration
static bool IsPrime(int number){
    int tracker = 0;
    for(int i = 1; i <= number; i++){
        if(number % i == 0){
            tracker++;
        }
    }
    if(tracker == 2) return true;
    else return false;
}

// Error Tracker
static void ErrorMessage(){
    Console.WriteLine("Incorrect Input. Please enter a number.");
}