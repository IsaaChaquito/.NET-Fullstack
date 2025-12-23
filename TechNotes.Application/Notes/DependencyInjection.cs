using System;
using Microsoft.Extensions.DependencyInjection;

namespace TechNotes.Application.Notes;

public static class DependencyInjection
{
  public static IServiceCollection AddApplication(this IServiceCollection services)
  {
    services.AddScoped<INoteService, NoteService>();
    return services;
  }
}
