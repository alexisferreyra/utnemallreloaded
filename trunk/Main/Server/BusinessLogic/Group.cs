﻿using UtnEmall.Server.DataModel;
using UtnEmall.Server.EntityModel;
using UtnEmall.Server.Base;
using System.ServiceModel;
using System;
using System.Collections.ObjectModel;
using System.Collections;

namespace UtnEmall.Server.BusinessLogic
{

	/// <summary>
	/// The <c>Group</c> implement business logic to process GroupEntity,
	/// saving, updating, deleting and validating entity data.
	/// </summary>
	public class Group: UtnEmall.Server.BusinessLogic.IGroup
	{
		private GroupDataAccess groupDataAccess; 
		public  Group()
		{
			groupDataAccess = new GroupDataAccess();
		} 

		/// <summary>
		/// Function to save a GroupEntity to the database.
		/// </summary>
		/// <param name="groupEntity">GroupEntity to save</param>
		/// <param name="session">User's session identifier.</param>
		/// <returns>null if the GroupEntity was saved successfully, the same GroupEntity otherwise</returns>
		/// <exception cref="ArgumentNullException">
		/// if <paramref name="groupEntity"/> is null.
		/// </exception>
		/// <exception cref="UtnEmallBusinessLogicException">
		/// If an UtnEmallDataAccessException occurs in DataModel.
		/// </exception>
		public GroupEntity Save(GroupEntity groupEntity, string session)
		{
			bool permited = ValidationService.Instance.ValidatePermission(session, "save", "Group");
			if (!permited)
			{
				ExceptionDetail detail = new ExceptionDetail(new UtnEmall.Server.BusinessLogic.UtnEmallPermissionException("The user hasn't permissions to save an entity"));
				throw new FaultException<ExceptionDetail>(detail);
			}

			if (!Validate(groupEntity))
			{
				return groupEntity;
			}
			try 
			{
				// Save groupEntity using data access object
				groupDataAccess.Save(groupEntity);
				return null;
			}
			catch (UtnEmallDataAccessException utnEmallDataAccessException)
			{
				throw new UtnEmall.Server.BusinessLogic.UtnEmallBusinessLogicException(utnEmallDataAccessException.Message, utnEmallDataAccessException);
			}
		} 

		/// <summary>
		/// Function to delete a GroupEntity from database.
		/// </summary>
		/// <param name="groupEntity">GroupEntity to delete</param>
		/// <param name="session">User's session identifier.</param>
		/// <returns>null if the GroupEntity was deleted successfully, the same GroupEntity otherwise</returns>
		/// <exception cref="ArgumentNullException">
		/// if <paramref name="groupEntity"/> is null.
		/// </exception>
		/// <exception cref="UtnEmallBusinessLogicException">
		/// If an UtnEmallDataAccessException occurs in DataModel.
		/// </exception>
		public GroupEntity Delete(GroupEntity groupEntity, string session)
		{
			bool permited = ValidationService.Instance.ValidatePermission(session, "delete", "Group");
			if (!permited)
			{
				ExceptionDetail detail = new ExceptionDetail(new UtnEmall.Server.BusinessLogic.UtnEmallPermissionException("The user hasn't permissions to delete an entity"));
				throw new FaultException<ExceptionDetail>(detail);
			}

			if (groupEntity == null)
			{
				throw new ArgumentException("The argument can not be null or be empty");
			}
			try 
			{
				// Delete groupEntity using data access object
				groupDataAccess.Delete(groupEntity);
				return null;
			}
			catch (UtnEmallDataAccessException utnEmallDataAccessException)
			{
				throw new UtnEmall.Server.BusinessLogic.UtnEmallBusinessLogicException(utnEmallDataAccessException.Message, utnEmallDataAccessException);
			}
		} 

		/// <summary>
		/// Get an specific groupEntity
		/// </summary>
		/// <param name="id">id of the GroupEntity to load</param>
		/// <param name="session">User's session identifier.</param>
		/// <returns>A GroupEntity</returns>
		/// <exception cref="ArgumentNullException">
		/// if <paramref name="groupEntity"/> is null.
		/// </exception>
		/// <exception cref="UtnEmallBusinessLogicException">
		/// If an UtnEmallDataAccessException occurs in DataModel.
		/// </exception>
		public GroupEntity GetGroup(int id, string session)
		{
			return GetGroup(id, true, session);
		} 

