namespace GodOfSped.Model.NFe;

public class Imposto
{
    public Decimal vTotTrib { get; set; }
    
    public Icms ICMS { get; set; }
}

public class Icms
{
    public Icms00 ICMS00 { get; set; }
    
    
}

public class Icms00
{
}