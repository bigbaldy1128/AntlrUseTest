using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RootNamespace.Folder;
using Antlr4.Runtime;
using System.IO;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader fileStream = new StreamReader(@"C:\Users\wa\Desktop\grammars-v4\c\examples\add.c"))
            {
                AntlrInputStream inputStream = new AntlrInputStream(fileStream);
                CLexer lexer = new CLexer(inputStream);
                CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
                CParser parser = new CParser(commonTokenStream);
                var tree = parser.compilationUnit();
                CVisitor cVisitor = new CVisitor();
                cVisitor.Visit(tree);
                Console.ReadLine();
            }
        }
    }
}
