﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.FindByDate {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="FindByDate.ZodiacFinderByDateSoap")]
    public interface ZodiacFinderByDateSoap {
        
        // CODEGEN: Generating message contract since element name FindZodiacByDateResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindZodiacByDate", ReplyAction="*")]
        WebApplication2.FindByDate.FindZodiacByDateResponse FindZodiacByDate(WebApplication2.FindByDate.FindZodiacByDateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindZodiacByDate", ReplyAction="*")]
        System.Threading.Tasks.Task<WebApplication2.FindByDate.FindZodiacByDateResponse> FindZodiacByDateAsync(WebApplication2.FindByDate.FindZodiacByDateRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindZodiacByDateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindZodiacByDate", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication2.FindByDate.FindZodiacByDateRequestBody Body;
        
        public FindZodiacByDateRequest() {
        }
        
        public FindZodiacByDateRequest(WebApplication2.FindByDate.FindZodiacByDateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindZodiacByDateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int mon;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int day;
        
        public FindZodiacByDateRequestBody() {
        }
        
        public FindZodiacByDateRequestBody(int mon, int day) {
            this.mon = mon;
            this.day = day;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindZodiacByDateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindZodiacByDateResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebApplication2.FindByDate.FindZodiacByDateResponseBody Body;
        
        public FindZodiacByDateResponse() {
        }
        
        public FindZodiacByDateResponse(WebApplication2.FindByDate.FindZodiacByDateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindZodiacByDateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string FindZodiacByDateResult;
        
        public FindZodiacByDateResponseBody() {
        }
        
        public FindZodiacByDateResponseBody(string FindZodiacByDateResult) {
            this.FindZodiacByDateResult = FindZodiacByDateResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ZodiacFinderByDateSoapChannel : WebApplication2.FindByDate.ZodiacFinderByDateSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ZodiacFinderByDateSoapClient : System.ServiceModel.ClientBase<WebApplication2.FindByDate.ZodiacFinderByDateSoap>, WebApplication2.FindByDate.ZodiacFinderByDateSoap {
        
        public ZodiacFinderByDateSoapClient() {
        }
        
        public ZodiacFinderByDateSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ZodiacFinderByDateSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ZodiacFinderByDateSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ZodiacFinderByDateSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebApplication2.FindByDate.FindZodiacByDateResponse WebApplication2.FindByDate.ZodiacFinderByDateSoap.FindZodiacByDate(WebApplication2.FindByDate.FindZodiacByDateRequest request) {
            return base.Channel.FindZodiacByDate(request);
        }
        
        public string FindZodiacByDate(int mon, int day) {
            WebApplication2.FindByDate.FindZodiacByDateRequest inValue = new WebApplication2.FindByDate.FindZodiacByDateRequest();
            inValue.Body = new WebApplication2.FindByDate.FindZodiacByDateRequestBody();
            inValue.Body.mon = mon;
            inValue.Body.day = day;
            WebApplication2.FindByDate.FindZodiacByDateResponse retVal = ((WebApplication2.FindByDate.ZodiacFinderByDateSoap)(this)).FindZodiacByDate(inValue);
            return retVal.Body.FindZodiacByDateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebApplication2.FindByDate.FindZodiacByDateResponse> WebApplication2.FindByDate.ZodiacFinderByDateSoap.FindZodiacByDateAsync(WebApplication2.FindByDate.FindZodiacByDateRequest request) {
            return base.Channel.FindZodiacByDateAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebApplication2.FindByDate.FindZodiacByDateResponse> FindZodiacByDateAsync(int mon, int day) {
            WebApplication2.FindByDate.FindZodiacByDateRequest inValue = new WebApplication2.FindByDate.FindZodiacByDateRequest();
            inValue.Body = new WebApplication2.FindByDate.FindZodiacByDateRequestBody();
            inValue.Body.mon = mon;
            inValue.Body.day = day;
            return ((WebApplication2.FindByDate.ZodiacFinderByDateSoap)(this)).FindZodiacByDateAsync(inValue);
        }
    }
}
