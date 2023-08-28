int op1 = 0, op2 = 0;
int num1 = 0, num2 = 0, den1 = 0, den2 = 0, resul = 0;
int mcm1 = 0;
do
{




    Console.WriteLine("Bienvenido a la calculadora ");

    Console.WriteLine("1.Realizar operacion");
    Console.WriteLine("2.Salir.");
    op1 = Int32.Parse(Console.ReadLine());



    switch (op1)
    {
        case 1:

            Console.WriteLine("1.suma");
            Console.WriteLine("2.resta");
            Console.WriteLine("3.multiplicacion");
            Console.WriteLine("4.Division");
            op2 = Int32.Parse(Console.ReadLine());

            switch (op2)
            {
                case 1:
                    Console.WriteLine("Escribir el primer numerador: ");
                    num1 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Escribir el primer denominador: ");
                    den1 = Int32.Parse(Console.ReadLine());



                    Console.WriteLine("Escribir el segundo numerador: ");
                    num2 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Escribir el segundo denominador: ");
                    den2 = Int32.Parse(Console.ReadLine());


                    if (den1 == den2)
                    {

                        resul = num1 + num2;

                        Console.WriteLine("Resultado: " + resul + "/" + den1);

                        resul = (num1 + num2) / den1;
                        Console.WriteLine("Resultado simplificado: " + resul + "/" + den1);


                    }
                    if (den1 != den2)
                    {

                        mcm1 = den1 * den2;
                        resul = (num1 * den2) + (num2 * den1);

                        Console.WriteLine(resul + "/" + mcm1);

                        if (resul % 2 == 0 && mcm1 % 2 == 0)
                        {

                            resul = resul / 2;
                            mcm1 = mcm1 / 2;
                            Console.WriteLine("Resultado simplificado: " + resul + "/" + mcm1);
                        }

                    }




                    break;

                case 2:

                    Console.WriteLine("Escribir el primer numerador: ");
                    num1 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Escribir el primer denominador: ");
                    den1 = Int32.Parse(Console.ReadLine());



                    Console.WriteLine("Escribir el segundo numerador: ");
                    num2 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Escribir el segundo denominador: ");
                    den2 = Int32.Parse(Console.ReadLine());


                    if (den1 == den2)
                    {

                        resul = (num1 - num2);

                        Console.WriteLine("Resultado: " + resul + "/" + den1);

                        resul = (num1 - num2) / den1;

                        if (resul == 0)
                        {
                            resul = resul + 1;
                        }
                        Console.WriteLine("Resultado simplificado: " + resul + "/" + den1);


                    }
                    if (den1 != den2)
                    {

                        mcm1 = den1 * den2;
                        resul = (num1 * den2) - (num2 * den1);

                        Console.WriteLine(resul + "/" + mcm1);

                        if (resul % 2 == 0 && mcm1 % 2 == 0)
                        {

                            resul = resul / 2;
                            mcm1 = mcm1 / 2;
                            Console.WriteLine("Resultado simplificado: " + resul + "/" + mcm1);
                        }


                    }

                    break;

                case 3:

                    Console.WriteLine("Escribir el primer numerador: ");
                    num1 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Escribir el primer denominador: ");
                    den1 = Int32.Parse(Console.ReadLine());



                    Console.WriteLine("Escribir el segundo numerador: ");
                    num2 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Escribir el segundo denominador: ");
                    den2 = Int32.Parse(Console.ReadLine());


                    resul = num1 * num2;
                    mcm1 = den1 * den2;
                    Console.WriteLine("Resultado: " + resul + "/" + mcm1);

                    if (resul % 2 == 0 && mcm1 % 2 == 0)
                    {

                        resul = resul / 2;
                        mcm1 = mcm1 / 2;
                        Console.WriteLine("Resultado simplificado: " + resul + "/" + mcm1);
                    }




                    break;


                case 4:

                    Console.WriteLine("Escribir el primer numerador: ");
                    num1 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Escribir el primer denominador: ");
                    den1 = Int32.Parse(Console.ReadLine());



                    Console.WriteLine("Escribir el segundo numerador: ");
                    num2 = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Escribir el segundo denominador: ");
                    den2 = Int32.Parse(Console.ReadLine());


                    if (num1 == 0 || num2 == 0 || den1 == 0 || den2 == 0)
                    {
                        Console.WriteLine("Error no se puede dividir entre 0 ");
                    }
                    else
                    {
                        resul = num1 * den2;
                        mcm1 = den1 * num2;
                        Console.WriteLine("Resultado: " + resul + "/" + mcm1);

                        if (resul % 2 == 0 && mcm1 % 2 == 0)
                        {

                            resul = resul / 2;
                            mcm1 = mcm1 / 2;
                            Console.WriteLine("Resultado simplificado: " + resul + "/" + mcm1);
                        }


                    }


                    break;

                default:

                    break;
            }

            break;


        case 2:
            Environment.Exit(0);

            break;

        default:

            break;
    }






} while (op1 == 1 || op1 == 2);
