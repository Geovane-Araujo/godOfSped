namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1350
{
    public String REG { get; set; } = "1350";

    public String SERIE { get; set; }

    public String FABRICANTE { get; set; }

    public String MODELO { get; set; }

    public String TIPO_MEDICAO { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{MODELO}|{TIPO_MEDICAO}|{SERIE}|{FABRICANTE}|";
        
        return ret;
    }

    
}