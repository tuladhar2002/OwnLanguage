using Antlr4.Runtime.Misc;
using OwnLanguage.Content;

namespace OwnLanguage;

// Override the GrammerBaseVisitor to implement the visitor pattern
public class SimpleVisitor: GrammerBaseVisitor<object?>
{
    //set dictionary for var
    private Dictionary<string, object?> Variables {get;} = new();

    // Add more visitors for more working functionality within Grammer.g4 

    public override object? VisitAssignment([NotNull] GrammerParser.AssignmentContext context)
    {
        var varname = context.IDENTIFIER().GetText(); // get used for assigning variables

        var value = Visit(context.expression()); 

        Variables[varname] = value;
        return null; // return null for assignments 
    }

/// <summary>
/// Handle consts
/// </summary>
/// <param name="context"></param>
/// <returns></returns>
/// <exception cref="NotImplementedException"></exception>

    public override object? VisitConstant([NotNull] GrammerParser.ConstantContext context) // define constants from the Grammer.g4 
    {
        if(context.INTEGER() is { } i)
        {
            return int.Parse(i.GetText());
        }

        if(context.FLOAT() is { } f)
        {
            return float.Parse(f.GetText());
        }

        if(context.STRING() is { } s)
        {
            return s.GetText()[1..^1]; // remove the quotes
        }

        if(context.BOOLEAN() is { } b)
        {
            return b.GetText()=="true";
        }

        if(context.NULL() is { })
        {
            return null;
        }

        throw new NotImplementedException();
    }

/// <summary>
/// Handle Indentifier Expressions
/// </summary>
/// <param name="context"></param>
/// <returns></returns>
/// <exception cref="NotImplementedException"></exception>

    public override object? VisitIdentifierExpression([NotNull] GrammerParser.IdentifierExpressionContext context)
    {
        var varname = context.IDENTIFIER().GetText();

        if(!Variables.ContainsKey(varname))
        {
            throw new Exception($"Variable {varname} not found.");
        }

        return Variables[varname];
    }

    public override object? VisitPrintStatement([NotNull] GrammerParser.PrintStatementContext context)
    {
        var value = Visit(context.expression());
        System.Diagnostics.Debug.WriteLine(value);
        Console.WriteLine(value);

        return null;
    }

