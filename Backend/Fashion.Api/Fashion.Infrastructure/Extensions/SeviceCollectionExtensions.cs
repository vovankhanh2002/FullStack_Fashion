using Fashion.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion.Infrastructure.Extensions
{
    public static class SeviceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection serviceProvider, IConfiguration configuration)
        {
            serviceProvider.AddDbContext<ApplicationDbcontext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
