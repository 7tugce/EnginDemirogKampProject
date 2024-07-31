using OOP2;

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Name = "Tuğçe";
customer1.Surname = "Özelmaci";
customer1.CustomerNUmber = "12345";
customer1.TcNumber = "123433554";
customer1.Id = 1;


CoorporateCustomer customer2 = new CoorporateCustomer();
customer2.Id = 2;
customer2.CustomerNUmber = "432423";
customer2.TaxNumber = "23272944";
customer2.CompanyName = "Kodlama.io";



Customer customer3 = new IndividualCustomer(); // müşteri referansını tutuyor
Customer customer4 = new CoorporateCustomer();

CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);


