
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoA010
{
    public String REG { get; } = "A010";
    
    public String CNPJ { get; set; }
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{CNPJ}|";
        
        return ret;
    }
}