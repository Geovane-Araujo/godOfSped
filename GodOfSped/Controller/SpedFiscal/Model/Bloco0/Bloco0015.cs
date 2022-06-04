namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class Bloco0015
{
    public String REG { get; set; } = "0015";
    public String UF_ST { get; set; }
    public String IE_ST { get; set; }
    
   

    public String ToString()
    {
        String ret = $"|{REG}|{UF_ST}|{IE_ST}|";
        
        return ret;
    }
}