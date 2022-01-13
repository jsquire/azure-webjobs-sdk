﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Microsoft.Azure.WebJobs.Host.Hosting
{
    public interface IWebJobsExtensionOptionDataSource
    {
        object Register(string section, object config);

        IReadOnlyDictionary<string, object> GetExtensionConfigs();
        
        void Clear();

        JObject GetOptions();
    }
}
