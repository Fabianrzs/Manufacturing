using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Common
{
    public class Response<TEntity> where TEntity: DomainEntity
    {
        public IEnumerable<TEntity> Entities { get; set; }
        public string Message { get; set; }
        public bool Error { get; set; }
        public TEntity Entity { get; set; }

        public Response(IEnumerable<TEntity> entities)
        {
            Entities = entities;
            Error = false;
        }

        public Response(TEntity entity)
        {
            Entity = entity;
            Error = false;
        }

        public Response(string message)
        {
            Message = message;
            Error = true;
        }
    }
}
