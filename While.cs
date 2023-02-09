

Console.WriteLine("---Bucle While---");
/*Escribe una tabla de multiplicar del 1 al 10 para un número entero que recibe por consola. 
Es decir, un programa que presente para el 1:
1 x 1 = 1
1 x 2 = 2
…
1 x 10 = 10*/

Console.WriteLine("--Tablas De Multiplicar--\n");
Console.WriteLine("Ingrese el numero a multplicar:");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;

while (i <= 10)
{
    int resultado = num * i;
    Console.WriteLine($"{num} x {i} = {resultado}");
    i++;
}



