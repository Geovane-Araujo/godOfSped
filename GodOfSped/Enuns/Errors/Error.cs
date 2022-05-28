using System.ComponentModel;

namespace GodOfSped.Enuns.Errors;

public enum Error
{
    [DefaultValue("Erro Não Catalogado %s")]
    GENERIC_ERROR,
    
    [DefaultValue("Existe um valor nulo no onjeto da classe %s")]
    NULL_POINTER

}