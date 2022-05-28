
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco0110
{
    public String REG { get; } = "0110";
    
    public String COD_INC_TRIB { get; set; }
    
    public String IND_APRO_CRED { get; set; }
    
    public String COD_TIPO_CONT { get; set; }
    
    public String IND_REG_CUM { get; set; }

    
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_INC_TRIB}|{IND_APRO_CRED}|{COD_TIPO_CONT}|{IND_REG_CUM}|";
        
        return ret;
    }
}