using System;
using System.Linq;
using EAP.Entity.Data;
using EAP.Shared.EntityFilterRepo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EAP.API.ActionFilter
{
    public class ValidateEntityExistaAttribute<T> : IActionFilter where T : class, TEntity
    {
        private readonly EAPDbContext _context;

        public ValidateEntityExistaAttribute(EAPDbContext context)
        {
            this._context = context;
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var id = Guid.Empty;
            if (context.ActionArguments.ContainsKey("id"))
            {
                id = (Guid)context.ActionArguments["id"];
            }
            else
            {
                context.Result = new BadRequestObjectResult("Bad id parameter");
                return;
            }

            var entity = _context.Set<T>().SingleOrDefault(x => x.Id.Equals(id));
            if (entity == null)
            {
                context.Result = new NotFoundObjectResult($"Selected information {id} not found on our record");
            }
            else
            {
                context.HttpContext.Items.Add("entity", entity);
            }
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}