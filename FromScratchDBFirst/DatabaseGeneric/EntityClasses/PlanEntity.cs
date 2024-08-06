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

	/// <summary>Entity class which represents the entity 'Plan'.<br/><br/></summary>
	[Serializable]
	public partial class PlanEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		private EntityCollection<PlanDetailEntity> _planDetails;
		private ProjectEntity _project;
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static PlanEntityStaticMetaData _staticMetaData = new PlanEntityStaticMetaData();
		private static PlanRelations _relationsFactory = new PlanRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Project</summary>
			public static readonly string Project = "Project";
			/// <summary>Member name PlanDetails</summary>
			public static readonly string PlanDetails = "PlanDetails";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class PlanEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public PlanEntityStaticMetaData()
			{
				SetEntityCoreInfo("PlanEntity", InheritanceHierarchyType.None, false, (int)TestLLBL.EntityType.PlanEntity, typeof(PlanEntity), typeof(PlanEntityFactory), false);
				AddNavigatorMetaData<PlanEntity, EntityCollection<PlanDetailEntity>>("PlanDetails", a => a._planDetails, (a, b) => a._planDetails = b, a => a.PlanDetails, () => new PlanRelations().PlanDetailEntityUsingPlanId, typeof(PlanDetailEntity), (int)TestLLBL.EntityType.PlanDetailEntity);
				AddNavigatorMetaData<PlanEntity, ProjectEntity>("Project", "Plans", (a, b) => a._project = b, a => a._project, (a, b) => a.Project = b, TestLLBL.RelationClasses.StaticPlanRelations.ProjectEntityUsingProjectIdStatic, ()=>new PlanRelations().ProjectEntityUsingProjectId, null, new int[] { (int)PlanFieldIndex.ProjectId }, null, true, (int)TestLLBL.EntityType.ProjectEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static PlanEntity()
		{
		}

		/// <summary> CTor</summary>
		public PlanEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public PlanEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this PlanEntity</param>
		public PlanEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Plan which data should be fetched into this Plan object</param>
		public PlanEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Plan which data should be fetched into this Plan object</param>
		/// <param name="validator">The custom validator object for this PlanEntity</param>
		public PlanEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected PlanEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'PlanDetail' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPlanDetails() { return CreateRelationInfoForNavigator("PlanDetails"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Project' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProject() { return CreateRelationInfoForNavigator("Project"); }
		
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
		/// <param name="validator">The validator object for this PlanEntity</param>
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
		public static PlanRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PlanDetail' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPlanDetails { get { return _staticMetaData.GetPrefetchPathElement("PlanDetails", CommonEntityBase.CreateEntityCollection<PlanDetailEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Project' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProject { get { return _staticMetaData.GetPrefetchPathElement("Project", CommonEntityBase.CreateEntityCollection<ProjectEntity>()); } }

		/// <summary>The CreatedDate property of the Entity Plan<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Plan1"."CreatedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> CreatedDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)PlanFieldIndex.CreatedDate, false); }
			set { SetValue((int)PlanFieldIndex.CreatedDate, value); }
		}

		/// <summary>The Id property of the Entity Plan<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Plan1"."Id".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)PlanFieldIndex.Id, true); }
			set { SetValue((int)PlanFieldIndex.Id, value); }
		}

		/// <summary>The Name property of the Entity Plan<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Plan1"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 200.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)PlanFieldIndex.Name, true); }
			set { SetValue((int)PlanFieldIndex.Name, value); }
		}

		/// <summary>The ProjectId property of the Entity Plan<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Plan1"."ProjectId".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> ProjectId
		{
			get { return (Nullable<System.Int32>)GetValue((int)PlanFieldIndex.ProjectId, false); }
			set { SetValue((int)PlanFieldIndex.ProjectId, value); }
		}

		/// <summary>The UpdatedDate property of the Entity Plan<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Plan1"."UpdatedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> UpdatedDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)PlanFieldIndex.UpdatedDate, false); }
			set { SetValue((int)PlanFieldIndex.UpdatedDate, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'PlanDetailEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(PlanDetailEntity))]
		public virtual EntityCollection<PlanDetailEntity> PlanDetails { get { return GetOrCreateEntityCollection<PlanDetailEntity, PlanDetailEntityFactory>("Plan", true, false, ref _planDetails); } }

		/// <summary>Gets / sets related entity of type 'ProjectEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ProjectEntity Project
		{
			get { return _project; }
			set { SetSingleRelatedEntityNavigator(value, "Project"); }
		}
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace TestLLBL
{
	public enum PlanFieldIndex
	{
		///<summary>CreatedDate. </summary>
		CreatedDate,
		///<summary>Id. </summary>
		Id,
		///<summary>Name. </summary>
		Name,
		///<summary>ProjectId. </summary>
		ProjectId,
		///<summary>UpdatedDate. </summary>
		UpdatedDate,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace TestLLBL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Plan. </summary>
	public partial class PlanRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between PlanEntity and PlanDetailEntity over the 1:n relation they have, using the relation between the fields: Plan.Id - PlanDetail.PlanId</summary>
		public virtual IEntityRelation PlanDetailEntityUsingPlanId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "PlanDetails", true, new[] { PlanFields.Id, PlanDetailFields.PlanId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between PlanEntity and ProjectEntity over the m:1 relation they have, using the relation between the fields: Plan.ProjectId - Project.Id</summary>
		public virtual IEntityRelation ProjectEntityUsingProjectId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Project", false, new[] { ProjectFields.Id, PlanFields.ProjectId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticPlanRelations
	{
		internal static readonly IEntityRelation PlanDetailEntityUsingPlanIdStatic = new PlanRelations().PlanDetailEntityUsingPlanId;
		internal static readonly IEntityRelation ProjectEntityUsingProjectIdStatic = new PlanRelations().ProjectEntityUsingProjectId;

		/// <summary>CTor</summary>
		static StaticPlanRelations() { }
	}
}