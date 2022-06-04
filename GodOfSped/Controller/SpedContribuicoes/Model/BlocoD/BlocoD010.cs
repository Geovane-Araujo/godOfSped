
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoD010
{
    public String REG { get; } = "D010";

    public String CNPJ { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{CNPJ}|";
        
        return ret;
    }
}