FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine as build

WORKDIR /usr/src/app
COPY . /usr/src/app

RUN dotnet restore && \
    dotnet publish -r linux-x64 -c Release -o out

FROM mcr.microsoft.com/dotnet/core/runtime:3.1-alpine

ENV API_TOKEN=abc
ENV API_TOKEN_PASSWORD=abc

WORKDIR /usr/src/app
COPY --from=build /usr/src/app/out /usr/src/app

ENTRYPOINT [ "VCLI" ]