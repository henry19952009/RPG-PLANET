using System.Net.Http;
using System.IO;
using System;
using System.Security.AccessControl;
using System.Threading.Tasks;


namespace blazorProyI.Client.Services
{
    public class HttpResponseWrapper<T>
    {
        public HttpResponseWrapper(T response, bool error, HttpResponseMessage httpResponseMessage){
            Error = error;
            Response = response;
            HttpResponseMessage = httpResponseMessage;
        }
        public bool Error {get;set;}
        public T Response {get;set;}
        public HttpResponseMessage HttpResponseMessage {get;set;}
        public async Task<string> GetBody()
        {
            return await HttpResponseMessage.Content.ReadAsStringAsync();
        }
    }
    
}