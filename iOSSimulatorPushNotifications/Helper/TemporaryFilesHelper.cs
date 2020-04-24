using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace iOSSimulatorPushNotifications
{
    public static class TemporaryFilesHelper
    {
        public static string CreateTempFile ()
        {
            var fileName = string.Empty;

            try {
                fileName = Path.GetTempFileName ();

                var fileInfo = new FileInfo (fileName) {
                    Attributes = FileAttributes.Temporary
                };
            }
            catch (Exception ex) {
                Console.WriteLine ($"Unable to create temp file {ex.Message}");
            }

            return fileName;
        }

        public static void UpdateTempFile (string tempFile, string input)
        {
            try {
                var streamWriter = File.AppendText (tempFile);
                streamWriter.WriteLine (JObject.Parse (input));
                streamWriter.Flush ();
                streamWriter.Close ();
            }
            catch (Exception ex) {
                Console.WriteLine ($"Error writing to temp file {ex.Message}");
            }
        }

        public static void DeleteTempFile (string tmpFile)
        {
            try {
                if (File.Exists (tmpFile)) {
                    File.Delete (tmpFile);
                }
            }
            catch (Exception ex) {
                Console.WriteLine ($"Error deleting temp file {ex.Message}");
            }
        }
    }
}
