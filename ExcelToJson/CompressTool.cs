using System;
using System.IO;
using System.Text;
using ICSharpCode.SharpZipLib.GZip;
using ICSharpCode.SharpZipLib.Zip;

public class CompressTool
{
    /// <summary>
    /// Compress plain text
    /// </summary>
    /// <param name="plainText">Plain text</param>
    /// <returns>result</returns>
    public static string Compress(string plainText)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            using (GZipOutputStream gzip = new GZipOutputStream(ms))
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(plainText);
                gzip.Write(bytes, 0, bytes.Length);
                gzip.Close();
                byte[] press = ms.ToArray();
                return Convert.ToBase64String(press);
            }
        }
    }
    /// <summary>
    /// Decompress string
    /// </summary>
    /// <param name="base64Compressed">Target string</param>
    /// <returns>result</returns>
    public static string Decompress(String base64Compressed)
    {
        byte[] bytes = Convert.FromBase64String(base64Compressed);
        using (GZipInputStream gzi = new GZipInputStream(new MemoryStream(bytes)))
        {
            using (MemoryStream re = new MemoryStream())
            {
                int count = 0;
                byte[] data = new byte[4096];
                while ((count = gzi.Read(data, 0, data.Length)) != 0)
                {
                    re.Write(data, 0, count);
                }
                byte[] depress = re.ToArray();
                return Encoding.UTF8.GetString(depress);
            }
        }
    }

    /// <summary>
    /// Unzip file
    /// </summary>
    /// <param name="fileStream">File stream</param>
    /// <param name="targetFolder">Target folder</param>
    /// <returns>status</returns>
    public static bool DeZIP(Stream fileStream, string targetFolder)
    {
        try
        {
            FastZip fastZip = new FastZip();
            fastZip.ExtractZip(fileStream, targetFolder, FastZip.Overwrite.Always, null, "", "", true, true);
        }
        catch (Exception ex)
        {
            //Log.Write(ex.ToString() + ex.StackTrace, Log.LogType.Error);
            return false;
        }
        return true;
    }
}