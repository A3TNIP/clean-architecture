using CleanArchitecture.Application.Common;

namespace CleanArchitecture.Infrastructure.Services;

public class DateTimeService: IDateTime
{
    public DateTime Now => DateTime.UtcNow;
}