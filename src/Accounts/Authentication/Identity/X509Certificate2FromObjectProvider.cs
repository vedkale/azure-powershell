﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------
//

using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Azure.PowerShell.Authenticators.Identity
{
    /// <summary>
    /// X509Certificate2FromObjectProvider provides an X509Certificate2 from an existing instance.
    /// </summary>
    internal class X509Certificate2FromObjectProvider : IX509Certificate2Provider
    {
        private X509Certificate2 Certificate { get; }

        public X509Certificate2FromObjectProvider(X509Certificate2 clientCertificate)
        {
            Certificate = clientCertificate ?? throw new ArgumentNullException(nameof(clientCertificate));
        }

        public ValueTask<X509Certificate2> GetCertificateAsync(bool async, CancellationToken cancellationToken)
        {
            return new ValueTask<X509Certificate2>(Certificate);
        }
    }
}
