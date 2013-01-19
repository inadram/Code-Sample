﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientMax.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MachineDTO", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
    [System.SerializableAttribute()]
    public partial class MachineDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MachineIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MachineNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MachineID {
            get {
                return this.MachineIDField;
            }
            set {
                if ((object.ReferenceEquals(this.MachineIDField, value) != true)) {
                    this.MachineIDField = value;
                    this.RaisePropertyChanged("MachineID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MachineName {
            get {
                return this.MachineNameField;
            }
            set {
                if ((object.ReferenceEquals(this.MachineNameField, value) != true)) {
                    this.MachineNameField = value;
                    this.RaisePropertyChanged("MachineName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IMachine")]
    public interface IMachine {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMachine/Add")]
        void Add(ClientMax.ServiceReference1.MachineDTO machineDTO);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMachine/GetMachineName", ReplyAction="http://tempuri.org/IMachine/GetMachineNameResponse")]
        string GetMachineName(ClientMax.ServiceReference1.MachineDTO machineDTO);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMachineChannel : ClientMax.ServiceReference1.IMachine, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MachineClient : System.ServiceModel.ClientBase<ClientMax.ServiceReference1.IMachine>, ClientMax.ServiceReference1.IMachine {
        
        public MachineClient() {
        }
        
        public MachineClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MachineClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MachineClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MachineClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Add(ClientMax.ServiceReference1.MachineDTO machineDTO) {
            base.Channel.Add(machineDTO);
        }
        
        public string GetMachineName(ClientMax.ServiceReference1.MachineDTO machineDTO) {
            return base.Channel.GetMachineName(machineDTO);
        }
    }
}
