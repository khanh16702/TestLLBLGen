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

	/// <summary>Entity class which represents the entity 'Unit'.<br/><br/></summary>
	[Serializable]
	public partial class UnitEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		private EntityCollection<UnitAndAccountEntity> _unitAndAccounts;
		private UnitTypeEntity _unitType;
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static UnitEntityStaticMetaData _staticMetaData = new UnitEntityStaticMetaData();
		private static UnitRelations _relationsFactory = new UnitRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name UnitType</summary>
			public static readonly string UnitType = "UnitType";
			/// <summary>Member name UnitAndAccounts</summary>
			public static readonly string UnitAndAccounts = "UnitAndAccounts";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class UnitEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public UnitEntityStaticMetaData()
			{
				SetEntityCoreInfo("UnitEntity", InheritanceHierarchyType.None, false, (int)TestLLBL.EntityType.UnitEntity, typeof(UnitEntity), typeof(UnitEntityFactory), false);
				AddNavigatorMetaData<UnitEntity, EntityCollection<UnitAndAccountEntity>>("UnitAndAccounts", a => a._unitAndAccounts, (a, b) => a._unitAndAccounts = b, a => a.UnitAndAccounts, () => new UnitRelations().UnitAndAccountEntityUsingUnitId, typeof(UnitAndAccountEntity), (int)TestLLBL.EntityType.UnitAndAccountEntity);
				AddNavigatorMetaData<UnitEntity, UnitTypeEntity>("UnitType", "Units", (a, b) => a._unitType = b, a => a._unitType, (a, b) => a.UnitType = b, TestLLBL.RelationClasses.StaticUnitRelations.UnitTypeEntityUsingUnitTypeIdStatic, ()=>new UnitRelations().UnitTypeEntityUsingUnitTypeId, null, new int[] { (int)UnitFieldIndex.UnitTypeId }, null, true, (int)TestLLBL.EntityType.UnitTypeEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static UnitEntity()
		{
		}

		/// <summary> CTor</summary>
		public UnitEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public UnitEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this UnitEntity</param>
		public UnitEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Unit which data should be fetched into this Unit object</param>
		public UnitEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Unit which data should be fetched into this Unit object</param>
		/// <param name="validator">The custom validator object for this UnitEntity</param>
		public UnitEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected UnitEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'UnitAndAccount' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUnitAndAccounts() { return CreateRelationInfoForNavigator("UnitAndAccounts"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'UnitType' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUnitType() { return CreateRelationInfoForNavigator("UnitType"); }
		
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
		/// <param name="validator">The validator object for this UnitEntity</param>
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
		public static UnitRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UnitAndAccount' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUnitAndAccounts { get { return _staticMetaData.GetPrefetchPathElement("UnitAndAccounts", CommonEntityBase.CreateEntityCollection<UnitAndAccountEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UnitType' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUnitType { get { return _staticMetaData.GetPrefetchPathElement("UnitType", CommonEntityBase.CreateEntityCollection<UnitTypeEntity>()); } }

		/// <summary>The Id property of the Entity Unit<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Unit"."Id".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)UnitFieldIndex.Id, true); }
			set { SetValue((int)UnitFieldIndex.Id, value); }
		}

		/// <summary>The Name property of the Entity Unit<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Unit"."Name".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 200.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)UnitFieldIndex.Name, true); }
			set { SetValue((int)UnitFieldIndex.Name, value); }
		}

		/// <summary>The UnitTypeId property of the Entity Unit<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Unit"."UnitTypeId".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> UnitTypeId
		{
			get { return (Nullable<System.Int32>)GetValue((int)UnitFieldIndex.UnitTypeId, false); }
			set { SetValue((int)UnitFieldIndex.UnitTypeId, value); }
		}

		/// <summary>Gets the EntityCollection with the related entities of type 'UnitAndAccountEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(UnitAndAccountEntity))]
		public virtual EntityCollection<UnitAndAccountEntity> UnitAndAccounts { get { return GetOrCreateEntityCollection<UnitAndAccountEntity, UnitAndAccountEntityFactory>("Unit", true, false, ref _unitAndAccounts); } }

		/// <summary>Gets / sets related entity of type 'UnitTypeEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual UnitTypeEntity UnitType
		{
			get { return _unitType; }
			set { SetSingleRelatedEntityNavigator(value, "UnitType"); }
		}
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace TestLLBL
{
	public enum UnitFieldIndex
	{
		///<summary>Id. </summary>
		Id,
		///<summary>Name. </summary>
		Name,
		///<summary>UnitTypeId. </summary>
		UnitTypeId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace TestLLBL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Unit. </summary>
	public partial class UnitRelations: RelationFactory
	{
		/// <summary>Returns a new IEntityRelation object, between UnitEntity and UnitAndAccountEntity over the 1:n relation they have, using the relation between the fields: Unit.Id - UnitAndAccount.UnitId</summary>
		public virtual IEntityRelation UnitAndAccountEntityUsingUnitId
		{
			get { return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.OneToMany, "UnitAndAccounts", true, new[] { UnitFields.Id, UnitAndAccountFields.UnitId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between UnitEntity and UnitTypeEntity over the m:1 relation they have, using the relation between the fields: Unit.UnitTypeId - UnitType.Id</summary>
		public virtual IEntityRelation UnitTypeEntityUsingUnitTypeId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "UnitType", false, new[] { UnitTypeFields.Id, UnitFields.UnitTypeId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticUnitRelations
	{
		internal static readonly IEntityRelation UnitAndAccountEntityUsingUnitIdStatic = new UnitRelations().UnitAndAccountEntityUsingUnitId;
		internal static readonly IEntityRelation UnitTypeEntityUsingUnitTypeIdStatic = new UnitRelations().UnitTypeEntityUsingUnitTypeId;

		/// <summary>CTor</summary>
		static StaticUnitRelations() { }
	}
}