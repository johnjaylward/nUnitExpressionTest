﻿using System;
using System.Linq.Expressions;

namespace nUnitExpressionTest.Linq
{
    public class ExpressionTranslator : ExpressionVisitor
    {
        public string Translate(Expression e)
        {
            return "";
            //throw new NotImplementedException();
        }
    }
}
