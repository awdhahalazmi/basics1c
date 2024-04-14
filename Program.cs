//Task 1&2
//Q1
const string name = "Awdhah";
int age = 23;
double gpa = 3.43;
Boolean is_gradutaed = true;
char letterGrade = 'A';
//Q2
string myAge = age.ToString();
int gpa_ = (int)gpa;
Console.WriteLine($"Name: {name} \n Age {age} \n graduated {is_gradutaed} \n letter grade {letterGrade} \n {myAge}");

// calculating rectangle Q2
Console.WriteLine("Enter Width");
double width = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Length");
double length = Convert.ToDouble(Console.ReadLine());
double area = width * length;
Console.WriteLine($"the area of the rectangle = {area: 00.00} ");

