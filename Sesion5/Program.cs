// ----- If -----

double price = 345098;
double percentage = 100.0;
double percentageDiscount = 19.0;

Console.WriteLine("Escriba su nombre: \n");
string name = Console.ReadLine();
Console.WriteLine("Escriba su email: \n");
string email = Console.ReadLine();

if (!email.Contains('@'))
{
    Console.WriteLine("EL correo no es valido\n");
}

Console.WriteLine("¿Cuenta con algún cupón? Escriba (si o no)\n");
string cupon = Console.ReadLine();

if (cupon == "si")
{
    double actualPrice = price - (percentageDiscount / percentage);
    Console.WriteLine($"El cliente {name} tiene un cupón de descuento\n");
    Console.Write($"El precio del producto es el siguiente {price}\n");
    Console.WriteLine($"El descuento por tener un cupón es de {actualPrice}\n");

}
else if (cupon == "no")
{
    Console.WriteLine($"El cliente {name} no tiene un cupón de descuento\n");
    Console.Write($"El precio del producto es el siguiente {price}\n");
}
else
{
    Console.WriteLine("Opción no valida\n");
}

// ----- Switch -----

string[] lenguajes = { "C#", "JavaScript", "Python", "React", "Angular", "NodeJS" };

Console.WriteLine("Selecciona un lenguaje de programación:");
for (int i = 0; i < lenguajes.Length; i++)
{
    Console.WriteLine($"{i + 1}. {lenguajes[i]}");
}

Console.WriteLine("O selecciona una letra correspondiente al lenguaje:");
for (int i = 0; i < lenguajes.Length; i++)
{
    Console.WriteLine($"{(char)('a' + i)}. {lenguajes[i]}");
}

Console.Write("Tu selección: ");
string opcion = Console.ReadLine();

switch (opcion)
{
    case "1":
    case "a":
        Console.WriteLine("Has seleccionado C#.");
        Console.WriteLine("Hola, mundo!");
        break;
    case "2":
    case "b":
        Console.WriteLine("Has seleccionado JavaScript.");
        break;
    case "3":
    case "c":
        Console.WriteLine("Has seleccionado Python.");
        break;
    case "4":
    case "d":
        Console.WriteLine("Has seleccionado React");
        break;
    case "5":
    case "e":
        Console.WriteLine("Has seleecionado Angular");
        break;
    case "6":
    case "f":
        Console.WriteLine("Has seleccionado NodeJS");
        break;
    default:
        Console.WriteLine("Opción inválida.");
        break;
}

Console.ReadLine();