namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1600
{
    public String REG { get; set; } = "1600";

    public String COD_PART { get; set; }

    public String TOT_CREDITO { get; set; }

    public String TOT_DEBITO { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{TOT_DEBITO}|{COD_PART}|{TOT_CREDITO}|";
        
        return ret;
    }

    
}