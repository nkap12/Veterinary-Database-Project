
# Veterinary Database Project

## Run

### Add connection string to 
SchoolDemo/SchoolDemo/appsettings.json

```

{
    "ConnectionStrings": {
      "SchoolProjectConnection": " Your SQL Server Connection String Here"
    }
} 

```


```
- dotnet restore
- dotnet ef database update
- dotnet run

```