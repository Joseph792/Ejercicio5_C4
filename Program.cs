// See https://aka.ms/new-console-template for more information
double edad1=0, edad2=0, edad3=0;
double men=0, may=0;

Console.WriteLine("Ingrese la primera edad");
edad1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese la segunda edad");
edad2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese la tercera edad");
edad3 = Convert.ToInt32(Console.ReadLine());

if(edad1 > edad2 && edad2 > edad3)
            {
                may = edad1;
            }
            else if(edad2 > edad3 && edad3 > edad1)
            {
                may = edad2;
            }
            else if(edad3 > edad2 && edad2 > edad1)
            {
                may = edad3;
            }

            if (edad1 < edad2 && edad2 < edad3)
            {
                men = edad1;
            }
            else if (edad2 < edad3 && edad3 < edad1)
            {
                men = edad2;
            }
            else if (edad3 < edad2 && edad2 < edad1)
                men = edad3;


Console.WriteLine("La edad Mayor es: "+ may);
Console.WriteLine($"La edad menor es: "+ men);

Console.ReadKey();
