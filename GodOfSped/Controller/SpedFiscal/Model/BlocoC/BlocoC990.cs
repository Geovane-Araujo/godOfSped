namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class BlocoC990
{
    public String REG { get; set; } = "C990";
    
    public String QTD_LIN_C { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{QTD_LIN_C}|";
        
        return ret;
    }
}