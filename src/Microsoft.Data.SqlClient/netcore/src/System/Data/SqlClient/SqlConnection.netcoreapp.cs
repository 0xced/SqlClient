﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Configuration;
using System.Data.Common;

namespace Microsoft.Data.SqlClient
{
    public sealed partial class SqlConnection : DbConnection, ICloneable
    {
        static SqlConnection()
        {
            SqlColumnEncryptionEnclaveProviderConfigurationSection sqlColumnEncryptionEnclaveProviderConfigurationSection = null;
            try
            {
                sqlColumnEncryptionEnclaveProviderConfigurationSection = (SqlColumnEncryptionEnclaveProviderConfigurationSection)ConfigurationManager.GetSection("SqlColumnEncryptionEnclaveProviders");
            }
            catch (ConfigurationErrorsException e)
            {
                throw SQL.CannotGetSqlColumnEncryptionEnclaveProviderConfig(e);
            }

            sqlColumnEncryptionEnclaveProviderConfigurationManager = new SqlColumnEncryptionEnclaveProviderConfigurationManager(sqlColumnEncryptionEnclaveProviderConfigurationSection);
        }

        static internal readonly SqlColumnEncryptionEnclaveProviderConfigurationManager sqlColumnEncryptionEnclaveProviderConfigurationManager;
    }
}