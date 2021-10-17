using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace blazorProyI.Client.Services
{
    public interface IErrorMessage
    {
        Task ShowErrorMessage (string message);
    }
}