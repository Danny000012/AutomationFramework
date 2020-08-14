using System;

namespace Framework.Models
{
    public class WithDrawalFailed : Message
    {
        public override string ResultMessage {get; set; } = "Transaction Failed. You can not withdraw amount more than the balance.";
    }
}
