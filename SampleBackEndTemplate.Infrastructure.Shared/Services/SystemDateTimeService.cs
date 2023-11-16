using SampleBackEndTemplate.Application.Interfaces.Shared;
using System;

namespace SampleBackEndTemplate.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}