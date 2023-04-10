using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Digite uma palavra: ");
    string a = Console.ReadLine();

    char[] caracteres = a.ToCharArray();
    int inicio = 0;
    int final = caracteres.Length - 1;

    while (inicio < final){
      char b = caracteres[inicio];
      caracteres[inicio] = caracteres[final];
      caracteres[final] = b;

      inicio++;
      final--;
    }
    string trocada = new string(caracteres);

    Console.WriteLine(trocada);
    
  }
}