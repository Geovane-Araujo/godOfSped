namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC116
{
    public String REG { get; set; } = "C116";

    public String COD_MOD { get; set; }

    public String NR_SAT { get; set; }

    public String CHV_CFE { get; set; }
    
    public String NUM_CFE { get; set; }

    public String DT_DOC { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOD}|{NR_SAT}||{CHV_CFE}|{NUM_CFE}|{DT_DOC}|";
        
        return ret;
    }
}