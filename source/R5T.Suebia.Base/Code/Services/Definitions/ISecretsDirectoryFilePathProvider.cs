using System;


namespace R5T.Suebia
{
    public interface ISecretsDirectoryFilePathProvider
    {
        string GetSecretsFilePath(string secretsFileName);
    }
}
