﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UtnEmall.ServerManager.SAL.Campaign {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "SAL.Campaign.ICampaign")]
    public interface ICampaign
    {
        [UtnEmall.Server.Core.ReferencePreservingDataContractFormat]
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICampaign/Save", ReplyAction = "http://tempuri.org/ICampaign/SaveResponse")]
        UtnEmall.Server.EntityModel.CampaignEntity Save(UtnEmall.Server.EntityModel.CampaignEntity campaignEntity, string session);

        [UtnEmall.Server.Core.ReferencePreservingDataContractFormat]
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICampaign/Delete", ReplyAction = "http://tempuri.org/ICampaign/DeleteResponse")]
        UtnEmall.Server.EntityModel.CampaignEntity Delete(UtnEmall.Server.EntityModel.CampaignEntity campaignEntity, string session);

        [UtnEmall.Server.Core.ReferencePreservingDataContractFormat]
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICampaign/GetCampaign", ReplyAction = "http://tempuri.org/ICampaign/GetCampaignResponse")]
        UtnEmall.Server.EntityModel.CampaignEntity GetCampaign(int id, bool loadRelation, string session);

        [UtnEmall.Server.Core.ReferencePreservingDataContractFormat]
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICampaign/GetAllCampaign", ReplyAction = "http://tempuri.org/ICampaign/GetAllCampaignResponse")]
        System.Collections.Generic.List<UtnEmall.Server.EntityModel.CampaignEntity> GetAllCampaign(bool loadRelation, string session);

        [UtnEmall.Server.Core.ReferencePreservingDataContractFormat]
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICampaign/GetCampaignWhere", ReplyAction = "http://tempuri.org/ICampaign/GetCampaignWhereResponse")]
        System.Collections.Generic.List<UtnEmall.Server.EntityModel.CampaignEntity> GetCampaignWhere(string propertyName, object expValue, bool loadRelation, UtnEmall.Server.Base.OperatorType operatorType, string session);

        [UtnEmall.Server.Core.ReferencePreservingDataContractFormat]
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICampaign/GetCampaignWhereEqual", ReplyAction = "http://tempuri.org/ICampaign/GetCampaignWhereEqualResponse")]
        System.Collections.Generic.List<UtnEmall.Server.EntityModel.CampaignEntity> GetCampaignWhereEqual(string propertyName, object expValue, bool loadRelation, string session);

        [UtnEmall.Server.Core.ReferencePreservingDataContractFormat]
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/ICampaign/Validate", ReplyAction = "http://tempuri.org/ICampaign/ValidateResponse")]
        bool Validate(UtnEmall.Server.EntityModel.CampaignEntity campaign);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ICampaignChannel : ServerManager.SAL.Campaign.ICampaign, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class CampaignClient : System.ServiceModel.ClientBase<ServerManager.SAL.Campaign.ICampaign>, ServerManager.SAL.Campaign.ICampaign {
        
        public CampaignClient() {
        }
        
        public CampaignClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CampaignClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CampaignClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }

        public CampaignClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }

        public UtnEmall.Server.EntityModel.CampaignEntity Save(UtnEmall.Server.EntityModel.CampaignEntity campaignEntity, string session)
        {
            return base.Channel.Save(campaignEntity, session);
        }

        public UtnEmall.Server.EntityModel.CampaignEntity Delete(UtnEmall.Server.EntityModel.CampaignEntity campaignEntity, string session)
        {
            return base.Channel.Delete(campaignEntity, session);
        }

        public UtnEmall.Server.EntityModel.CampaignEntity GetCampaign(int id, bool loadRelation, string session)
        {
            return base.Channel.GetCampaign(id, loadRelation, session);
        }

        public System.Collections.Generic.List<UtnEmall.Server.EntityModel.CampaignEntity> GetAllCampaign(bool loadRelation, string session)
        {
            return base.Channel.GetAllCampaign(loadRelation, session);
        }

        public System.Collections.Generic.List<UtnEmall.Server.EntityModel.CampaignEntity> GetCampaignWhere(string propertyName, object expValue, bool loadRelation, UtnEmall.Server.Base.OperatorType operatorType, string session)
        {
            return base.Channel.GetCampaignWhere(propertyName, expValue, loadRelation, operatorType, session);
        }

        public System.Collections.Generic.List<UtnEmall.Server.EntityModel.CampaignEntity> GetCampaignWhereEqual(string propertyName, object expValue, bool loadRelation, string session)
        {
            return base.Channel.GetCampaignWhereEqual(propertyName, expValue, loadRelation, session);
        }

        public bool Validate(UtnEmall.Server.EntityModel.CampaignEntity campaign)
        {
            return base.Channel.Validate(campaign);
        }
    }
}