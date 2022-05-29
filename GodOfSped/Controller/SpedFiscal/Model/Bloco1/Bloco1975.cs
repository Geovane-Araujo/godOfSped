namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1975
{
    public String REG { get; set; } = "1975";

    public String ALIQ_IMP_BASE { get; set; }

    public String G3_10 { get; set; }

    public String G3_11 { get; set; }

    public String G3_12 { get; set; }

    

    public String ToString()
    {
        String ret = $"|{REG}|{G3_11}|{G3_12}|{ALIQ_IMP_BASE}|{G3_10}|";
        
        return ret;
    }

    
}