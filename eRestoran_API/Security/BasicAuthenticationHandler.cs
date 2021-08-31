using eRestoran_API.Database;
using eRestoran_API.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace eRestoran_API.Security
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IZaposlenikService _userService;
        private readonly IKlijentService _klijentService;
        private readonly IB140235Context _context;

        public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock, IZaposlenikService userService, IKlijentService klijentService, IB140235Context context) : base(options, logger, encoder, clock)
        {
            _userService = userService;
            _klijentService = klijentService;
            _context = context;

        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("Missing Authorization Header");

            eRestoran.Model.Zaposlenik user = null;
            eRestoran.Model.Klijent klijent = null;

            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
                var username = credentials[0];
                var password = credentials[1];

                user = _userService.Authenticiraj(username, password);
                if (user == null)
                {
                    klijent = _klijentService.Authenticiraj(username, password);
                }
            }
            catch
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }


            if (user == null && klijent == null)
                return AuthenticateResult.Fail("Invalid Username or Password");
            if (user != null)
            {
                var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, user.Username),
                new Claim(ClaimTypes.Name, user.Ime),
            };

                string uloga = _context.Uloga.Where(x => x.UlogaId == user.UlogaId).FirstOrDefault().Naziv;

                if (user.IsAdministrator == true)
                {
                    uloga = "Administrator";
                }

                claims.Add(new Claim(ClaimTypes.Role, uloga));
                var identity = new ClaimsIdentity(claims, Scheme.Name);
                var principal = new ClaimsPrincipal(identity);
                var ticket = new AuthenticationTicket(principal, Scheme.Name);

                return AuthenticateResult.Success(ticket);
            }
            else
            {
                var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, klijent.Username),
                new Claim(ClaimTypes.Name, klijent.Ime),
            };

                claims.Add(new Claim(ClaimTypes.Role, "Klijent"));
                var identity = new ClaimsIdentity(claims, Scheme.Name);
                var principal = new ClaimsPrincipal(identity);
                var ticket = new AuthenticationTicket(principal, Scheme.Name);

                return AuthenticateResult.Success(ticket);
            }



        }
    }
}
