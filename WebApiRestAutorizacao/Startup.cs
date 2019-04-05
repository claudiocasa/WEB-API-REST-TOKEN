using Microsoft.Owin.Security.OAuth;
using Owin;
using System;


namespace WebApiRestAutorizacao
{
    public class Startup
    {
        public static OAuthAuthorizationServerOptions OAuthOptions { get; set; }
        public void Configuration(IAppBuilder app)
        {
            app.UseOAuthBearerTokens(OAuthOptions);
        }
        static Startup()
        {
            OAuthOptions = new OAuthAuthorizationServerOptions
            {
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                AllowInsecureHttp = true,
                TokenEndpointPath = new Microsoft.Owin.PathString("/api/token"),
                Provider = new OAuthProvider()
            };
        }
    }
}