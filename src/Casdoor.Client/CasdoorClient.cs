﻿// Copyright 2022 The Casdoor Authors. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Net.Http.Json;
using IdentityModel.Client;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace Casdoor.Client;

public partial class CasdoorClient : ICasdoorClient
{
    private readonly HttpClient _httpClient;
    private readonly TokenClient _tokenClient;
    private readonly CasdoorOptions _options;

    public CasdoorClient(HttpClient httpClient, TokenClient tokenClient, CasdoorOptions options)
    {
        _httpClient = httpClient;
        _tokenClient = tokenClient;
        _options = options;
    }
}