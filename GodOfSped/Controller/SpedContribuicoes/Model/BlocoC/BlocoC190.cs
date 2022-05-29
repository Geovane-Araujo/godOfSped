
namespace GodOfSped.Model.SpedContribuicoes.Model;

public class BlocoC190
{
    public String REG { get; } = "C190";
    
    public String COD_MOD { get; set; } = "";
    
    public String DT_REF_INI { get; set; } = "";
    
    public String DT_REF_FIN { get; set; } = "";
    
    public String COD_ITEM { get; set; } = "";
    
    public String COD_NCM { get; set; } = "";
    
    public String EX_IPI { get; set; } = "";
    
    public String VL_TOT_ITEM { get; set; } = "";
    
    
    public String ToString()
    {
        String ret = $"|{REG}|{COD_MOD}|{DT_REF_INI}|{DT_REF_FIN}|{COD_ITEM}|{COD_NCM}|{EX_IPI}|" +
                     $"{VL_TOT_ITEM}|";
        return ret;
    }
}