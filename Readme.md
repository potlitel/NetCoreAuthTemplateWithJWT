## Usefull commands

dotnet --list-sdks
dotnet new webapi -o NetCoreAuthTemplateWithJWT --framework "net7.0"
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
dotnet add package System.IdentityModel.Tokens.Jwt
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package BCrypt.Net-Next --version 4.0.3
dotnet add package Microsoft.EntityFrameworkCore.InMemory --version 7.0.9
dotnet add package Microsoft.OpenApi --version 1.6.5
dotnet watch run

## Usefull links

[dotnet-6-jwt-refresh-tokens-api](https://github.com/cornflourblue/dotnet-6-jwt-refresh-tokens-api)
[.NET 7.0 + C# - JWT Authentication Tutorial without ASP.NET Core Identity](https://jasonwatmore.com/net-7-csharp-jwt-authentication-tutorial-without-aspnet-core-identity)
[.NET 6.0 - JWT Authentication with Refresh Tokens Tutorial with Example API](https://jasonwatmore.com/net-6-jwt-authentication-with-refresh-tokens-tutorial-with-example-api)
[.NET 6.0 - Boilerplate API Tutorial with Email Sign Up, Verification, Authentication & Forgot Password](https://jasonwatmore.com/post/2022/02/26/net-6-boilerplate-api-tutorial-with-email-sign-up-verification-authentication-forgot-password)
[Startup.cs class is missing in .NET 6](https://stackoverflow.com/questions/70952271/startup-cs-class-is-missing-in-net-6)
[Implement JWT Authentication in Asp.net Core 5 Web API [Token Base Auth]](https://codepedia.info/jwt-authentication-in-aspnet-core-web-api-token#google_vignette)
[Implement authorization for Swagger in ASP.NET Core 6](https://www.infoworld.com/article/3650668/implement-authorization-for-swagger-in-aspnet-core-6.html)
