using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.IServices
{
    public interface ISecurityService
    {
        string GenerateHash(string salt, string password);
        string GenerateSalt();
        string GeneratePassword();
    }
}
