namespace GodOfSped.Controller.SpedFiscal.Model.Bloco1;

public class Bloco1970
{
    public String REG { get; set; } = "1970";

    public String IND_AP { get; set; }

    public String G3_01 { get; set; }

    public String G3_02 { get; set; }

    public String G3_03 { get; set; }

    public String G3_04 { get; set; }

    public String G3_05 { get; set; }

    public String G3_06 { get; set; }

    public String G3_07 { get; set; }

    public String G3_T { get; set; }

    public String G3_08 { get; set; }

    public String G3_09 { get; set; }


    public String ToString()
    {
        String ret = $"|{REG}|{G3_02}|{G3_03}|{IND_AP}|{G3_01}|{G3_04}|{G3_05}|{G3_06}|{G3_07}|{G3_T}|{G3_08}|{G3_09}|";
        
        return ret;
    }

    
}