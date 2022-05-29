namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC177
{
    public String REG { get; set; } = "C177";

    public String COD_INF_ITEM { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{COD_INF_ITEM}|";
        
        return ret;
    }
}