﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UtnEmall.ServerManager.SAL.StatisticsAnalyzer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SAL.StatisticsAnalyzer.IStatisticsAnalyzer")]
    public interface IStatisticsAnalyzer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsAnalyzer/GetRegistersClickAmount", ReplyAction="http://tempuri.org/IStatisticsAnalyzer/GetRegistersClickAmountResponse")]
        [UtnEmall.Server.Core.ReferencePreservingDataContractFormat]
        System.Collections.Generic.List<System.Collections.DictionaryEntry> GetRegistersClickAmount(UtnEmall.Server.EntityModel.ComponentEntity listFormComponent, string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsAnalyzer/GetRegisterClickPercentageAmount", ReplyAction="http://tempuri.org/IStatisticsAnalyzer/GetRegisterClickPercentageAmountResponse")]
        [UtnEmall.Server.Core.ReferencePreservingDataContractFormat]
        System.Collections.Generic.List<System.Collections.DictionaryEntry> GetRegisterClickPercentageAmount(UtnEmall.Server.EntityModel.ComponentEntity listFormComponent, string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsAnalyzer/GetCustomersAccessAmount", ReplyAction="http://tempuri.org/IStatisticsAnalyzer/GetCustomersAccessAmountResponse")]
        [UtnEmall.Server.Core.ReferencePreservingDataContractFormat]
        System.Collections.Generic.List<System.Collections.DictionaryEntry> GetCustomersAccessAmount(string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsAnalyzer/GetCustomersTimeAmountByStore", ReplyAction="http://tempuri.org/IStatisticsAnalyzer/GetCustomersTimeAmountByStoreResponse")]
        [UtnEmall.Server.Core.ReferencePreservingDataContractFormat]
        System.Collections.Generic.List<System.Collections.DictionaryEntry> GetCustomersTimeAmountByStore(UtnEmall.Server.EntityModel.StoreEntity store, string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsAnalyzer/GetCustomersAccessAmountByStore", ReplyAction="http://tempuri.org/IStatisticsAnalyzer/GetCustomersAccessAmountByStoreResponse")]
        [UtnEmall.Server.Core.ReferencePreservingDataContractFormat]
        System.Collections.Generic.List<System.Collections.DictionaryEntry> GetCustomersAccessAmountByStore(UtnEmall.Server.EntityModel.StoreEntity store, string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsAnalyzer/GetCustomersTimeAmount", ReplyAction="http://tempuri.org/IStatisticsAnalyzer/GetCustomersTimeAmountResponse")]
        [UtnEmall.Server.Core.ReferencePreservingDataContractFormat]
        System.Collections.Generic.List<System.Collections.DictionaryEntry> GetCustomersTimeAmount(string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsAnalyzer/GetCustomerAccessAmount", ReplyAction="http://tempuri.org/IStatisticsAnalyzer/GetCustomerAccessAmountResponse")]
        [UtnEmall.Server.Core.ReferencePreservingDataContractFormat]
        System.Collections.Generic.List<System.Collections.DictionaryEntry> GetCustomerAccessAmount(int customerId, string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsAnalyzer/GetCustomerTimeAmount", ReplyAction="http://tempuri.org/IStatisticsAnalyzer/GetCustomerTimeAmountResponse")]
        [UtnEmall.Server.Core.ReferencePreservingDataContractFormat]
        System.Collections.Generic.List<System.Collections.DictionaryEntry> GetCustomerTimeAmount(int customerId, string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsAnalyzer/GetCustomerFormAccessAmount", ReplyAction="http://tempuri.org/IStatisticsAnalyzer/GetCustomerFormAccessAmountResponse")]
        [UtnEmall.Server.Core.ReferencePreservingDataContractFormat]
        int GetCustomerFormAccessAmount(UtnEmall.Server.EntityModel.ComponentEntity component, string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsAnalyzer/GetFormAccessAmount", ReplyAction="http://tempuri.org/IStatisticsAnalyzer/GetFormAccessAmountResponse")]
        [UtnEmall.Server.Core.ReferencePreservingDataContractFormat]
        int GetFormAccessAmount(UtnEmall.Server.EntityModel.ComponentEntity component, string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsAnalyzer/GetMenuItemAccessAmounts", ReplyAction="http://tempuri.org/IStatisticsAnalyzer/GetMenuItemAccessAmountsResponse")]
        [UtnEmall.Server.Core.ReferencePreservingDataContractFormat]
        System.Collections.Generic.List<System.Collections.DictionaryEntry> GetMenuItemAccessAmounts(UtnEmall.Server.EntityModel.ComponentEntity component, string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsAnalyzer/GetMenuItemAccessAmount", ReplyAction="http://tempuri.org/IStatisticsAnalyzer/GetMenuItemAccessAmountResponse")]
        [UtnEmall.Server.Core.ReferencePreservingDataContractFormat]
        int GetMenuItemAccessAmount(UtnEmall.Server.EntityModel.ComponentEntity component, string session);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IStatisticsAnalyzerChannel : ServerManager.SAL.StatisticsAnalyzer.IStatisticsAnalyzer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class StatisticsAnalyzerClient : System.ServiceModel.ClientBase<ServerManager.SAL.StatisticsAnalyzer.IStatisticsAnalyzer>, ServerManager.SAL.StatisticsAnalyzer.IStatisticsAnalyzer {
        
        public StatisticsAnalyzerClient() {
        }
        
        public StatisticsAnalyzerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StatisticsAnalyzerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StatisticsAnalyzerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StatisticsAnalyzerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<System.Collections.DictionaryEntry> GetRegistersClickAmount(UtnEmall.Server.EntityModel.ComponentEntity listFormComponent, string session) {
            return base.Channel.GetRegistersClickAmount(listFormComponent, session);
        }
        
        public System.Collections.Generic.List<System.Collections.DictionaryEntry> GetRegisterClickPercentageAmount(UtnEmall.Server.EntityModel.ComponentEntity listFormComponent, string session) {
            return base.Channel.GetRegisterClickPercentageAmount(listFormComponent, session);
        }
        
        public System.Collections.Generic.List<System.Collections.DictionaryEntry> GetCustomersAccessAmount(string session) {
            return base.Channel.GetCustomersAccessAmount(session);
        }
        
        public System.Collections.Generic.List<System.Collections.DictionaryEntry> GetCustomersTimeAmountByStore(UtnEmall.Server.EntityModel.StoreEntity store, string session) {
            return base.Channel.GetCustomersTimeAmountByStore(store, session);
        }
        
        public System.Collections.Generic.List<System.Collections.DictionaryEntry> GetCustomersAccessAmountByStore(UtnEmall.Server.EntityModel.StoreEntity store, string session) {
            return base.Channel.GetCustomersAccessAmountByStore(store, session);
        }
        
        public System.Collections.Generic.List<System.Collections.DictionaryEntry> GetCustomersTimeAmount(string session) {
            return base.Channel.GetCustomersTimeAmount(session);
        }
        
        public System.Collections.Generic.List<System.Collections.DictionaryEntry> GetCustomerAccessAmount(int customerId, string session) {
            return base.Channel.GetCustomerAccessAmount(customerId, session);
        }
        
        public System.Collections.Generic.List<System.Collections.DictionaryEntry> GetCustomerTimeAmount(int customerId, string session) {
            return base.Channel.GetCustomerTimeAmount(customerId, session);
        }
        
        public int GetCustomerFormAccessAmount(UtnEmall.Server.EntityModel.ComponentEntity component, string session) {
            return base.Channel.GetCustomerFormAccessAmount(component, session);
        }
        
        public int GetFormAccessAmount(UtnEmall.Server.EntityModel.ComponentEntity component, string session) {
            return base.Channel.GetFormAccessAmount(component, session);
        }
        
        public System.Collections.Generic.List<System.Collections.DictionaryEntry> GetMenuItemAccessAmounts(UtnEmall.Server.EntityModel.ComponentEntity component, string session) {
            return base.Channel.GetMenuItemAccessAmounts(component, session);
        }
        
        public int GetMenuItemAccessAmount(UtnEmall.Server.EntityModel.ComponentEntity component, string session) {
            return base.Channel.GetMenuItemAccessAmount(component, session);
        }
    }
}