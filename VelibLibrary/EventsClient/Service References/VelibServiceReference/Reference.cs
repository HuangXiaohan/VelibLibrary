﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventsClient.VelibServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VelibServiceReference.IVelibService", CallbackContract=typeof(EventsClient.VelibServiceReference.IVelibServiceCallback))]
    public interface IVelibService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/GetBikeNum", ReplyAction="http://tempuri.org/IVelibService/GetBikeNumResponse")]
        void GetBikeNum(string city, string station);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/GetBikeNum", ReplyAction="http://tempuri.org/IVelibService/GetBikeNumResponse")]
        System.Threading.Tasks.Task GetBikeNumAsync(string city, string station);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/SubscribeGottrnBikeNumEvent", ReplyAction="http://tempuri.org/IVelibService/SubscribeGottrnBikeNumEventResponse")]
        void SubscribeGottrnBikeNumEvent();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/SubscribeGottrnBikeNumEvent", ReplyAction="http://tempuri.org/IVelibService/SubscribeGottrnBikeNumEventResponse")]
        System.Threading.Tasks.Task SubscribeGottrnBikeNumEventAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/SubscribeGottenFinishedEvent", ReplyAction="http://tempuri.org/IVelibService/SubscribeGottenFinishedEventResponse")]
        void SubscribeGottenFinishedEvent();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/SubscribeGottenFinishedEvent", ReplyAction="http://tempuri.org/IVelibService/SubscribeGottenFinishedEventResponse")]
        System.Threading.Tasks.Task SubscribeGottenFinishedEventAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVelibServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IVelibService/GottenBikeNum")]
        void GottenBikeNum(string city, string station, string num);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IVelibService/GottenFinished")]
        void GottenFinished();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVelibServiceChannel : EventsClient.VelibServiceReference.IVelibService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VelibServiceClient : System.ServiceModel.DuplexClientBase<EventsClient.VelibServiceReference.IVelibService>, EventsClient.VelibServiceReference.IVelibService {
        
        public VelibServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public VelibServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public VelibServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public VelibServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public VelibServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void GetBikeNum(string city, string station) {
            base.Channel.GetBikeNum(city, station);
        }
        
        public System.Threading.Tasks.Task GetBikeNumAsync(string city, string station) {
            return base.Channel.GetBikeNumAsync(city, station);
        }
        
        public void SubscribeGottrnBikeNumEvent() {
            base.Channel.SubscribeGottrnBikeNumEvent();
        }
        
        public System.Threading.Tasks.Task SubscribeGottrnBikeNumEventAsync() {
            return base.Channel.SubscribeGottrnBikeNumEventAsync();
        }
        
        public void SubscribeGottenFinishedEvent() {
            base.Channel.SubscribeGottenFinishedEvent();
        }
        
        public System.Threading.Tasks.Task SubscribeGottenFinishedEventAsync() {
            return base.Channel.SubscribeGottenFinishedEventAsync();
        }
    }
}