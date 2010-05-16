﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UtnEmall.ServerManager.SAL.UserAction
{


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "ServiceReference1.IUserAction")]
    public interface IUserAction
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IUserAction/Save", ReplyAction = "http://tempuri.org/IUserAction/SaveResponse")]
        UtnEmall.Server.EntityModel.UserActionEntity Save(UtnEmall.Server.EntityModel.UserActionEntity userActionEntity, string session);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IUserAction/Delete", ReplyAction = "http://tempuri.org/IUserAction/DeleteResponse")]
        UtnEmall.Server.EntityModel.UserActionEntity Delete(UtnEmall.Server.EntityModel.UserActionEntity userActionEntity, string session);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IUserAction/GetUserAction", ReplyAction = "http://tempuri.org/IUserAction/GetUserActionResponse")]
        UtnEmall.Server.EntityModel.UserActionEntity GetUserAction(int id, bool loadRelation, string session);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IUserAction/GetAllUserAction", ReplyAction = "http://tempuri.org/IUserAction/GetAllUserActionResponse")]
        UtnEmall.Server.EntityModel.UserActionEntity[] GetAllUserAction(bool loadRelation, string session);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IUserAction/GetUserActionWhere", ReplyAction = "http://tempuri.org/IUserAction/GetUserActionWhereResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.Base.OperatorType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserActionEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.Error[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.Error))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CustomerEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.PreferenceEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.PreferenceEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CategoryEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CategoryEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ServiceCategoryEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ServiceCategoryEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ServiceEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.MallEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ServiceEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.StoreEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.StoreEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.StoreCategoryEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.StoreCategoryEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.DataModelEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.DataModelEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.TableEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.TableEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.FieldEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.FieldEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ComponentEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CustomerServiceDataEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ComponentEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ConnectionWidgetEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ConnectionWidgetEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ConnectionPointEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.RelationEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.RelationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserGroupEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserGroupEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.GroupEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.PermissionEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.PermissionEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CustomerEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.DeviceProfileEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.DeviceProfileEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserActionEntity[]))]
        UtnEmall.Server.EntityModel.UserActionEntity[] GetUserActionWhere(string propertyName, object expValue, bool loadRelation, UtnEmall.Server.Base.OperatorType operatorType, string session);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IUserAction/GetUserActionWhereEqual", ReplyAction = "http://tempuri.org/IUserAction/GetUserActionWhereEqualResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.Base.OperatorType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserActionEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.Error[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.Error))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CustomerEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.PreferenceEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.PreferenceEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CategoryEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CategoryEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ServiceCategoryEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ServiceCategoryEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ServiceEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.MallEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ServiceEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.StoreEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.StoreEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.StoreCategoryEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.StoreCategoryEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.DataModelEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.DataModelEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.TableEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.TableEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.FieldEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.FieldEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ComponentEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CustomerServiceDataEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ComponentEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ConnectionWidgetEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ConnectionWidgetEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.ConnectionPointEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.RelationEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.RelationEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserGroupEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserGroupEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.GroupEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.PermissionEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.PermissionEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.CustomerEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.DeviceProfileEntity[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.DeviceProfileEntity))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(UtnEmall.Server.EntityModel.UserActionEntity[]))]
        UtnEmall.Server.EntityModel.UserActionEntity[] GetUserActionWhereEqual(string propertyName, object expValue, bool loadRelation, string session);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IUserAction/Validate", ReplyAction = "http://tempuri.org/IUserAction/ValidateResponse")]
        bool Validate(UtnEmall.Server.EntityModel.UserActionEntity userAction);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IUserActionChannel : ServerManager.SAL.UserAction.IUserAction, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class UserActionClient : System.ServiceModel.ClientBase<ServerManager.SAL.UserAction.IUserAction>, ServerManager.SAL.UserAction.IUserAction
    {

        public UserActionClient()
        {
        }

        public UserActionClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public UserActionClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public UserActionClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public UserActionClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        public UtnEmall.Server.EntityModel.UserActionEntity Save(UtnEmall.Server.EntityModel.UserActionEntity userActionEntity, string session)
        {
            return base.Channel.Save(userActionEntity, session);
        }

        public UtnEmall.Server.EntityModel.UserActionEntity Delete(UtnEmall.Server.EntityModel.UserActionEntity userActionEntity, string session)
        {
            return base.Channel.Delete(userActionEntity, session);
        }

        public UtnEmall.Server.EntityModel.UserActionEntity GetUserAction(int id, bool loadRelation, string session)
        {
            return base.Channel.GetUserAction(id, loadRelation, session);
        }

        public UtnEmall.Server.EntityModel.UserActionEntity[] GetAllUserAction(bool loadRelation, string session)
        {
            return base.Channel.GetAllUserAction(loadRelation, session);
        }

        public UtnEmall.Server.EntityModel.UserActionEntity[] GetUserActionWhere(string propertyName, object expValue, bool loadRelation, UtnEmall.Server.Base.OperatorType operatorType, string session)
        {
            return base.Channel.GetUserActionWhere(propertyName, expValue, loadRelation, operatorType, session);
        }

        public UtnEmall.Server.EntityModel.UserActionEntity[] GetUserActionWhereEqual(string propertyName, object expValue, bool loadRelation, string session)
        {
            return base.Channel.GetUserActionWhereEqual(propertyName, expValue, loadRelation, session);
        }

        public bool Validate(UtnEmall.Server.EntityModel.UserActionEntity userAction)
        {
            return base.Channel.Validate(userAction);
        }
    }
}