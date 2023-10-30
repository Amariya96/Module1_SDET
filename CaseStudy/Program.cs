using CaseStudy;
Customers cust21 = new Customers();
cust21.CustomerID = 1;
cust21.CustomerName = "Anu";
cust21.CustomerEmail = "anu@yahoo";
Customers.customersx.Add(cust21);
Customers cust22 = new Customers();
cust22.CustomerID = 2;
cust22.CustomerName = "Manu";
cust22.CustomerEmail = "manu@yahoo";
Customers.customersx.Add(cust22);
Customers cust23 = new Customers();
cust23.CustomerID = 3;
cust23.CustomerName = "Lilly";
cust23.CustomerEmail = "lilly@yahoo";
Customers.customersx.Add(cust23);

while (true)
{
    Console.WriteLine("Choose your option\n1.User\n2.Admin");
    int option = Convert.ToInt32(Console.ReadLine());

    if (option == 1)

    {
        Console.WriteLine("Enter the customer id");
        int cusId = Convert.ToInt32(Console.ReadLine());
        if (Customers.customersx.Find(x => x.CustomerID == cusId) == null)
        {
            Console.WriteLine("Customer not found");
            break;
        }
        while (true)
        {
            Console.WriteLine("choose your option\n1.Add product to cart\n2.View all product\n3.Place order\n4.Support\n5.View orders");
            int optionuser = Convert.ToInt32(Console.ReadLine());

            switch (optionuser)
            {

                case 1:

                    Console.WriteLine("Enter Product id for add to cart");
                    int productId = Convert.ToInt32(Console.ReadLine());
                    Customers customers = Customers.customersx.Find(x => x.CustomerID == cusId);
                    if (DigitalProduct.Products.Find(x => x.ProId == productId) == null)
                    {
                        if (PhysicalProduct.Products.Find(x => x.ProId == productId) == null)
                        {
                            Console.WriteLine("Invalid product id");
                        }
                        else
                        {
                            customers.ordersphy.Add(PhysicalProduct.Products.Find(x => x.ProId == productId));
                            Console.WriteLine("Product added to cart");
                        }
                    }
                    else
                    {
                        customers.orders.Add(DigitalProduct.Products.Find(x => x.ProId == productId));
                        Console.WriteLine("Product added to cart");
                    }
                    break;
                case 2:
                    Console.WriteLine("Products are");
                    if (DigitalProduct.Products.Count == 0 && PhysicalProduct.Products.Count == 0)
                    {
                        Console.WriteLine("No Product Found found");
                    }
                    foreach (var item in DigitalProduct.Products)
                    {
                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProId,
                            item.Name, item.Price, item.Quantity, item.FileFormat, item.Link);
                    }
                    foreach (var item in PhysicalProduct.Products)
                    {
                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                            "\tDimension:{5}", item.ProId,
                            item.Name, item.Price, item.Quantity, item.Quantity, item.Dimensions);
                    }
                    break;
                case 3:
                    Customers customer = Customers.customersx.Find(x => x.CustomerID == cusId);
                    if (customer.orders.Count == 0 && customer.ordersphy.Count == 0)
                    {
                        Console.WriteLine("No product found in cart");
                    }
                    else
                    {
                        foreach (var item in customer.orders)
                        {
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProId,
                             item.Name, item.Price, item.Quantity, item.FileFormat, item.Link);
                            item.PlaceOrder();
                            item.ProcessPayments();
                            item.DeliverProducts();

                        }
                        foreach (var item in customer.ordersphy)
                        {
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                           "\tDimension:{5}", item.ProId,
                           item.Name, item.Price, item.Quantity, item.Quantity, item.Dimensions);
                            item.PlaceOrder();
                            item.ProcessPayments();
                            item.DeliverProducts();
                        }
                        Console.WriteLine("Do you want to place all the order\n1.yes\n2.no");
                        int confirm = Convert.ToInt32(Console.ReadLine());
                        if (confirm == 1)
                        {
                            customer.confirmedorders.AddRange(customer.orders);
                            customer.orders.Clear();
                            customer.confirmedordersphy.AddRange(customer.ordersphy);
                            customer.ordersphy.Clear();
                            Console.WriteLine("Order placed successfully");
                        }
                        else
                        {
                            Console.WriteLine("Removing everything in cart");
                        }


                    }



                    break;
                case 4:
                    Console.WriteLine("For any support call to 7869054781");
                    break;
                case 5:
                    Customers customer2 = Customers.customersx.Find(x => x.CustomerID == cusId);
                    if (customer2.confirmedorders.Count == 0 && customer2.confirmedordersphy.Count == 0)
                    {
                        Console.WriteLine("No order details found");
                    }
                    else
                    {
                        Console.WriteLine("Orders are");
                        foreach (var item in customer2.confirmedorders)
                        {
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProId,
                            item.Name, item.Price, item.Quantity, item.FileFormat, item.Link);
                        }
                        foreach (var item in customer2.confirmedordersphy)
                        {
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                           "\tDimension:{5}", item.ProId,
                           item.Name, item.Price, item.Quantity, item.Quantity, item.Dimensions);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Invalid input");

                    break;
            }

            Console.WriteLine("Do you want to continue as user\n1.Yes\n2.No");
            int optuser = Convert.ToInt32(Console.ReadLine());
            if (optuser == 1)
            {
                continue;
            }
            else if (optuser == 2)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }


    }

    else if (option == 2)
    {
        Console.WriteLine("Choose option\n1.Add Product\n2.View report");
        int optionadmin = Convert.ToInt32(Console.ReadLine());
        if (optionadmin == 1)
        {
            Console.WriteLine("Choose the option \n1.Digital Product\n2.Physical Product");
            int optionProduct = Convert.ToInt32(Console.ReadLine());
            if (optionProduct == 1)
            {
                Console.WriteLine("Enter Product id");
                int productid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Product Name");
                string? productName = Console.ReadLine();
                Console.WriteLine("enter the price");
                double productCost = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the fileformat");
                string? fileFormat = Console.ReadLine();
                Console.WriteLine("Enter downloadLink");
                string? downloadLink = Console.ReadLine();
                Console.WriteLine("Enter the Quantity");
                int quantity = Convert.ToInt32(Console.ReadLine());


                DigitalProduct digitalProduct = new DigitalProduct();
                digitalProduct.Name = productName;
                digitalProduct.ProId = productid;
                digitalProduct.FileFormat = fileFormat;
                digitalProduct.Link = downloadLink;
                digitalProduct.Price = productCost;
                digitalProduct.Quantity = quantity;
                DigitalProduct.Products.Add(digitalProduct);
            }
            else if (optionProduct == 2)
            {
                Console.WriteLine("Enter Product id");
                int productid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Product Name");
                string? productName = Console.ReadLine();
                Console.WriteLine("enter the price");
                double productCost = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the Weight");
                int weight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter dimension");
                string? dimension = Console.ReadLine();
                Console.WriteLine("Enter the Quantity");
                int quantity = Convert.ToInt32(Console.ReadLine());

                PhysicalProduct physicalProduct = new PhysicalProduct();
                physicalProduct.Name = productName;
                physicalProduct.ProId = productid;
                physicalProduct.Price = productCost;
                physicalProduct.Dimensions = dimension;
                physicalProduct.Weight = weight;
                physicalProduct.Quantity = quantity;


                PhysicalProduct.Products.Add(physicalProduct);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
    else
    {
        Console.WriteLine("Invalid option");
    }
    Console.WriteLine("Do you want to continue\n1.Yes\n2.No");
    int opt = Convert.ToInt32(Console.ReadLine());
    if (opt == 1)
    {
        continue;
    }
    else if (opt == 2)
    {
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Invalid input");
    }

}

/*  
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

*/