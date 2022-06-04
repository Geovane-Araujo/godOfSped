namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC114
{
    public String REG { get; set; } = "C114";

    public String COD_MOD { get; set; }

    public String ECF_FAB { get; set; }

    public String ECF_CX { get; set; }
    
    public String NUM_DOC { get; set; }

    public String DT_DOC { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOD}|{ECF_FAB}|{ECF_CX}|{NUM_DOC}|{DT_DOC}|";
        
        return ret;
    }
}