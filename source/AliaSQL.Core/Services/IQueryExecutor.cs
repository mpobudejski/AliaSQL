﻿using AliaSQL.Core.Model;

namespace AliaSQL.Core.Services
{
	public interface IQueryExecutor
	{
		void ExecuteNonQuery(ConnectionSettings settings, string sql, bool runAgainstSpecificDatabase);
		int ExecuteScalarInteger(ConnectionSettings settings, string sql);
		string[] ReadFirstColumnAsStringArray(ConnectionSettings settings, string sql);
	    bool CheckDatabaseExists(ConnectionSettings settings);
	}
}