   int intento=10,NumBuenas=0;

   String[] Palabras = {"GATO","EN","JARDIN" };
   
   string palabra;
   do {

     
       for (int i = 1; intento <=10;i++) {

           Console.WriteLine("Intentos restantes : " + intento);

           Console.WriteLine("EL " + "____ " + " JUEGA " + "__ " + " EL " + "______");
           palabra= Console.ReadLine();

           if (palabra.ToUpper() == Palabras[0])
           {

               Console.WriteLine("HAS ADIVINADO");
               Console.WriteLine("EL " + Palabras[0] + " JUEGA " + "__ " + " EL " + "______");
               palabra = Console.ReadLine();

               if (palabra.ToUpper() == Palabras[1]) {

                   Console.WriteLine("HAS ADIVINADO");
                   Console.WriteLine("EL " + Palabras[0] + " JUEGA " + Palabras[1] + " EL " + "______");
                   palabra = Console.ReadLine();

                   if (palabra.ToUpper() == Palabras[2])
                   {
                       Console.WriteLine("HAS GANADO!");
                       Console.WriteLine("EL " + Palabras[0] + " JUEGA " + Palabras[1] + " EL " + Palabras[2]);

                       Console.WriteLine("PRESIONE CUALQUIER TECLA PARA FINALIZAR");
                       Console.ReadKey();
                       Environment.Exit(0);


                   }
                   else {
                       Console.WriteLine("TE HAS EQUIVOCADO");
                       intento -= 1;


                   }



               }
               else {
                   Console.WriteLine("TE HAS EQUIVOCADO");
                   intento -= 1;

               }


           }
           else {
               Console.WriteLine("TE HAS EQUIVOCADO");
               intento -= 1;
           }

       }
   
   
   }while(true);
