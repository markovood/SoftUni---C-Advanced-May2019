using System;
using System.IO;
using System.IO.Compression;

namespace ZipAndExtract
{
    public class ZipAndExtract
    {
        public static void Main()
        {
            string filePath = @"..\..\..\..\Resources\copyMe.png";
            string archivePath = @"..\..\..\copyMe.zip";

            // before uncomment the 'un-archiving' lines, comment first the 'archiving' ones or exception will
            // be thrown

            // Archiving
            using (ZipArchive archive = ZipFile.Open(archivePath, ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(filePath, Path.GetFileName(filePath));
            }

            // un-archiving
            // ZipFile.ExtractToDirectory(archivePath, @"..\..\..\");
        }
    }
}
