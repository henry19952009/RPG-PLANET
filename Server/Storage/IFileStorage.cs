using System.Threading.Tasks;
using System;
namespace blazorProyI.Server.Storage
{
    public interface IFileStorage
    {
        Task<string> SaveFile(byte[] contenido, string extension,string nombreCarpeta);
        Task DeleteFile(string ruta, string FilesStorage);
        Task<string> EditFile(byte[] contenido, string extension,string nombreCarpeta, string ruta);
    }
}