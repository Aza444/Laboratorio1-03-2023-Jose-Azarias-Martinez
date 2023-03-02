using Laboratorio_1_Jose_Azarias_Martinez;
using Laboratorio_1_Jose_Azarias_Martinez.Negocio;
using System.Drawing;


Personas personas = new Personas();
ClsPersonas clsPersonas = new ClsPersonas(); 


Console.WriteLine("Ingrese su nombre");
string Nombre = Console.ReadLine();


Console.WriteLine("Ingrese su edad");
string Edad = Console.ReadLine();
int E = Convert.ToInt32(Edad);


Console.WriteLine("Ingrese su sexo,M(Hombre),M(MUJER)");
string Sexo = Console.ReadLine();


Console.WriteLine("Ingrese su peso");
string Peso = Console.ReadLine();
int P = Convert.ToInt32(Peso);


Console.WriteLine("Ingrese su altura");
string Altura = Console.ReadLine();
double A = Convert.ToDouble(Altura);


personas.Nombre = Nombre;
personas.Edad = E;
personas.Peso = P;
personas.Altura = A;


String Resultado = clsPersonas.calcularIMC(personas);
Console.WriteLine(Resultado);


String Result = clsPersonas.EsMayorDeEdad(personas);
Console.WriteLine(Result);

