﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceProject
{
	public static class Globals
	{
		public static OracleConnection GlobalConnection { get; set; }
		public static string ConnectionString { get; set; }
	}
}