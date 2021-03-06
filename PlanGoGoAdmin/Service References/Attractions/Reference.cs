﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PlanGoGoAdmin.Attractions {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Attractions.IAttractions")]
    public interface IAttractions {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAttractions/AttractionsUpdate", ReplyAction="http://tempuri.org/IAttractions/AttractionsUpdateResponse")]
        void AttractionsUpdate(BusinessEntites.Common.AttractionsDTO attractionsDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAttractions/AttractionsUpdate", ReplyAction="http://tempuri.org/IAttractions/AttractionsUpdateResponse")]
        System.Threading.Tasks.Task AttractionsUpdateAsync(BusinessEntites.Common.AttractionsDTO attractionsDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAttractions/AttractionsCheckExists", ReplyAction="http://tempuri.org/IAttractions/AttractionsCheckExistsResponse")]
        System.Collections.Generic.List<BusinessEntites.Common.AttractionsDTO> AttractionsCheckExists(BusinessEntites.Common.AttractionsDTO attractionsDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAttractions/AttractionsCheckExists", ReplyAction="http://tempuri.org/IAttractions/AttractionsCheckExistsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BusinessEntites.Common.AttractionsDTO>> AttractionsCheckExistsAsync(BusinessEntites.Common.AttractionsDTO attractionsDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAttractions/AttractionsOnCityId", ReplyAction="http://tempuri.org/IAttractions/AttractionsOnCityIdResponse")]
        System.Collections.Generic.List<BusinessEntites.Common.AttractionsDTO> AttractionsOnCityId(BusinessEntites.Common.AttractionsDTO attractionsDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAttractions/AttractionsOnCityId", ReplyAction="http://tempuri.org/IAttractions/AttractionsOnCityIdResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BusinessEntites.Common.AttractionsDTO>> AttractionsOnCityIdAsync(BusinessEntites.Common.AttractionsDTO attractionsDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAttractions/AttractionsOnAttractionsId", ReplyAction="http://tempuri.org/IAttractions/AttractionsOnAttractionsIdResponse")]
        BusinessEntites.Common.AttractionsDTO AttractionsOnAttractionsId(BusinessEntites.Common.AttractionsDTO attractionsDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAttractions/AttractionsOnAttractionsId", ReplyAction="http://tempuri.org/IAttractions/AttractionsOnAttractionsIdResponse")]
        System.Threading.Tasks.Task<BusinessEntites.Common.AttractionsDTO> AttractionsOnAttractionsIdAsync(BusinessEntites.Common.AttractionsDTO attractionsDTO);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAttractionsChannel : PlanGoGoAdmin.Attractions.IAttractions, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AttractionsClient : System.ServiceModel.ClientBase<PlanGoGoAdmin.Attractions.IAttractions>, PlanGoGoAdmin.Attractions.IAttractions {
        
        public AttractionsClient() {
        }
        
        public AttractionsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AttractionsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AttractionsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AttractionsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AttractionsUpdate(BusinessEntites.Common.AttractionsDTO attractionsDTO) {
            base.Channel.AttractionsUpdate(attractionsDTO);
        }
        
        public System.Threading.Tasks.Task AttractionsUpdateAsync(BusinessEntites.Common.AttractionsDTO attractionsDTO) {
            return base.Channel.AttractionsUpdateAsync(attractionsDTO);
        }
        
        public System.Collections.Generic.List<BusinessEntites.Common.AttractionsDTO> AttractionsCheckExists(BusinessEntites.Common.AttractionsDTO attractionsDTO) {
            return base.Channel.AttractionsCheckExists(attractionsDTO);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BusinessEntites.Common.AttractionsDTO>> AttractionsCheckExistsAsync(BusinessEntites.Common.AttractionsDTO attractionsDTO) {
            return base.Channel.AttractionsCheckExistsAsync(attractionsDTO);
        }
        
        public System.Collections.Generic.List<BusinessEntites.Common.AttractionsDTO> AttractionsOnCityId(BusinessEntites.Common.AttractionsDTO attractionsDTO) {
            return base.Channel.AttractionsOnCityId(attractionsDTO);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BusinessEntites.Common.AttractionsDTO>> AttractionsOnCityIdAsync(BusinessEntites.Common.AttractionsDTO attractionsDTO) {
            return base.Channel.AttractionsOnCityIdAsync(attractionsDTO);
        }
        
        public BusinessEntites.Common.AttractionsDTO AttractionsOnAttractionsId(BusinessEntites.Common.AttractionsDTO attractionsDTO) {
            return base.Channel.AttractionsOnAttractionsId(attractionsDTO);
        }
        
        public System.Threading.Tasks.Task<BusinessEntites.Common.AttractionsDTO> AttractionsOnAttractionsIdAsync(BusinessEntites.Common.AttractionsDTO attractionsDTO) {
            return base.Channel.AttractionsOnAttractionsIdAsync(attractionsDTO);
        }
    }
}
