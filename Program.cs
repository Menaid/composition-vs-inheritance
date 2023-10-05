using composition_vs_inheritance;

Console.WriteLine("Hello, world!");


User user = new User(username"jenseneducation.m.noltorp", email"manuel@nodehill.com");
User admin = new Admin();

admin.Age();
user.Age();