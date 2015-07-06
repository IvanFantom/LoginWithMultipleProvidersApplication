using System.Web.Helpers;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using Owin.Security.Providers.LinkedIn;

namespace LoginWithMultipleProvidersApplication
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Account/Login")
            });

            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

            app.UseGoogleAuthentication(
                clientId: "394343389150-pjmd9ce2g22e37pqq7qa2q96911jfsh4.apps.googleusercontent.com",
                clientSecret: "TGPdiGlibRlSVEC2dJMX64fK");

            app.UseFacebookAuthentication(
                appId: "1461968390770111",
                appSecret: "e0272de1a390958bbd8cee50e1dcdfb8");

            app.UseLinkedInAuthentication(
                clientId: "774gbhxjezyr25",
                clientSecret: "nfkVDomTl0XytDHi");
        }
    }
}