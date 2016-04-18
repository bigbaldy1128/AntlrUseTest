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
            using (StreamReader fileStream = new StreamReader(@"C:\Users\wa\Desktop\antlr\src\read.cbl"))
            {
                AntlrInputStream inputStream = new AntlrInputStream(fileStream);
                Cobol85Lexer lexer = new Cobol85Lexer(inputStream);
                CommonTokenStream commonTokenStream = new CommonTokenStream(lexer);
                Cobol85Parser parser = new Cobol85Parser(commonTokenStream);
            }
        }
    }
}
