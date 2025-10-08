// See https://aka.ms/new-console-template for more information

char[] bokalak = new char[5] {'a','e','i','o','u'};

for(int i=0; i<bokalak.Length; i++)
{
    Console.WriteLine("Elemento {0}: {1}", i, bokalak[i]);
    
}
int[,] matriz1 = new int[3,2] { {1,2}, {3,8}, {4,6} };
for(int i=0; i<matriz1.GetLength(0); i++)
{
    Console.Write("Zutabe {0}: ", i+1);
    for(int j=0; j<matriz1.GetLength(1); j++)
    {
        Console.Write("{0} ", matriz1[i,j]);
    }
    Console.WriteLine();
    Console.WriteLine();
}
