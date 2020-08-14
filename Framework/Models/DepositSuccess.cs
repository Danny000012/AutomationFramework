using System;

namespace Framework.Models
{
    public class DepositSuccess : Message
    {
        public override string ResultMessage {get; set; } = "Deposit Successful";
    }
}
