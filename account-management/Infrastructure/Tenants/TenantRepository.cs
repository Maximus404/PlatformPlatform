using Microsoft.EntityFrameworkCore;
using PlatformPlatform.AccountManagement.Domain.Tenants;
using PlatformPlatform.Foundation.InfrastructureCore.Persistence;

namespace PlatformPlatform.AccountManagement.Infrastructure.Tenants;

public sealed class TenantRepository : RepositoryBase<Tenant, TenantId>, ITenantRepository
{
    // ReSharper disable once SuggestBaseTypeForParameterInConstructor
    public TenantRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
    {
    }

    public Task<bool> IsSubdomainFreeAsync(string subdomain, CancellationToken cancellationToken)
    {
        return DbSet.AllAsync(tenant => tenant.Subdomain != subdomain, cancellationToken);
    }
}