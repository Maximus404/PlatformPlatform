using PlatformPlatform.SharedKernel.DomainModeling.Persistence;

namespace PlatformPlatform.SharedKernel.Tests.TestEntities;

public interface ITestAggregateRepository : IRepository<TestAggregate, long>
{
}