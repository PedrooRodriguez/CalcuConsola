
using System.Runtime.InteropServices.Marshalling;
using calcuPedro.Logica;

Calculadora calc = new();

Console.WriteLine("-------------Bienvenido a Calculadora-------------");

string continuar = "si";
do{
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine("Ingrese el primer numero: ");
        double n1= double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo numero: ");
        double n2= double.Parse(Console.ReadLine());

    Console.WriteLine("Selecciona Suma(s), Resta(r), Division(d), Multiplicar(m)");
        string opcion= Console.ReadLine();

    double res = 0;

        if(opcion=="s"){
            res=calc.Sumar(n1,n2);
        }
        else if(opcion=="r"){
            res=calc.Restar(n1,n2);
        }
        else if(opcion=="m"){
            res=calc.Multiplicar(n1,n2);
        }
        else if(opcion=="d"){
            if(n2!=0){
                res=calc.Dividir(n1,n2);
            }
            else{
                Console.Write("No se puede dividir entre 0!!!");
                continue;
            }
        }
        else{
            Console.WriteLine("Opcion invalida.");
            continue;
        }
    Console.WriteLine("Resultado: "+res);

    Console.WriteLine("Desea continuar? si/no");
    continuar= Console.ReadLine()??"no";

}while(continuar.ToLower()=="si");