using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Security.Claims;

namespace AutoPakevApp.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
