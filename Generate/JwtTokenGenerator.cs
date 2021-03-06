using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Lab.Generate
{
    public interface IJwtTokenGenerator
    {
        string Generate(string user, string role);
    }
    public class JwtTokenGenerator : IJwtTokenGenerator
    {

        public string Generate(string user, string role)
        {
            var keyBytes = Encoding.UTF8.GetBytes("w+1alOGke7bSPTgeMVlDXS5FRg3jcjRxkBtG0u3NrOo=");
            var secret = new SymmetricSecurityKey(keyBytes);
            var credentials = new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user),
                new Claim(ClaimTypes.Role, role)
            };
            var token = new JwtSecurityToken(
                "test",
                claims: claims,
                expires: DateTime.Now.AddMinutes(0.5f),
                signingCredentials: credentials
            );
            var jwtTokenHandler = new JwtSecurityTokenHandler();
            return jwtTokenHandler.WriteToken(token);
        }
    }
}
