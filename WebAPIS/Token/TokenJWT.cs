using System.IdentityModel.Tokens.Jwt;

namespace WebAPIS.Token
{
    public class TokenJWT
    {
        private JwtSecurityToken token;
        internal TokenJWT(JwtSecurityToken token)
        {
            this.token = token;
        }

        public DateTime Valid => token.ValidTo;
        public string value => new JwtSecurityTokenHandler().WriteToken(this.token);
    }
}
