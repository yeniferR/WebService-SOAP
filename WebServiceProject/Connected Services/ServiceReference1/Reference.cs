﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceProject.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfInt", Namespace="http://tempuri.org/", ItemName="int")]
    [System.SerializableAttribute()]
    public class ArrayOfInt : System.Collections.Generic.List<int> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WebServiceProject.ServiceReference1.HelloWorldResponse HelloWorld(WebServiceProject.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceProject.ServiceReference1.HelloWorldResponse> HelloWorldAsync(WebServiceProject.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento listInt del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        WebServiceProject.ServiceReference1.AddResponse Add(WebServiceProject.ServiceReference1.AddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceProject.ServiceReference1.AddResponse> AddAsync(WebServiceProject.ServiceReference1.AddRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceProject.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WebServiceProject.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceProject.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WebServiceProject.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Add", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceProject.ServiceReference1.AddRequestBody Body;
        
        public AddRequest() {
        }
        
        public AddRequest(WebServiceProject.ServiceReference1.AddRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public WebServiceProject.ServiceReference1.ArrayOfInt listInt;
        
        public AddRequestBody() {
        }
        
        public AddRequestBody(WebServiceProject.ServiceReference1.ArrayOfInt listInt) {
            this.listInt = listInt;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceProject.ServiceReference1.AddResponseBody Body;
        
        public AddResponse() {
        }
        
        public AddResponse(WebServiceProject.ServiceReference1.AddResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int AddResult;
        
        public AddResponseBody() {
        }
        
        public AddResponseBody(int AddResult) {
            this.AddResult = AddResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : WebServiceProject.ServiceReference1.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<WebServiceProject.ServiceReference1.WebServiceSoap>, WebServiceProject.ServiceReference1.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceProject.ServiceReference1.HelloWorldResponse WebServiceProject.ServiceReference1.WebServiceSoap.HelloWorld(WebServiceProject.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WebServiceProject.ServiceReference1.HelloWorldRequest inValue = new WebServiceProject.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WebServiceProject.ServiceReference1.HelloWorldRequestBody();
            WebServiceProject.ServiceReference1.HelloWorldResponse retVal = ((WebServiceProject.ServiceReference1.WebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceProject.ServiceReference1.HelloWorldResponse> WebServiceProject.ServiceReference1.WebServiceSoap.HelloWorldAsync(WebServiceProject.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceProject.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            WebServiceProject.ServiceReference1.HelloWorldRequest inValue = new WebServiceProject.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WebServiceProject.ServiceReference1.HelloWorldRequestBody();
            return ((WebServiceProject.ServiceReference1.WebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceProject.ServiceReference1.AddResponse WebServiceProject.ServiceReference1.WebServiceSoap.Add(WebServiceProject.ServiceReference1.AddRequest request) {
            return base.Channel.Add(request);
        }
        
        public int Add(WebServiceProject.ServiceReference1.ArrayOfInt listInt) {
            WebServiceProject.ServiceReference1.AddRequest inValue = new WebServiceProject.ServiceReference1.AddRequest();
            inValue.Body = new WebServiceProject.ServiceReference1.AddRequestBody();
            inValue.Body.listInt = listInt;
            WebServiceProject.ServiceReference1.AddResponse retVal = ((WebServiceProject.ServiceReference1.WebServiceSoap)(this)).Add(inValue);
            return retVal.Body.AddResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceProject.ServiceReference1.AddResponse> WebServiceProject.ServiceReference1.WebServiceSoap.AddAsync(WebServiceProject.ServiceReference1.AddRequest request) {
            return base.Channel.AddAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceProject.ServiceReference1.AddResponse> AddAsync(WebServiceProject.ServiceReference1.ArrayOfInt listInt) {
            WebServiceProject.ServiceReference1.AddRequest inValue = new WebServiceProject.ServiceReference1.AddRequest();
            inValue.Body = new WebServiceProject.ServiceReference1.AddRequestBody();
            inValue.Body.listInt = listInt;
            return ((WebServiceProject.ServiceReference1.WebServiceSoap)(this)).AddAsync(inValue);
        }
    }
}
