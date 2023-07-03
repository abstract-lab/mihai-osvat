using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace domain.dtos
{
    public record OrganizationDtoResp(int Id, string Name, string LogoUrl);
}