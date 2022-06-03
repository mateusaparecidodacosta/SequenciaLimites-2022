int inicio, fim;

Console.Clear();
Console.WriteLine("-----Sequência-----\n");

Console.Write("Insira o número de início: ");
inicio = Convert.ToInt32(Console.ReadLine());
Console.Write("Insira o número de término: ");
fim = Convert.ToInt32(Console.ReadLine());

if (fim < inicio)
{
    // Mensagem de erro
    Console.Beep();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nO número de término deve ser maior que o de início!");
    Console.ResetColor();
}
else
{
    Console.WriteLine($"\nSequência de {inicio} a {fim}\n");

    Console.ForegroundColor = ConsoleColor.DarkGreen;
    while (inicio <= fim)
    {
        Console.Write($"{inicio} ");
        inicio++;
    }
    Console.ResetColor();

    Console.WriteLine();
}


// Pausa para o usuário ver o resultado
Console.Write("\nPressione uma tecla para finalizar... ");
Console.ReadKey();

// Só acontece após o usuario pressionar uma tecla
Console.Clear();