//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StartbeatMenu.Views
{
    
    public interface IHost
    {
        void SendMessage(IMessage message);
        void SaveConfiguration(IModule module);
        System.Collections.Generic.IList<IModule> GetModules();
        IConfiguration GetGlobalConfiguration();
    }
}

