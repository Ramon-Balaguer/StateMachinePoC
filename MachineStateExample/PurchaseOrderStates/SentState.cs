namespace MachineStateExample.PurchaseOrderStates;

class SentState : StateMachine
{
    public SentState(PurchaseOrder purchaseOrder) : base(purchaseOrder)
    {
    }

    public override void Created()
    {
        throw new Exception("Can't change state from WithErrorsState to CreatedState");
    }

    public override void WithError(Errors error)
    {
        this.PurchaseOrder.ChangeState(new WithErrorsState(this.PurchaseOrder, error));
    }

    public override void Sent()
    {
        throw new Exception("Can't send twice");
    }

}