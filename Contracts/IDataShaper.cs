using System.Collections.Generic;
using System.Dynamic;
using Entities.Models;

namespace Contracts
{
    public interface IDataShaper<in T>
    {
        IEnumerable<Entity> ShapeData(IEnumerable<T> entities, string fieldString);

        Entity ShapeData(T entity, string fieldString);
    }
}