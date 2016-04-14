﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

#region Copyright
// -----------------------------------------------------------------------
// <copyright company="cdmdotnet Limited">
//     Copyright cdmdotnet Limited. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------
#endregion
using Cqrs.Domain;
using Northwind.Domain.Orders;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Cqrs.Authentication;
using Cqrs.Services;

namespace Northwind.Domain.Orders.Services
{
	public partial interface IOrderService : IEventService<Cqrs.Authentication.ISingleSignOnToken>
	{
		[OperationContract]
		IServiceResponseWithResultData<IEnumerable<Entities.OrderEntity>> GetAllOrders(IServiceRequestWithData<Cqrs.Authentication.ISingleSignOnToken, OrderServiceGetAllOrdersParameters> serviceRequest);

	}

	/// <summary>
	/// The parameters for the <see cref="IOrderService.GetAllOrders" /> method.
	/// </summary>
	public class OrderServiceGetAllOrdersParameters
	{
	}

}
