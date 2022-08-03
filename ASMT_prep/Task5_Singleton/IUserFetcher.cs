using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_Singleton
{
    public interface IUserFetcher
    {
        Task<string> Fetch();
    }
}
