using ScreenSound.Modelos;

namespace ScreenSound.Menu;

public class Menu
{
    public void ExibirTituloDaOpcao(string titulo)
    {
        var quantidadeDeLetras = titulo.Length;
        var asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
    }
}