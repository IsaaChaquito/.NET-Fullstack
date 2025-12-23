using System;
using Microsoft.Extensions.DependencyInjection;

namespace TechNotes.Application.Notes;

public static class DependencyInjection
{
  public static IServiceCollection AddApplication(this IServiceCollection services)
  {
    services.AddMediatR(configuration =>
    {
      configuration.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly);
    });

    return services;
  }
}
