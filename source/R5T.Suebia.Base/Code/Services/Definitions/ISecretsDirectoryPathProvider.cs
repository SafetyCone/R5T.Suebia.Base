﻿using System;

using R5T.T0064;


namespace R5T.Suebia
{
    [ServiceDefinitionMarker]
    public interface ISecretsDirectoryPathProvider : IServiceDefinition
    {
        string GetSecretsDirectoryPath();
    }
}
