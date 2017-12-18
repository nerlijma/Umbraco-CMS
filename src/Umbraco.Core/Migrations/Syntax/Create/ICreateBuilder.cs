﻿using System;
using Umbraco.Core.Migrations.Syntax.Create.Column;
using Umbraco.Core.Migrations.Syntax.Create.Constraint;
using Umbraco.Core.Migrations.Syntax.Create.ForeignKey;
using Umbraco.Core.Migrations.Syntax.Create.Index;
using Umbraco.Core.Migrations.Syntax.Create.Table;

namespace Umbraco.Core.Migrations.Syntax.Create
{
    public interface ICreateBuilder : IFluentSyntax
    {
        void Table<T>(bool withoutKeysAndIndexes = false);
        void KeysAndIndexes<T>();
        void KeysAndIndexes(Type typeOfDto);

        ICreateTableWithColumnSyntax Table(string tableName);
        ICreateColumnOnTableSyntax Column(string columnName);

        ICreateForeignKeyFromTableSyntax ForeignKey();
        ICreateForeignKeyFromTableSyntax ForeignKey(string foreignKeyName);

        ICreateIndexForTableSyntax Index();
        ICreateIndexForTableSyntax Index(string indexName);

        ICreateConstraintOnTableSyntax PrimaryKey();
        ICreateConstraintOnTableSyntax PrimaryKey(string primaryKeyName);

        ICreateConstraintOnTableSyntax UniqueConstraint();
        ICreateConstraintOnTableSyntax UniqueConstraint(string constraintName);
        ICreateConstraintOnTableSyntax Constraint(string constraintName);
    }
}