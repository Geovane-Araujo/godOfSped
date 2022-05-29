namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC120
{
    public String REG { get; set; } = "C120";

    public String COD_DOC_IMP { get; set; }

    public String NUM_DOC__IMP { get; set; }

    public String PIS_IMP { get; set; }
    
    public String COFINS_IMP { get; set; }

    public String NUM_ACDRAW { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_DOC_IMP}|{NUM_DOC__IMP}||{PIS_IMP}|{COFINS_IMP}|{NUM_ACDRAW}|";
        
        return ret;
    }
}