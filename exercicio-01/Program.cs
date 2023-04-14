Console.WriteLine($"Digite o ano atual: ");
int anoatual = int .Parse(Console.ReadLine());


Console.WriteLine($"Insira seu ano de nascimento:");
int anonascimento = int.Parse(Console.ReadLine());

static int votacao(int anoatual, int anonascimento)
{
    return anoatual-anonascimento;
}

if( votacao(anoatual,anonascimento) < 16 )
{
    Console.WriteLine($"Voce nao pode votar! ");
    
}
else 
{
    Console.WriteLine($"Voce pode votar! ");
    
}