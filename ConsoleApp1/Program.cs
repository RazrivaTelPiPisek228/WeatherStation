using Database;
Console.WriteLine(User.GetCounter());
User u1 = new User("Ja", 999);
User u2 = new User("Ja", 999);
Console.WriteLine(User.GetCounter());
User u3 = new User("Ja", 999);
User u4 = new User("Ja", 999);
User u5 = new User("Ja", 999);
User u6 = new User("Ja", 999);

Sensor s1 = new Sensor();

Console.WriteLine(User.GetCounter());