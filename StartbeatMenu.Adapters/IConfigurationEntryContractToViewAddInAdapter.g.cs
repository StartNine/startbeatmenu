//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StartbeatMenu.Adapters
{
    
    public class IConfigurationEntryContractToViewAddInAdapter : StartbeatMenu.Views.IConfigurationEntry
    {
        private Start9.Api.Contracts.IConfigurationEntryContract _contract;
        private System.AddIn.Pipeline.ContractHandle _handle;
        static IConfigurationEntryContractToViewAddInAdapter()
        {
        }
        public IConfigurationEntryContractToViewAddInAdapter(Start9.Api.Contracts.IConfigurationEntryContract contract)
        {
            _contract = contract;
            _handle = new System.AddIn.Pipeline.ContractHandle(contract);
        }
        public object Object
        {
            get
            {
                return _contract.Object;
            }
        }
        public string FriendlyName
        {
            get
            {
                return _contract.FriendlyName;
            }
        }
        internal Start9.Api.Contracts.IConfigurationEntryContract GetSourceContract()
        {
            return _contract;
        }
    }
}

