var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Use /crypt or /decrypt");

app.MapGet("/crypt", (int num1, int num2) => AddNumbers(num1, num2));

app.MapGet("/decrypt", (int num1, int num2) => SubNumbers(num1, num2));

app.Run();

string AddNumbers(int num1, int num2)
    {
        return $"summan är {num1 + num2}";
    }
string SubNumbers(int num1, int num2)
    {
        return $"summan är {num1 - num2}";
    }