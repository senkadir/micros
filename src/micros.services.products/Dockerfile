FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /app
EXPOSE 80

RUN mkdir -p /micros.services.infrastructure/ 
RUN mkdir -p /micros.services.products/


COPY src/micros.services.infrastructure/ ./micros.services.infrastructure/
COPY src/micros.services.products/ ./micros.services.products


RUN dotnet restore ./micros.services.products/
RUN dotnet publish ./micros.services.products/ -c Release -o /app/out

FROM microsoft/dotnet:2.1-aspnetcore-runtime AS runtime
 
WORKDIR /app
 
COPY --from=build /app/out .
 
ENTRYPOINT ["dotnet","micros.services.products.dll"]