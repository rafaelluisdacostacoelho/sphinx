using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;

public class FileUploadOperation : IOperationFilter
{
    public void Apply(Operation operation, OperationFilterContext context)
    {
        if (operation.OperationId == "ApiV1VisionDetect-text-asyncPost")
        {
            operation.Parameters.Clear();
            operation.Parameters.Add(new NonBodyParameter
            {
                Name = "uploadedFile",
                In = "formData",
                Description = "Upload File",
                Required = true,
                Type = "file"
            });
            operation.Consumes.Add("multipart/form-data");
        }
    }
}