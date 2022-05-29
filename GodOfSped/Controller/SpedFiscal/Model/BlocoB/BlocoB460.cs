namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoB460
{
    public String REG { get; set; } = "B4600";
    
    public String IND_DED { get; set; }
    
    public String VL_DED { get; set; }
    
    public String NUM_PROC { get; set; }
    
    public String IND_PROC { get; set; }
    
    public String PROC { get; set; }
    
    public String COD_INF_OBS { get; set; } 

    public String IND_OBR { get; set; }  

    public String ToString()
    {
        String ret = $"|{REG}|{IND_DED}|{VL_DED}|{NUM_PROC}|{IND_PROC}|{PROC}|{COD_INF_OBS}|{IND_OBR}";
        
        return ret;
    }
}