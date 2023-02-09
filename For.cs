/*Escribe un programa que realice estos pasos:
Reciba 3 datos:
ancho
alto
relleno o no
Dibuje en consola con un mismo caracter, por ejemplo *, un rectángulo de las dimensiones introducidas 
y use el tercer dato para discernir si el rectángulo está relleno (tiene más * dentro) o no.
En caso de recibir el mismo número n dos veces debe dibujar un cuadrado de lado n.

Reto: Extiende el programa anterior para recibir otro número que sea el número de cuadrados o rectángulos 
que se deben dibujar en la pantalla. Ejemplos:
Input: 2,2,2, relleno = true
Output:
** **
** **
Input: 3, 4, 1, relleno = false
Output:
***
* *
* *
***    */

Console.WriteLine("----Bucle For----");

Console.WriteLine("Ingrese cantidad de cuadros a dibujar:");
int cant = Convert.ToInt32(Console.ReadLine());
int c;

Console.WriteLine("Ingrese dimension de anchura:");
int ancho = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese dimension de altura:");
int alto = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Desea rellenar con * ? S/N ");
string rellenar = Console.ReadLine();


for (c = 0; c < cant; c++)
{
    llenar(ancho, alto, rellenar);
    vacio(rellenar, ancho, alto);
}
Console.Write(" ");


//Rectangulo relleno
static void llenar(int ancho, int alto, string rellenar)
{
    while (rellenar == "S")
    {
        for (int i = 1; i <= ancho; i++)
        {
            for (int j = 1; j <= alto; j++)
            {
                Console.Write("* ", j);
            }
            Console.Write("  ");
        }

        Console.WriteLine("  ");
        return;
    }

}


//Rectangulo Vacio 
static void vacio(string rellenar, int ancho, int alto)
{
    string Simb;
    while (rellenar == "N")
    {
        Simb = new string('*', ancho);

        for (int i = 0; i < alto; i++)
        {
            if (i == 0 || i == (alto - 1))
            {
                Console.WriteLine(Simb);
            }
            else
            {
                Console.WriteLine("*{0," + (ancho - 2) + "}*", ' ');
            }
        }
        return;
    }
    Console.Write("  ");

}
















