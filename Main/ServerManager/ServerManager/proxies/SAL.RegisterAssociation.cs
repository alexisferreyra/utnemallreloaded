﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UtnEmall.ServerManager.SAL.RegisterAssociation {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SAL.RegisterAssociation.IRegisterAssociation")]
    public interface IRegisterAssociation {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegisterAssociation/Save", ReplyAction="http://tempuri.org/IRegisterAssociation/SaveResponse")]
        UtnEmall.Server.EntityModel.RegisterAssociationEntity Save(UtnEmall.Server.EntityModel.RegisterAssociationEntity registerAssociationEntity, string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegisterAssociation/Delete", ReplyAction="http://tempuri.org/IRegisterAssociation/DeleteResponse")]
        UtnEmall.Server.EntityModel.RegisterAssociationEntity Delete(UtnEmall.Server.EntityModel.RegisterAssociationEntity registerAssociationEntity, string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegisterAssociation/GetRegisterAssociation", ReplyAction="http://tempuri.org/IRegisterAssociation/GetRegisterAssociationResponse")]
        UtnEmall.Server.EntityModel.RegisterAssociationEntity GetRegisterAssociation(int id, bool loadRelation, string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegisterAssociation/GetAllRegisterAssociation", ReplyAction="http://tempuri.org/IRegisterAssociation/GetAllRegisterAssociationResponse")]
        UtnEmall.Server.EntityModel.RegisterAssociationEntity[] GetAllRegisterAssociation(bool loadRelation, string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegisterAssociation/GetRegisterAssociationWhere", ReplyAction="http://tempuri.org/IRegisterAssociation/GetRegisterAssociationWhereResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.Base.OperatorType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.RegisterAssociationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.Error[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.Error))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.TableEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.FieldEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.FieldEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.DataModelEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.TableEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.RelationEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.RelationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.MallEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ServiceEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ServiceEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.StoreEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.StoreCategoryEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.StoreCategoryEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CategoryEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CategoryEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.PreferenceEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.PreferenceEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CustomerEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.DeviceProfileEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.DeviceProfileEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ServiceCategoryEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ServiceCategoryEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.DataModelEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserGroupEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserGroupEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.GroupEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.PermissionEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.PermissionEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CustomerServiceDataEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ComponentEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ComponentEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ConnectionPointEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ConnectionWidgetEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ConnectionWidgetEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.StoreEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CustomerEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.RegisterAssociationCategoriesEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.RegisterAssociationCategoriesEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.RegisterAssociationEntity[]))]
        UtnEmall.Server.EntityModel.RegisterAssociationEntity[] GetRegisterAssociationWhere(string propertyName, object expValue, bool loadRelation, UtnEmall.Server.Base.OperatorType operatorType, string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegisterAssociation/GetRegisterAssociationWhereEqual", ReplyAction="http://tempuri.org/IRegisterAssociation/GetRegisterAssociationWhereEqualResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.Base.OperatorType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.RegisterAssociationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.Error[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.Error))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.TableEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.FieldEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.FieldEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.DataModelEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.TableEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.RelationEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.RelationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.MallEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ServiceEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ServiceEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.StoreEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.StoreCategoryEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.StoreCategoryEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CategoryEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CategoryEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.PreferenceEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.PreferenceEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CustomerEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.DeviceProfileEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.DeviceProfileEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ServiceCategoryEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ServiceCategoryEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.DataModelEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserGroupEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserGroupEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.GroupEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.PermissionEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.PermissionEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CustomerServiceDataEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ComponentEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ComponentEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ConnectionPointEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ConnectionWidgetEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ConnectionWidgetEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.StoreEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CustomerEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.RegisterAssociationCategoriesEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.RegisterAssociationCategoriesEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.RegisterAssociationEntity[]))]
        UtnEmall.Server.EntityModel.RegisterAssociationEntity[] GetRegisterAssociationWhereEqual(string propertyName, object expValue, bool loadRelation, string session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegisterAssociation/Validate", ReplyAction="http://tempuri.org/IRegisterAssociation/ValidateResponse")]
        bool Validate(UtnEmall.Server.EntityModel.RegisterAssociationEntity registerAssociation);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IRegisterAssociationChannel : ServerManager.SAL.RegisterAssociation.IRegisterAssociation, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class RegisterAssociationClient : System.ServiceModel.ClientBase<ServerManager.SAL.RegisterAssociation.IRegisterAssociation>, ServerManager.SAL.RegisterAssociation.IRegisterAssociation {
        
        public RegisterAssociationClient() {
        }
        
        public RegisterAssociationClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RegisterAssociationClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RegisterAssociationClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RegisterAssociationClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public UtnEmall.Server.EntityModel.RegisterAssociationEntity Save(UtnEmall.Server.EntityModel.RegisterAssociationEntity registerAssociationEntity, string session) {
            return base.Channel.Save(registerAssociationEntity, session);
        }
        
        public UtnEmall.Server.EntityModel.RegisterAssociationEntity Delete(UtnEmall.Server.EntityModel.RegisterAssociationEntity registerAssociationEntity, string session) {
            return base.Channel.Delete(registerAssociationEntity, session);
        }
        
        public UtnEmall.Server.EntityModel.RegisterAssociationEntity GetRegisterAssociation(int id, bool loadRelation, string session) {
            return base.Channel.GetRegisterAssociation(id, loadRelation, session);
        }
        
        public UtnEmall.Server.EntityModel.RegisterAssociationEntity[] GetAllRegisterAssociation(bool loadRelation, string session) {
            return base.Channel.GetAllRegisterAssociation(loadRelation, session);
        }

        public UtnEmall.Server.EntityModel.RegisterAssociationEntity[] GetRegisterAssociationWhere(string propertyName, object expValue, bool loadRelation, UtnEmall.Server.Base.OperatorType operatorType, string session)
        {
            return base.Channel.GetRegisterAssociationWhere(propertyName, expValue, loadRelation, operatorType, session);
        }
        
        public UtnEmall.Server.EntityModel.RegisterAssociationEntity[] GetRegisterAssociationWhereEqual(string propertyName, object expValue, bool loadRelation, string session) {
            return base.Channel.GetRegisterAssociationWhereEqual(propertyName, expValue, loadRelation, session);
        }
        
        public bool Validate(UtnEmall.Server.EntityModel.RegisterAssociationEntity registerAssociation) {
            return base.Channel.Validate(registerAssociation);
        }
    }
}