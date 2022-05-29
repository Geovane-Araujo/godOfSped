
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoI010
{
    public String REG { get; } = "I010";
    
    public String CNPJ { get; set; } = "";
    
    public String IND_ATIV { get; set; } = "";
    
    public String INFO_COMPL { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{CNPJ}|{IND_ATIV}|{INFO_COMPL}|";
        
        return ret;
    }
}