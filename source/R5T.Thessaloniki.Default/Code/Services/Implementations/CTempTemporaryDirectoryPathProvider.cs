using System;using R5T.T0064;


namespace R5T.Thessaloniki.Default
{[ServiceImplementationMarker]
    /// <summary>
    /// Provides the <see cref="CTempTemporaryDirectoryPathProvider.DirectoryPath"/> value as the temporary directory path.
    /// </summary>
    public class CTempTemporaryDirectoryPathProvider : ITemporaryDirectoryPathProvider,IServiceImplementation
    {
        public const string DirectoryPath = @"C:\Temp";


        public string GetTemporaryDirectoryPath()
        {
            return CTempTemporaryDirectoryPathProvider.DirectoryPath;
        }
    }
}
