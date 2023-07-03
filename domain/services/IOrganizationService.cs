using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using domain.dtos;

namespace domain.services
{
    public interface IOrganizationService
    {
        public IEnumerable<OrganizationDtoResp> GetOrganizations();
    }
}