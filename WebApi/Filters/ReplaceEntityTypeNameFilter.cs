namespace MyShop.WebApi.Filters;

using System;
using System.Linq;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

/// <summary>
/// 
/// </summary>
public class ReplaceEntityTypeNameFilter : IOperationFilter
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="operation"></param>
    /// <param name="context"></param>
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        var entityType = context.MethodInfo.DeclaringType?.GetGenericArguments().FirstOrDefault();
        if (entityType != null)
        {
            var entityTypeDisplayName = entityType.Name;
            if (entityTypeDisplayName.EndsWith("Dto", StringComparison.OrdinalIgnoreCase))
            {
                entityTypeDisplayName = entityTypeDisplayName[..^3];
            }

            operation.Summary = operation.Summary?.Replace("T", entityTypeDisplayName.ToLower());
            operation.Description = operation.Description?.Replace("T", entityTypeDisplayName.ToLower());

            foreach (var parameter in operation.Parameters)
            {
                parameter.Description = parameter.Description?.Replace("T", entityTypeDisplayName.ToLower());
            }
        }
    }
}
