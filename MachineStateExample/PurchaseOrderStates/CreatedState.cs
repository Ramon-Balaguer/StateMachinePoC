namespace MachineStateExample.PurchaseOrderStates;

class CreatedState : StateMachine
{
    public CreatedState(PurchaseOrder purchaseOrder) : base(purchaseOrder)
    {
    }

    public override void Created()
    {
    }

    public override void WithError(Errors error)
    {
        this.PurchaseOrder.ChangeState(new WithErrorsState(this.PurchaseOrder, error));
    }

    public override void Sent()
    {
        this.PurchaseOrder.ChangeState(new SentState(this.PurchaseOrder));
    }
}