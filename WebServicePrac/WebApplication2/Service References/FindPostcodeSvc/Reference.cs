﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.FindPostcodeSvc {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FindPostcodeSvc.PostcodeFinderServiceSoap")]
    public interface PostcodeFinderServiceSoap {
        
        // CODEGEN: Generating message contract since element name suburb from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindPostcode", ReplyAction="*")]
        WebApplication2.FindPostcodeSvc.FindPostcodeResponse FindPostcode(WebApplication2.FindPostcodeSvc.FindPostcodeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindPostcode", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication2.FindPostcodeSvc.FindPostcodeResponse> FindPostcodeAsync(WebApplication2.FindPostcodeSvc.FindPostcodeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindPostcodeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindPostcode", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication2.FindPostcodeSvc.FindPostcodeRequestBody Body;
        
        public FindPostcodeRequest() {
        }
        
        public FindPostcodeRequest(WebApplication2.FindPostcodeSvc.FindPostcodeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindPostcodeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string suburb;
        
        public FindPostcodeRequestBody() {
        }
        
        public FindPostcodeRequestBody(string suburb) {
            this.suburb = suburb;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindPostcodeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindPostcodeResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication2.FindPostcodeSvc.FindPostcodeResponseBody Body;
        
        public FindPostcodeResponse() {
        }
        
        public FindPostcodeResponse(WebApplication2.FindPostcodeSvc.FindPostcodeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindPostcodeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string FindPostcodeResult;
        
        public FindPostcodeResponseBody() {
        }
        
        public FindPostcodeResponseBody(string FindPostcodeResult) {
            this.FindPostcodeResult = FindPostcodeResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface PostcodeFinderServiceSoapChannel : WebApplication2.FindPostcodeSvc.PostcodeFinderServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PostcodeFinderServiceSoapClient : System.ServiceModel.ClientBase<WebApplication2.FindPostcodeSvc.PostcodeFinderServiceSoap>, WebApplication2.FindPostcodeSvc.PostcodeFinderServiceSoap {
        
        public PostcodeFinderServiceSoapClient() {
        }
        
        public PostcodeFinderServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PostcodeFinderServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PostcodeFinderServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PostcodeFinderServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication2.FindPostcodeSvc.FindPostcodeResponse WebApplication2.FindPostcodeSvc.PostcodeFinderServiceSoap.FindPostcode(WebApplication2.FindPostcodeSvc.FindPostcodeRequest request) {
            return base.Channel.FindPostcode(request);
        }
        
        public string FindPostcode(string suburb) {
            WebApplication2.FindPostcodeSvc.FindPostcodeRequest inValue = new WebApplication2.FindPostcodeSvc.FindPostcodeRequest();
            inValue.Body = new WebApplication2.FindPostcodeSvc.FindPostcodeRequestBody();
            inValue.Body.suburb = suburb;
            WebApplication2.FindPostcodeSvc.FindPostcodeResponse retVal = ((WebApplication2.FindPostcodeSvc.PostcodeFinderServiceSoap)(this)).FindPostcode(inValue);
            return retVal.Body.FindPostcodeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication2.FindPostcodeSvc.FindPostcodeResponse> WebApplication2.FindPostcodeSvc.PostcodeFinderServiceSoap.FindPostcodeAsync(WebApplication2.FindPostcodeSvc.FindPostcodeRequest request) {
            return base.Channel.FindPostcodeAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication2.FindPostcodeSvc.FindPostcodeResponse> FindPostcodeAsync(string suburb) {
            WebApplication2.FindPostcodeSvc.FindPostcodeRequest inValue = new WebApplication2.FindPostcodeSvc.FindPostcodeRequest();
            inValue.Body = new WebApplication2.FindPostcodeSvc.FindPostcodeRequestBody();
            inValue.Body.suburb = suburb;
            return ((WebApplication2.FindPostcodeSvc.PostcodeFinderServiceSoap)(this)).FindPostcodeAsync(inValue);
        }
    }
}
