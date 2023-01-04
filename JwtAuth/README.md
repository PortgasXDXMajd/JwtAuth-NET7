# ASP.NET Core 7.0 with JWT Authentication
## step by step guid

### Install the following packages

use dotnet add package from powershell or cmd
using Install-Package from PMC

```sh
Install-Package Microsoft.AspNetCore.Authentication.JwtBearer
Install-Package Microsoft.AspNetCore.Identity.EntityFrameworkCore
Install-Package System.IdentityModel.Tokens.Jwt
```

###  Modify Appsetting.json file for JWT configuration setting
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "JWT": {
    "Key": "This is my supper secret key for jwt",
    "Issuer": "https://majdalkayyal.com,
    "Audience": "majdalkayyal.com"
  }
}
```
