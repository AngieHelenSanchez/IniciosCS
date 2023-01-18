// De la siguiente forma concatenamos una variable con una cadena de caracteres:
string firstName = "Bob";
string message = "Hello" + firstName;
Console.WriteLine(message);

//Concatenar varias variables y cadenas literales.
string firstName = "Bob";
string greeting = "Hello";
string message = greeting + " " + firstName + "!";
Console.WriteLine(message);

//--------------sin variable intermedia
string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");

//Interpolación de cadenas
string firstName = "Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);

//Interpolación de cadenas con varias variables y cadenas literales
string firstName = "Bob";
string greeting = "Hello";
string message = $"{greeting} {firstName}!";
Console.WriteLine(message);

//-------------sin variable intermedia
string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine($"{greeting} {firstName}!");

// Combinar los literales textuales y la interpolación de cadenas
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

//Ejercicio general
string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");
            
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");