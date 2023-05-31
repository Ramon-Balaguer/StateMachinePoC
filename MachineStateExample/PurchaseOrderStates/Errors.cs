using Ardalis.SmartEnum;

namespace MachineStateExample.PurchaseOrderStates;

public class Errors: SmartEnum<Errors>
{
    public static Errors IncorrectCif = new(nameof(IncorrectCif), 1);
    public static Errors ClientNotExist = new(nameof(ClientNotExist), 2);

    private Errors(string name, int id)
        : base(name, id)
    {
    }
}