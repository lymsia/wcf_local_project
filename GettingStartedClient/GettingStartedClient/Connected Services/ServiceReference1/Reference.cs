﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GettingStartedClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="user", Namespace="http://schemas.datacontract.org/2004/07/GettingStartedLib.Class")]
    [System.SerializableAttribute()]
    public partial class user : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int is_activateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int is_adminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime last_loginField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string passwordField;
        
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
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int is_activate {
            get {
                return this.is_activateField;
            }
            set {
                if ((this.is_activateField.Equals(value) != true)) {
                    this.is_activateField = value;
                    this.RaisePropertyChanged("is_activate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int is_admin {
            get {
                return this.is_adminField;
            }
            set {
                if ((this.is_adminField.Equals(value) != true)) {
                    this.is_adminField = value;
                    this.RaisePropertyChanged("is_admin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime last_login {
            get {
                return this.last_loginField;
            }
            set {
                if ((this.last_loginField.Equals(value) != true)) {
                    this.last_loginField = value;
                    this.RaisePropertyChanged("last_login");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                if ((object.ReferenceEquals(this.passwordField, value) != true)) {
                    this.passwordField = value;
                    this.RaisePropertyChanged("password");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.MyService")]
    public interface MyService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MyService/List", ReplyAction="http://tempuri.org/MyService/ListResponse")]
        GettingStartedClient.ServiceReference1.user List(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MyService/List", ReplyAction="http://tempuri.org/MyService/ListResponse")]
        System.Threading.Tasks.Task<GettingStartedClient.ServiceReference1.user> ListAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MyService/Add", ReplyAction="http://tempuri.org/MyService/AddResponse")]
        bool Add(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MyService/Add", ReplyAction="http://tempuri.org/MyService/AddResponse")]
        System.Threading.Tasks.Task<bool> AddAsync(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MyService/Update", ReplyAction="http://tempuri.org/MyService/UpdateResponse")]
        bool Update(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MyService/Update", ReplyAction="http://tempuri.org/MyService/UpdateResponse")]
        System.Threading.Tasks.Task<bool> UpdateAsync(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MyService/Delete", ReplyAction="http://tempuri.org/MyService/DeleteResponse")]
        bool Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MyService/Delete", ReplyAction="http://tempuri.org/MyService/DeleteResponse")]
        System.Threading.Tasks.Task<bool> DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MyServiceChannel : GettingStartedClient.ServiceReference1.MyService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyServiceClient : System.ServiceModel.ClientBase<GettingStartedClient.ServiceReference1.MyService>, GettingStartedClient.ServiceReference1.MyService {
        
        public MyServiceClient() {
        }
        
        public MyServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GettingStartedClient.ServiceReference1.user List(string email) {
            return base.Channel.List(email);
        }
        
        public System.Threading.Tasks.Task<GettingStartedClient.ServiceReference1.user> ListAsync(string email) {
            return base.Channel.ListAsync(email);
        }
        
        public bool Add(string name, string password) {
            return base.Channel.Add(name, password);
        }
        
        public System.Threading.Tasks.Task<bool> AddAsync(string name, string password) {
            return base.Channel.AddAsync(name, password);
        }
        
        public bool Update(string name, string password) {
            return base.Channel.Update(name, password);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAsync(string name, string password) {
            return base.Channel.UpdateAsync(name, password);
        }
        
        public bool Delete(int id) {
            return base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}
