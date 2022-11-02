// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// this will throw an error as we can assign null value to value type;
DateTime date = null;

// this will not throw an error as datetime has been made of nullable type
DateTime? date1 = null;

// this will throw an error as date1 is og nullable type and date2 is not, what if date1 has null value to prevent this it will throw an compile time error
DateTime date2 = date1;

//alternative
DateTime date3 = date1 ?? DateTime.Today;

// OR
DateTime date4 = date1.GetValueOrDefault();

//OR
DateTime date5 = (date != null) ? date1.GetValueOrDefault() : DateTime.Today;
