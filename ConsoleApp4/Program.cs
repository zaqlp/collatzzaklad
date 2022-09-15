// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string zadanecislo;
long i;
long start = 0;
long pocet = 0;
zadanecislo =Console.ReadLine();
start= long.Parse(zadanecislo);

    
    i = start;
    pocet = 0;
    while (i > 1)
    {

        if (i % 2 == 0)
        {

            i = i / 2;

            pocet++;
        }
        else
        {

            i = i * 3;
            i++;

            pocet++;
        }
    }



Console.WriteLine(pocet);

