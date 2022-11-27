using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace NgBackend.API.Filters
{
    public class ErrorHandlingFilter : ExceptionFilterAttribute
    {


        public override void OnException(ExceptionContext context)
        {
            var exception = context.Exception;
            Console.WriteLine(exception.StackTrace);
            string[] resp = exception.Message.Split("_");
            Console.WriteLine(resp.Count());
            if (resp.Count() == 2)
            {
                context.Result = new ObjectResult(new { error = resp[0] }) { StatusCode = int.Parse(resp[1]) };
            }
            else
            {
                context.Result = new ObjectResult(new { error = exception.Message }) { StatusCode = 500 };
            }
            context.ExceptionHandled = true;

            // base.OnException(context);
        }


    }
}