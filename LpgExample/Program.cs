using System;

using LPG2.Runtime;
namespace LpgExample
{
    
    class Program
    {
        static void Main(string[] args)
        {

            LPGLexer lexer= new LPGLexer(@"E:\LPG2\lpg2\src\jikespg.g", 8); // Create the lexer
            lexer.printTokens= true;
            LPGParser parser = new LPGParser(lexer.getILexStream()); // Create the parser
            
            lexer.lexer(null, parser.getIPrsStream());
            var ast = parser.parser(null, 100000);
            Console.WriteLine("Hello World!");
  
          
        }
    }


}
