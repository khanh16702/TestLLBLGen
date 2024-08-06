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

	/// <summary>Entity class which represents the entity 'Petition'.<br/><br/></summary>
	[Serializable]
	public partial class PetitionEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
	
	{
		private AccountEntity _account;
		private PetitionStatusEntity _petitionStatus;
		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END

		private static PetitionEntityStaticMetaData _staticMetaData = new PetitionEntityStaticMetaData();
		private static PetitionRelations _relationsFactory = new PetitionRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Account</summary>
			public static readonly string Account = "Account";
			/// <summary>Member name PetitionStatus</summary>
			public static readonly string PetitionStatus = "PetitionStatus";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class PetitionEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public PetitionEntityStaticMetaData()
			{
				SetEntityCoreInfo("PetitionEntity", InheritanceHierarchyType.None, false, (int)TestLLBL.EntityType.PetitionEntity, typeof(PetitionEntity), typeof(PetitionEntityFactory), false);
				AddNavigatorMetaData<PetitionEntity, AccountEntity>("Account", "Petitions", (a, b) => a._account = b, a => a._account, (a, b) => a.Account = b, TestLLBL.RelationClasses.StaticPetitionRelations.AccountEntityUsingAccountIdStatic, ()=>new PetitionRelations().AccountEntityUsingAccountId, null, new int[] { (int)PetitionFieldIndex.AccountId }, null, true, (int)TestLLBL.EntityType.AccountEntity);
				AddNavigatorMetaData<PetitionEntity, PetitionStatusEntity>("PetitionStatus", "Petitions", (a, b) => a._petitionStatus = b, a => a._petitionStatus, (a, b) => a.PetitionStatus = b, TestLLBL.RelationClasses.StaticPetitionRelations.PetitionStatusEntityUsingPetitionStatusIdStatic, ()=>new PetitionRelations().PetitionStatusEntityUsingPetitionStatusId, null, new int[] { (int)PetitionFieldIndex.PetitionStatusId }, null, true, (int)TestLLBL.EntityType.PetitionStatusEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static PetitionEntity()
		{
		}

		/// <summary> CTor</summary>
		public PetitionEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public PetitionEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this PetitionEntity</param>
		public PetitionEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Petition which data should be fetched into this Petition object</param>
		public PetitionEntity(System.Int32 id) : this(id, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="id">PK value for Petition which data should be fetched into this Petition object</param>
		/// <param name="validator">The custom validator object for this PetitionEntity</param>
		public PetitionEntity(System.Int32 id, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.Id = id;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected PetitionEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Account' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoAccount() { return CreateRelationInfoForNavigator("Account"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'PetitionStatus' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoPetitionStatus() { return CreateRelationInfoForNavigator("PetitionStatus"); }
		
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
		/// <param name="validator">The validator object for this PetitionEntity</param>
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
		public static PetitionRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Account' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathAccount { get { return _staticMetaData.GetPrefetchPathElement("Account", CommonEntityBase.CreateEntityCollection<AccountEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'PetitionStatus' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathPetitionStatus { get { return _staticMetaData.GetPrefetchPathElement("PetitionStatus", CommonEntityBase.CreateEntityCollection<PetitionStatusEntity>()); } }

		/// <summary>The AccountId property of the Entity Petition<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Petition"."AccountId".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> AccountId
		{
			get { return (Nullable<System.Int32>)GetValue((int)PetitionFieldIndex.AccountId, false); }
			set { SetValue((int)PetitionFieldIndex.AccountId, value); }
		}

		/// <summary>The Content property of the Entity Petition<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Petition"."Content".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Content
		{
			get { return (System.String)GetValue((int)PetitionFieldIndex.Content, true); }
			set { SetValue((int)PetitionFieldIndex.Content, value); }
		}

		/// <summary>The CreatedDate property of the Entity Petition<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Petition"."CreatedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> CreatedDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)PetitionFieldIndex.CreatedDate, false); }
			set { SetValue((int)PetitionFieldIndex.CreatedDate, value); }
		}

		/// <summary>The Id property of the Entity Petition<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Petition"."Id".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		public virtual System.Int32 Id
		{
			get { return (System.Int32)GetValue((int)PetitionFieldIndex.Id, true); }
			set { SetValue((int)PetitionFieldIndex.Id, value); }
		}

		/// <summary>The PetitionStatusId property of the Entity Petition<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Petition"."PetitionStatusId".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> PetitionStatusId
		{
			get { return (Nullable<System.Int32>)GetValue((int)PetitionFieldIndex.PetitionStatusId, false); }
			set { SetValue((int)PetitionFieldIndex.PetitionStatusId, value); }
		}

		/// <summary>The Title property of the Entity Petition<br/><br/></summary>
		/// <remarks>Mapped on  table field: "Petition"."Title".<br/>Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 200.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Title
		{
			get { return (System.String)GetValue((int)PetitionFieldIndex.Title, true); }
			set { SetValue((int)PetitionFieldIndex.Title, value); }
		}

		/// <summary>Gets / sets related entity of type 'AccountEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual AccountEntity Account
		{
			get { return _account; }
			set { SetSingleRelatedEntityNavigator(value, "Account"); }
		}

		/// <summary>Gets / sets related entity of type 'PetitionStatusEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual PetitionStatusEntity PetitionStatus
		{
			get { return _petitionStatus; }
			set { SetSingleRelatedEntityNavigator(value, "PetitionStatus"); }
		}
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END


	}
}

namespace TestLLBL
{
	public enum PetitionFieldIndex
	{
		///<summary>AccountId. </summary>
		AccountId,
		///<summary>Content. </summary>
		Content,
		///<summary>CreatedDate. </summary>
		CreatedDate,
		///<summary>Id. </summary>
		Id,
		///<summary>PetitionStatusId. </summary>
		PetitionStatusId,
		///<summary>Title. </summary>
		Title,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace TestLLBL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: Petition. </summary>
	public partial class PetitionRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between PetitionEntity and AccountEntity over the m:1 relation they have, using the relation between the fields: Petition.AccountId - Account.Id</summary>
		public virtual IEntityRelation AccountEntityUsingAccountId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Account", false, new[] { AccountFields.Id, PetitionFields.AccountId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between PetitionEntity and PetitionStatusEntity over the m:1 relation they have, using the relation between the fields: Petition.PetitionStatusId - PetitionStatus.Id</summary>
		public virtual IEntityRelation PetitionStatusEntityUsingPetitionStatusId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "PetitionStatus", false, new[] { PetitionStatusFields.Id, PetitionFields.PetitionStatusId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticPetitionRelations
	{
		internal static readonly IEntityRelation AccountEntityUsingAccountIdStatic = new PetitionRelations().AccountEntityUsingAccountId;
		internal static readonly IEntityRelation PetitionStatusEntityUsingPetitionStatusIdStatic = new PetitionRelations().PetitionStatusEntityUsingPetitionStatusId;

		/// <summary>CTor</summary>
		static StaticPetitionRelations() { }
	}
}
