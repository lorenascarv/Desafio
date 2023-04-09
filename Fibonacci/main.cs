using System;

class Program {
  public static void Main (string[] args) {
    int n, a = 0, b = 1;
    bool numero = false;

    Console.WriteLine("Digite um número: ");
    n = int.Parse(Console.ReadLine());
    
    while (b<=n){
      int c = a + b;
      a = b;
      b = c;
      if (b == n){
        numero = true;
      }  
    }

    if (numero) {
      Console.WriteLine("O número digitado faz parte da sequência de Fibonacci");
    }
    else {
      Console.WriteLine("O número digitado não faz parte da sequência de Fibonacci");
    }
    
  }
}