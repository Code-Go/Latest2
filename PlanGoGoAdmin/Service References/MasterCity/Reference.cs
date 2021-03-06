﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlanGoGoAdmin.MasterCity {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MasterCity.IMasterCity")]
    public interface IMasterCity {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMasterCity/Admin_MasterCityCheckExists", ReplyAction="http://tempuri.org/IMasterCity/Admin_MasterCityCheckExistsResponse")]
        System.Collections.Generic.List<BusinessEntites.Admin.MasterCityDTO> Admin_MasterCityCheckExists(BusinessEntites.Admin.MasterCityDTO masterCityDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMasterCity/Admin_MasterCityCheckExists", ReplyAction="http://tempuri.org/IMasterCity/Admin_MasterCityCheckExistsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BusinessEntites.Admin.MasterCityDTO>> Admin_MasterCityCheckExistsAsync(BusinessEntites.Admin.MasterCityDTO masterCityDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMasterCity/Admin_MasterCityGet", ReplyAction="http://tempuri.org/IMasterCity/Admin_MasterCityGetResponse")]
        System.Collections.Generic.List<BusinessEntites.Admin.MasterCityDTO> Admin_MasterCityGet();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMasterCity/Admin_MasterCityGet", ReplyAction="http://tempuri.org/IMasterCity/Admin_MasterCityGetResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BusinessEntites.Admin.MasterCityDTO>> Admin_MasterCityGetAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMasterCity/Admin_MasterCityGetOnStateId", ReplyAction="http://tempuri.org/IMasterCity/Admin_MasterCityGetOnStateIdResponse")]
        System.Collections.Generic.List<BusinessEntites.Admin.MasterCityDTO> Admin_MasterCityGetOnStateId(int stateId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMasterCity/Admin_MasterCityGetOnStateId", ReplyAction="http://tempuri.org/IMasterCity/Admin_MasterCityGetOnStateIdResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BusinessEntites.Admin.MasterCityDTO>> Admin_MasterCityGetOnStateIdAsync(int stateId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMasterCity/Admin_MasterCityGetOnCityId", ReplyAction="http://tempuri.org/IMasterCity/Admin_MasterCityGetOnCityIdResponse")]
        BusinessEntites.Admin.MasterCityDTO Admin_MasterCityGetOnCityId(int cityId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMasterCity/Admin_MasterCityGetOnCityId", ReplyAction="http://tempuri.org/IMasterCity/Admin_MasterCityGetOnCityIdResponse")]
        System.Threading.Tasks.Task<BusinessEntites.Admin.MasterCityDTO> Admin_MasterCityGetOnCityIdAsync(int cityId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMasterCity/Admin_MasterCityUpdate", ReplyAction="http://tempuri.org/IMasterCity/Admin_MasterCityUpdateResponse")]
        void Admin_MasterCityUpdate(BusinessEntites.Admin.MasterCityDTO masterCityDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMasterCity/Admin_MasterCityUpdate", ReplyAction="http://tempuri.org/IMasterCity/Admin_MasterCityUpdateResponse")]
        System.Threading.Tasks.Task Admin_MasterCityUpdateAsync(BusinessEntites.Admin.MasterCityDTO masterCityDTO);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMasterCityChannel : PlanGoGoAdmin.MasterCity.IMasterCity, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MasterCityClient : System.ServiceModel.ClientBase<PlanGoGoAdmin.MasterCity.IMasterCity>, PlanGoGoAdmin.MasterCity.IMasterCity {
        
        public MasterCityClient() {
        }
        
        public MasterCityClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MasterCityClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MasterCityClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MasterCityClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<BusinessEntites.Admin.MasterCityDTO> Admin_MasterCityCheckExists(BusinessEntites.Admin.MasterCityDTO masterCityDTO) {
            return base.Channel.Admin_MasterCityCheckExists(masterCityDTO);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BusinessEntites.Admin.MasterCityDTO>> Admin_MasterCityCheckExistsAsync(BusinessEntites.Admin.MasterCityDTO masterCityDTO) {
            return base.Channel.Admin_MasterCityCheckExistsAsync(masterCityDTO);
        }
        
        public System.Collections.Generic.List<BusinessEntites.Admin.MasterCityDTO> Admin_MasterCityGet() {
            return base.Channel.Admin_MasterCityGet();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BusinessEntites.Admin.MasterCityDTO>> Admin_MasterCityGetAsync() {
            return base.Channel.Admin_MasterCityGetAsync();
        }
        
        public System.Collections.Generic.List<BusinessEntites.Admin.MasterCityDTO> Admin_MasterCityGetOnStateId(int stateId) {
            return base.Channel.Admin_MasterCityGetOnStateId(stateId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BusinessEntites.Admin.MasterCityDTO>> Admin_MasterCityGetOnStateIdAsync(int stateId) {
            return base.Channel.Admin_MasterCityGetOnStateIdAsync(stateId);
        }
        
        public BusinessEntites.Admin.MasterCityDTO Admin_MasterCityGetOnCityId(int cityId) {
            return base.Channel.Admin_MasterCityGetOnCityId(cityId);
        }
        
        public System.Threading.Tasks.Task<BusinessEntites.Admin.MasterCityDTO> Admin_MasterCityGetOnCityIdAsync(int cityId) {
            return base.Channel.Admin_MasterCityGetOnCityIdAsync(cityId);
        }
        
        public void Admin_MasterCityUpdate(BusinessEntites.Admin.MasterCityDTO masterCityDTO) {
            base.Channel.Admin_MasterCityUpdate(masterCityDTO);
        }
        
        public System.Threading.Tasks.Task Admin_MasterCityUpdateAsync(BusinessEntites.Admin.MasterCityDTO masterCityDTO) {
            return base.Channel.Admin_MasterCityUpdateAsync(masterCityDTO);
        }
    }
}
