namespace Clasa_Carte;

public class Carte
{
    private const char SEPARATOR = ' ';
    public string Titlu { get; set; }
    public string Autor { get; set; }
    public string Editura { get; set; }
    public Carte()
    {
        Titlu = string.Empty;
        Autor = string.Empty;
        Editura = string.Empty;
    }
    public Carte(string titlu, string autor, string editura)
    {
        Titlu = titlu;
        Autor = autor;
        Editura = editura;
    }
    public enum CategorieVarsta
    {
        v0_18 = 1,
        v18_35 = 2,
        v35_60 = 3,
        vpeste60 = 4,
    };
    public string Info()
    {

        string info = $"Titlu:{Titlu ?? "NECUNOSCUT"} Autor:{Autor ?? "NECUNOSCUT"}  Editura: {Editura ?? "NECUNOSCUT"}";
        return info;       
    }   
}
    class Program
    {
        static void Main()
        {

        }
    }