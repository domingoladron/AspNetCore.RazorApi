FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["AspNetCore.RazorApi/AspNetCore.RazorApi.csproj", "AspNetCore.RazorApi/"]
RUN dotnet restore "AspNetCore.RazorApi/AspNetCore.RazorApi.csproj"
COPY . .
WORKDIR "/src/AspNetCore.RazorApi"
RUN dotnet build "AspNetCore.RazorApi.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "AspNetCore.RazorApi.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "AspNetCore.RazorApi.dll"]