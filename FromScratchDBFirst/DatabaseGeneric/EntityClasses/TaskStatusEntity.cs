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

	/// <summary>Entity class which represents the entity 'TaskStatus'.<br/><br/></summary>
	[Serializable]
	public partial class TaskStatusEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		private EntityCollection<TaskEntity> _tasks;
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static TaskStatusEntityStaticMetaData _staticMetaData = new TaskStatusEntityStaticMetaData();
		private static TaskStatusRelations _relationsFactory = new TaskStatusRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Tasks</summary>
			public static readonly string Tasks = "Tasks";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class TaskStatusEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public TaskStatusEntityStaticMetaData()
			{
				SetEntityCoreInfo("TaskStatusEntity", InheritanceHierarchyType.None, false, (int)TestLLBL.EntityType.TaskStatusEntity, typeof(TaskStatusEntity), typeof(TaskStatusEntityFactory), false);
				AddNavigatorMetaData<TaskStatusEntity, EntityCollection<TaskEntity>>("Tasks", a => a._tasks, (a, b) => a._tasks = b, a => a.Tasks, () => new TaskStatusRelations().TaskEntityUsingTaskStatusId, typeof(TaskEntity), (int)TestLLBL.EntityType.TaskEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static TaskStatusEntity()
		{
		}

		/// <summary> CTor</summary>
		public TaskStatusEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public TaskStatusEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this TaskStatusEntity</param>
		public TaskStatusEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for TaskStatus which data should be fetched into this TaskStatus object</param>
		public TaskStatusEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for TaskStatus which data should be fetched into this TaskStatus object</param>
		/// <param name="validator">The custom validator object for this TaskStatusEntity</param>
		public TaskStatusEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected TaskStatusEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'Task' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTasks() { return CreateRelationInfoForNavigator("Tasks"); }
		
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
		/// <param name="validator">The validator object for this TaskStatusEntity</param>
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
		public static TaskStatusRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Task' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTasks { get { return _staticMetaData.GetPrefetchPathElement("Tasks", CommonEntityBase.CreateEntityCollection<TaskEntity>()); } }

		/// <summary>The Id property of the Entity TaskStatus<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TaskStatus"."Id".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)TaskStatusFieldIndex.Id, true); }
			set { SetValue((int)TaskStatusFieldIndex.Id, value); }
		}

		/// <summary>The Name property of the Entity TaskStatus<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TaskStatus"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 200.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)TaskStatusFieldIndex.Name, true); }
			set { SetValue((int)TaskStatusFieldIndex.Name, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'TaskEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(TaskEntity))]
		public virtual EntityCollection<TaskEntity> Tasks { get { return GetOrCreateEntityCollection<TaskEntity, TaskEntityFactory>("TaskStatus", true, false, ref _tasks); } }
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace TestLLBL
{
	public enum TaskStatusFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace TestLLBL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: TaskStatus. </summary>
	public partial class TaskStatusRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between TaskStatusEntity and TaskEntity over the 1:n relation they have, using the relation between the fields: TaskStatus.Id - Task.TaskStatusId</summary>
		public virtual IEntityRelation TaskEntityUsingTaskStatusId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Tasks", true, new[] { TaskStatusFields.Id, TaskFields.TaskStatusId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticTaskStatusRelations
	{
		internal static readonly IEntityRelation TaskEntityUsingTaskStatusIdStatic = new TaskStatusRelations().TaskEntityUsingTaskStatusId;

		/// <summary>CTor</summary>
		static StaticTaskStatusRelations() { }
	}
}