namespace GodOfSped.Controller.SpedFiscal.Model.Bloco9;

public class BlocoC179
{
    public String REG { get; set; } = "C179";

    public String BC_ST_ORIG_DEST { get; set; }

    public String ICMS_ST_REP { get; set; }

    public String ICMS_ST_COMPL { get; set; }
    
    public String BC_RET { get; set; }

    public String ICMS_RET { get; set; }

    public String ToString()
    {
        String ret = $"|{REG}|{BC_ST_ORIG_DEST}|{ICMS_ST_REP}|{ICMS_ST_COMPL}|{BC_RET}|{ICMS_RET}|";
     
        return ret;
    }
}