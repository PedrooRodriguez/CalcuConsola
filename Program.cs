
using calcuPedro.Logica;

Calculadora calc = new();

Console.WriteLine("Ingrese el primer numero: ");
    double n1= double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero: ");
    double n2= double.Parse(Console.ReadLine());

Console.WriteLine("Selecciona Suma(s), Resta(r), Division(d), Multiplicar(m)");
    string opcion= Console.ReadLine();

double res = 0;

    if(opcion=="s"){
        res=opcion=="s"?calc.Sumar(n1,n2):0;
    }
    else if(opcion=="r"){
        res=opcion=="r"?calc.Restar(n1,n2):0;
    }
    else if(opcion=="m"){
        res=opcion=="m"?calc.Multiplicar(n1,n2):0;
    }
    else if(opcion=="d"){
        if(n2!=0){
            res=opcion=="d"?calc.Dividir(n1,n2):0;
        }
        else{
            Console.Write("No se puede dividir entre 0!!!");
        }
    }
    else{
        Console.WriteLine("Opcion invalida.");
        return;
    }

Console.WriteLine("Resultado: "+res);