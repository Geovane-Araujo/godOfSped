namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class Bloco0005
{
    public String REG { get; set; } = "0005";
    
    public String FANTASIA { get; set; }
    
    public String CEP { get; set; }
    
    public String END { get; set; }
    
    public String NUM { get; set; }
    
    public String COMPL { get; set; }
    
    public String BAIRRO { get; set; }
    
    public String FONE { get; set; }
    
    public String FAX { get; set; }
    
    public String EMAIL { get; set; }
    
    public String ToString()
    {
        String ret = $"|{REG}|{FANTASIA}|{CEP}|{END}|{NUM}|{COMPL}|{BAIRRO}|{FONE}|{FAX}|{EMAIL}|";
        
        return ret;
    }
}