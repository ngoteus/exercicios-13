Console.WriteLine(@$"
Qual combustivel voce esta comprando:
Digite 'A' para Alcool
Ou Digite 'G' para Gasolina
");
char combustivel = char.Parse(Console.ReadLine());

Console.WriteLine($"Quantos litros voce ira comprar: ");
float litros = float.Parse(Console.ReadLine());

static float preco(char combustivel, float litros)
{
    if( combustivel == 'G')
    {
       
        if(litros <=20)
        {
           return  litros *5.30F - litros *5.30F *0.03F ;
        }
        else
        {
           return  litros *5.30F - litros *5.30F *0.05F ;
        }
    
    }
    else if(combustivel == 'A')
    {
       if (litros <=20)
        {
            return  litros*4.90F - litros*4.90F *0.04F ;
        }
        else
        {
            return litros *4.90F - litros *4.90F *0.06F ;
        }
       
    }
    else
    {
       return 0;
        
    }
    
    
}
Console.WriteLine($" Sua gasolina fica {preco(combustivel,litros)} com seu desconto.");



