﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.11.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using TestLLBL.FactoryClasses;
using TestLLBL.RelationClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace TestLLBL.HelperClasses
{
	/// <summary>Singleton implementation of the ModelInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	public static class ModelInfoProviderSingleton
	{
		private static readonly IModelInfoProvider _providerInstance = new ModelInfoProviderCore();

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static ModelInfoProviderSingleton()	{ }

		/// <summary>Gets the singleton instance of the ModelInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IModelInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the ModelInfoProvider.</summary>
	internal class ModelInfoProviderCore : ModelInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="ModelInfoProviderCore"/> class.</summary>
		internal ModelInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass();
			InitAccountEntityInfo();
			InitPetitionEntityInfo();
			InitPetitionStatusEntityInfo();
			InitPlanEntityInfo();
			InitPlanDetailEntityInfo();
			InitProjectEntityInfo();
			InitRatingTypeEntityInfo();
			InitTaskEntityInfo();
			InitTaskStatusEntityInfo();
			InitTaskTypeEntityInfo();
			InitUnitEntityInfo();
			InitUnitAndAccountEntityInfo();
			InitUnitTypeEntityInfo();
			this.BuildInternalStructures();
		}

		/// <summary>Inits AccountEntity's info objects</summary>
		private void InitAccountEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(AccountFieldIndex), "AccountEntity");
			this.AddElementFieldInfo("AccountEntity", "Avatar", typeof(System.String), false, false, false, true,  (int)AccountFieldIndex.Avatar, 200, 0, 0);
			this.AddElementFieldInfo("AccountEntity", "CreatedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)AccountFieldIndex.CreatedDate, 0, 0, 0);
			this.AddElementFieldInfo("AccountEntity", "DisplayName", typeof(System.String), false, false, false, true,  (int)AccountFieldIndex.DisplayName, 200, 0, 0);
			this.AddElementFieldInfo("AccountEntity", "Email", typeof(System.String), false, false, false, true,  (int)AccountFieldIndex.Email, 200, 0, 0);
			this.AddElementFieldInfo("AccountEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)AccountFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("AccountEntity", "Password", typeof(System.String), false, false, false, true,  (int)AccountFieldIndex.Password, 200, 0, 0);
			this.AddElementFieldInfo("AccountEntity", "Username", typeof(System.String), false, false, false, true,  (int)AccountFieldIndex.Username, 200, 0, 0);
		}

		/// <summary>Inits PetitionEntity's info objects</summary>
		private void InitPetitionEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(PetitionFieldIndex), "PetitionEntity");
			this.AddElementFieldInfo("PetitionEntity", "AccountId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)PetitionFieldIndex.AccountId, 0, 0, 10);
			this.AddElementFieldInfo("PetitionEntity", "Content", typeof(System.String), false, false, false, true,  (int)PetitionFieldIndex.Content, 2147483647, 0, 0);
			this.AddElementFieldInfo("PetitionEntity", "CreatedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PetitionFieldIndex.CreatedDate, 0, 0, 0);
			this.AddElementFieldInfo("PetitionEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)PetitionFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("PetitionEntity", "PetitionStatusId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)PetitionFieldIndex.PetitionStatusId, 0, 0, 10);
			this.AddElementFieldInfo("PetitionEntity", "Title", typeof(System.String), false, false, false, true,  (int)PetitionFieldIndex.Title, 200, 0, 0);
		}

		/// <summary>Inits PetitionStatusEntity's info objects</summary>
		private void InitPetitionStatusEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(PetitionStatusFieldIndex), "PetitionStatusEntity");
			this.AddElementFieldInfo("PetitionStatusEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)PetitionStatusFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("PetitionStatusEntity", "Name", typeof(System.String), false, false, false, true,  (int)PetitionStatusFieldIndex.Name, 200, 0, 0);
		}

		/// <summary>Inits PlanEntity's info objects</summary>
		private void InitPlanEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(PlanFieldIndex), "PlanEntity");
			this.AddElementFieldInfo("PlanEntity", "CreatedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PlanFieldIndex.CreatedDate, 0, 0, 0);
			this.AddElementFieldInfo("PlanEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)PlanFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("PlanEntity", "Name", typeof(System.String), false, false, false, true,  (int)PlanFieldIndex.Name, 200, 0, 0);
			this.AddElementFieldInfo("PlanEntity", "ProjectId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)PlanFieldIndex.ProjectId, 0, 0, 10);
			this.AddElementFieldInfo("PlanEntity", "UpdatedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PlanFieldIndex.UpdatedDate, 0, 0, 0);
		}

		/// <summary>Inits PlanDetailEntity's info objects</summary>
		private void InitPlanDetailEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(PlanDetailFieldIndex), "PlanDetailEntity");
			this.AddElementFieldInfo("PlanDetailEntity", "CompleteDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PlanDetailFieldIndex.CompleteDate, 0, 0, 0);
			this.AddElementFieldInfo("PlanDetailEntity", "CreatedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PlanDetailFieldIndex.CreatedDate, 0, 0, 0);
			this.AddElementFieldInfo("PlanDetailEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)PlanDetailFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("PlanDetailEntity", "Name", typeof(System.String), false, false, false, true,  (int)PlanDetailFieldIndex.Name, 200, 0, 0);
			this.AddElementFieldInfo("PlanDetailEntity", "PlanId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)PlanDetailFieldIndex.PlanId, 0, 0, 10);
			this.AddElementFieldInfo("PlanDetailEntity", "UpdatedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PlanDetailFieldIndex.UpdatedDate, 0, 0, 0);
		}

		/// <summary>Inits ProjectEntity's info objects</summary>
		private void InitProjectEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(ProjectFieldIndex), "ProjectEntity");
			this.AddElementFieldInfo("ProjectEntity", "AccountId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)ProjectFieldIndex.AccountId, 0, 0, 10);
			this.AddElementFieldInfo("ProjectEntity", "CreatedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProjectFieldIndex.CreatedDate, 0, 0, 0);
			this.AddElementFieldInfo("ProjectEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)ProjectFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("ProjectEntity", "Name", typeof(System.String), false, false, false, true,  (int)ProjectFieldIndex.Name, 200, 0, 0);
			this.AddElementFieldInfo("ProjectEntity", "UpdatedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)ProjectFieldIndex.UpdatedDate, 0, 0, 0);
		}

		/// <summary>Inits RatingTypeEntity's info objects</summary>
		private void InitRatingTypeEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(RatingTypeFieldIndex), "RatingTypeEntity");
			this.AddElementFieldInfo("RatingTypeEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)RatingTypeFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("RatingTypeEntity", "Name", typeof(System.String), false, false, false, true,  (int)RatingTypeFieldIndex.Name, 200, 0, 0);
		}

		/// <summary>Inits TaskEntity's info objects</summary>
		private void InitTaskEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(TaskFieldIndex), "TaskEntity");
			this.AddElementFieldInfo("TaskEntity", "AccountId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)TaskFieldIndex.AccountId, 0, 0, 10);
			this.AddElementFieldInfo("TaskEntity", "CreatedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)TaskFieldIndex.CreatedDate, 0, 0, 0);
			this.AddElementFieldInfo("TaskEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)TaskFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("TaskEntity", "Name", typeof(System.String), false, false, false, true,  (int)TaskFieldIndex.Name, 200, 0, 0);
			this.AddElementFieldInfo("TaskEntity", "PlanDetailId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)TaskFieldIndex.PlanDetailId, 0, 0, 10);
			this.AddElementFieldInfo("TaskEntity", "Progress", typeof(Nullable<System.Double>), false, false, false, true,  (int)TaskFieldIndex.Progress, 0, 0, 38);
			this.AddElementFieldInfo("TaskEntity", "RatingTypeId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)TaskFieldIndex.RatingTypeId, 0, 0, 10);
			this.AddElementFieldInfo("TaskEntity", "TaskStatusId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)TaskFieldIndex.TaskStatusId, 0, 0, 10);
			this.AddElementFieldInfo("TaskEntity", "TaskTypeId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)TaskFieldIndex.TaskTypeId, 0, 0, 10);
			this.AddElementFieldInfo("TaskEntity", "UpdatedDate", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)TaskFieldIndex.UpdatedDate, 0, 0, 0);
		}

		/// <summary>Inits TaskStatusEntity's info objects</summary>
		private void InitTaskStatusEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(TaskStatusFieldIndex), "TaskStatusEntity");
			this.AddElementFieldInfo("TaskStatusEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)TaskStatusFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("TaskStatusEntity", "Name", typeof(System.String), false, false, false, true,  (int)TaskStatusFieldIndex.Name, 200, 0, 0);
		}

		/// <summary>Inits TaskTypeEntity's info objects</summary>
		private void InitTaskTypeEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(TaskTypeFieldIndex), "TaskTypeEntity");
			this.AddElementFieldInfo("TaskTypeEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)TaskTypeFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("TaskTypeEntity", "Name", typeof(System.String), false, false, false, true,  (int)TaskTypeFieldIndex.Name, 200, 0, 0);
		}

		/// <summary>Inits UnitEntity's info objects</summary>
		private void InitUnitEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(UnitFieldIndex), "UnitEntity");
			this.AddElementFieldInfo("UnitEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)UnitFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("UnitEntity", "Name", typeof(System.String), false, false, false, true,  (int)UnitFieldIndex.Name, 200, 0, 0);
			this.AddElementFieldInfo("UnitEntity", "UnitTypeId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)UnitFieldIndex.UnitTypeId, 0, 0, 10);
		}

		/// <summary>Inits UnitAndAccountEntity's info objects</summary>
		private void InitUnitAndAccountEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(UnitAndAccountFieldIndex), "UnitAndAccountEntity");
			this.AddElementFieldInfo("UnitAndAccountEntity", "AccountId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)UnitAndAccountFieldIndex.AccountId, 0, 0, 10);
			this.AddElementFieldInfo("UnitAndAccountEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)UnitAndAccountFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("UnitAndAccountEntity", "UnitId", typeof(Nullable<System.Int32>), false, true, false, true,  (int)UnitAndAccountFieldIndex.UnitId, 0, 0, 10);
		}

		/// <summary>Inits UnitTypeEntity's info objects</summary>
		private void InitUnitTypeEntityInfo()
		{
			this.AddFieldIndexEnumForElementName(typeof(UnitTypeFieldIndex), "UnitTypeEntity");
			this.AddElementFieldInfo("UnitTypeEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)UnitTypeFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("UnitTypeEntity", "Name", typeof(System.String), false, false, false, true,  (int)UnitTypeFieldIndex.Name, 200, 0, 0);
		}
	}
}