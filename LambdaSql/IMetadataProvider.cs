﻿using System;
using System.Data.Common;
using System.Linq.Expressions;

namespace LambdaSql
{
    public interface IMetadataProvider
    {
        string GetTableName<TEntity>();
        string GetTableName(Type entityType);
        string GetPropertyName(LambdaExpression propertyExpression);
        string GetPropertyName(MemberExpression propertyExpression);
        DbParameter CreateDbParameter();
        string ParameterToString(object value);
        SqlAlias<TEntity> AliasFor<TEntity>();
    }
}