		/// <summary>
		/// Get an specific groupEntity
		/// </summary>
		/// <param name="id">id of the GroupEntity to load</param>
		/// <param name="loadRelation">true to load the relations</param>
		/// <param name="session">User's session identifier.</param>
		/// <returns>A GroupEntity</returns>
		/// <exception cref="ArgumentNullException">
		/// if <paramref name="groupEntity"/> is null.
		/// </exception>
		/// <exception cref="UtnEmallBusinessLogicException">
		/// If an UtnEmallDataAccessException occurs in DataModel.
		/// </exception>
		public GroupEntity GetGroup(int id, bool loadRelation, string session)
		{
			bool permited = ValidationService.Instance.ValidatePermission(session, "read", "Group");
			if (!permited)
			{
				ExceptionDetail detail = new ExceptionDetail(new UtnEmall.Server.BusinessLogic.UtnEmallPermissionException("The user hasn't permissions to read an entity"));
				throw new FaultException<ExceptionDetail>(detail);
			}

			try 
			{
				return groupDataAccess.Load(id, loadRelation);
			}
			catch (UtnEmallDataAccessException utnEmallDataAccessException)
			{
				throw new UtnEmall.Server.BusinessLogic.UtnEmallBusinessLogicException(utnEmallDataAccessException.Message, utnEmallDataAccessException);
			}
		} 

		/// <summary>
		/// Get collection of all groupEntity
		/// </summary>
		/// <param name="session">User's session identifier.</param>
		/// <returns>Collection of all GroupEntity</returns>
		/// <exception cref="UtnEmallBusinessLogicException">
		/// If an UtnEmallDataAccessException occurs in DataModel.
		/// </exception>
		public Collection<GroupEntity> GetAllGroup(string session)
		{
			return GetAllGroup(true, session);
		} 

		/// <summary>
		/// Get collection of all groupEntity
		/// </summary>
		/// <param name="loadRelation">true to load the relations</param>
		/// <param name="session">User's session identifier.</param>
		/// <returns>Collection of all GroupEntity</returns>
		/// <exception cref="UtnEmallBusinessLogicException">
		/// If an UtnEmallDataAccessException occurs in DataModel.
		/// </exception>
		public Collection<GroupEntity> GetAllGroup(bool loadRelation, string session)
		{
			bool permited = ValidationService.Instance.ValidatePermission(session, "read", "Group");
			if (!permited)
			{
				ExceptionDetail detail = new ExceptionDetail(new UtnEmall.Server.BusinessLogic.UtnEmallPermissionException("The user hasn't permissions to read an entity"));
				throw new FaultException<ExceptionDetail>(detail);
			}

			try 
			{
				return groupDataAccess.LoadAll(loadRelation);
			}
			catch (UtnEmallDataAccessException utnEmallDataAccessException)
			{
				throw new UtnEmall.Server.BusinessLogic.UtnEmallBusinessLogicException(utnEmallDataAccessException.Message, utnEmallDataAccessException);
			}
		} 

		/// <summary>
		/// Get collection of all groupEntity that comply with certain pattern
		/// </summary>
		/// <param name="propertyName">property of groupEntity</param>
		/// <param name="expValue">pattern</param>
		/// <param name="session">User's session identifier.</param>
		/// <returns>Collection of GroupEntity</returns>
		/// <exception cref="ArgumentNullException">
		/// if <paramref name="propertyName"/> is null or empty.
		/// <exception cref="ArgumentNullException">
		/// if <paramref name="expValue"/> is null or empty.
		/// </exception>
		/// <exception cref="UtnEmallBusinessLogicException">
		/// If an UtnEmallDataAccessException occurs in DataModel.
		/// </exception>
		public Collection<GroupEntity> GetGroupWhere(string propertyName, object expValue, OperatorType operatorType, string session)
		{
			return GetGroupWhere(propertyName, expValue, true, operatorType, session);
		} 

		/// <summary>
		/// Get collection of all groupEntity that comply with certain pattern
		/// </summary>
		/// <param name="propertyName">property of groupEntity</param>
		/// <param name="expValue">pattern</param>
		/// <param name="loadRelation">true to load the relations</param>
		/// <param name="session">User's session identifier.</param>
		/// <returns>Collection of GroupEntity</returns>
		/// <exception cref="ArgumentNullException">
		/// if <paramref name="propertyName"/> is null or empty.
		/// <exception cref="ArgumentNullException">
		/// if <paramref name="expValue"/> is null or empty.
		/// </exception>
		/// <exception cref="UtnEmallBusinessLogicException">
		/// If an UtnEmallDataAccessException occurs in DataModel.
		/// </exception>
		public Collection<GroupEntity> GetGroupWhere(string propertyName, object expValue, bool loadRelation, OperatorType operatorType, string session)
		{
			bool permited = ValidationService.Instance.ValidatePermission(session, "read", "Group");
			if (!permited)
			{
				ExceptionDetail detail = new ExceptionDetail(new UtnEmall.Server.BusinessLogic.UtnEmallPermissionException("The user hasn't permissions to read an entity"));
				throw new FaultException<ExceptionDetail>(detail);
			}

			try 
			{
				return groupDataAccess.LoadWhere(propertyName, expValue, loadRelation, operatorType);
			}
			catch (UtnEmallDataAccessException utnEmallDataAccessException)
			{
				throw new UtnEmall.Server.BusinessLogic.UtnEmallBusinessLogicException(utnEmallDataAccessException.Message, utnEmallDataAccessException);
			}
		} 

