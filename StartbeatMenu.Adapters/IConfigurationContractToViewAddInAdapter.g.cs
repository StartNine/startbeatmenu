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
    
    public class IConfigurationContractToViewAddInAdapter : StartbeatMenu.Views.IConfiguration
    {
        private Start9.Api.Contracts.IConfigurationContract _contract;
        private System.AddIn.Pipeline.ContractHandle _handle;
        static IConfigurationContractToViewAddInAdapter()
        {
        }
        public IConfigurationContractToViewAddInAdapter(Start9.Api.Contracts.IConfigurationContract contract)
        {
            _contract = contract;
            _handle = new System.AddIn.Pipeline.ContractHandle(contract);
        }
        public System.Collections.Generic.IList<StartbeatMenu.Views.IConfigurationEntry> Entries
        {
            get
            {
                return System.AddIn.Pipeline.CollectionAdapters.ToIList<Start9.Api.Contracts.IConfigurationEntryContract, StartbeatMenu.Views.IConfigurationEntry>(_contract.Entries, StartbeatMenu.Adapters.IConfigurationEntryAddInAdapter.ContractToViewAdapter, StartbeatMenu.Adapters.IConfigurationEntryAddInAdapter.ViewToContractAdapter);
            }
        }
        internal Start9.Api.Contracts.IConfigurationContract GetSourceContract()
        {
            return _contract;
        }
    }
}

