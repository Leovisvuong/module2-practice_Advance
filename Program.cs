// practice advance
/*
// L123
// part 1
int num = 10;
Console.WriteLine("The value of num is: " + num);

// part 2
string firstName = "Leovis";
string lastName = "Vuong";
Console.WriteLine(firstName + " " + lastName);

// part 3
Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine("Your age is: " + age);

// part 4
Console.WriteLine("The sum of 5 and 7 is: " + (5+7));

// part 5
Console.Write("Celsius temperature: ");
int Celsius = int.Parse(Console.ReadLine());
Console.WriteLine("The Fahrenheit equivalent is: " + ((Celsius*9/5)+32));

// part 6
int playerHealth = 100;
Console.WriteLine("Player's health: " + playerHealth);

// part 7
Console.Write("Enter your name: ");
string playerName = Console.ReadLine();
Console.WriteLine("Welcome to the game, " + playerName + "!");

// part 8
int length = 10;
int width = 5;
Console.WriteLine("The area of the rectangular movement space is: " + length*width);

// part 9
string playerLevel = "Level 10";
int playerLevelInInteger = Int32.Parse(playerLevel.Substring(6));
Console.WriteLine("Player's Level: Level 10\nPlayer's Level as an integer: " + playerLevelInInteger);

// part 10
int pointsForKillEnemy = 100;
int pointsForCollectBonus = 50;
Console.WriteLine("The total score is: " + (pointsForCollectBonus + pointsForKillEnemy));

// part 11
Console.Write("Enter the string: ");
string String = Console.ReadLine();
Console.WriteLine("The string in upper case: " + String.ToUpper() + "\nThe string in lower case: " + String.ToLower());
for(int i=0; i<String.Length; i++){
    if(i==0 && String[i]!=' '){
        String = String.Substring(0,1).ToUpper() + String.Substring(1);
    }
    else if(i!=String.Length-1 && String[i]==' '){
        String = String.Substring(0,i+1) + String.Substring(i+1,1).ToUpper() + String.Substring(i+2);
    }
}
Console.WriteLine("The string in title case: " + String);

// part 12
Console.Write("Enter the principle amount: ");
double principalAmount = double.Parse(Console.ReadLine());
Console.Write("Enter the interest rate: ");
double interestRate = double.Parse(Console.ReadLine());
Console.Write("Enter the time period: ");
double timePeriod = double.Parse(Console.ReadLine());
double note = 1+interestRate/100;
double compoundInterest = principalAmount*Math.Pow(note,timePeriod)-principalAmount;
Console.WriteLine("The compound interest is: " + compoundInterest.ToString("0.00"));

// part 13
Console.Write("Enter the first number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
int secondNumber = int.Parse(Console.ReadLine());
int intNote = firstNumber;
firstNumber = secondNumber;
secondNumber = intNote;
Console.WriteLine("First number: " + firstNumber + "\nSecond number: " + secondNumber);

// part 14
Console.Write("Enter the first number: ");
firstNumber = int.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
secondNumber = int.Parse(Console.ReadLine());
Console.Write("Enter the third number: ");
int thirdNumber = int.Parse(Console.ReadLine());
Console.WriteLine("The 3 numbers are: " + firstNumber + " " + secondNumber + " " + thirdNumber + "\nThe greatest number is: " + Math.Max(firstNumber,Math.Max(secondNumber,thirdNumber)));

// part 15
Console.Write("Enter the first number: ");
firstNumber = int.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
secondNumber = int.Parse(Console.ReadLine());
int GCD(int numberA, int numberB){
    for(int i=Math.Min(numberA,numberB); i>0; i--){
        if(numberA%i==0 && numberB%i==0){
            return i;
        }
    }
    return 0;
}
Console.WriteLine("The GCD of " + firstNumber + " and " + secondNumber + " is: " + GCD(firstNumber,secondNumber));

// part 16
Console.Write("Enter the radius of the sphere: ");
double radius = double.Parse(Console.ReadLine());
double sphereVolume = 4*(Math.PI)*(Math.Pow(radius,3.00))/3;
Console.WriteLine("The volume of the sphere is: " + sphereVolume);
// part 17
Console.Write("Enter the string: ");
String = Console.ReadLine();
Console.Write("Enter the character to find: ");
char character = Console.ReadKey().KeyChar;
Console.Write("\nEnter the starting position: ");
int position = int.Parse(Console.ReadLine());
Console.WriteLine("The index of '" + character + "' starting from position " + position + " is: " + String.IndexOf(character,position));

// part 18
Console.Write("Enter the string: ");
String = Console.ReadLine();
Console.Write("Enter the character to remove: ");
character = Console.ReadKey().KeyChar;
string whiteChar = "";
Console.WriteLine("\nThe string after removing '" + character + "' is: " + String.Replace(character.ToString(), string.Empty));

// part 19
Console.Write("Enter the string: ");
String = Console.ReadLine();
Console.Write("Enter the character to replace: ");
character = Console.ReadKey().KeyChar;
Console.Write("\nEnter the character to replace with: ");
char characterReplace = Console.ReadKey().KeyChar;
Console.WriteLine("\nThe string after replacing '" + character + "' with '" + characterReplace + "' is: " + String.Replace(character,characterReplace));

// part 20
Console.Write("Enter the string: ");
String = Console.ReadLine();
Console.Write("Enter the start index: ");
int startIndex = int.Parse(Console.ReadLine());
Console.Write("Enter the end index: ");
int endIndex = int.Parse(Console.ReadLine());
Console.WriteLine("The substring from index " + startIndex + " to " + endIndex + " is: " + String.Substring(startIndex,endIndex));
*/



