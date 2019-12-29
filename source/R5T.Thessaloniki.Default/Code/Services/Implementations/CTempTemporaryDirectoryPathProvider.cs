using System;


namespace R5T.Thessaloniki.Default
{
    /// <summary>
    /// Provides the <see cref="CTempTemporaryDirectoryPathProvider.DirectoryPath"/> value as the temporary directory path.
    /// </summary>
    public class CTempTemporaryDirectoryPathProvider : ITemporaryDirectoryPathProvider
    {
        public const string DirectoryPath = @"C:\Temp";


        public string GetTemporaryDirectoryPath()
        {
            return CTempTemporaryDirectoryPathProvider.DirectoryPath;
        }
    }
}
