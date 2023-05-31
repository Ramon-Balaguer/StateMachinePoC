using MachineStateExample;
using MachineStateExample.PurchaseOrderStates;

var purchaseOrder = new PurchaseOrder();
purchaseOrder.Sent();
purchaseOrder.WithError(Errors.IncorrectCif);
if (purchaseOrder.HasError())
    Console.WriteLine(purchaseOrder.GetErrorName());
purchaseOrder.WithError(Errors.ClientNotExist);
purchaseOrder.Created();

