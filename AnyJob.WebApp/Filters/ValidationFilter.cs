using AnyJob.Application;
using AnyJob.Application.Exceptions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AnyJob.WebApp.Filters;

public class ValidationFilter : IAsyncActionFilter
{
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        if (!context.ModelState.IsValid)
        {
            ModelError error = context.ModelState.SelectMany(x => x.Value.Errors).First();
            throw new BusinessException(error.ErrorMessage);
        }

        // Prepare input(s)
        foreach (InputModelBase input in context.ActionArguments.Where(a => a.Value is InputModelBase).Select(a => (InputModelBase)a.Value!))
            input.Prepare();

        await next();
    }
}