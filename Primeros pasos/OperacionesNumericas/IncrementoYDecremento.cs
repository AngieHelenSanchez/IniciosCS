//Operador +=, las líneas 3 y 4 son lo mimso:
int value = 0;
value = value +5;
value += 5;

//Operador ++, las líneas 8 y 9 son lo mismo:
int value = 0;
value = value +1;
value++;

//Estos son operadores de asignación compuesta: +=, -=, *=, ++, --

//Ejercicio de ejemplo 1:
int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

//Ejercicio 2. La diferencia de poner ++ antes o después del valor a recuperar
int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine("Second: " + value++);
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));
