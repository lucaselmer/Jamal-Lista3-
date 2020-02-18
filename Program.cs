using System;
using System.IO;

namespace Jamal_Lista3_
{
    class Program
    {
        static void Main(string[] args)
        {

        /*              ** Para escrever Tabuada **
        try{

            using (StreamWriter escrita = new StreamWriter("save.txt")){
                int i;
                int num;
                Console.WriteLine("Qual a Tabuado desejada");
                num = Convert.ToInt32(Console.ReadLine());
                for(i=1; i<=10; i++) {                
                    escrita.WriteLine("\n" +num+" x "+i+" = "+num*i+"\n");
                    Console.WriteLine("\n" +num+" x "+i+" = "+num*i);
                }
                
            }
        } catch {

            }*/
        try{

            using (StreamReader leitura = new StreamReader("save.txt")){
                string line;
                while ((line = leitura.ReadLine()) != null){
                    Console.WriteLine(line);
                }

            }
        } catch(Exception e){
            Console.WriteLine(e.Message);
            }

        }
    }
}
