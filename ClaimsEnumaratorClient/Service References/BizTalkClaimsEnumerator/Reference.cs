﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClaimsEnumaratorClient.BizTalkClaimsEnumerator {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BizTalkClaimsEnumerator.ClaimsBizTalkService_ClaimEnumerator_ClaimsBizTalkService" +
        "Port")]
    public interface ClaimsBizTalkService_ClaimEnumerator_ClaimsBizTalkServicePort {
        
        // CODEGEN: Generating message contract since the operation CaimsOrchestration is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="CaimsOrchestration", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        ClaimsEnumaratorClient.BizTalkClaimsEnumerator.CaimsOrchestrationResponse CaimsOrchestration(ClaimsEnumaratorClient.BizTalkClaimsEnumerator.CaimsOrchestrationRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ClaimsBizTalkService.claimsRequest")]
    public partial class ClaimsRequest : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string outputField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string output {
            get {
                return this.outputField;
            }
            set {
                this.outputField = value;
                this.RaisePropertyChanged("output");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://ClaimsBizTalkService.claimsResponse")]
    public partial class ClaimsResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string inputField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string input {
            get {
                return this.inputField;
            }
            set {
                this.inputField = value;
                this.RaisePropertyChanged("input");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CaimsOrchestrationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ClaimsBizTalkService.claimsRequest", Order=0)]
        public ClaimsEnumaratorClient.BizTalkClaimsEnumerator.ClaimsRequest ClaimsRequest;
        
        public CaimsOrchestrationRequest() {
        }
        
        public CaimsOrchestrationRequest(ClaimsEnumaratorClient.BizTalkClaimsEnumerator.ClaimsRequest ClaimsRequest) {
            this.ClaimsRequest = ClaimsRequest;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CaimsOrchestrationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ClaimsBizTalkService.claimsResponse", Order=0)]
        public ClaimsEnumaratorClient.BizTalkClaimsEnumerator.ClaimsResponse ClaimsResponse;
        
        public CaimsOrchestrationResponse() {
        }
        
        public CaimsOrchestrationResponse(ClaimsEnumaratorClient.BizTalkClaimsEnumerator.ClaimsResponse ClaimsResponse) {
            this.ClaimsResponse = ClaimsResponse;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ClaimsBizTalkService_ClaimEnumerator_ClaimsBizTalkServicePortChannel : ClaimsEnumaratorClient.BizTalkClaimsEnumerator.ClaimsBizTalkService_ClaimEnumerator_ClaimsBizTalkServicePort, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClaimsBizTalkService_ClaimEnumerator_ClaimsBizTalkServicePortClient : System.ServiceModel.ClientBase<ClaimsEnumaratorClient.BizTalkClaimsEnumerator.ClaimsBizTalkService_ClaimEnumerator_ClaimsBizTalkServicePort>, ClaimsEnumaratorClient.BizTalkClaimsEnumerator.ClaimsBizTalkService_ClaimEnumerator_ClaimsBizTalkServicePort {
        
        public ClaimsBizTalkService_ClaimEnumerator_ClaimsBizTalkServicePortClient() {
        }
        
        public ClaimsBizTalkService_ClaimEnumerator_ClaimsBizTalkServicePortClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ClaimsBizTalkService_ClaimEnumerator_ClaimsBizTalkServicePortClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClaimsBizTalkService_ClaimEnumerator_ClaimsBizTalkServicePortClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ClaimsBizTalkService_ClaimEnumerator_ClaimsBizTalkServicePortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClaimsEnumaratorClient.BizTalkClaimsEnumerator.CaimsOrchestrationResponse ClaimsEnumaratorClient.BizTalkClaimsEnumerator.ClaimsBizTalkService_ClaimEnumerator_ClaimsBizTalkServicePort.CaimsOrchestration(ClaimsEnumaratorClient.BizTalkClaimsEnumerator.CaimsOrchestrationRequest request) {
            return base.Channel.CaimsOrchestration(request);
        }
        
        public ClaimsEnumaratorClient.BizTalkClaimsEnumerator.ClaimsResponse CaimsOrchestration(ClaimsEnumaratorClient.BizTalkClaimsEnumerator.ClaimsRequest ClaimsRequest) {
            ClaimsEnumaratorClient.BizTalkClaimsEnumerator.CaimsOrchestrationRequest inValue = new ClaimsEnumaratorClient.BizTalkClaimsEnumerator.CaimsOrchestrationRequest();
            inValue.ClaimsRequest = ClaimsRequest;
            ClaimsEnumaratorClient.BizTalkClaimsEnumerator.CaimsOrchestrationResponse retVal = ((ClaimsEnumaratorClient.BizTalkClaimsEnumerator.ClaimsBizTalkService_ClaimEnumerator_ClaimsBizTalkServicePort)(this)).CaimsOrchestration(inValue);
            return retVal.ClaimsResponse;
        }
    }
}