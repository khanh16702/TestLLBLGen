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

	/// <summary>Entity class which represents the entity 'TaskType'.<br/><br/></summary>
	[Serializable]
	public partial class TaskTypeEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		private EntityCollection<TaskEntity> _tasks;
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static TaskTypeEntityStaticMetaData _staticMetaData = new TaskTypeEntityStaticMetaData();
		private static TaskTypeRelations _relationsFactory = new TaskTypeRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Tasks</summary>
			public static readonly string Tasks = "Tasks";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class TaskTypeEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public TaskTypeEntityStaticMetaData()
			{
				SetEntityCoreInfo("TaskTypeEntity", InheritanceHierarchyType.None, false, (int)TestLLBL.EntityType.TaskTypeEntity, typeof(TaskTypeEntity), typeof(TaskTypeEntityFactory), false);
				AddNavigatorMetaData<TaskTypeEntity, EntityCollection<TaskEntity>>("Tasks", a => a._tasks, (a, b) => a._tasks = b, a => a.Tasks, () => new TaskTypeRelations().TaskEntityUsingTaskTypeId, typeof(TaskEntity), (int)TestLLBL.EntityType.TaskEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static TaskTypeEntity()
		{
		}

		/// <summary> CTor</summary>
		public TaskTypeEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public TaskTypeEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this TaskTypeEntity</param>
		public TaskTypeEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for TaskType which data should be fetched into this TaskType object</param>
		public TaskTypeEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for TaskType which data should be fetched into this TaskType object</param>
		/// <param name="validator">The custom validator object for this TaskTypeEntity</param>
		public TaskTypeEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected TaskTypeEntity(SerializationInfo info, StreamingContext context) : base(info, context)
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
		/// <param name="validator">The validator object for this TaskTypeEntity</param>
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
		public static TaskTypeRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Task' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTasks { get { return _staticMetaData.GetPrefetchPathElement("Tasks", CommonEntityBase.CreateEntityCollection<TaskEntity>()); } }

		/// <summary>The Id property of the Entity TaskType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TaskType"."Id".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)TaskTypeFieldIndex.Id, true); }
			set { SetValue((int)TaskTypeFieldIndex.Id, value); }
		}

		/// <summary>The Name property of the Entity TaskType<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TaskType"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 200.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)TaskTypeFieldIndex.Name, true); }
			set { SetValue((int)TaskTypeFieldIndex.Name, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'TaskEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(TaskEntity))]
		public virtual EntityCollection<TaskEntity> Tasks { get { return GetOrCreateEntityCollection<TaskEntity, TaskEntityFactory>("TaskType", true, false, ref _tasks); } }
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace TestLLBL
{
	public enum TaskTypeFieldIndex
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
	/// <summary>Implements the relations factory for the entity: TaskType. </summary>
	public partial class TaskTypeRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between TaskTypeEntity and TaskEntity over the 1:n relation they have, using the relation between the fields: TaskType.Id - Task.TaskTypeId</summary>
		public virtual IEntityRelation TaskEntityUsingTaskTypeId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "Tasks", true, new[] { TaskTypeFields.Id, TaskFields.TaskTypeId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticTaskTypeRelations
	{
		internal static readonly IEntityRelation TaskEntityUsingTaskTypeIdStatic = new TaskTypeRelations().TaskEntityUsingTaskTypeId;

		/// <summary>CTor</summary>
		static StaticTaskTypeRelations() { }
	}
}