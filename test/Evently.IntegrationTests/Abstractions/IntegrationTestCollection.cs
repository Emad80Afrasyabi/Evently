﻿namespace Evently.IntegrationTests.Abstractions;

#pragma warning disable CA1515
[CollectionDefinition(nameof(IntegrationTestCollection))]
public sealed class IntegrationTestCollection : ICollectionFixture<IntegrationTestWebAppFactory>;
#pragma warning disable CA1515
