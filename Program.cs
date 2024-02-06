var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Välkommen till Krypteraren! Skriv /kryptera eller /avkryptera följt av ");

app.MapGet("/kryptera", (string text, int skillnad) => Cipher(text, skillnad));

app.MapGet("/avkryptera", (string text, int skillnad) => Cipher(text, -skillnad));

app.Run();

static string Cipher(string text, int skillnad)
{
    string resultat = "";

    foreach (char c in text)
    {
        if (char.IsLetter(c))
        {
            char skillnadBokstav = (char)(c + skillnad);

            if ((char.IsLower(c) && skillnadBokstav > 'z') || (char.IsUpper(c) && skillnadBokstav > 'Z'))
            {
                skillnadBokstav = (char)(c - (26 - skillnad));
            }

            resultat += skillnadBokstav;
        }
        else
        {
            resultat += c;
        }
    }

    return resultat;
}
