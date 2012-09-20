using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CloudCompare.Domain.Contracts.Repositories
{
    public interface IBaseRepository
    {
        bool Insert<T>(string userId, T model) where T : class;
        bool Update<T>(string userId, T model) where T : class;
    }
}
