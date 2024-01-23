using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace InvestmentPortal.API.Application.DTOs
{
    public record UserLoginDto(string UserName, string Password);
}
