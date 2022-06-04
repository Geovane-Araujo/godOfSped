namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class Bloco0190
{
    public String REG { get; set; } = "0190";
    
    public String UNID { get; set; }
    
    public String DESCR { get; set; }
    
    

    public String ToString()
    {
        String ret = $"|{REG}|{UNID}|{DESCR}|";
        
        return ret;
    }
}