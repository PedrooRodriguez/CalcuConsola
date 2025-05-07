
using calcuPedro.Logica;

Calculadora calc = new();

Console.WriteLine("Ingrese el primer número: ");
string? input1 = Console.ReadLine();
if (!double.TryParse(input1, out double n1))
{
    Console.WriteLine("Número inválido.");
    return;
}

Console.WriteLine("Ingrese el segundo número: ");
string? input2 = Console.ReadLine();
if (!double.TryParse(input2, out double n2))
{
    Console.WriteLine("Número inválido.");
    return;
}

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
        }
    }
    else{
        Console.WriteLine("Opcion invalida.");
        return;
    }

Console.WriteLine("Resultado: "+res);