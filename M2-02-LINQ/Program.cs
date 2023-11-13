using M2_02;
    
Console.WriteLine("Hello! Your program has started 🆕");

// Fetch data from PersonDataStorage class
var people = PersonDataStorage.People;





// Opgave 1 - lav loops om til LINQ
// 1.1 Udregn den samlede alder for alle mennesker

// var totalAge = people.Aggregate(0,(sum, next) => sum + next.Age);
var totalAge = people.Sum(p => p.Age);

// 1.1 Tæl hvor mange der hedder Nielsen

// var countNielsen = people.Aggregate(0, (count, next) => count + (next.Name.Contains("Nielsen") ? 1 : 0));
var countNielsen = people.Count(person => person.Name.Contains("Nielsen"));

// 1.1 Find den ældste person
var oldestPerson = people.OrderByDescending(person => person.Age).First();

Console.WriteLine($"1.1 - Total age: {totalAge}");
Console.WriteLine($"1.1 - Count Nielsen: {countNielsen}");
Console.WriteLine($"1.1 - Oldest person: {oldestPerson.Name}");

// Opgave 2 - LINQ på et array

// Opgave 3 - Filter funktion til ord

// Opgave 4 - Bruger defineret BubbleSort

// Opgave 5 - Højere Ordens Funktion
