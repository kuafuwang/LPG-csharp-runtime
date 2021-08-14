using System;
using LpgJava;

namespace JavaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var _lexer = new JavaLexer("D:/workspace/New_Parser/lpg_java/src/test/test2.java"); // Create the lexer
            var parser = new JavaParser(_lexer.getILexStream());
            _lexer.printTokens = true;
            _lexer.lexer(parser.getIPrsStream());

            var ast = parser.parser();
            if (ast != null)
            {
                Console.WriteLine("成功");
            }
            else
            {
                Console.WriteLine("失败");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
