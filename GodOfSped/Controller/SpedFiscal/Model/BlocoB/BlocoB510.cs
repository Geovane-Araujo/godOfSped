namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoB510
{
    public String REG { get; set; } = "B510";
    
    public String IND_PROF { get; set; }
    
    public String IND_ESC { get; set; }
    
    public String IND_SOC { get; set; }
    
    public String CPF { get; set; }
    
    public String NOME { get; set; } 

    public String ToString()
    {
        String ret = $"|{REG}|{IND_PROF}|{IND_ESC}|{IND_SOC}|{CPF}|{NOME}";
        
        return ret;
    }
}