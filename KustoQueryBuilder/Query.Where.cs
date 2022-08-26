﻿using KustoQueryBuilder.Clauses;

namespace KustoQueryBuilder;

public partial class Query
{

    public Query Where(string column, string value)
    {
        return Where(column, Operator.EqualTo, value);
    }

    public Query Where(string column, string op, string value)
    {
        _clauses.Add(new BasicCondition(column, op, value));

        return this;
    }
    
    public Query WhereBetween(string column, string fromValue, string toValue)
    {
        _clauses.Add(new BetweenCondition(column, fromValue, toValue));

        return this;
    }
}
