using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazorProyI.Client.Services
{
    public class ErrorMessage: IErrorMessage
    {
        public async Task ShowErrorMessage(string messageError){
            await Task.FromResult(0);
        }
    }
}