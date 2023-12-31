using Br.Com.FiapInvestiments.Infrastructure.Data;

namespace Br.Com.FiapInvestiments.Api.Seed
{
    internal static class ContextInitializerExtension
    {
        public static IApplicationBuilder ContextSeed(this IApplicationBuilder app)
        {
            ArgumentNullException.ThrowIfNull(app, nameof(app));

            using var scope = app.ApplicationServices.CreateScope();
            var services = scope.ServiceProvider;
            try
            {
                var context = services.GetRequiredService<ApiContext>();
                ContextInitializer.Initialize(context);
            }
            catch (Exception)
            {

                throw;
            }

            return app;
        }
    }
}
