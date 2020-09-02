<img alt="FactSet" src="https://www.factset.com/hubfs/Assets/images/factset-logo.svg" height="56" width="290">

# Analytics API Engines .NET SDK

[![build](https://img.shields.io/github/workflow/status/afernandes85/analyticsapi-engines-dotnet-sdk/CI)](https://github.com/afernandes85/analyticsapi-engines-dotnet-sdk/actions?query=workflow%3ACI)
[![nuget](https://img.shields.io/nuget/v/FactSet.AnalyticsAPI.Engines)](https://www.nuget.org/packages/FactSet.AnalyticsAPI.Engines)
![API version](https://img.shields.io/badge/API-v2-blue)
[![Apache-2 license](https://img.shields.io/badge/license-Apache2-brightgreen.svg)](https://www.apache.org/licenses/LICENSE-2.0)

Use this library to integrate with FactSet's Analytics APIs. Below APIs are supported by this SDK.

* [PA Engine API](https://developer.factset.com/api-catalog/pa-engine-api)
* [SPAR Engine API](https://developer.factset.com/api-catalog/spar-engine-api)
* [Vault API](https://developer.factset.com/api-catalog/vault-api)

## Contents

* [Engines](Engines) - Auto-generated code using [Analytics API Engines SDK Generator](https://github.com/afernandes85/analyticsapi-engines-sdk-generator)
* [Examples](Examples) - Sample project containing code snippets to quickly get started with the SDK  
* [Tests](Tests) - Integration tests

## Requirements

* .Net Standard 2.0 or higher

## Installation

* Install with Package Manager Console:

  ```sh
  Install-Package FactSet.AnalyticsAPI.Engines
  ```

* Install with NuGet:

  ```sh
  nuget install FactSet.AnalyticsAPI.Engines
  ```

* Install with .NET Core:

  ```sh
  dotnet add package FactSet.AnalyticsAPI.Engines
  ```

* Alternatively, download or clone this repository, build the SDK and add it as reference to your project:

  ```sh
  git clone https://github.com/afernandes85/analyticsapi-engines-dotnet-sdk.git
  cd Engines
  dotnet build FactSet.AnalyticsAPI.Engines
  ```

## Usage

Refer [Examples](Examples) project for sample code snippets to quickly get started with the SDK

## Tests

First, clone the repo locally and `cd` into the directory.

```sh
git clone https://github.com/afernandes85/analyticsapi-engines-dotnet-sdk.git
cd Tests
```

Before running the tests, set the below environment variables. Use the [Developer Portal Manage API Keys page](https://developer.factset.com/manage-api-keys) to get these values.

```sh
export ANALYTICS_API_USERNAME_SERIAL = "username-serial"
export ANALYTICS_API_PASSWORD = "apikey"
```

Run the tests with below command.

```sh
dotnet test
```

## Contributing

* Files in [Engines](Engines) are auto-generated and should not be manually edited here. Refer [Analytics API Engines SDK Generator](https://github.com/afernandes85/analyticsapi-engines-sdk-generator) for instructions on how to modify these files.
* [Examples](Examples) and [Tests](Tests) projects are open to enhancements and bug fixes. Please create a pull requests with the proposed changes.
