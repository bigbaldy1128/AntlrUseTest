using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using RootNamespace.Folder;

namespace ConsoleApplication7
{
    public class CVisitor:CBaseVisitor<string>
    {
        public override string VisitConditionalExpression([NotNull] CParser.ConditionalExpressionContext context)
        {
            Console.WriteLine(context.GetText());
            return base.VisitConditionalExpression(context);
        }
    }
}
