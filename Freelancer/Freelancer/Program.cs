// See https://aka.ms/new-console-template for more information
using Freelancer.Abstract;
using Freelancer.Entities;
using Freelancer.Services;

Console.WriteLine("Hello, World!");


/*Customer customer1 = new() {
    Id = Guid.NewGuid(),
    CreatedOn = DateTimeOffset.Now,
    FirstName = "Name Test 1",
    LastName = "Last Name Test 1",
    PhoneNumber = "0533 333 33 33",
};*/

/*ICsvConvertible freelancerInstance = new Freelancer.Entities.Freelancer()
{
    Id = Guid.NewGuid(),          // Replace with a valid GUID
    CreatedOn = DateTime.Now,    // Replace with the creation date
    FirstName = "John",
    LastName = "Doe",
    WorkExperience = "5 years of experience in web development",
    Reviews = new List<Review>
    {
        new Review { Text = "Excellent freelancer!", Rating = 5 },
        new Review { Text = "Great work!", Rating = 4 }
    }
};*/

var customerInstance = new Customer
{
    Id = Guid.NewGuid(),          // Replace with a valid GUID
    CreatedOn = DateTime.Now,    // Replace with the creation date
    FirstName = "Bob",
    LastName = "Smith",
    PhoneNumber = "555-123-4567" // Replace with an actual phone number
};

Console.WriteLine();
//Console.WriteLine(customer1.GetValuesCSV());

NotepadService notepadService = new();
//notepadService.SaveToNotepad(customerInstance);

//notepadService.SaveToNotepad(freelancerInstance);
//notepadService.SaveToNotepad(customer1.GetValuesCSV());


string customerData = notepadService.GetOnNotepad("C:\\Users\\livan\\source\\repos\\Freelancer\\Freelancer\\Database\\Customers.txt");

string[] splittedLines = customerData.Split("\n", StringSplitOptions.RemoveEmptyEntries);

List<Customer> customers = new();

foreach (var line in splittedLines)
{
    Customer customer = new();
    customer.SetValuesCSV(line);
    customers.Add(customer);
}