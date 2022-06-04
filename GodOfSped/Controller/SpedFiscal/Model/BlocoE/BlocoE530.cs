namespace GodOfSped.Controller.SpedFiscal.Model.BlocoE;

public class BlocoE530
{
    public String REG { get; set; } = "E530";

    public String IND_AJ { get; set; }

    public String VL_AJ { get; set; }

    public String COD_AJ { get; set; }

    public String IND_DOC { get; set; }

    public String NUM_DOC { get; set; } 

    public String DESCR_AJ { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_AJ}|{VL_AJ}|{COD_AJ}|{IND_DOC}|{NUM_DOC}|{DESCR_AJ}|";
        
        return ret;
    }
    
}