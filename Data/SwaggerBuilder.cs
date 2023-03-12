using Microsoft.OpenApi.Models;

namespace EgweneService.Data;

public class SwaggerBuilder
{

    private readonly WebApplicationBuilder _builder;
    public SwaggerBuilder(WebApplicationBuilder builder)
    {
        _builder = builder;
    }

    public void EnableSwagger()
    {
        _builder.Services.AddEndpointsApiExplorer();
        _builder.Services.AddSwaggerGen(c =>
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