// See https://aka.ms/new-console-template for more information
using LambdaExpression;
Books books3 = new Books();

Books books = new Books() { Title = "Economics", price= 500};
Books books1 = new Books() { Title = "Maths", price = 100 };
Books books2 = new Books() { Title = "Economics", price = 200 };

books3.book.Add(books1);
books3.book.Add(books);
books3.book.Add(books2);

Action<List<Books>> isCheap = (books) =>
{
    foreach (var book in books) 
    {
        if (book.price < 400) 
        {
            Console.WriteLine($"{book.Title}  {book.price}");
        }    
    }
};

isCheap(books3.book);

// OR

var cheapBook = books3.book.FindAll(book => book.price < 400);

foreach (var v in cheapBook) 
{
    Console.WriteLine($"{v.Title}  {v.price}");
}






// have the return type
Func<int,int> multiplier1 = (number) => {
    Console.WriteLine(number * 5);
    return number * 5;
    };
Console.WriteLine(multiplier1(5));

// Does not give return value
Action<int> multiplier = (number) => Console.WriteLine(number * 5);
multiplier(5);



Console.WriteLine();
