﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumirRepoRomsWS.RomsWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="cRom", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class cRom : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string sinopsisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] coverField;
        
        private System.DateTime fechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string videoField;
        
        private int consolaIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string sinopsis {
            get {
                return this.sinopsisField;
            }
            set {
                if ((object.ReferenceEquals(this.sinopsisField, value) != true)) {
                    this.sinopsisField = value;
                    this.RaisePropertyChanged("sinopsis");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public byte[] cover {
            get {
                return this.coverField;
            }
            set {
                if ((object.ReferenceEquals(this.coverField, value) != true)) {
                    this.coverField = value;
                    this.RaisePropertyChanged("cover");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public System.DateTime fecha {
            get {
                return this.fechaField;
            }
            set {
                if ((this.fechaField.Equals(value) != true)) {
                    this.fechaField = value;
                    this.RaisePropertyChanged("fecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string video {
            get {
                return this.videoField;
            }
            set {
                if ((object.ReferenceEquals(this.videoField, value) != true)) {
                    this.videoField = value;
                    this.RaisePropertyChanged("video");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public int consolaId {
            get {
                return this.consolaIdField;
            }
            set {
                if ((this.consolaIdField.Equals(value) != true)) {
                    this.consolaIdField = value;
                    this.RaisePropertyChanged("consolaId");
                }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfCRom", Namespace="http://tempuri.org/", ItemName="cRom")]
    [System.SerializableAttribute()]
    public class ArrayOfCRom : System.Collections.Generic.List<ConsumirRepoRomsWS.RomsWS.cRom> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfCConsola", Namespace="http://tempuri.org/", ItemName="cConsola")]
    [System.SerializableAttribute()]
    public class ArrayOfCConsola : System.Collections.Generic.List<ConsumirRepoRomsWS.RomsWS.cConsola> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="cConsola", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class cConsola : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RomsWS.RomsWebServiceSoap")]
    public interface RomsWebServiceSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ConsumirRepoRomsWS.RomsWS.HelloWorldResponse HelloWorld(ConsumirRepoRomsWS.RomsWS.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsumirRepoRomsWS.RomsWS.HelloWorldResponse> HelloWorldAsync(ConsumirRepoRomsWS.RomsWS.HelloWorldRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento nombre del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarRom", ReplyAction="*")]
        ConsumirRepoRomsWS.RomsWS.AgregarRomResponse AgregarRom(ConsumirRepoRomsWS.RomsWS.AgregarRomRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AgregarRom", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsumirRepoRomsWS.RomsWS.AgregarRomResponse> AgregarRomAsync(ConsumirRepoRomsWS.RomsWS.AgregarRomRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarRom", ReplyAction="*")]
        int EliminarRom(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EliminarRom", ReplyAction="*")]
        System.Threading.Tasks.Task<int> EliminarRomAsync(int id);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento DetalleRomResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DetalleRom", ReplyAction="*")]
        ConsumirRepoRomsWS.RomsWS.DetalleRomResponse DetalleRom(ConsumirRepoRomsWS.RomsWS.DetalleRomRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/DetalleRom", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsumirRepoRomsWS.RomsWS.DetalleRomResponse> DetalleRomAsync(ConsumirRepoRomsWS.RomsWS.DetalleRomRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento ListarRomsResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarRoms", ReplyAction="*")]
        ConsumirRepoRomsWS.RomsWS.ListarRomsResponse ListarRoms(ConsumirRepoRomsWS.RomsWS.ListarRomsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarRoms", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsumirRepoRomsWS.RomsWS.ListarRomsResponse> ListarRomsAsync(ConsumirRepoRomsWS.RomsWS.ListarRomsRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento ListarConsolaResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarConsola", ReplyAction="*")]
        ConsumirRepoRomsWS.RomsWS.ListarConsolaResponse ListarConsola(ConsumirRepoRomsWS.RomsWS.ListarConsolaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarConsola", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsumirRepoRomsWS.RomsWS.ListarConsolaResponse> ListarConsolaAsync(ConsumirRepoRomsWS.RomsWS.ListarConsolaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ConsumirRepoRomsWS.RomsWS.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(ConsumirRepoRomsWS.RomsWS.HelloWorldRequestBody Body) {
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
        public ConsumirRepoRomsWS.RomsWS.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(ConsumirRepoRomsWS.RomsWS.HelloWorldResponseBody Body) {
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
    public partial class AgregarRomRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarRom", Namespace="http://tempuri.org/", Order=0)]
        public ConsumirRepoRomsWS.RomsWS.AgregarRomRequestBody Body;
        
        public AgregarRomRequest() {
        }
        
        public AgregarRomRequest(ConsumirRepoRomsWS.RomsWS.AgregarRomRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarRomRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nombre;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string sinopsis;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public byte[] cover;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public System.DateTime fecha;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string video;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int consolaId;
        
        public AgregarRomRequestBody() {
        }
        
        public AgregarRomRequestBody(string nombre, string sinopsis, byte[] cover, System.DateTime fecha, string video, int consolaId) {
            this.nombre = nombre;
            this.sinopsis = sinopsis;
            this.cover = cover;
            this.fecha = fecha;
            this.video = video;
            this.consolaId = consolaId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarRomResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarRomResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsumirRepoRomsWS.RomsWS.AgregarRomResponseBody Body;
        
        public AgregarRomResponse() {
        }
        
        public AgregarRomResponse(ConsumirRepoRomsWS.RomsWS.AgregarRomResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AgregarRomResponseBody {
        
        public AgregarRomResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DetalleRomRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DetalleRom", Namespace="http://tempuri.org/", Order=0)]
        public ConsumirRepoRomsWS.RomsWS.DetalleRomRequestBody Body;
        
        public DetalleRomRequest() {
        }
        
        public DetalleRomRequest(ConsumirRepoRomsWS.RomsWS.DetalleRomRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DetalleRomRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public DetalleRomRequestBody() {
        }
        
        public DetalleRomRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class DetalleRomResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="DetalleRomResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsumirRepoRomsWS.RomsWS.DetalleRomResponseBody Body;
        
        public DetalleRomResponse() {
        }
        
        public DetalleRomResponse(ConsumirRepoRomsWS.RomsWS.DetalleRomResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class DetalleRomResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ConsumirRepoRomsWS.RomsWS.cRom DetalleRomResult;
        
        public DetalleRomResponseBody() {
        }
        
        public DetalleRomResponseBody(ConsumirRepoRomsWS.RomsWS.cRom DetalleRomResult) {
            this.DetalleRomResult = DetalleRomResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListarRomsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListarRoms", Namespace="http://tempuri.org/", Order=0)]
        public ConsumirRepoRomsWS.RomsWS.ListarRomsRequestBody Body;
        
        public ListarRomsRequest() {
        }
        
        public ListarRomsRequest(ConsumirRepoRomsWS.RomsWS.ListarRomsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListarRomsRequestBody {
        
        public ListarRomsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListarRomsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListarRomsResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsumirRepoRomsWS.RomsWS.ListarRomsResponseBody Body;
        
        public ListarRomsResponse() {
        }
        
        public ListarRomsResponse(ConsumirRepoRomsWS.RomsWS.ListarRomsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ListarRomsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ConsumirRepoRomsWS.RomsWS.ArrayOfCRom ListarRomsResult;
        
        public ListarRomsResponseBody() {
        }
        
        public ListarRomsResponseBody(ConsumirRepoRomsWS.RomsWS.ArrayOfCRom ListarRomsResult) {
            this.ListarRomsResult = ListarRomsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListarConsolaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListarConsola", Namespace="http://tempuri.org/", Order=0)]
        public ConsumirRepoRomsWS.RomsWS.ListarConsolaRequestBody Body;
        
        public ListarConsolaRequest() {
        }
        
        public ListarConsolaRequest(ConsumirRepoRomsWS.RomsWS.ListarConsolaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListarConsolaRequestBody {
        
        public ListarConsolaRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListarConsolaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListarConsolaResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsumirRepoRomsWS.RomsWS.ListarConsolaResponseBody Body;
        
        public ListarConsolaResponse() {
        }
        
        public ListarConsolaResponse(ConsumirRepoRomsWS.RomsWS.ListarConsolaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ListarConsolaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ConsumirRepoRomsWS.RomsWS.ArrayOfCConsola ListarConsolaResult;
        
        public ListarConsolaResponseBody() {
        }
        
        public ListarConsolaResponseBody(ConsumirRepoRomsWS.RomsWS.ArrayOfCConsola ListarConsolaResult) {
            this.ListarConsolaResult = ListarConsolaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface RomsWebServiceSoapChannel : ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RomsWebServiceSoapClient : System.ServiceModel.ClientBase<ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap>, ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap {
        
        public RomsWebServiceSoapClient() {
        }
        
        public RomsWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RomsWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RomsWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RomsWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsumirRepoRomsWS.RomsWS.HelloWorldResponse ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap.HelloWorld(ConsumirRepoRomsWS.RomsWS.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            ConsumirRepoRomsWS.RomsWS.HelloWorldRequest inValue = new ConsumirRepoRomsWS.RomsWS.HelloWorldRequest();
            inValue.Body = new ConsumirRepoRomsWS.RomsWS.HelloWorldRequestBody();
            ConsumirRepoRomsWS.RomsWS.HelloWorldResponse retVal = ((ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsumirRepoRomsWS.RomsWS.HelloWorldResponse> ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap.HelloWorldAsync(ConsumirRepoRomsWS.RomsWS.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsumirRepoRomsWS.RomsWS.HelloWorldResponse> HelloWorldAsync() {
            ConsumirRepoRomsWS.RomsWS.HelloWorldRequest inValue = new ConsumirRepoRomsWS.RomsWS.HelloWorldRequest();
            inValue.Body = new ConsumirRepoRomsWS.RomsWS.HelloWorldRequestBody();
            return ((ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsumirRepoRomsWS.RomsWS.AgregarRomResponse ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap.AgregarRom(ConsumirRepoRomsWS.RomsWS.AgregarRomRequest request) {
            return base.Channel.AgregarRom(request);
        }
        
        public void AgregarRom(string nombre, string sinopsis, byte[] cover, System.DateTime fecha, string video, int consolaId) {
            ConsumirRepoRomsWS.RomsWS.AgregarRomRequest inValue = new ConsumirRepoRomsWS.RomsWS.AgregarRomRequest();
            inValue.Body = new ConsumirRepoRomsWS.RomsWS.AgregarRomRequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.sinopsis = sinopsis;
            inValue.Body.cover = cover;
            inValue.Body.fecha = fecha;
            inValue.Body.video = video;
            inValue.Body.consolaId = consolaId;
            ConsumirRepoRomsWS.RomsWS.AgregarRomResponse retVal = ((ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap)(this)).AgregarRom(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsumirRepoRomsWS.RomsWS.AgregarRomResponse> ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap.AgregarRomAsync(ConsumirRepoRomsWS.RomsWS.AgregarRomRequest request) {
            return base.Channel.AgregarRomAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsumirRepoRomsWS.RomsWS.AgregarRomResponse> AgregarRomAsync(string nombre, string sinopsis, byte[] cover, System.DateTime fecha, string video, int consolaId) {
            ConsumirRepoRomsWS.RomsWS.AgregarRomRequest inValue = new ConsumirRepoRomsWS.RomsWS.AgregarRomRequest();
            inValue.Body = new ConsumirRepoRomsWS.RomsWS.AgregarRomRequestBody();
            inValue.Body.nombre = nombre;
            inValue.Body.sinopsis = sinopsis;
            inValue.Body.cover = cover;
            inValue.Body.fecha = fecha;
            inValue.Body.video = video;
            inValue.Body.consolaId = consolaId;
            return ((ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap)(this)).AgregarRomAsync(inValue);
        }
        
        public int EliminarRom(int id) {
            return base.Channel.EliminarRom(id);
        }
        
        public System.Threading.Tasks.Task<int> EliminarRomAsync(int id) {
            return base.Channel.EliminarRomAsync(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsumirRepoRomsWS.RomsWS.DetalleRomResponse ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap.DetalleRom(ConsumirRepoRomsWS.RomsWS.DetalleRomRequest request) {
            return base.Channel.DetalleRom(request);
        }
        
        public ConsumirRepoRomsWS.RomsWS.cRom DetalleRom(int id) {
            ConsumirRepoRomsWS.RomsWS.DetalleRomRequest inValue = new ConsumirRepoRomsWS.RomsWS.DetalleRomRequest();
            inValue.Body = new ConsumirRepoRomsWS.RomsWS.DetalleRomRequestBody();
            inValue.Body.id = id;
            ConsumirRepoRomsWS.RomsWS.DetalleRomResponse retVal = ((ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap)(this)).DetalleRom(inValue);
            return retVal.Body.DetalleRomResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsumirRepoRomsWS.RomsWS.DetalleRomResponse> ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap.DetalleRomAsync(ConsumirRepoRomsWS.RomsWS.DetalleRomRequest request) {
            return base.Channel.DetalleRomAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsumirRepoRomsWS.RomsWS.DetalleRomResponse> DetalleRomAsync(int id) {
            ConsumirRepoRomsWS.RomsWS.DetalleRomRequest inValue = new ConsumirRepoRomsWS.RomsWS.DetalleRomRequest();
            inValue.Body = new ConsumirRepoRomsWS.RomsWS.DetalleRomRequestBody();
            inValue.Body.id = id;
            return ((ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap)(this)).DetalleRomAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsumirRepoRomsWS.RomsWS.ListarRomsResponse ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap.ListarRoms(ConsumirRepoRomsWS.RomsWS.ListarRomsRequest request) {
            return base.Channel.ListarRoms(request);
        }
        
        public ConsumirRepoRomsWS.RomsWS.ArrayOfCRom ListarRoms() {
            ConsumirRepoRomsWS.RomsWS.ListarRomsRequest inValue = new ConsumirRepoRomsWS.RomsWS.ListarRomsRequest();
            inValue.Body = new ConsumirRepoRomsWS.RomsWS.ListarRomsRequestBody();
            ConsumirRepoRomsWS.RomsWS.ListarRomsResponse retVal = ((ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap)(this)).ListarRoms(inValue);
            return retVal.Body.ListarRomsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsumirRepoRomsWS.RomsWS.ListarRomsResponse> ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap.ListarRomsAsync(ConsumirRepoRomsWS.RomsWS.ListarRomsRequest request) {
            return base.Channel.ListarRomsAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsumirRepoRomsWS.RomsWS.ListarRomsResponse> ListarRomsAsync() {
            ConsumirRepoRomsWS.RomsWS.ListarRomsRequest inValue = new ConsumirRepoRomsWS.RomsWS.ListarRomsRequest();
            inValue.Body = new ConsumirRepoRomsWS.RomsWS.ListarRomsRequestBody();
            return ((ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap)(this)).ListarRomsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsumirRepoRomsWS.RomsWS.ListarConsolaResponse ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap.ListarConsola(ConsumirRepoRomsWS.RomsWS.ListarConsolaRequest request) {
            return base.Channel.ListarConsola(request);
        }
        
        public ConsumirRepoRomsWS.RomsWS.ArrayOfCConsola ListarConsola() {
            ConsumirRepoRomsWS.RomsWS.ListarConsolaRequest inValue = new ConsumirRepoRomsWS.RomsWS.ListarConsolaRequest();
            inValue.Body = new ConsumirRepoRomsWS.RomsWS.ListarConsolaRequestBody();
            ConsumirRepoRomsWS.RomsWS.ListarConsolaResponse retVal = ((ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap)(this)).ListarConsola(inValue);
            return retVal.Body.ListarConsolaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsumirRepoRomsWS.RomsWS.ListarConsolaResponse> ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap.ListarConsolaAsync(ConsumirRepoRomsWS.RomsWS.ListarConsolaRequest request) {
            return base.Channel.ListarConsolaAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsumirRepoRomsWS.RomsWS.ListarConsolaResponse> ListarConsolaAsync() {
            ConsumirRepoRomsWS.RomsWS.ListarConsolaRequest inValue = new ConsumirRepoRomsWS.RomsWS.ListarConsolaRequest();
            inValue.Body = new ConsumirRepoRomsWS.RomsWS.ListarConsolaRequestBody();
            return ((ConsumirRepoRomsWS.RomsWS.RomsWebServiceSoap)(this)).ListarConsolaAsync(inValue);
        }
    }
}
