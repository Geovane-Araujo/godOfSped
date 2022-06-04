namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class Bloco0220
{
    public String REG { get; set; } = "0220";
    
    public String UNID_CONV { get; set; }
    
    public String FAT_CONV { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{UNID_CONV}|{FAT_CONV}|";
        
        return ret;
    }
}