		/// <summary>
		/// Get collection of all groupEntity that comply with certain pattern
		/// </summary>
		/// <param name="propertyName">property of groupEntity</param>
		/// <param name="expValue">pattern</param>
		/// <param name="session">User's session identifier.</param>
		/// <returns>Collection of GroupEntity</returns>
		/// <exception cref="ArgumentNullException">
		/// if <paramref name="propertyName"/> is null or empty.
		/// <exception cref="ArgumentNullException">
		/// if <paramref name="expValue"/> is null or empty.
		/// </exception>
		/// <exception cref="UtnEmallBusinessLogicException">
		/// If an UtnEmallDataAccessException occurs in DataModel.
		/// </exception>
		public Collection<GroupEntity> GetGroupWhereEqual(string propertyName, object expValue, string session)
		{
			return GetGroupWhere(propertyName, expValue, true, OperatorType.Equal, session);
		} 

		/// <summary>
		/// Get collection of all groupEntity that comply with certain pattern
		/// </summary>
		/// <param name="propertyName">property of groupEntity</param>
		/// <param name="expValue">pattern</param>
		/// <param name="loadRelation">true to load the relations</param>
		/// <param name="session">User's session identifier.</param>
		/// <returns>Collection of GroupEntity</returns>
		/// <exception cref="ArgumentNullException">
		/// if <paramref name="propertyName"/> is null or empty.
		/// <exception cref="ArgumentNullException">
		/// if <paramref name="expValue"/> is null or empty.
		/// </exception>
		/// <exception cref="UtnEmallBusinessLogicException">
		/// If an UtnEmallDataAccessException occurs in DataModel.
		/// </exception>
		public Collection<GroupEntity> GetGroupWhereEqual(string propertyName, object expValue, bool loadRelation, string session)
		{
			return GetGroupWhere(propertyName, expValue, loadRelation, OperatorType.Equal, session);
		} 

		/// <summary>
		/// Function to validate a GroupEntity before it's saved.
		/// </summary>
		/// <param name="groupEntity">GroupEntity to validate</param>
		/// <param name="session">User's session identifier.</param>
		/// <returns>null if the GroupEntity was deleted successfully, the same GroupEntity otherwise</returns>
		/// <exception cref="ArgumentNullException">
		/// if <paramref name="groupEntity"/> is null.
		/// </exception>
		/// <exception cref="UtnEmallBusinessLogicException">
		/// If an UtnEmallDataAccessException occurs in DataModel.
		/// </exception>
		public bool Validate(GroupEntity group)
		{
			bool result = true;

			if (group == null)
			{
				throw new ArgumentException("The argument can not be null or be empty");
			}
			// Check entity data
			if (String.IsNullOrEmpty(group.Name))
			{
				group.Errors.Add(new Error("Name", "Name", "El nombre no puede estar vacío"));
				result = false;
			}
			if (group.Name != null)
			{
				Collection<GroupEntity> listOfEquals = groupDataAccess.LoadWhere(GroupEntity.DBName, group.Name, false, OperatorType.Equal);

				if (listOfEquals.Count > 0 && listOfEquals[0].Id != group.Id)
				{
					group.Errors.Add(new Error("Name", "Name", "Nombre duplicado"));
					result = false;
				}
			}
			if (String.IsNullOrEmpty(group.Description))
			{
				group.Errors.Add(new Error("Description", "Description", "La descripción no puede estar vacía"));
				result = false;
			}

			if (group.Permissions == null)
			{
				group.Errors.Add(new Error("Permissions", "Permissions", "Los permisos no pueden estar vacíos"));
				result = false;
			}
			if (!ValidatePermissions(group.Permissions))
			{
				result = false;
			}

			Hashtable groupPermissions = new Hashtable();
			foreach(PermissionEntity  permission in group.Permissions)
			{
				if (!permission.AllowRead && !permission.AllowUpdate && !permission.AllowNew && !permission.AllowDelete)
				{
					result = false;
					group.Errors.Add(new Error(permission.BusinessClassName, "Permisos", "No se pueden establecer todos los permisos a falso para " + permission.BusinessClassName));
				}

				if (groupPermissions.Contains(permission.BusinessClassName))
				{
					result = false;
					group.Errors.Add(new Error(permission.BusinessClassName, "Permisos", group.Name + " ya tiene permisos para " + permission.BusinessClassName));
				}
				else 
				{
					groupPermissions.Add(permission.BusinessClassName, null);
				}
			}
			return result;
		} 

		private static bool ValidatePermissions(Collection<PermissionEntity> Permissions)
		{
			bool result = true;

			for (int  i = 0; i < Permissions.Count; i++)
			{
				PermissionEntity item = Permissions[i];
				if (String.IsNullOrEmpty(item.BusinessClassName))
				{
					item.Errors.Add(new Error("BusinessClassName", "BusinessClassName", "El nombre de clase de negocio no puede estar vacío"));
					result = false;
				}
			}
			return result;
		} 

	} 

}
