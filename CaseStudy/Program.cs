using CaseStudy;
    
    Console.WriteLine("Book Market:");
    Console.WriteLine("1. Add Book \n 2. Add Customer Details \n 3. Place Order");
    Console.WriteLine("Select Option");
    Order order = new Order();
    int option = Convert.ToInt32(Console.ReadLine());
BookType[] bookTypes = new BookType[]
{
        new("Two States", "Chetan Bagath", 31, 145,"Yes", "Non-Fiction"),
        new("W", "Kim Seo Joon", 89, 350,"Yes", "Fiction")
    };
switch (option)
{
    case 1:
        Console.WriteLine("Added Books");
        foreach (BookType bookType1 in bookTypes)
        {
            bookType1.DisplayBookDetails();
        }
        break;

    case 2:
        Console.WriteLine("Enter CId:");
        int CId = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Customer Name:");
        string? cName = Console.ReadLine();
        Console.WriteLine("Enter Phone Number:");
        double phoneNumber = Convert.ToDouble(Console.ReadLine());
        Customer customer = new Customer(cName, phoneNumber, CId);
        customer.DisplayCustomerDetails();
        break;
    case 3:
        Console.WriteLine("Enter Book Details:");
        string? title = Console.ReadLine();
        foreach (var book in bookTypes)
        {
            if (book.Title.Equals(title))
            {
                Console.WriteLine("Enter the Order Date:");
                order.OrderDate = Console.ReadLine();
                Console.WriteLine("Order Confirmed");
                Console.WriteLine("Book Title : {0}, Book Price : {1}, Book Availability :{2}", book.Title, book.Price, book.Availability);
                order.Cost = book.Price;
                Console.WriteLine("Cost :", order.Cost);

            }
            else
            {
                Console.WriteLine("Book is not Available");
            }
        }
        break;
}