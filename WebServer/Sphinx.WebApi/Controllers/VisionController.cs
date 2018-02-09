using System.IO;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sphinx.Application.Interfaces.Google.MachineLearning.Vision;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using System;
using System.IO;
using System.Net.Http;
using Google.Cloud.Language.V1;

namespace Sphinx.WebApi.Controllers
{
    [EnableCors("AllowAll")]
    [Route("api/v1/vision")]
    public class VisionController : Controller
    {
        private readonly IVisionService service;

        public VisionController(IVisionService service)
        {
            this.service = service;
        }

        public async Task AuthImplicit(string projectId)
        {
            // If you don't specify credentials when constructing the client, the
            // client library will look for credentials in the environment.
            var credential = await GoogleCredential.GetApplicationDefaultAsync();
            // var storage = StorageClient.Create(credential);
            // Make an authenticated API request.
            // var buckets = storage.ListBuckets(projectId);
            // foreach (var bucket in buckets)
            // {
            //     Console.WriteLine(bucket.Name);
            // }

            await Task.FromResult(0);
        }

        [HttpPost]
        [Route("detect-text-async")]
        public async void DetectTextAsync(IFormFile uploadedFile)
        {
            MemoryStream stream = new MemoryStream();

            await uploadedFile.CopyToAsync(stream);

            byte[] image = stream.ToArray();

            var response = await service.DetectTextAsync(image);
        }
    }
}