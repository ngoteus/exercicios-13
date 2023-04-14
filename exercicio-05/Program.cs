string busca;
string [] nomes = new string [10];
string resultado = "";

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Digite {i+1}ª nome sem repetir: "); 
   nomes[i]=Console.ReadLine();
   
}
Console.WriteLine($"Digite um nome para efetuar a busca: ");
busca = Console.ReadLine();
for (int i = 0; i < 10; i++)
{
    

if(nomes[i]==busca)
{
    resultado= "ACHEI";
    
}
else
{
    resultado="NAO ACHEI";
    
}
}
Console.WriteLine($"{resultado} o(a) {busca}");