/*
// L456
// question 1
Console.Write("Enter your weight in kilograms: ");
double weight = double.Parse(Console.ReadLine());
Console.Write("Enter your height in metres: ");
double height = double.Parse(Console.ReadLine());
double BMI = weight/(height*height);
string BMIHealth = "";
switch(BMI){
    case <18.5:
        BMIHealth = "Underweight";
        break;
    case <=23:
        BMIHealth = "Normal Weight";
        break;
    case <=27.5:
        BMIHealth = "Overweight";
        break;
    case >27.5:
        BMIHealth = "Obese";
        break;
}
Console.WriteLine("You are " + BMIHealth);

// question 2
Console.Write("Enter amount spent: ");
int amount = int.Parse(Console.ReadLine());
int discountRate = 0;
if(amount<=100) discountRate = 0;
else if(amount<=500) discountRate = 5;
else if(amount<=1000) discountRate = 10;
else if(amount>1000) discountRate = 20;
Console.WriteLine(amount*discountRate/100);

// question 3
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());
for(int i=1; i<13; i++){
    Console.WriteLine(i + " " + number*i);
}
// question 4
while(number != 0){
    Console.WriteLine("------------- MENU --------------\n[1] Calculate Body Mass Index\n[2] Calculate Discount\n[3] Display Multiplication Table\n[0] Exit\n---------------------------------");
    number = int.Parse(Console.ReadLine());
}

// question 5
List<string> words = new List<string>();
string inputWord = "";
int letters = 0;
while(true){
    Console.Write("Enter a word (or 'x' to stop): ");
    inputWord = Console.ReadLine();
    letters += inputWord.Length;
    if(inputWord == "x" || words.Count()==5)break;
    words.Add(inputWord);
}
Console.WriteLine("List of words:");
foreach(string word in words){
    Console.WriteLine("- " + word);
}
Console.WriteLine("Total number of letters: " + letters);

// question 6
Random random = new Random();
number = random.Next(1,100);
int guessNumber = 0;
for(int i=1; i<6; i++){
    Console.Write("Guess the number (between 1 and 100, or enter -1 to quit): ");
    guessNumber = int.Parse(Console.ReadLine());
    if(guessNumber<0) break;
    if(guessNumber>number) Console.WriteLine("Too high!");
    else if(guessNumber<number) Console.WriteLine("Too low!");
    else{
        Console.WriteLine("Congratulations! You guessed the correct number in " + i + " tries.");
        break;
    }
}
*/