 int numero,A,B,C,Suma,res;



 do {


     Console.WriteLine("Ingrese el numero : ");
     numero = Int32.Parse(Console.ReadLine());

     if (numero % 5 == 0)
     {
         if (numero % 2 == 0 || numero % 3 == 0)
         {
             Console.WriteLine("No es un numero especial ");
             

         }
         else
         {
             A = numero % 10;
             numero = numero / 10;
             B = numero % 10;
             numero = numero / 10;
             C = numero % 10;
             Suma = A + B + C;

             if (Suma > 10)
             {

                 Console.WriteLine("Si es un numero especial ");

             }
             else {

                 Console.WriteLine("No es un numero especial ");
             }



         }

     }
     else
     {
         Console.WriteLine("No es un numero especial ");
         
     }


     Console.WriteLine("Desea seguir jugando?\n" + "1.SI\n" + "2NO");
     res = Int32.Parse(Console.ReadLine());



 } while (res==1);



