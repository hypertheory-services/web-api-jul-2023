


using NullablesAndRecords;


//var emp1 = new Employee
//{
//    Id = 1,
//    Name = "Bob Smith"
//};

//var emp2 = new Employee
//{
//    Id = 1,
//    Name = "Bob Smith"
//};


//if (emp1 == emp2)
//{
//    Console.WriteLine("They are the same");
//} else
//{
//    Console.WriteLine("They are different");
//}
//var response = Utils.FormatName("Han", "Solo");
//Console.WriteLine(response.FullName);
//Console.WriteLine(new String('=', response.NumberOfLetters));

var dev = new EmployeeSummaryResponseModel(99, "Joe", "Schmidt", "DEV");


//var movedDev = new EmployeeSummaryResponseModel(dev.Id, dev.FirstName, dev.LastName, "QA");
var movedDev = dev with { Department = "QA" };
Console.WriteLine(dev);
Console.WriteLine(movedDev);

//Console.WriteLine(dev);



//using NullablesAndRecords;

//Console.WriteLine("Hello, World!");
//var c = new Customer();

//if (c.Name is not null)
//{
//    c.Name = c.Name.ToUpper();
//}

//c.Friends.Add("Bill");

//Console.WriteLine($"The id is {c.Id}");
//Console.WriteLine($"The name is {c.Name}");
//Console.WriteLine($"The birthday is {c.Birthday}");
//Console.WriteLine(c.GetInfo());

//var name = null ?? null ?? null ?? "Tacos" ?? null ?? "Enchiladas";

//Console.WriteLine( name);
//// Tony Hoare