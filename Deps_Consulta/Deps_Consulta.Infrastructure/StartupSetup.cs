using Deps_Consulta.Infrastructure.Data;
using Deps_Consulta.Infrastructure.Identity;
using Deps_Consulta.SharedKernel.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Deps_Consulta.Infrastructure;

public static class StartupSetup
{
    public static void AddInfrastructuresServices(this IServiceCollection services)
    {
    }

    public static void AddDbContext(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(AmbienteUtil.GetValue("POSTGRES_CONNECTION")));
    }

    public static void ConfigureJwt(this IServiceCollection services)
    {
        JwtStartupSetup.RegisterJWT(services);
    }
}