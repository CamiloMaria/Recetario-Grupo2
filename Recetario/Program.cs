using Antlr4.Runtime;

var input = CharStreams.fromPath(@"..\..\..\Recetas.txt");

Console.WriteLine("Output:");

var lexer = new RecetarioLexer(input);
var tokenStream = new CommonTokenStream(lexer);
var parser = new RecetarioParser(tokenStream);
var tree = parser.recetario();
var recetario = new Recetario.Recetario();
recetario.Visit(tree);

int x = 0;

foreach (string line in recetario.Output)
{
    x++;
    Console.WriteLine(line);
}

Console.WriteLine("\nPulse cualquier tecla para salir.");
Console.ReadKey();