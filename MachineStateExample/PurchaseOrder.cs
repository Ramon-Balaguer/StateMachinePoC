using MachineStateExample.PurchaseOrderStates;

namespace MachineStateExample;

class PurchaseOrder
{
    private StateMachine _state;
    public PurchaseOrder()
    {
        _state = new CreatedState(this);
    }
    public void ChangeState(StateMachine state)
    {
        this._state = state;
    }
    
    public void Created()
    {
        this._state.Created();
    }

    public void WithError(Errors error)
    {
        this._state.WithError(error);
    }

    public void Sent()
    {
        this._state.Sent();
    }

    public bool HasError()
    {
        return this._state is WithErrorsState;
    }
    
    public string GetErrorName()
    {
        if (this._state is WithErrorsState errorsState)
        {
            return errorsState.ToString();
        }
        return String.Empty;
    }
}