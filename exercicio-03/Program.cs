Console.WriteLine($"Digite o nome do produto: ");
string nome = Console.ReadLine();

Console.WriteLine($"Digite a quantidade adquirida: ");
int quantidade = int.Parse(Console.ReadLine());

Console.WriteLine($"Digite o preco unitario: ");
float preco = float.Parse(Console.ReadLine());

static float desconto (int quantidade, float preco)
{
    if(quantidade <=5)
    {
        return preco- preco * 0.02F;
    }
    else if(quantidade >5 && quantidade <= 10)
    {
       return preco - preco*0.03F;
    }
    else if (quantidade > 10)
    {
      return  preco - preco*0.05F;
    }
    else
    {
        return 0;
    }
}

Console.WriteLine($"o preco ficou {desconto(quantidade,preco)} com o desconto.");


