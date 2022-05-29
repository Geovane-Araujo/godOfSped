namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC174
{
    public String REG { get; set; } = "C174";
    
    public String IND_ARM { get; set; }

    public String NUM_ARM { get; set; }
    
    public String DESCR_COMPL { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{IND_ARM}|{NUM_ARM}|{DESCR_COMPL}|";
        
        return ret;
    }
}