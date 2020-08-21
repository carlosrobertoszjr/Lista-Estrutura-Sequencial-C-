using System;
class MainClass {

// 3) SOMA DE DOIS número

  public static void Exerc03 (float num1, float num2) {
    Console.WriteLine (" A soma dos números é {0,1}", num1+num2);
    }

  public static void Main () {
    float num1;
    float num2;
  
    //TYPECAST
    Console.Write("Digite o primeiro número >> ");
    num1 = float.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número >> ");
    num2 = float.Parse(Console.ReadLine());
    Exerc03(num1,num2);
    
  }



// 4) Faça um Programa que peça as 4 notas bimestrais e mostre a média
 
class MainClass {
  public static void Exerc04 (float num1, float num2, float num3, float num4, float media) {
    Console.WriteLine("A média das notas é " + media);
    }

  public static void Main () {
    float num1;
    float num2;
    float num3;
    float num4;
    

  
    //TYPECAST
    Console.Write("Digite o primeiro número >> ");
    num1 = float.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número >> ");
    num2 = float.Parse(Console.ReadLine());
    Console.Write("Digite o terceiro número >> ");
    num3 = float.Parse(Console.ReadLine());
    Console.Write("Digite o quarto número >> ");
    num4 = float.Parse(Console.ReadLine());
    float media = ((num1+num2+num3+num4) / 4);
    Exerc04(num1,num2,num3,num4,media);
    
  }
    
}
