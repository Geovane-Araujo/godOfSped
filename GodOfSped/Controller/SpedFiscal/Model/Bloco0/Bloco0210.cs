namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class Bloco0210
{
    public String REG { get; set; } = "0210";
    
    public String COD_ITEM_COMP { get; set; }
    
    public String QTD_COMP { get; set; }
    
    public String PERDA { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{COD_ITEM_COMP}|{QTD_COMP}|{PERDA}|";
        
        return ret;
    }
}