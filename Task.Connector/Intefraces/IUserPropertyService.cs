﻿using Task.Integration.Data.Models.Models;

namespace Task.Connector.Intefraces;

internal interface IUserPropertyService
{
	IEnumerable<UserProperty> GetUserProperties(string userLogin);
	void UpdateUserProperties(IEnumerable<UserProperty> properties, string userLogin);
}
