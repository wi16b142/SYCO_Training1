﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Viewer.SR_Person {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Data", Namespace="http://schemas.datacontract.org/2004/07/Shared")]
    [System.SerializableAttribute()]
    public partial class Data : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SalaryField;
        
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
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Salary {
            get {
                return this.SalaryField;
            }
            set {
                if ((this.SalaryField.Equals(value) != true)) {
                    this.SalaryField = value;
                    this.RaisePropertyChanged("Salary");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SR_Person.IService_Person")]
    public interface IService_Person {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Person/QueryAllData", ReplyAction="http://tempuri.org/IService_Person/QueryAllDataResponse")]
        Viewer.SR_Person.Data[] QueryAllData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Person/QueryAllData", ReplyAction="http://tempuri.org/IService_Person/QueryAllDataResponse")]
        System.Threading.Tasks.Task<Viewer.SR_Person.Data[]> QueryAllDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Person/AddData", ReplyAction="http://tempuri.org/IService_Person/AddDataResponse")]
        Viewer.SR_Person.Data AddData(System.Guid id, string name, int salary);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService_Person/AddData", ReplyAction="http://tempuri.org/IService_Person/AddDataResponse")]
        System.Threading.Tasks.Task<Viewer.SR_Person.Data> AddDataAsync(System.Guid id, string name, int salary);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService_PersonChannel : Viewer.SR_Person.IService_Person, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service_PersonClient : System.ServiceModel.ClientBase<Viewer.SR_Person.IService_Person>, Viewer.SR_Person.IService_Person {
        
        public Service_PersonClient() {
        }
        
        public Service_PersonClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service_PersonClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_PersonClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service_PersonClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Viewer.SR_Person.Data[] QueryAllData() {
            return base.Channel.QueryAllData();
        }
        
        public System.Threading.Tasks.Task<Viewer.SR_Person.Data[]> QueryAllDataAsync() {
            return base.Channel.QueryAllDataAsync();
        }
        
        public Viewer.SR_Person.Data AddData(System.Guid id, string name, int salary) {
            return base.Channel.AddData(id, name, salary);
        }
        
        public System.Threading.Tasks.Task<Viewer.SR_Person.Data> AddDataAsync(System.Guid id, string name, int salary) {
            return base.Channel.AddDataAsync(id, name, salary);
        }
    }
}
