using System;

namespace SqlQueryBuilder
{
    public class Select
    {
        private readonly string[] _columns;

        public Select(params string[] columns)
        {
            _columns = columns;
        }

        public override string ToString()
        {
            return $"SELECT {string.Join(", ", _columns)}";
        }

        public From From(string tableName)
        {
            return new From(this, tableName);
        }
    }

    public class From
    {
        private readonly string _tableName;
        private readonly object _parent;

        public From(object parent, string tableName)
        {
            _parent = parent;
            _tableName = tableName;
        }

        public override string ToString()
        {
            return $"{_parent} FROM {_tableName}";
        }

        public Where Where(string clause)
        {
            return new Where(this, clause);
        }
    }

    public class Where
    {
        private readonly string _clause;
        private readonly object _parent;

        public Where(object parent, string clause)
        {
            _parent = parent;
            _clause = clause;
        }

        public override string ToString()
        {
            return $"{_parent} WHERE {_clause}";
        }
    }
}
