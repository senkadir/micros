FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app
EXPOSE 80
 
COPY src/micros.gateway/*.csproj ./

RUN dotnet restore 

COPY src/micros.gateway/. ./

RUN dotnet publish -c Release -o out

FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
 
WORKDIR /app
 
COPY --from=build /app/out .
 
ENTRYPOINT ["dotnet","micros.gateway.dll"]