using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Common.Interfaces
{
    public interface IHttpService
    {
        Task<string> SendRawRequest(string payload, string url, string type);
    }
}
