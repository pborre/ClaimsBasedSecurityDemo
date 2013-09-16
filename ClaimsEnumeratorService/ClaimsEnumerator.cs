using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Microsoft.IdentityModel;
using Microsoft.IdentityModel.Claims;
using System.Threading;

namespace ClaimsEnumeratorService
{
    
    public class ClaimsEnumerator : IClaimsEnumerator
    {

        public List<ClaimItem> EnumerateMyClaims()
        {
            List<ClaimItem> items = new List<ClaimItem>();

            IClaimsIdentity ici = Thread.CurrentPrincipal.Identity as IClaimsIdentity;

            items = (from c in ici.Claims
                     select new ClaimItem
                     {
                         ClaimType = c.ClaimType,
                         ClaimValue = c.Value
                     }).ToList();

            return items;
        }
    }
}
