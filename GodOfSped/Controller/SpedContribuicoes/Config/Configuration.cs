namespace GodOfSped.Model.SpedContribuicoes;

public class Configuration
{
    public bool geraC { get; set; } = false;
    
    public Configuration(bool geraC)
    {
        this.geraC = geraC;
    }
}