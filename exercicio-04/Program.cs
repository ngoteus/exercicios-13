
int valorMaior=0;
int valorMenor=0;

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"Digite um valor: ");
    int valor = int.Parse(Console.ReadLine());
   if(i==1)
    {
        valorMaior=valor;
        valorMenor=valor;
    }
    else
    {
        if(valor > valorMaior )
        {
            valorMaior = valor;
        }
        else if ( valor < valorMenor )
        {
            valorMenor = valor;
        }
    }
      
}
Console.WriteLine($"Maior valor: {valorMaior}");
Console.WriteLine($"Menor valor: {valorMenor}");


  

   
