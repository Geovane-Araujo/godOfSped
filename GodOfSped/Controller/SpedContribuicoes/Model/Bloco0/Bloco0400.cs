
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class Bloco0400
{
    public String REG { get; } = "0400";
    
    public String COD_NAT { get; set; }
    
    public String DESCR_NAT { get; set; }
 
    public String ToString()
    {
        String ret = $"|{REG}|{COD_NAT}|{DESCR_NAT}|";
        
        return ret;
    }
}