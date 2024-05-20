//1.Четем вход от конзолата
// - Брой страници в текущата книга - int
// - Страници, които прочита за 1 час - int
// - Броят на дните, за които трябва да прочете книгата - int
//2.Намираме общо време за четене на книгата (брой страници / страници, които прочита за 1 час)
//3.Намираме колко са необходимите часове на ден (общо време за четене / броя на дните)
//4. Отпечатваме резултата на конзолата 
int pages = int.Parse(Console.ReadLine());
int pagesPerHours = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());
int hoursPerDay = (pages / pagesPerHours) / days;
Console.WriteLine(hoursPerDay);