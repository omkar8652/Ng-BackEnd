using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NgBackend.Application.Interfaces.ExternalServiceCall
{
    public interface IExternalSerivce
    {
        public Task<String> StartProcess(string key, Dictionary<string, object> Dictemplate);
        public Task<String> otherMicroServiceCall();
    }
}