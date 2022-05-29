namespace GodOfSped.Controller.SpedFiscal.Model.Bloco0;

public class Bloco0300
{
    public String REG { get; set; } = "0300";
    
    public String COD_IND_BEM { get; set; }
    
    public String IDENT_MERC { get; set; }
    
    public String DESCR_ITEM { get; set; }
    
    public String COD_PRNC { get; set; }
    
    public String COD_CTA { get; set; }
    
    public String NR_PARC { get; set; }
    

    public String ToString()
    {
        String ret = $"|{REG}|{COD_IND_BEM}|{IDENT_MERC}|{DESCR_ITEM}|{COD_PRNC}|{COD_CTA}|{NR_PARC}|";
        
        return ret;
    }
}