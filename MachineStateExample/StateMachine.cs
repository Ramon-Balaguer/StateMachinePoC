using MachineStateExample.PurchaseOrderStates;

namespace MachineStateExample;

abstract class StateMachine
{
    protected readonly PurchaseOrder PurchaseOrder;

    protected StateMachine(PurchaseOrder purchaseOrder)
    {
        PurchaseOrder = purchaseOrder;
    }
    
    public abstract void Created();

    public abstract void WithError(Errors error);

    public abstract void Sent();
}