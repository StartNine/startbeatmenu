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
    
    public class IConfigurationAddInAdapter
    {
        internal static StartbeatMenu.Views.IConfiguration ContractToViewAdapter(Start9.Api.Contracts.IConfigurationContract contract)
        {
            if ((contract == null))
            {
                return null;
            }
            if (((System.Runtime.Remoting.RemotingServices.IsObjectOutOfAppDomain(contract) != true) 
                        && contract.GetType().Equals(typeof(IConfigurationViewToContractAddInAdapter))))
            {
                return ((IConfigurationViewToContractAddInAdapter)(contract)).GetSourceView();
            }
            else
            {
                return new IConfigurationContractToViewAddInAdapter(contract);
            }
        }
        internal static Start9.Api.Contracts.IConfigurationContract ViewToContractAdapter(StartbeatMenu.Views.IConfiguration view)
        {
            if ((view == null))
            {
                return null;
            }
            if (view.GetType().Equals(typeof(IConfigurationContractToViewAddInAdapter)))
            {
                return ((IConfigurationContractToViewAddInAdapter)(view)).GetSourceContract();
            }
            else
            {
                return new IConfigurationViewToContractAddInAdapter(view);
            }
        }
    }
}

