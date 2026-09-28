namespace Session07_Basics
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //var firstName = "Instant";
            //var lastName = "Academy";

            ////var fullName ="The First Name IS :" +  firstName + " And The Last Name is " + lastName;
            //var fullName = $"The First Name is : {firstName} And the Last Name is : {lastName}"; // String Interpolation
            //Console.WriteLine(fullName); // cw + tab

            //int a = 10;
            //int b = 15;
            //var sum = a + b;
            //var sub = a - b;
            //var mul = a * b;
            //var div = b / a;
            //var mod = b % a;
            //Console.WriteLine($"sum is : {sum} , sub is : {sub} , mul is : {mul} , div is : {div} , mod is : {mod}");
            //Console.WriteLine((float)b / a);

            //Console.WriteLine(b > a);
            //Console.WriteLine(b < a);
            //Console.WriteLine(b == a);
            //Console.WriteLine(b != a);
            //Console.WriteLine(b <= a);
            //Console.WriteLine(b >= a);

            //Console.Write("Enter Your Name:");
            //var name = Console.ReadLine();
            //Console.Write("Enter Your Age:");
            //var age = Console.ReadLine();
            //int userAge = Convert.ToInt32(age);

            //Console.WriteLine($"Your Name is : {name} and You are {age} years old!");
            //int userAge2 = int.Parse(age);

            //Console.WriteLine("Enter your score (0-100)");
            //float score = Convert.ToSingle(Console.ReadLine());

            //if (score >= 90)
            //{
            //    Console.WriteLine("Grade: A - Excellent!");
            //}
            //else if (score >= 75)
            //{
            //    Console.WriteLine("Grade: B - Good Work!");
            //}
            //else if (score >= 55)
            //{
            //    Console.WriteLine("Grade: C - Passed");
            //}
            //else
            //{
            //    Console.WriteLine("Grade : F - Let's Try one more time");
            //}

            //int temp = 55;
            //bool isSunny = false;

            //if(temp > 25 && isSunny)
            //{
            //    Console.WriteLine("Let's Swim right now");
            //}

            //if(temp < 0 || temp > 40)
            //{
            //    Console.WriteLine("Dangerous weather : Stay home");
            //}

            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine($"Round{i}");
            //}

            var countdown = 5;
            while (countdown > 0)
            {
                Console.WriteLine($"Round{countdown}");
                countdown--;
            }
            Console.WriteLine("Done");
            // 0xc0001123

            // Stack                             Heap
            // Int[]arr1 = 0xc000123             {1,2,3}
            // Int[]arr2 = 0xc000123
            // 
            int number = 42;
            object box = number; // boxing : wraps value type in a heap object
            int unboxing = (int)box;
            Console.WriteLine(unboxing);

            string message = "not null";
            string result = (message == null) ? "message is null" : message.Length.ToString();
            //Console.WriteLine(message??"message is null");
            //string message2 = message ?? "message is null"; 
            // ternary operator : var variableName = (condition) ? trueResult : flaseResult;
            // null coalescing opreator :var variableName = variableName ?? defaultValue;
            int? number1 = null;
            int? number2;
            if ((number1 == 0))
            {
                number2 = 10;
            }
            else
            {
                number2 = number1;
            }

            int? number3 = number1 ?? 10;

            Console.WriteLine($"number1 is : {number1} , number2 is : {number2} , number3 is : {number3}");

            //if (message != null)
            //{
            //    Console.WriteLine(message.Length);
            //}
            //else
            //{
            //    Console.WriteLine("Message is null , please check your code/message");
            //}
            Console.WriteLine(result);
        }
    }
}
