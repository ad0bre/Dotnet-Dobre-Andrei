using System; //utilizeaza un namespace

namespace Dobre_Andrei //structura de organizare
{
    class Program // clasa ce contine membre (ex: functie, constructor)
    {
        static void Main(string[] args) //functie, contine instructiuni
        {
            //Console.WriteLine("Hello World!"); //instructiune (ce executa computerul)

            //functii de tip static si instance
            //Program myProgram = new Program(); //pentru a folosi o functie de tip instance, trebuie creat un obiect al clasei care are aceasta functie ca membru 
            //myProgram.Print(); // functia este apelata in Main

            //citirea de valori din standard input
            //string name = Console.ReadLine(); // functia ReadLine primeste input un sir de caractere, pe care il returneaza 
            //Console.WriteLine($"Hello {name}!"); //textu afisat de WriteLine poate fi formatat pentru a contine valorile unor variabile

            //declararea si initializarea variabilelor
            //int x = 5; // se declara o variabila 'x' de tip int, initializata cu valoarea 5
            //int y; // declararea unei variabile
            //y = 5; // initializarea unei variabile
            //int? z = null; //pentru a evita erorile atunci cand este declarata o variabila fara valoare

            //tipuri de date
            //int a = -5; // intreg
            //uint b = 5; // intreg fara semn (strict >= 0)
            //char c = 'C'; // caracter - se folosesc ' ' , nu " "
            //float d = 5.5f; // numar real - pentru tipul float se foloseste sufixul f
            //double e = 5.5; // numar real
            //decimal f = 5.5M; // numar real cu precizie mai mare decat double
            //bool g = true; // valoare de adevarat sau fals (1 sau 0)
            //string h = "Hello"; // sir de caractere

            //variabile de tip valoare si variabile de tip referinta
            //int a = -5; int b = a; // b primeste valoarea -5 a lui a, fiecare avand valoarea -5
            //int[] v = { -5 }; int[] u = v; // variabilele u si v sunt tablouri, deci sunt de tip referinta (indica o zona de memorie)
            //u[0] = 10; // schimband valoarea lui u[0], se va schimba si valoarea lui v[0]

            //clasa Math
            //double x = 5.5;
            //Console.WriteLine(Math.Round(x)); // rotunjeste numarul la cel mai apropiat numar par
            //double y = 5.909;
            //Console.WriteLine(Math.Truncate(y)); // afiseaza partea intreaga a numarului
            //Console.WriteLine(Math.Max(x,y)); // afiseaza cel mai mare nr dintre cele transmise ca argumente  



        }
        //void Print() // o functie trebuie declarata
        //{
        //    Console.WriteLine("Hello!");
        //    Console.WriteLine("Print.");
        //}
    }
}
//namespace -> clase -> functii -> instructiuni