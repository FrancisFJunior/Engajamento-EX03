using System;

/*3- Crie um programa que funcione para uma votação eleitoral. Existem três candidatos:
33 - José Couve
25 - Joana Bravo
10 - Roberto Nove
0 - Voto branco
4 - Voto nulo

Deseja-se saber:
- O candidato vencedor;
- O total de votos em branco;
- O total de votos nulos;*/

class EX03Class {

  public static void Main (string[] args) {
    
    Console.WriteLine("-------------------");
    Console.WriteLine("33 - José Couve    ");
    Console.WriteLine("25 - Joana Bravo   ");
    Console.WriteLine("10 - Roberto Nove  ");
    Console.WriteLine("0  - Voto branco   ");
    Console.WriteLine("4  - Voto nulo     ");
    Console.WriteLine("1  - Sair          ");
    Console.WriteLine("-------------------");
    
    string vencedor = "nulo";
    int cand1 = 0;
    int cand2 = 0;
    int cand3 = 0;
    int branco = 0;
    int nulo = 0;
    int voto = 0;
    
    
    do{

      Console.Write("Digite seu voto: ");
      voto = int.Parse(Console.ReadLine());
      if(voto == 33){
        cand1=cand1 + 1;
      }else if(voto == 25){
        cand2=cand2 + 1;
      }else if(voto == 10){
        cand3=cand3 + 1;
      }else if(voto == 0){
        branco=branco + 1;
      }else if(voto == 4){
        nulo=nulo + 1;
      }else if(voto == 1){
        Console.WriteLine("\n");
      }else{
        Console.WriteLine("Opção invalida!! \n");
      }

    }while(voto != 1);

    if(cand1 > cand2 && cand1 > cand3){
      vencedor = "José Couve";
    }else if(cand2 > cand1 && cand2 > cand3){
      vencedor = "Joana Bravo";
    }else if(cand3 > cand1 && cand3 > cand2){
      vencedor = "Roberto Nove";
    }
    
    //CASO OUVEER EMPATE/NENHUM VOTO
    if(cand1 == cand2 && cand1 == cand3){
      vencedor = "**Não ouve vencedor**";
    }else if(cand2 == cand1 && cand2 == cand3){
      vencedor = "**Não ouve vencedor**";
    }else if(cand3 == cand1 && cand3 == cand2){
      vencedor = "**Não ouve vencedor**";
    }

    Console.WriteLine("Canditato vencedor: {0}",vencedor);
    Console.WriteLine("Total de votos em branco: {0}",branco);
    Console.WriteLine("Total de votos nulo: {0}",nulo);

  }
}