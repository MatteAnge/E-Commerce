﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:4.0.30319.42000
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_Commerce.E_CommerceServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="E_CommerceServiceReference.IServiceE_Commerce")]
    public interface IServiceE_Commerce {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceE_Commerce/Connection", ReplyAction="http://tempuri.org/IServiceE_Commerce/ConnectionResponse")]
        void Connection();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceE_Commerce/Connection", ReplyAction="http://tempuri.org/IServiceE_Commerce/ConnectionResponse")]
        System.Threading.Tasks.Task ConnectionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceE_Commerce/DoWork", ReplyAction="http://tempuri.org/IServiceE_Commerce/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceE_Commerce/DoWork", ReplyAction="http://tempuri.org/IServiceE_Commerce/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceE_Commerce/saluto", ReplyAction="http://tempuri.org/IServiceE_Commerce/salutoResponse")]
        string saluto(string nome);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceE_Commerce/saluto", ReplyAction="http://tempuri.org/IServiceE_Commerce/salutoResponse")]
        System.Threading.Tasks.Task<string> salutoAsync(string nome);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceE_CommerceChannel : E_Commerce.E_CommerceServiceReference.IServiceE_Commerce, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceE_CommerceClient : System.ServiceModel.ClientBase<E_Commerce.E_CommerceServiceReference.IServiceE_Commerce>, E_Commerce.E_CommerceServiceReference.IServiceE_Commerce {
        
        public ServiceE_CommerceClient() {
        }
        
        public ServiceE_CommerceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceE_CommerceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceE_CommerceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceE_CommerceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Connection() {
            base.Channel.Connection();
        }
        
        public System.Threading.Tasks.Task ConnectionAsync() {
            return base.Channel.ConnectionAsync();
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public string saluto(string nome) {
            return base.Channel.saluto(nome);
        }
        
        public System.Threading.Tasks.Task<string> salutoAsync(string nome) {
            return base.Channel.salutoAsync(nome);
        }
    }
}
