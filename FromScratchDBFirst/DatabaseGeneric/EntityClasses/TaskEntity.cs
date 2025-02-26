﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.11.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using TestLLBL.HelperClasses;
using TestLLBL.FactoryClasses;
using TestLLBL.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace TestLLBL.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END

	/// <summary>Entity class which represents the entity 'Task'.<br/><br/></summary>
	[Serializable]
	public partial class TaskEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		private AccountEntity _account;
		private PlanDetailEntity _planDetail;
		private RatingTypeEntity _ratingType;
		private TaskStatusEntity _taskStatus;
		private TaskTypeEntity _taskType;
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static TaskEntityStaticMetaData _staticMetaData = new TaskEntityStaticMetaData();
		private static TaskRelations _relationsFactory = new TaskRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Account</summary>
			public static readonly string Account = "Account";
			/// <summary>Member name PlanDetail</summary>
			public static readonly string PlanDetail = "PlanDetail";
			/// <summary>Member name RatingType</summary>
			public static readonly string RatingType = "RatingType";
			/// <summary>Member name TaskStatus</summary>
			public static readonly string TaskStatus = "TaskStatus";
			/// <summary>Member name TaskType</summary>
			public static readonly string TaskType = "TaskType";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class TaskEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public TaskEntityStaticMetaData()
			{
				SetEntityCoreInfo("TaskEntity", InheritanceHierarchyType.None, false, (int)TestLLBL.EntityType.TaskEntity, typeof(TaskEntity), typeof(TaskEntityFactory), false);
				AddNavigatorMetaData<TaskEntity, AccountEntity>("Account", "Tasks", (a, b) => a._account = b, a => a._account, (a, b) => a.Account = b, TestLLBL.RelationClasses.StaticTaskRelations.AccountEntityUsingAccountIdStatic, ()=>new TaskRelations().AccountEntityUsingAccountId, null, new int[] { (int)TaskFieldIndex.AccountId }, null, true, (int)TestLLBL.EntityType.AccountEntity);
				AddNavigatorMetaData<TaskEntity, PlanDetailEntity>("PlanDetail", "Tasks", (a, b) => a._planDetail = b, a => a._planDetail, (a, b) => a.PlanDetail = b, TestLLBL.RelationClasses.StaticTaskRelations.PlanDetailEntityUsingPlanDetailIdStatic, ()=>new TaskRelations().PlanDetailEntityUsingPlanDetailId, null, new int[] { (int)TaskFieldIndex.PlanDetailId }, null, true, (int)TestLLBL.EntityType.PlanDetailEntity);
				AddNavigatorMetaData<TaskEntity, RatingTypeEntity>("RatingType", "Tasks", (a, b) => a._ratingType = b, a => a._ratingType, (a, b) => a.RatingType = b, TestLLBL.RelationClasses.StaticTaskRelations.RatingTypeEntityUsingRatingTypeIdStatic, ()=>new TaskRelations().RatingTypeEntityUsingRatingTypeId, null, new int[] { (int)TaskFieldIndex.RatingTypeId }, null, true, (int)TestLLBL.EntityType.RatingTypeEntity);
				AddNavigatorMetaData<TaskEntity, TaskStatusEntity>("TaskStatus", "Tasks", (a, b) => a._taskStatus = b, a => a._taskStatus, (a, b) => a.TaskStatus = b, TestLLBL.RelationClasses.StaticTaskRelations.TaskStatusEntityUsingTaskStatusIdStatic, ()=>new TaskRelations().TaskStatusEntityUsingTaskStatusId, null, new int[] { (int)TaskFieldIndex.TaskStatusId }, null, true, (int)TestLLBL.EntityType.TaskStatusEntity);
				AddNavigatorMetaData<TaskEntity, TaskTypeEntity>("TaskType", "Tasks", (a, b) => a._taskType = b, a => a._taskType, (a, b) => a.TaskType = b, TestLLBL.RelationClasses.StaticTaskRelations.TaskTypeEntityUsingTaskTypeIdStatic, ()=>new TaskRelations().TaskTypeEntityUsingTaskTypeId, null, new int[] { (int)TaskFieldIndex.TaskTypeId }, null, true, (int)TestLLBL.EntityType.TaskTypeEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static TaskEntity()
		{
		}

		/// <summary> CTor</summary>
		public TaskEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public TaskEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this TaskEntity</param>
		public TaskEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Task which data should be fetched into this Task object</param>
		public TaskEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Task which data should be fetched into this Task object</param>
		/// <param name="validator">The custom validator object for this TaskEntity</param>
		public TaskEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected TaskEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Account' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccount() { return CreateRelationInfoForNavigator("Account"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'PlanDetail' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPlanDetail() { return CreateRelationInfoForNavigator("PlanDetail"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'RatingType' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRatingType() { return CreateRelationInfoForNavigator("RatingType"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'TaskStatus' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTaskStatus() { return CreateRelationInfoForNavigator("TaskStatus"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'TaskType' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTaskType() { return CreateRelationInfoForNavigator("TaskType"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this TaskEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END


			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static TaskRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Account' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccount { get { return _staticMetaData.GetPrefetchPathElement("Account", CommonEntityBase.CreateEntityCollection<AccountEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PlanDetail' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPlanDetail { get { return _staticMetaData.GetPrefetchPathElement("PlanDetail", CommonEntityBase.CreateEntityCollection<PlanDetailEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'RatingType' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRatingType { get { return _staticMetaData.GetPrefetchPathElement("RatingType", CommonEntityBase.CreateEntityCollection<RatingTypeEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'TaskStatus' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTaskStatus { get { return _staticMetaData.GetPrefetchPathElement("TaskStatus", CommonEntityBase.CreateEntityCollection<TaskStatusEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'TaskType' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTaskType { get { return _staticMetaData.GetPrefetchPathElement("TaskType", CommonEntityBase.CreateEntityCollection<TaskTypeEntity>()); } }

		/// <summary>The AccountId property of the Entity Task<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Task"."AccountId".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> AccountId
		{
			get { return (Nullable<System.Int32>)GetValue((int)TaskFieldIndex.AccountId, false); }
			set { SetValue((int)TaskFieldIndex.AccountId, value); }
		}

		/// <summary>The CreatedDate property of the Entity Task<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Task"."CreatedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> CreatedDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)TaskFieldIndex.CreatedDate, false); }
			set { SetValue((int)TaskFieldIndex.CreatedDate, value); }
		}

		/// <summary>The Id property of the Entity Task<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Task"."Id".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)TaskFieldIndex.Id, true); }
			set { SetValue((int)TaskFieldIndex.Id, value); }
		}

		/// <summary>The Name property of the Entity Task<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Task"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 200.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)TaskFieldIndex.Name, true); }
			set { SetValue((int)TaskFieldIndex.Name, value); }
		}

		/// <summary>The PlanDetailId property of the Entity Task<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Task"."PlanDetailId".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> PlanDetailId
		{
			get { return (Nullable<System.Int32>)GetValue((int)TaskFieldIndex.PlanDetailId, false); }
			set { SetValue((int)TaskFieldIndex.PlanDetailId, value); }
		}

		/// <summary>The Progress property of the Entity Task<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Task"."Progress".<br/>Table field type characteristics (type, precision, scale, length): Float, 38, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Double> Progress
		{
			get { return (Nullable<System.Double>)GetValue((int)TaskFieldIndex.Progress, false); }
			set { SetValue((int)TaskFieldIndex.Progress, value); }
		}

		/// <summary>The RatingTypeId property of the Entity Task<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Task"."RatingTypeId".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> RatingTypeId
		{
			get { return (Nullable<System.Int32>)GetValue((int)TaskFieldIndex.RatingTypeId, false); }
			set { SetValue((int)TaskFieldIndex.RatingTypeId, value); }
		}

		/// <summary>The TaskStatusId property of the Entity Task<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Task"."TaskStatusId".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> TaskStatusId
		{
			get { return (Nullable<System.Int32>)GetValue((int)TaskFieldIndex.TaskStatusId, false); }
			set { SetValue((int)TaskFieldIndex.TaskStatusId, value); }
		}

		/// <summary>The TaskTypeId property of the Entity Task<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Task"."TaskTypeId".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> TaskTypeId
		{
			get { return (Nullable<System.Int32>)GetValue((int)TaskFieldIndex.TaskTypeId, false); }
			set { SetValue((int)TaskFieldIndex.TaskTypeId, value); }
		}

		/// <summary>The UpdatedDate property of the Entity Task<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Task"."UpdatedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> UpdatedDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)TaskFieldIndex.UpdatedDate, false); }
			set { SetValue((int)TaskFieldIndex.UpdatedDate, value); }
		}

		/// <summary>Gets / sets related entity of type 'AccountEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual AccountEntity Account
		{
			get { return _account; }
			set { SetSingleRelatedEntityNavigator(value, "Account"); }
		}

		/// <summary>Gets / sets related entity of type 'PlanDetailEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual PlanDetailEntity PlanDetail
		{
			get { return _planDetail; }
			set { SetSingleRelatedEntityNavigator(value, "PlanDetail"); }
		}

		/// <summary>Gets / sets related entity of type 'RatingTypeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual RatingTypeEntity RatingType
		{
			get { return _ratingType; }
			set { SetSingleRelatedEntityNavigator(value, "RatingType"); }
		}

		/// <summary>Gets / sets related entity of type 'TaskStatusEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual TaskStatusEntity TaskStatus
		{
			get { return _taskStatus; }
			set { SetSingleRelatedEntityNavigator(value, "TaskStatus"); }
		}

		/// <summary>Gets / sets related entity of type 'TaskTypeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual TaskTypeEntity TaskType
		{
			get { return _taskType; }
			set { SetSingleRelatedEntityNavigator(value, "TaskType"); }
		}
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace TestLLBL
{
	public enum TaskFieldIndex
	{
		///<summary>AccountId. </summary>
		AccountId,
		///<summary>CreatedDate. </summary>
		CreatedDate,
		///<summary>Id. </summary>
		Id,
		///<summary>Name. </summary>
		Name,
		///<summary>PlanDetailId. </summary>
		PlanDetailId,
		///<summary>Progress. </summary>
		Progress,
		///<summary>RatingTypeId. </summary>
		RatingTypeId,
		///<summary>TaskStatusId. </summary>
		TaskStatusId,
		///<summary>TaskTypeId. </summary>
		TaskTypeId,
		///<summary>UpdatedDate. </summary>
		UpdatedDate,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace TestLLBL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Task. </summary>
	public partial class TaskRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between TaskEntity and AccountEntity over the m:1 relation they have, using the relation between the fields: Task.AccountId - Account.Id</summary>
		public virtual IEntityRelation AccountEntityUsingAccountId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Account", false, new[] { AccountFields.Id, TaskFields.AccountId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between TaskEntity and PlanDetailEntity over the m:1 relation they have, using the relation between the fields: Task.PlanDetailId - PlanDetail.Id</summary>
		public virtual IEntityRelation PlanDetailEntityUsingPlanDetailId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "PlanDetail", false, new[] { PlanDetailFields.Id, TaskFields.PlanDetailId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between TaskEntity and RatingTypeEntity over the m:1 relation they have, using the relation between the fields: Task.RatingTypeId - RatingType.Id</summary>
		public virtual IEntityRelation RatingTypeEntityUsingRatingTypeId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "RatingType", false, new[] { RatingTypeFields.Id, TaskFields.RatingTypeId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between TaskEntity and TaskStatusEntity over the m:1 relation they have, using the relation between the fields: Task.TaskStatusId - TaskStatus.Id</summary>
		public virtual IEntityRelation TaskStatusEntityUsingTaskStatusId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "TaskStatus", false, new[] { TaskStatusFields.Id, TaskFields.TaskStatusId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between TaskEntity and TaskTypeEntity over the m:1 relation they have, using the relation between the fields: Task.TaskTypeId - TaskType.Id</summary>
		public virtual IEntityRelation TaskTypeEntityUsingTaskTypeId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "TaskType", false, new[] { TaskTypeFields.Id, TaskFields.TaskTypeId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticTaskRelations
	{
		internal static readonly IEntityRelation AccountEntityUsingAccountIdStatic = new TaskRelations().AccountEntityUsingAccountId;
		internal static readonly IEntityRelation PlanDetailEntityUsingPlanDetailIdStatic = new TaskRelations().PlanDetailEntityUsingPlanDetailId;
		internal static readonly IEntityRelation RatingTypeEntityUsingRatingTypeIdStatic = new TaskRelations().RatingTypeEntityUsingRatingTypeId;
		internal static readonly IEntityRelation TaskStatusEntityUsingTaskStatusIdStatic = new TaskRelations().TaskStatusEntityUsingTaskStatusId;
		internal static readonly IEntityRelation TaskTypeEntityUsingTaskTypeIdStatic = new TaskRelations().TaskTypeEntityUsingTaskTypeId;

		/// <summary>CTor</summary>
		static StaticTaskRelations() { }
	}
}
