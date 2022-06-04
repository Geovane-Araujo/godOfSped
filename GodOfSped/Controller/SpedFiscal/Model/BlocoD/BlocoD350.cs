namespace GodOfSped.Controller.SpedFiscal.Model.BlocoB;

public class BlocoD350
{
    public String REG { get; set; } = "D350";

    public String COD_MOD { get; set; }
    
    public String ECF_MOD { get; set; }
    
    public String ECF_FAB  { get; set; }
    
    public String ECF_CX { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOD}|{ECF_MOD}|{ECF_FAB}|{ECF_CX}|";
        
        return ret;
    }
}