using System;
using System.Threading;
using System.Threading.Tasks;
namespace game {

 class MainClass {
  public static void Main() {
   Console.Clear();

   Console.WriteLine(@"__________ __________   ________ ");
   Console.WriteLine(@"\______   \\______   \ /  _____/ ");
   Console.WriteLine(@" |       _/ |     ___//   \  ___ ");
   Console.WriteLine(@" |    |   \ |    |    \    \_\  \");
   Console.WriteLine(@" |____|_  / |____|     \______  /");
   Console.WriteLine(@"        \/                    \/ ");



   Personagem p1 = new Personagem();
   Item v = new Item();

   Console.WriteLine("Seja bem vindo ...");
   Console.WriteLine("Qual era mesmo seu nome ? ");
   p1.setNome(Console.ReadLine());
   Console.Clear();
   Console.WriteLine(@"#----------------------------------#");
   Console.WriteLine(@" ");
   Console.WriteLine(" {0}, rápido pegue uma arma!", p1.getNome());
   Console.WriteLine(@" ");

   v.Espada();
   v.Machado();

   p1.setArma(Console.ReadLine());
   Console.Clear();
   Console.WriteLine(@"- {0} obteve {1} ", p1.getNome(), p1.getArma());

   if(p1.getArma() == "Espada"){
     v.Espada();
   }else{
      v.Machado();
      }

   Thread.Sleep(3000);
   Console.Clear();
   v.InimigoGoblin();
   Console.WriteLine(@"Goblin apareceu!");




  }
 }
}