  int i = 0, j = 0, ran1, ran2, res = 0, intentos, res2 = 0;
  Random rand = new Random();
 

  do {


      Console.WriteLine("Indique el rango de las tablas de multiplicar :");
      Console.WriteLine("Desde :");
      ran1 = Int32.Parse(Console.ReadLine());

      Console.WriteLine("Hasta :");
      ran2 = Int32.Parse(Console.ReadLine());

      for (i = ran1; i <= ran2; i++)
      {
          int NumAl = rand.Next(1, 10);

          Console.WriteLine("\n Tabla del : " + i);
          Console.WriteLine("-----------------------");

          for (j = 1; j <= 10; j++)
          {

              
              if (NumAl == j)
              {
                  Console.WriteLine(i + " x " + "?" + " = " + i * j);

           
              }
              else {
                  Console.WriteLine(i + " x " + j + " = " + i * j);
               
              }



          }


          do
          {
              Console.WriteLine("ADIVINA EL NUMERO");

              intentos = Int32.Parse(Console.ReadLine());
              Console.WriteLine(NumAl);
              if (intentos == NumAl)
              {
                  Console.WriteLine("HAS ADIVINADO EL NUMERO" + NumAl);

                  break;

              }
              else
              {
                  Console.WriteLine("PERDISTE SIGUE INTENTANDO");
                  Console.WriteLine("Desea seguir intentando?\n" + "1.SI\n" + "2NO");
                  res = Int32.Parse(Console.ReadLine());

              }



          } while (res!=2);


      }
    

      Console.WriteLine("Desea seguir jugando?\n"+ "1.SI\n"+"2NO");
      res = Int32.Parse(Console.ReadLine());


  } while (res == 1 );
          