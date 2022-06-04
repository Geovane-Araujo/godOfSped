namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1105
{
    public String REG { get; set; } = "1105";

    public String COD_MOD { get; set; }

    public String SERIE { get; set; }

    public String NUM_DOC { get; set; }

    public String CHV_NFE { get; set; }

    public String DT_DOC { get; set; }

    public String COD_ITEM { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{NUM_DOC}|{CHV_NFE}|{COD_MOD}|{SERIE}|{DT_DOC}|{COD_ITEM}|";
        
        return ret;
    }

    
}