namespace MachineStateExample.PurchaseOrderStates;

class WithErrorsState : StateMachine
{
    private Errors _error;

    public WithErrorsState(PurchaseOrder purchaseOrder, Errors error) : base(purchaseOrder)
    {
        _error = error;
    }

    public override void Created()
    {
        throw new Exception("Can't change state from WithErrorsState to CreatedState");
    }

    public override void WithError(Errors error)
    {
        this._error = error;
    }

    public override void Sent()
    {
        throw new Exception("Can't change state from WithErrorsState to SentState");
    }

    public override string ToString()
    {
        return _error.Name;
    }
}