using AssignmentsScheduler.Domain;
using AssignmentsScheduler.Domain.Abstract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsScheduler.CompositionRoot
{
    public static class DependencyInjectionExtension
    {
        public static void AddDependencies(IServiceCollection services)
        {
            services.AddScoped<IAssignmentsService, AssignmentsService>();
        }
    }
}
