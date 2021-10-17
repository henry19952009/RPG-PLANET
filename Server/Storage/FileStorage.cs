using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;




namespace blazorProyI.Server.Storage
{
    public class FileStorage:IFileStorage
    {
        private string connectionString;
        public FileStorage(IConfiguration configuration){
            connectionString= configuration.GetConnectionString("AzureStorage");
        }
        public async Task<string> SaveFile(byte[] contenido, string extension, string nombreCarpeta){
            var client = new BlobContainerClient(connectionString,nombreCarpeta);
            await client.CreateIfNotExistsAsync();
            client.SetAccessPolicy(Azure.Storage.Blobs.Models.PublicAccessType.Blob);
            var fileName = $"{Guid.NewGuid()}{extension}";

            var blob = client.GetBlobClient(fileName);
            using(var memoryStream = new MemoryStream(contenido)){
                await blob.UploadAsync(memoryStream);
            };
            return blob.Uri.ToString();

            
        }
        public async Task DeleteFile(string ruta, string nombreCarpeta){ 
            if (string.IsNullOrEmpty(ruta)){
                return;
            }
            var client = new BlobContainerClient(connectionString,nombreCarpeta);
            await client.CreateIfNotExistsAsync();
            var fileName = Path.GetFileName(ruta);
            var blob = client.GetBlobClient(fileName);
            await blob.DeleteIfExistsAsync();


        }
        public async Task<string> EditFile(byte[] contenido, string extension, string nombreCarpeta, string ruta){
            await DeleteFile(ruta, nombreCarpeta);
            return await SaveFile(contenido, extension, nombreCarpeta);
        }
    }
}