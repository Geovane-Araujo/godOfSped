namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1926
{
    public String REG { get; set; } = "1926";

    public String COD_OR { get; set; }

    public String VL_OR { get; set; }

    public String DT_VCTO { get; set; }

    public String COD_REC { get; set; }

    public String NUM_PROC { get; set; }

    public String IND_PROC { get; set; }

    public String PROC { get; set; }

    public String TXT_COMPL { get; set; }

    public String MES_REF { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{DT_VCTO}|{COD_REC}|{COD_OR}|{VL_OR}|{NUM_PROC}|{IND_PROC}|{PROC}|{TXT_COMPL}|{MES_REF}|";
        
        return ret;
    }

    
}