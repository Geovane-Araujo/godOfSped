namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1700
{
    public String REG { get; set; } = "1700";

    public String COD_DISP { get; set; }

    public String SER { get; set; }

    public String SUB { get; set; }

    public String NUM_DOC_INI { get; set; }

    public String NUM_DOC_FIN { get; set; }

    public String COD_MOD { get; set; }

    public String NUM_AUT { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{SUB}|{NUM_DOC_INI}|{COD_DISP}|{SER}|{NUM_DOC_FIN}|{COD_MOD}|{NUM_AUT}|";
        
        return ret;
    }

    
}