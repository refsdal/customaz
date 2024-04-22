namespace Customaz.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddMediatR(config =>
        {
            
        });
        
        return serviceCollection;
    }
}