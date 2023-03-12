using Microsoft.OpenApi.Models;

namespace EgweneService.Data;

public class SwaggerBuilder
{

    private readonly IServiceCollection _services;
    public SwaggerBuilder(IServiceCollection services)
    {
        _services = services;
    }

    public void EnableSwagger()
    {
        _services.AddEndpointsApiExplorer();
        _services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Egwene API",
                Description = "Egwene API", 
                Version = "v1"
            });
        });
    }
}