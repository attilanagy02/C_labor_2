using HelloCSharp;
using static System.Console;

Dog dog = new Dog
{
	Name = "Néró",
	DateOfBirth = new DateTime(2020, 06, 10),
	["ChipId"] = "abcd"
};

var watson = new Dog { Name = "Watson" };
var watson2 = new Dog { Name = watson.Name };
var watson3 = new DogRec(Guid.Empty, "Watson");
var watson4 = new DogRec(Guid.Empty, "Watson");
var watson5 = watson4 with { Name = "Sherlock" };
var watson6 = watson4 with { Name = "Sherlock", Metadata = new Dictionary<string, object>() };
var watson7 = watson6 with { Name = "Watson" };
watson7.Metadata.Add("Chip azonosító", "12345QQ");
var watson8 = new DogRecExt { Name = "Watson" };
watson8.DateOfBirth = DateTime.Now.AddYears(-15);
var watson9 = watson8 with { };

WriteLine(watson4);
WriteLine(watson5);
WriteLine(watson6);
WriteLine(watson8);
WriteLine(watson9);

/*List<Dog> dogs = 
[
	dog, 
	watson, 
	new Dog { Name = "unnamed", DateOfBirth = new DateTime(2022, 01, 01) }
];

List<Dog> dogs2 = [.. dogs, new Dog { Name = "test" }];

foreach (var d in dogs2)
	WriteLine($"{d} chip: {d["ChipId"]}");
*/
ReadKey();


