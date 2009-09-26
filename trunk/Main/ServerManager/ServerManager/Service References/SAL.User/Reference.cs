﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UtnEmall.ServerManager.SAL.User {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SAL.User.IUser")]
    public interface IUser {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/Save", ReplyAction="http://tempuri.org/IUser/SaveResponse")]
        UtnEmall.Server.EntityModel.UserEntity Save(UtnEmall.Server.EntityModel.UserEntity userEntity, string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/Delete", ReplyAction="http://tempuri.org/IUser/DeleteResponse")]
        UtnEmall.Server.EntityModel.UserEntity Delete(UtnEmall.Server.EntityModel.UserEntity userEntity, string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUser", ReplyAction="http://tempuri.org/IUser/GetUserResponse")]
        UtnEmall.Server.EntityModel.UserEntity GetUser(int id, bool loadRelation, string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetAllUser", ReplyAction="http://tempuri.org/IUser/GetAllUserResponse")]
        System.Collections.Generic.List<UtnEmall.Server.EntityModel.UserEntity> GetAllUser(bool loadRelation, string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUserWhere", ReplyAction="http://tempuri.org/IUser/GetUserWhereResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.Base.OperatorType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.Error>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.Error))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.UserGroupEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserGroupEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.GroupEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.PermissionEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.PermissionEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.StoreEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.StoreCategoryEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.StoreCategoryEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CategoryEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.CategoryEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.PreferenceEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.PreferenceEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CustomerEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.MallEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.ServiceEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ServiceEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.ServiceCategoryEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ServiceCategoryEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CustomerServiceDataEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.ComponentEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ComponentEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ConnectionPointEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ConnectionWidgetEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.TableEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.FieldEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.FieldEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.DataModelEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.TableEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.RelationEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.RelationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.ConnectionWidgetEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.StoreEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.CustomerEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.DataModelEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.DeviceProfileEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.DeviceProfileEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.UserEntity>))]
        System.Collections.Generic.List<UtnEmall.Server.EntityModel.UserEntity> GetUserWhere(string propertyName, object expValue, bool loadRelation, UtnEmall.Server.Base.OperatorType operatorType, string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/GetUserWhereEqual", ReplyAction="http://tempuri.org/IUser/GetUserWhereEqualResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.Base.OperatorType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.Error>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.Error))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.UserGroupEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserGroupEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.GroupEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.PermissionEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.PermissionEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.StoreEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.StoreCategoryEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.StoreCategoryEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CategoryEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.CategoryEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.PreferenceEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.PreferenceEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CustomerEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.MallEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.ServiceEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ServiceEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.ServiceCategoryEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ServiceCategoryEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CustomerServiceDataEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.ComponentEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ComponentEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ConnectionPointEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ConnectionWidgetEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.TableEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.FieldEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.FieldEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.DataModelEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.TableEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.RelationEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.RelationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.ConnectionWidgetEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.StoreEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.CustomerEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.DataModelEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.DeviceProfileEntity>))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.DeviceProfileEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Collections.Generic.List<UtnEmall.Server.EntityModel.UserEntity>))]
        System.Collections.Generic.List<UtnEmall.Server.EntityModel.UserEntity> GetUserWhereEqual(string propertyName, object expValue, bool loadRelation, string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUser/Validate", ReplyAction="http://tempuri.org/IUser/ValidateResponse")]
        bool Validate(UtnEmall.Server.EntityModel.UserEntity user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IUserChannel : UtnEmall.ServerManager.SAL.User.IUser, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class UserClient : System.ServiceModel.ClientBase<UtnEmall.ServerManager.SAL.User.IUser>, UtnEmall.ServerManager.SAL.User.IUser {
        
        public UserClient() {
        }
        
        public UserClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UserClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UserClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public UtnEmall.Server.EntityModel.UserEntity Save(UtnEmall.Server.EntityModel.UserEntity userEntity, string session) {
            return base.Channel.Save(userEntity, session);
        }
        
        public UtnEmall.Server.EntityModel.UserEntity Delete(UtnEmall.Server.EntityModel.UserEntity userEntity, string session) {
            return base.Channel.Delete(userEntity, session);
        }
        
        public UtnEmall.Server.EntityModel.UserEntity GetUser(int id, bool loadRelation, string session) {
            return base.Channel.GetUser(id, loadRelation, session);
        }
        
        public System.Collections.Generic.List<UtnEmall.Server.EntityModel.UserEntity> GetAllUser(bool loadRelation, string session) {
            return base.Channel.GetAllUser(loadRelation, session);
        }
        
        public System.Collections.Generic.List<UtnEmall.Server.EntityModel.UserEntity> GetUserWhere(string propertyName, object expValue, bool loadRelation, UtnEmall.Server.Base.OperatorType operatorType, string session) {
            return base.Channel.GetUserWhere(propertyName, expValue, loadRelation, operatorType, session);
        }
        
        public System.Collections.Generic.List<UtnEmall.Server.EntityModel.UserEntity> GetUserWhereEqual(string propertyName, object expValue, bool loadRelation, string session) {
            return base.Channel.GetUserWhereEqual(propertyName, expValue, loadRelation, session);
        }
        
        public bool Validate(UtnEmall.Server.EntityModel.UserEntity user) {
            return base.Channel.Validate(user);
        }
    }
}