    /// <summary>
    /// Handle "+"and "-"operations
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public override object? VisitAddExpression([NotNull] GrammerParser.AddExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));

        var oprator = context.add_op().GetText();

        return oprator switch
        {
            "+" => Add(left, right),
            "plus"=> Add(left, right),
            "-" => Subtract(left, right),
            "minus" => Subtract(left, right),
            _ => throw new NotImplementedException()
        };

    }
    /// <summary>
    /// Handle comparison operations
    /// </summary>
    /// <param name="context"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>

    public override object? VisitCompExpression([NotNull] GrammerParser.CompExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));

        var oprator = context.comp_op().GetText();

        return oprator switch
        {
            "==" => Equal(left, right),
            "is equal to" => Equal(left, right),
            "!=" => NotEqualTo(left, right),
            "is not equal to" => NotEqualTo(left, right),
            "<" => LessThan(left, right),
            "is less than" => LessThan(left, right),
            ">" => GreaterThan(right, left),
            "is greater than" => GreaterThan(right, left),
            "<=" => LessThanOrEquals(left, right),
            "is less than or equal to" => LessThanOrEquals(left, right),
            ">=" => GreaterThanOrEquals(left, right),
            "is greater than or equal to" => GreaterThanOrEquals(left, right),
            _ => throw new NotImplementedException()
        };
    }

    public override object? VisitBoolExpression([NotNull] GrammerParser.BoolExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));

        var oprator = context.bool_op().GetText();

        return oprator switch
        {
            "and" => AndOperator(left, right),
            "or" => OrOperator(left, right),
            _ => throw new NotImplementedException()
        };
    }

    public override object? VisitMultExpression([NotNull] GrammerParser.MultExpressionContext context)
    {
        var left = Visit(context.expression(0));
        var right = Visit(context.expression(1));

        var oprator = context.mult_op().GetText();

        return oprator switch
        {
            "*" => Multiply(left, right),
            "times" => Multiply(left, right),
            "/" => Divide(left, right),
            "divided by" => Divide(left, right),
            "%" => Modulus(left, right),
            "modulus" => Modulus(left, right),
            _ => throw new NotImplementedException()
        };
    }

    private object? Add(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return l + r;
        }

        if(left is float lf && right is float rf)
        {
            return lf + rf;
        }

        if(left is string ls && right is string rs)
        {
            return ls + rs;
        }

        if(left is int li && right is float rfloat)
        {
            return li + rfloat;
        }

        if(left is float lfloat && right is int ri)
        {
            return lfloat + ri;
        }

        if (left is string || right is string)
        {
            return $"{left}{right}";
        }

        if(left is null && right is not null)
        {
            throw new Exception($"Cannot add values for types {null} and {right?.GetType()}");
        }

        if(left is not null && right is null)
        {
            throw new Exception($"Cannot add values for types {left?.GetType()} and {null}");
        }

        throw new Exception($"Cannot add values for types {left?.GetType()} and {right?.GetType()}");
    }

    private object? Subtract(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return l - r;
        }

        if(left is float lf && right is float rf)
        {
            return lf - rf;
        }

        if(left is int li && right is float rfloat)
        {
            return li - rfloat;
        }

        if(left is float lfloat && right is int ri)
        {
            return lfloat - ri;
        }

        throw new Exception($"Cannot subtract values for types {left?.GetType()} and {right?.GetType()}");
    }

    private object? Equal(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return l == r;
        }

        if(left is float lf && right is float rf)
        {
            return lf == rf;
        }

        if(left is string ls && right is string rs)
        {
            return ls == rs;
        }

        if(left is bool lb && right is bool rb)
        {
            return lb == rb;
        }

        if(left is null && right is null)
        {
            return true;
        }

        return false;
    }

    private object? NotEqualTo(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return l != r;
        }

        if(left is float lf && right is float rf)
        {
            return lf != rf;
        }

        if(left is string ls && right is string rs)
        {
            return ls != rs;
        }

        if(left is bool lb && right is bool rb)
        {
            return lb != rb;
        }

        if(left is null && right is null)
        {
            return false;
        }

        return true;
    }

    private object? LessThan(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return r < l;
        }

        if(left is float lf && right is float rf)
        {
            return lf < rf;
        }

        throw new Exception($"Cannot compare values for types {left?.GetType()} and {right?.GetType()}");
    }

    private object? GreaterThan(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return r > l;
        }

        if(left is float lf && right is float rf)
        {
            return lf > rf;
        }

        throw new Exception($"Cannot compare values for types {left?.GetType()} and {right?.GetType()}");
    }

    private object? LessThanOrEquals(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return l <= r;
        }

        if(left is float lf && right is float rf)
        {
            return lf <= rf;
        }

        throw new Exception($"Cannot compare values for types {left?.GetType()} and {right?.GetType()}");
    }

    private object? GreaterThanOrEquals(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return l >= r;
        }

        if(left is float lf && right is float rf)
        {
            return lf >= rf;
        }

        throw new Exception($"Cannot compare values for types {left?.GetType()} and {right?.GetType()}");
    }

    private object? AndOperator(object? left, object? right)
    {
        if(left is bool lb && right is bool rb)
        {
            return lb && rb;
        }

        throw new Exception($"Cannot use AND operator for types {left?.GetType()} and {right?.GetType()}");
    }

    private object? OrOperator(object? left, object? right)
    {
        if(left is bool lb && right is bool rb)
        {
            return lb || rb;
        }

        throw new Exception($"Cannot use OR operator for types {left?.GetType()} and {right?.GetType()}");
    }

    private object? Multiply(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return l * r;
        }

        if(left is float lf && right is float rf)
        {
            return lf * rf;
        }

        if(left is int li && right is float rfloat)
        {
            return li * rfloat;
        }

        if(left is float lfloat && right is int ri)
        {
            return lfloat * ri;
        }

        throw new Exception($"Cannot multiply values for types {left?.GetType()} and {right?.GetType()}");
    }

    private object? Divide(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return l / r;
        }

        if(left is float lf && right is float rf)
        {
            return lf / rf;
        }

        if(left is int li && right is float rfloat)
        {
            return li / rfloat;
        }

        if(left is float lfloat && right is int ri)
        {
            return lfloat / ri;
        }

        throw new Exception($"Cannot divide values for types {left?.GetType()} and {right?.GetType()}");
    }

    private object? Modulus(object? left, object? right)
    {
        if(left is int l && right is int r)
        {
            return l % r;
        }

        if(left is float lf && right is float rf)
        {
            return lf % rf;
        }

        if(left is int li && right is float rfloat)
        {
            return li % (int)rfloat;
        }

        if(left is float lfloat && right is int ri)
        {
            return (int)lfloat % ri;
        }

        throw new Exception($"Cannot use modulus for types {left?.GetType()} and {right?.GetType()}");
    }

}