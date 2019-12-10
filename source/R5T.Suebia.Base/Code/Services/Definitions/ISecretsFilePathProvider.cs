using System;


namespace R5T.Suebia
{
    public interface ISecretsFilePathProvider
    {
        string GetSecretsFilePath(string secretsFileName);
    }
}
