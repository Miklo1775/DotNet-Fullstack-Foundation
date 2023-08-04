using ADEL;
using System.Globalization;
using System.Linq.Expressions;


//anon types remind me of objects in JS


//var kittyName = new
//{
//    firstName = "Chichi",
//    lastName = "Cheddar",
//    age = 12,
//    personality = new
//    {
//        food = "Tuna",
//        toy = "Springy toy",
//        energyLevel = "High"
//    },
//    projects = new[]
//    {
//        new {projectName = "test", duration = "10hrs"},
//        new {projectName = "test2", duration = "8hrs"},
//        new {projectName = "test3", duration = "6hrs" }
//    }
//};

//Console.WriteLine(kittyName.firstName);
//Console.WriteLine(kittyName.lastName);
//Console.WriteLine(kittyName.age);
//Console.WriteLine(kittyName.personality.food);
//Console.WriteLine(kittyName.personality.toy);
//Console.WriteLine(kittyName.personality.energyLevel);
//Console.WriteLine(kittyName.projects[0].projectName);
//Console.WriteLine(kittyName.projects[1].duration);
//Console.WriteLine(kittyName.projects[2]);

//CalculateDelegate c1 = new CalculateDelegate(DelegateExample.addition);
//CalculateDelegate c2 = new CalculateDelegate(DelegateExample.multiplication);
//c1(100);
//Console.WriteLine(DelegateExample.getNumber());
//c2(200);
//Console.WriteLine(DelegateExample.getNumber());

//CalculateDelegate c1 = new CalculateDelegate(DelegateExample.addition);
//c1(100);
//Console.WriteLine(DelegateExample.getNumber());
//c1 = new CalculateDelegate(DelegateExample.multiplication);
//c1(2);
//Console.WriteLine(DelegateExample.getNumber());
//c1(2);
//Console.Write(DelegateExample.getNumber());

//The subscriber model

//EventsExample events = new EventsExample();
//events.event_OddNumber += new EventsExample.delegate_OddNumber(EventMessage);

//events.addition();
//Console.ReadLine();
//static void EventMessage()
//{
//    Console.WriteLine("Event executed: Odd Number");
//}

//AnonMethods.InvokeMethod();

//Expression Lambda

//var numbers = new int[] { 2, 4, 6, 5, 5, 8, 1, 3, 7 };
//var count = numbers.Count(x => x == 5);
//Console.WriteLine(count);

////Statement Lambda

//List<int> numbers2 = new List<int> { 2, 4, 6, 5, 5, 8, 1, 3, 7 };

//var count1 = numbers.Count(x => { return x == 5; });

//Console.WriteLine(count1);

// Expression Tree

Func<string, string, string> stringJoins = (str1, str2) =>
{
    return str1 + str2;
};

Expression<Func<string, string, string>> stringJoinsExpr = (str1, str2) => string.Concat(str1, str2);

var func = stringJoinsExpr.Compile();
var result = func("Hello", "World");

Console.WriteLine(result);

//OR

var result1 = stringJoinsExpr.Compile()("Goodbye", "World");

Console.WriteLine(result1);