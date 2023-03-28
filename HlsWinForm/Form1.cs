using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Certificate;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

using Microsoft.Extensions.Logging;
namespace HlsWinForm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        var services = new ServiceCollection();
        System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

        services.AddWindowsFormsBlazorWebView();
        // services.AddAuthentication(
        //         CertificateAuthenticationDefaults.AuthenticationScheme)
        //     .AddCertificate(options =>
        //     {
        //         options.Events = new CertificateAuthenticationEvents
        //         {
        //             OnCertificateValidated = context =>
        //             {
        //                 var claims = new[]
        //                 {
        //                     new Claim(
        //                         ClaimTypes.NameIdentifier,
        //                         context.ClientCertificate.Subject,
        //                         ClaimValueTypes.String, context.Options.ClaimsIssuer),
        //                     new Claim(
        //                         ClaimTypes.Name,
        //                         context.ClientCertificate.Subject,
        //                         ClaimValueTypes.String, context.Options.ClaimsIssuer)
        //                 };
        //
        //                 context.Principal = new ClaimsPrincipal(
        //                     new ClaimsIdentity(claims, context.Scheme.Name));
        //                 context.Success();
        //
        //                 return Task.CompletedTask;
        //             },
        //             OnAuthenticationFailed = context =>
        //             {
        //                 context.Fail(context.Exception);
        //                 return Task.CompletedTask;
        //             }
        //         };
        //     });
        services.AddBlazorWebViewDeveloperTools();
        services.AddLogging();
        blazorWebView.HostPage = "wwwroot\\index.html";
        
        blazorWebView.Services = services.BuildServiceProvider();
        blazorWebView.RootComponents.Add<HlsVideo>("#app");
    }
}