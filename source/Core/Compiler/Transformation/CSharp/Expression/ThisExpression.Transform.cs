﻿using System.Collections.Generic;
using Blade.Compiler.Models;
using Roslyn.Compilers.CSharp;

namespace Blade.Compiler.Transformation.CSharp
{
    internal partial class Transformer : SyntaxVisitor<IEnumerable<IModel>>
    {
        public override IEnumerable<IModel> VisitThisExpression(ThisExpressionSyntax node)
        {
            yield return Create<ThisExpression>(node);
        }
    }
}
