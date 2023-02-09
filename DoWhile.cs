/*Escribe un programa que realice estos pasos:
Reciba al menos un número por consola
Determine si el número es positivo o negativo
Presente un contador para cada tipo (positivo y negativo).
Nota: el cero se puede abordar en una clase adicional ya que no es ni positivo ni negativo.
Tienes completa libertad para elegir el formato de la salida.*/

Console.WriteLine("----Bucle DoWhile----");
Console.WriteLine("---Numero Positivo o Negativo---");
Console.WriteLine("Ingrese el numero a validar:");
int num = Convert.ToInt32(Console.ReadLine());


do
{

    if (num < 0)//Validamos a 0 como numero neutro
    {
        Console.WriteLine($"{num} es un numero negativo ");

    }

    if (num > 0) //Numero positivo
    {
        Console.WriteLine($"{num} es Positivo "); 
      
    }

    else //numero negativo
    {
        Console.WriteLine($"{num} es Neutro "); 

    }
    return;
    
} while (num!=0);











