// See https://aka.ms/new-console-template for more information
long maiorSequencia = 1;

for (long i = 1; i <= 1000000; i++)
{
    long numero = i;
    long count = 1;
    while (numero != 1)
    {
        if (numero % 2 == 0)
        {
            numero = numero / 2;
            count++;
        }
        else
        {
            numero = numero * 3 + 1;
            count++;
        }
    }
    
    if (count > maiorSequencia)
    {
       maiorSequencia = i; 
    }
    
}
System.Console.WriteLine("O número que produz a maior sequencia é: " + maiorSequencia);