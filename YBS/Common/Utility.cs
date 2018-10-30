using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Compression;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.RegularExpressions;

namespace  YBS.Common
{
    public delegate void CallbackAdd(int index);

    public enum ReportTypes { BhikkuPersonalInfo, BhikkuAllInfo,NAN }

    public class Utility
    {
        internal static void WriteWrrorLog(Exception ex)
        {
            try
            {
                string fileName = string.Concat(@"Logs\", DateTime.Now.ToString("yyyy-MMM"), ".csv");

                using (StreamWriter fileWriter = File.AppendText(fileName))
                {
                    fileWriter.WriteLine("\n#####################################");
                    fileWriter.WriteLine(string.Concat(DateTime.Now, "\n", ex.Message, "\n", ex.StackTrace, "\n\n"));
                    fileWriter.Flush();
                }
            }
            catch
            {

            }
        }


        public static string Get64String(byte[] data)
        {
            return Convert.ToBase64String(data);
        }

        public static byte[] GetByte64String(string data)
        {
            return Convert.FromBase64String(data);
        }


        public static void SetDatagridViewRow(DataGridView grid)
        {
            //set row number
            int rowCount = 1;
            foreach (DataGridViewRow row in grid.Rows)
            {
                row.HeaderCell.Value = (rowCount++).ToString();
            }
        }

        public static byte[] Serialize(object obj)
        {
            IFormatter formatter = new BinaryFormatter();

            using (MemoryStream stream = new MemoryStream())
            {
                formatter.Serialize(stream, obj);
                obj = null;
                GC.Collect();

                stream.Seek(0, SeekOrigin.Begin);

                byte[] data = new byte[stream.Length];

                stream.Read(data, 0, data.Length);

                return data;
            }

        }



        /// <summary>
        /// Deserialize the given byte array
        /// </summary>
        public static object Deserialize(byte[] bytesBuffer)
        {
            IFormatter formatter = new BinaryFormatter();

            using (MemoryStream stream = new MemoryStream())
            {
                stream.Write(bytesBuffer, 0, bytesBuffer.Length);
                stream.Seek(0, SeekOrigin.Begin);
                GC.Collect();
                object obj = formatter.Deserialize(stream);

                return obj;
            }
        }

        public static byte[] CompressGZip(byte[] bytesbuffer)
        {
            using (MemoryStream gz_ms = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(gz_ms, System.Text.Encoding.ASCII))
                {
                    writer.Write(bytesbuffer.Length);
                    using (GZipStream gz_mgzip = new GZipStream(gz_ms, CompressionMode.Compress, true))
                    {
                        gz_mgzip.Write(bytesbuffer, 0, bytesbuffer.Length);

                    }

                    byte[] data = new byte[gz_ms.Length];
                    gz_ms.Seek(0, SeekOrigin.Begin);
                    gz_ms.Read(data, 0, data.Length);
                    return data;

                }
            }
        }


        //decompress given byteArray
        public static byte[] DecompressGZip(byte[] obj)
        {
            using (MemoryStream gzipUncompress = new MemoryStream())
            {
                gzipUncompress.Write(obj, 0, obj.Length);
                gzipUncompress.Seek(0, SeekOrigin.Begin);

                using (BinaryReader reader = new BinaryReader(gzipUncompress))
                {
                    Int32 size = reader.ReadInt32();
                    byte[] buffer = new byte[size];

                    using (GZipStream gzipDecompress = new GZipStream(gzipUncompress, CompressionMode.Decompress))
                    {
                        int count = gzipDecompress.Read(buffer, 0, buffer.Length);

                        return buffer;
                    }
                }
            }
        }


        internal static byte[] GetFileByteCompress(string fileName)
        {

            byte[] fileData = File.ReadAllBytes(fileName);

            return CompressGZip(fileData);
        }

        public static bool IsValidEmailAddress(string s)
        {
            var regex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            return regex.IsMatch(s);
        }

        public static bool IsValiedPhoneNumber(string number)
        {
            double d = 0;

            if (!string.IsNullOrEmpty(number) && (number.Length != 10 || !double.TryParse(number, out d) || d > 999999999))
            {
                return false;
            }

            return true;
        }

    }
}
