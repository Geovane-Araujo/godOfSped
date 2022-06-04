namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1360
{
    public String REG { get; set; } = "1360";

    public String NUM_LACRE { get; set; }

    public String DT_APLICACAO { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{NUM_LACRE}|{DT_APLICACAO}|";
        
        return ret;
    }

    
}