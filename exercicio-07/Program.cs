float [] valores = new float[15];

for (int i = 0; i < 15; i++)
{
    Console.WriteLine($"Digite o {i+1}ª numero: ");
    valores[i]= float.Parse(Console.ReadLine());
    
}
for (int i = 14; i >= 0   ; i--)
{
    Console.WriteLine($" {i+1}ª numero: {valores[i]}");
    
}
