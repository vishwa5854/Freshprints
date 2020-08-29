using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Freshprints.JWT
{
    public class JwtAuthenticationManager : IJwtAuthenticationManager
    {
        private readonly string _key;

        public JwtAuthenticationManager(string key)
        {
            _key = key;
        }
        
        public string Authenticate(string username, string password)
        {
            Console.Out.WriteLine(username, password);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(_key);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, username),
                }),
                SigningCredentials = new SigningCredentials
                (
                    new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature
                )
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}