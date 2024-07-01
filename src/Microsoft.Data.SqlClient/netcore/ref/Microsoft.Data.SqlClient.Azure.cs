// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// NOTE: The current Microsoft.VSDesigner editor attributes are implemented for System.Data.SqlClient, and are not publicly available.
// New attributes that are designed to work with Microsoft.Data.SqlClient and are publicly documented should be included in future.

using System;

[assembly: System.CLSCompliant(true)]
namespace Microsoft.Data.SqlClient
{
    /// <include file='../../../../doc/snippets/Microsoft.Data.SqlClient/ActiveDirectoryAuthenticationProvider.xml' path='docs/members[@name="ActiveDirectoryAuthenticationProvider"]/ActiveDirectoryAuthenticationProvider/*'/>
    public sealed partial class ActiveDirectoryAuthenticationProvider : SqlAuthenticationProvider
    {
        /// <include file='../../../../doc/snippets/Microsoft.Data.SqlClient/ActiveDirectoryAuthenticationProvider.xml' path='docs/members[@name="ActiveDirectoryAuthenticationProvider"]/ctor/*'/>
        public ActiveDirectoryAuthenticationProvider() { }
        /// <include file='../../../../doc/snippets/Microsoft.Data.SqlClient/ActiveDirectoryAuthenticationProvider.xml' path='docs/members[@name="ActiveDirectoryAuthenticationProvider"]/ctor2/*'/>
        public ActiveDirectoryAuthenticationProvider(string applicationClientId) { }
        /// <include file='../../../../doc/snippets/Microsoft.Data.SqlClient/ActiveDirectoryAuthenticationProvider.xml' path='docs/members[@name="ActiveDirectoryAuthenticationProvider"]/ClearUserTokenCache/*'/>
        public static void ClearUserTokenCache() { }
        /// <include file='../../../../doc/snippets/Microsoft.Data.SqlClient/ActiveDirectoryAuthenticationProvider.xml' path='docs/members[@name="ActiveDirectoryAuthenticationProvider"]/ctor3/*'/>
        public ActiveDirectoryAuthenticationProvider(System.Func<Microsoft.Identity.Client.DeviceCodeResult, System.Threading.Tasks.Task> deviceCodeFlowCallbackMethod, string applicationClientId = null) { }
        /// <include file='../../../../doc/snippets/Microsoft.Data.SqlClient/ActiveDirectoryAuthenticationProvider.xml' path='docs/members[@name="ActiveDirectoryAuthenticationProvider"]/AcquireTokenAsync/*'/>
        public override System.Threading.Tasks.Task<SqlAuthenticationToken> AcquireTokenAsync(SqlAuthenticationParameters parameters) { throw null; }
        /// <include file='../../../../doc/snippets/Microsoft.Data.SqlClient/ActiveDirectoryAuthenticationProvider.xml' path='docs/members[@name="ActiveDirectoryAuthenticationProvider"]/SetDeviceCodeFlowCallback/*'/>
        public void SetDeviceCodeFlowCallback(System.Func<Microsoft.Identity.Client.DeviceCodeResult, System.Threading.Tasks.Task> deviceCodeFlowCallbackMethod) { }
        /// <include file='../../../../doc/snippets/Microsoft.Data.SqlClient/ActiveDirectoryAuthenticationProvider.xml' path='docs/members[@name="ActiveDirectoryAuthenticationProvider"]/SetAcquireAuthorizationCodeAsyncCallback/*'/>
        public void SetAcquireAuthorizationCodeAsyncCallback(System.Func<System.Uri, System.Uri, System.Threading.CancellationToken, System.Threading.Tasks.Task<System.Uri>> acquireAuthorizationCodeAsyncCallback) { }
        /// <include file='../../../../doc/snippets/Microsoft.Data.SqlClient/ActiveDirectoryAuthenticationProvider.xml' path='docs/members[@name="ActiveDirectoryAuthenticationProvider"]/IsSupported/*'/>
        public override bool IsSupported(SqlAuthenticationMethod authentication) { throw null; }
        /// <include file='../../../../doc/snippets/Microsoft.Data.SqlClient/ActiveDirectoryAuthenticationProvider.xml' path='docs/members[@name="ActiveDirectoryAuthenticationProvider"]/BeforeLoad/*'/>
        public override void BeforeLoad(SqlAuthenticationMethod authentication) { }
        /// <include file='../../../..//doc/snippets/Microsoft.Data.SqlClient/ActiveDirectoryAuthenticationProvider.xml' path='docs/members[@name="ActiveDirectoryAuthenticationProvider"]/BeforeUnload/*'/>
        public override void BeforeUnload(SqlAuthenticationMethod authentication) { }
    }
}
