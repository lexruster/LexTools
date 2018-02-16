using System;
using Dapper;

namespace LexTools.Database
{
    public abstract class BaseDbEntity
    {
        [Key]
        public int Id { get; set; }

        [ReadOnly(true)]
        public DateTime CreateDate { get; set; }
    }
}
