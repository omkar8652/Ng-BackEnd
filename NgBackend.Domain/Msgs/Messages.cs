using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NgBackend.Domain.Msgs
{
    public class Messages
    {
        public string UserAlreadyExist = "User Already Exist_502";
        public string Login = "Please Check Creds_502";
        public string kafkaError = "Problem Processing Data_502";
    }
}