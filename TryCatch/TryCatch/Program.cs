
try
{
    Console.Write("Informe o primeiro valor!");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Informe o segundo valor!");
    int b = Convert.ToInt32(Console.ReadLine());
    int r = a / b;
    Console.WriteLine($"O resultado é {r}");

}catch(DivideByZeroException ex)
{
    Console.WriteLine($"Não é permitido divisão por zero! + {ex.Message}");
}catch(InvalidCastException ex)
{
    Console.WriteLine($"Conversão de string para letra não é permitida! {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu um erro {ex.Message}");
}
finally
{
    Console.WriteLine("Aqui passa de qualquer forma!");
}