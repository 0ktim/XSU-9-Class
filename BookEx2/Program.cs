using BookEx2;

BookClass book1 = new BookClass();
Console.WriteLine("Напишете заглавието на книгата: ");
book1.TitleOfTheBook = Console.ReadLine();
Console.WriteLine("Напишете автора на книгата: ");
book1.AuthorOfTheBook = Console.ReadLine();
Console.WriteLine("Напишете годината на издаване на книгата: ");
book1.AgeOfIzdavane = double.Parse(Console.ReadLine());
book1.Combined();