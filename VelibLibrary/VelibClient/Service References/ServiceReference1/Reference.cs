﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VelibClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IVelibService")]
    public interface IVelibService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/searchStations", ReplyAction="http://tempuri.org/IVelibService/searchStationsResponse")]
        string searchStations(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/searchStations", ReplyAction="http://tempuri.org/IVelibService/searchStationsResponse")]
        System.Threading.Tasks.Task<string> searchStationsAsync(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/searchBikeNum", ReplyAction="http://tempuri.org/IVelibService/searchBikeNumResponse")]
        string searchBikeNum(string city, string station);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/searchBikeNum", ReplyAction="http://tempuri.org/IVelibService/searchBikeNumResponse")]
        System.Threading.Tasks.Task<string> searchBikeNumAsync(string city, string station);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/getCities", ReplyAction="http://tempuri.org/IVelibService/getCitiesResponse")]
        string getCities();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/getCities", ReplyAction="http://tempuri.org/IVelibService/getCitiesResponse")]
        System.Threading.Tasks.Task<string> getCitiesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVelibServiceChannel : VelibClient.ServiceReference1.IVelibService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VelibServiceClient : System.ServiceModel.ClientBase<VelibClient.ServiceReference1.IVelibService>, VelibClient.ServiceReference1.IVelibService {
        
        public VelibServiceClient() {
        }
        
        public VelibServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VelibServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VelibServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VelibServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string searchStations(string city) {
            return base.Channel.searchStations(city);
        }
        
        public System.Threading.Tasks.Task<string> searchStationsAsync(string city) {
            return base.Channel.searchStationsAsync(city);
        }
        
        public string searchBikeNum(string city, string station) {
            return base.Channel.searchBikeNum(city, station);
        }
        
        public System.Threading.Tasks.Task<string> searchBikeNumAsync(string city, string station) {
            return base.Channel.searchBikeNumAsync(city, station);
        }
        
        public string getCities() {
            return base.Channel.getCities();
        }
        
        public System.Threading.Tasks.Task<string> getCitiesAsync() {
            return base.Channel.getCitiesAsync();
        }
    }
}
