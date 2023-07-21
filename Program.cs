


using ConsoleApp1;

public class App
{   
    
        static void Main(string[] args)
        {
            
            Pessoa p = new Pessoa();
        
      Console.WriteLine("Entre com seus dados");
        Console.Write("Nome: ");
       
        
       p.nome= Console.ReadLine();
        Console.Clear();

      Console.WriteLine("Digite sua altura");
      p.altura = Convert.ToDouble(Console.ReadLine());
      Console.Clear();

      Console.WriteLine("Digite seu peso");
      p.peso = Convert.ToDouble(Console.ReadLine());
      Console.Clear();
      p.dados();
      p.tabela();  
    
        Console.ReadKey();
        
        }
    
}