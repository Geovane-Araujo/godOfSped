
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoC010
{
    public String REG { get; } = "C010";
    
    public String CNPJ { get; set; } = "";
    
    public String IND_ESCRI { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{CNPJ}|{IND_ESCRI}|";
        
        return ret;
    }
}