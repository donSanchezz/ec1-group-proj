﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EBillPayment.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name Id from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LinkAccount", ReplyAction="*")]
        EBillPayment.ServiceReference1.LinkAccountResponse LinkAccount(EBillPayment.ServiceReference1.LinkAccountRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LinkAccount", ReplyAction="*")]
        System.Threading.Tasks.Task<EBillPayment.ServiceReference1.LinkAccountResponse> LinkAccountAsync(EBillPayment.ServiceReference1.LinkAccountRequest request);
        
        // CODEGEN: Generating message contract since element name Id from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetFlowBalance", ReplyAction="*")]
        EBillPayment.ServiceReference1.GetFlowBalanceResponse GetFlowBalance(EBillPayment.ServiceReference1.GetFlowBalanceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetFlowBalance", ReplyAction="*")]
        System.Threading.Tasks.Task<EBillPayment.ServiceReference1.GetFlowBalanceResponse> GetFlowBalanceAsync(EBillPayment.ServiceReference1.GetFlowBalanceRequest request);
        
        // CODEGEN: Generating message contract since element name Id from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSagicorBalance", ReplyAction="*")]
        EBillPayment.ServiceReference1.GetSagicorBalanceResponse GetSagicorBalance(EBillPayment.ServiceReference1.GetSagicorBalanceRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetSagicorBalance", ReplyAction="*")]
        System.Threading.Tasks.Task<EBillPayment.ServiceReference1.GetSagicorBalanceResponse> GetSagicorBalanceAsync(EBillPayment.ServiceReference1.GetSagicorBalanceRequest request);
        
        // CODEGEN: Generating message contract since element name Id from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MakePaymentFlow", ReplyAction="*")]
        EBillPayment.ServiceReference1.MakePaymentFlowResponse MakePaymentFlow(EBillPayment.ServiceReference1.MakePaymentFlowRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MakePaymentFlow", ReplyAction="*")]
        System.Threading.Tasks.Task<EBillPayment.ServiceReference1.MakePaymentFlowResponse> MakePaymentFlowAsync(EBillPayment.ServiceReference1.MakePaymentFlowRequest request);
        
        // CODEGEN: Generating message contract since element name Id from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MakePaymentSagicor", ReplyAction="*")]
        EBillPayment.ServiceReference1.MakePaymentSagicorResponse MakePaymentSagicor(EBillPayment.ServiceReference1.MakePaymentSagicorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MakePaymentSagicor", ReplyAction="*")]
        System.Threading.Tasks.Task<EBillPayment.ServiceReference1.MakePaymentSagicorResponse> MakePaymentSagicorAsync(EBillPayment.ServiceReference1.MakePaymentSagicorRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LinkAccountRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LinkAccount", Namespace="http://tempuri.org/", Order=0)]
        public EBillPayment.ServiceReference1.LinkAccountRequestBody Body;
        
        public LinkAccountRequest() {
        }
        
        public LinkAccountRequest(EBillPayment.ServiceReference1.LinkAccountRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LinkAccountRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string accType;
        
        public LinkAccountRequestBody() {
        }
        
        public LinkAccountRequestBody(string Id, string accType) {
            this.Id = Id;
            this.accType = accType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LinkAccountResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LinkAccountResponse", Namespace="http://tempuri.org/", Order=0)]
        public EBillPayment.ServiceReference1.LinkAccountResponseBody Body;
        
        public LinkAccountResponse() {
        }
        
        public LinkAccountResponse(EBillPayment.ServiceReference1.LinkAccountResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LinkAccountResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public float LinkAccountResult;
        
        public LinkAccountResponseBody() {
        }
        
        public LinkAccountResponseBody(float LinkAccountResult) {
            this.LinkAccountResult = LinkAccountResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetFlowBalanceRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetFlowBalance", Namespace="http://tempuri.org/", Order=0)]
        public EBillPayment.ServiceReference1.GetFlowBalanceRequestBody Body;
        
        public GetFlowBalanceRequest() {
        }
        
        public GetFlowBalanceRequest(EBillPayment.ServiceReference1.GetFlowBalanceRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetFlowBalanceRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Id;
        
        public GetFlowBalanceRequestBody() {
        }
        
        public GetFlowBalanceRequestBody(string Id) {
            this.Id = Id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetFlowBalanceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetFlowBalanceResponse", Namespace="http://tempuri.org/", Order=0)]
        public EBillPayment.ServiceReference1.GetFlowBalanceResponseBody Body;
        
        public GetFlowBalanceResponse() {
        }
        
        public GetFlowBalanceResponse(EBillPayment.ServiceReference1.GetFlowBalanceResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetFlowBalanceResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public float GetFlowBalanceResult;
        
        public GetFlowBalanceResponseBody() {
        }
        
        public GetFlowBalanceResponseBody(float GetFlowBalanceResult) {
            this.GetFlowBalanceResult = GetFlowBalanceResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSagicorBalanceRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSagicorBalance", Namespace="http://tempuri.org/", Order=0)]
        public EBillPayment.ServiceReference1.GetSagicorBalanceRequestBody Body;
        
        public GetSagicorBalanceRequest() {
        }
        
        public GetSagicorBalanceRequest(EBillPayment.ServiceReference1.GetSagicorBalanceRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetSagicorBalanceRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Id;
        
        public GetSagicorBalanceRequestBody() {
        }
        
        public GetSagicorBalanceRequestBody(string Id) {
            this.Id = Id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetSagicorBalanceResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetSagicorBalanceResponse", Namespace="http://tempuri.org/", Order=0)]
        public EBillPayment.ServiceReference1.GetSagicorBalanceResponseBody Body;
        
        public GetSagicorBalanceResponse() {
        }
        
        public GetSagicorBalanceResponse(EBillPayment.ServiceReference1.GetSagicorBalanceResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetSagicorBalanceResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public float GetSagicorBalanceResult;
        
        public GetSagicorBalanceResponseBody() {
        }
        
        public GetSagicorBalanceResponseBody(float GetSagicorBalanceResult) {
            this.GetSagicorBalanceResult = GetSagicorBalanceResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MakePaymentFlowRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MakePaymentFlow", Namespace="http://tempuri.org/", Order=0)]
        public EBillPayment.ServiceReference1.MakePaymentFlowRequestBody Body;
        
        public MakePaymentFlowRequest() {
        }
        
        public MakePaymentFlowRequest(EBillPayment.ServiceReference1.MakePaymentFlowRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MakePaymentFlowRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Id;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public float currentBal;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public float Amount;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string From;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public float ToBalance;
        
        public MakePaymentFlowRequestBody() {
        }
        
        public MakePaymentFlowRequestBody(string Id, float currentBal, float Amount, string From, float ToBalance) {
            this.Id = Id;
            this.currentBal = currentBal;
            this.Amount = Amount;
            this.From = From;
            this.ToBalance = ToBalance;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MakePaymentFlowResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MakePaymentFlowResponse", Namespace="http://tempuri.org/", Order=0)]
        public EBillPayment.ServiceReference1.MakePaymentFlowResponseBody Body;
        
        public MakePaymentFlowResponse() {
        }
        
        public MakePaymentFlowResponse(EBillPayment.ServiceReference1.MakePaymentFlowResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MakePaymentFlowResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public float MakePaymentFlowResult;
        
        public MakePaymentFlowResponseBody() {
        }
        
        public MakePaymentFlowResponseBody(float MakePaymentFlowResult) {
            this.MakePaymentFlowResult = MakePaymentFlowResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MakePaymentSagicorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MakePaymentSagicor", Namespace="http://tempuri.org/", Order=0)]
        public EBillPayment.ServiceReference1.MakePaymentSagicorRequestBody Body;
        
        public MakePaymentSagicorRequest() {
        }
        
        public MakePaymentSagicorRequest(EBillPayment.ServiceReference1.MakePaymentSagicorRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MakePaymentSagicorRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Id;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public float currentBal;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public float Amount;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string From;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public float ToBalance;
        
        public MakePaymentSagicorRequestBody() {
        }
        
        public MakePaymentSagicorRequestBody(string Id, float currentBal, float Amount, string From, float ToBalance) {
            this.Id = Id;
            this.currentBal = currentBal;
            this.Amount = Amount;
            this.From = From;
            this.ToBalance = ToBalance;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MakePaymentSagicorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MakePaymentSagicorResponse", Namespace="http://tempuri.org/", Order=0)]
        public EBillPayment.ServiceReference1.MakePaymentSagicorResponseBody Body;
        
        public MakePaymentSagicorResponse() {
        }
        
        public MakePaymentSagicorResponse(EBillPayment.ServiceReference1.MakePaymentSagicorResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MakePaymentSagicorResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public float MakePaymentSagicorResult;
        
        public MakePaymentSagicorResponseBody() {
        }
        
        public MakePaymentSagicorResponseBody(float MakePaymentSagicorResult) {
            this.MakePaymentSagicorResult = MakePaymentSagicorResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : EBillPayment.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<EBillPayment.ServiceReference1.WebService1Soap>, EBillPayment.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EBillPayment.ServiceReference1.LinkAccountResponse EBillPayment.ServiceReference1.WebService1Soap.LinkAccount(EBillPayment.ServiceReference1.LinkAccountRequest request) {
            return base.Channel.LinkAccount(request);
        }
        
        public float LinkAccount(string Id, string accType) {
            EBillPayment.ServiceReference1.LinkAccountRequest inValue = new EBillPayment.ServiceReference1.LinkAccountRequest();
            inValue.Body = new EBillPayment.ServiceReference1.LinkAccountRequestBody();
            inValue.Body.Id = Id;
            inValue.Body.accType = accType;
            EBillPayment.ServiceReference1.LinkAccountResponse retVal = ((EBillPayment.ServiceReference1.WebService1Soap)(this)).LinkAccount(inValue);
            return retVal.Body.LinkAccountResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<EBillPayment.ServiceReference1.LinkAccountResponse> EBillPayment.ServiceReference1.WebService1Soap.LinkAccountAsync(EBillPayment.ServiceReference1.LinkAccountRequest request) {
            return base.Channel.LinkAccountAsync(request);
        }
        
        public System.Threading.Tasks.Task<EBillPayment.ServiceReference1.LinkAccountResponse> LinkAccountAsync(string Id, string accType) {
            EBillPayment.ServiceReference1.LinkAccountRequest inValue = new EBillPayment.ServiceReference1.LinkAccountRequest();
            inValue.Body = new EBillPayment.ServiceReference1.LinkAccountRequestBody();
            inValue.Body.Id = Id;
            inValue.Body.accType = accType;
            return ((EBillPayment.ServiceReference1.WebService1Soap)(this)).LinkAccountAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EBillPayment.ServiceReference1.GetFlowBalanceResponse EBillPayment.ServiceReference1.WebService1Soap.GetFlowBalance(EBillPayment.ServiceReference1.GetFlowBalanceRequest request) {
            return base.Channel.GetFlowBalance(request);
        }
        
        public float GetFlowBalance(string Id) {
            EBillPayment.ServiceReference1.GetFlowBalanceRequest inValue = new EBillPayment.ServiceReference1.GetFlowBalanceRequest();
            inValue.Body = new EBillPayment.ServiceReference1.GetFlowBalanceRequestBody();
            inValue.Body.Id = Id;
            EBillPayment.ServiceReference1.GetFlowBalanceResponse retVal = ((EBillPayment.ServiceReference1.WebService1Soap)(this)).GetFlowBalance(inValue);
            return retVal.Body.GetFlowBalanceResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<EBillPayment.ServiceReference1.GetFlowBalanceResponse> EBillPayment.ServiceReference1.WebService1Soap.GetFlowBalanceAsync(EBillPayment.ServiceReference1.GetFlowBalanceRequest request) {
            return base.Channel.GetFlowBalanceAsync(request);
        }
        
        public System.Threading.Tasks.Task<EBillPayment.ServiceReference1.GetFlowBalanceResponse> GetFlowBalanceAsync(string Id) {
            EBillPayment.ServiceReference1.GetFlowBalanceRequest inValue = new EBillPayment.ServiceReference1.GetFlowBalanceRequest();
            inValue.Body = new EBillPayment.ServiceReference1.GetFlowBalanceRequestBody();
            inValue.Body.Id = Id;
            return ((EBillPayment.ServiceReference1.WebService1Soap)(this)).GetFlowBalanceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EBillPayment.ServiceReference1.GetSagicorBalanceResponse EBillPayment.ServiceReference1.WebService1Soap.GetSagicorBalance(EBillPayment.ServiceReference1.GetSagicorBalanceRequest request) {
            return base.Channel.GetSagicorBalance(request);
        }
        
        public float GetSagicorBalance(string Id) {
            EBillPayment.ServiceReference1.GetSagicorBalanceRequest inValue = new EBillPayment.ServiceReference1.GetSagicorBalanceRequest();
            inValue.Body = new EBillPayment.ServiceReference1.GetSagicorBalanceRequestBody();
            inValue.Body.Id = Id;
            EBillPayment.ServiceReference1.GetSagicorBalanceResponse retVal = ((EBillPayment.ServiceReference1.WebService1Soap)(this)).GetSagicorBalance(inValue);
            return retVal.Body.GetSagicorBalanceResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<EBillPayment.ServiceReference1.GetSagicorBalanceResponse> EBillPayment.ServiceReference1.WebService1Soap.GetSagicorBalanceAsync(EBillPayment.ServiceReference1.GetSagicorBalanceRequest request) {
            return base.Channel.GetSagicorBalanceAsync(request);
        }
        
        public System.Threading.Tasks.Task<EBillPayment.ServiceReference1.GetSagicorBalanceResponse> GetSagicorBalanceAsync(string Id) {
            EBillPayment.ServiceReference1.GetSagicorBalanceRequest inValue = new EBillPayment.ServiceReference1.GetSagicorBalanceRequest();
            inValue.Body = new EBillPayment.ServiceReference1.GetSagicorBalanceRequestBody();
            inValue.Body.Id = Id;
            return ((EBillPayment.ServiceReference1.WebService1Soap)(this)).GetSagicorBalanceAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EBillPayment.ServiceReference1.MakePaymentFlowResponse EBillPayment.ServiceReference1.WebService1Soap.MakePaymentFlow(EBillPayment.ServiceReference1.MakePaymentFlowRequest request) {
            return base.Channel.MakePaymentFlow(request);
        }
        
        public float MakePaymentFlow(string Id, float currentBal, float Amount, string From, float ToBalance) {
            EBillPayment.ServiceReference1.MakePaymentFlowRequest inValue = new EBillPayment.ServiceReference1.MakePaymentFlowRequest();
            inValue.Body = new EBillPayment.ServiceReference1.MakePaymentFlowRequestBody();
            inValue.Body.Id = Id;
            inValue.Body.currentBal = currentBal;
            inValue.Body.Amount = Amount;
            inValue.Body.From = From;
            inValue.Body.ToBalance = ToBalance;
            EBillPayment.ServiceReference1.MakePaymentFlowResponse retVal = ((EBillPayment.ServiceReference1.WebService1Soap)(this)).MakePaymentFlow(inValue);
            return retVal.Body.MakePaymentFlowResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<EBillPayment.ServiceReference1.MakePaymentFlowResponse> EBillPayment.ServiceReference1.WebService1Soap.MakePaymentFlowAsync(EBillPayment.ServiceReference1.MakePaymentFlowRequest request) {
            return base.Channel.MakePaymentFlowAsync(request);
        }
        
        public System.Threading.Tasks.Task<EBillPayment.ServiceReference1.MakePaymentFlowResponse> MakePaymentFlowAsync(string Id, float currentBal, float Amount, string From, float ToBalance) {
            EBillPayment.ServiceReference1.MakePaymentFlowRequest inValue = new EBillPayment.ServiceReference1.MakePaymentFlowRequest();
            inValue.Body = new EBillPayment.ServiceReference1.MakePaymentFlowRequestBody();
            inValue.Body.Id = Id;
            inValue.Body.currentBal = currentBal;
            inValue.Body.Amount = Amount;
            inValue.Body.From = From;
            inValue.Body.ToBalance = ToBalance;
            return ((EBillPayment.ServiceReference1.WebService1Soap)(this)).MakePaymentFlowAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EBillPayment.ServiceReference1.MakePaymentSagicorResponse EBillPayment.ServiceReference1.WebService1Soap.MakePaymentSagicor(EBillPayment.ServiceReference1.MakePaymentSagicorRequest request) {
            return base.Channel.MakePaymentSagicor(request);
        }
        
        public float MakePaymentSagicor(string Id, float currentBal, float Amount, string From, float ToBalance) {
            EBillPayment.ServiceReference1.MakePaymentSagicorRequest inValue = new EBillPayment.ServiceReference1.MakePaymentSagicorRequest();
            inValue.Body = new EBillPayment.ServiceReference1.MakePaymentSagicorRequestBody();
            inValue.Body.Id = Id;
            inValue.Body.currentBal = currentBal;
            inValue.Body.Amount = Amount;
            inValue.Body.From = From;
            inValue.Body.ToBalance = ToBalance;
            EBillPayment.ServiceReference1.MakePaymentSagicorResponse retVal = ((EBillPayment.ServiceReference1.WebService1Soap)(this)).MakePaymentSagicor(inValue);
            return retVal.Body.MakePaymentSagicorResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<EBillPayment.ServiceReference1.MakePaymentSagicorResponse> EBillPayment.ServiceReference1.WebService1Soap.MakePaymentSagicorAsync(EBillPayment.ServiceReference1.MakePaymentSagicorRequest request) {
            return base.Channel.MakePaymentSagicorAsync(request);
        }
        
        public System.Threading.Tasks.Task<EBillPayment.ServiceReference1.MakePaymentSagicorResponse> MakePaymentSagicorAsync(string Id, float currentBal, float Amount, string From, float ToBalance) {
            EBillPayment.ServiceReference1.MakePaymentSagicorRequest inValue = new EBillPayment.ServiceReference1.MakePaymentSagicorRequest();
            inValue.Body = new EBillPayment.ServiceReference1.MakePaymentSagicorRequestBody();
            inValue.Body.Id = Id;
            inValue.Body.currentBal = currentBal;
            inValue.Body.Amount = Amount;
            inValue.Body.From = From;
            inValue.Body.ToBalance = ToBalance;
            return ((EBillPayment.ServiceReference1.WebService1Soap)(this)).MakePaymentSagicorAsync(inValue);
        }
    }
}
