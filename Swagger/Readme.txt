-->Web Api Setup
Install NuGet Package
Install-Package Microsoft.AspNetCore.Mvc

Modify Program.cs
Add a Controllers folder and add TestController.cs file
Setup TestController.cs

set launchsettings.json dev ASPNETCORE_ENVIRONMENT



-->Swagger Setup (Beginner Level)
Install NuGet Package
Install-Package Swashbuckle.AspNetCore

Register Swagger in Program.cs--> AddSwaggerGen
User Midalware
1) app.UseSwagger();
2) app.UseSwaggerUI();
Enable Swagger only in Development environment
if (app.Environment.IsDevelopment())

Run → open /swagger


Remove Endpoint from Document
[ApiExplorerSettings(IgnoreApi = true)]

