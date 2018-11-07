using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace CW_Assembly_Resolve
{
    [CompilerGenerated]
    internal static class AssemblyLoader
    {
        private static string CultureToString(CultureInfo culture)
        {
            if (culture == null)
            {
                return "";
            }
            return culture.Name;
        }

        private static Assembly ReadExistingAssembly(AssemblyName name)
        {
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                AssemblyName name2 = assembly.GetName();
                if (string.Equals(name2.Name, name.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(AssemblyLoader.CultureToString(name2.CultureInfo), AssemblyLoader.CultureToString(name.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
                {
                    return assembly;
                }
            }
            return null;
        }

        private static void CopyTo(Stream source, Stream destination)
        {
            byte[] array = new byte[1456789];
            int count;
            while ((count = source.Read(array, 0, array.Length)) != 0)
            {
                destination.Write(array, 0, count);
            }
        }
        public static void KutuphaneCikart(string path)
        {
            try
            {
                using (SaveFileDialog sdg = new SaveFileDialog())
                {
                    sdg.Filter = "Dll Dosyaları | *.dll";
                    if (sdg.ShowDialog() == DialogResult.OK)
                    {
                        using (Stream manifestResourceStream = File.OpenRead(path))
                        {
                            BinaryReader br = new BinaryReader(manifestResourceStream);

                            byte[] decompressed = AssemblyLoader.Decompress(br.ReadBytes((int)manifestResourceStream.Length));

                            FileStream s = new FileStream(sdg.FileName, FileMode.Create);
                            BinaryWriter bw = new BinaryWriter(s);
                            bw.Write(decompressed, 0, decompressed.Length);
                            s.Close();
                            MessageBox.Show("Dosya başarıyla çıkartıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void KutuphaneSikistir(string path)
        {
            try
            {
                using (SaveFileDialog sdg = new SaveFileDialog())
                {
                    sdg.Filter = "Sıkıştırılmış Dosyalar | *.0xCompressed";
                    if (sdg.ShowDialog() == DialogResult.OK)
                    {
                        using (Stream manifestResourceStream = File.OpenRead(path))
                        {
                            BinaryReader ss = new BinaryReader(manifestResourceStream);

                            byte[] comp = AssemblyLoader.Compress(ss.ReadBytes((int)manifestResourceStream.Length));

                            FileStream s = new FileStream(sdg.FileName, FileMode.Create);
                            BinaryWriter wr = new BinaryWriter(s);
                            wr.Write(comp, 0, comp.Length);
                            s.Close();
                            MessageBox.Show("Dosya başarıyla sıkıştırıldı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }
        private static byte[] Decompress(byte[] data)
        {
            using (var compressedStream = new MemoryStream(data))
            using (var zipStream = new GZipStream(compressedStream, CompressionMode.Decompress))
            using (var resultStream = new MemoryStream())
            {
                AssemblyLoader.CopyTo(zipStream, resultStream);
                return resultStream.ToArray();
            }
        }
        private static byte[] Compress(byte[] data)
        {
            using (var compressedStream = new MemoryStream())
            using (var zipStream = new GZipStream(compressedStream, CompressionMode.Compress))
            {
                zipStream.Write(data, 0, data.Length);
                zipStream.Close();
                return compressedStream.ToArray();
            }
        }
        private static Stream LoadStream(string fullname)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            if (fullname.EndsWith(".0xcompressed"))
            {
                using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(fullname))
                {
                    BinaryReader br = new BinaryReader(manifestResourceStream);
                    MemoryStream memoryStream = new MemoryStream(Decompress(br.ReadBytes((int)manifestResourceStream.Length)));
                    return memoryStream;

                }
            }
            return executingAssembly.GetManifestResourceStream(fullname);
        }
        private static Stream LoadStream(Dictionary<string, string> resourceNames, string name)
        {
            string fullname;
            if (resourceNames.TryGetValue(name, out fullname))
            {
                return AssemblyLoader.LoadStream(fullname);
            }
            return null;
        }
        private static byte[] ReadStream(Stream stream)
        {
            byte[] array = new byte[stream.Length];
            stream.Read(array, 0, array.Length);
            return array;
        }
        private static Assembly ReadFromEmbeddedResources(Dictionary<string, string> assemblyNames, Dictionary<string, string> symbolNames, AssemblyName requestedAssemblyName)
        {
            string text = requestedAssemblyName.Name.ToLowerInvariant();
            if (requestedAssemblyName.CultureInfo != null && !string.IsNullOrEmpty(requestedAssemblyName.CultureInfo.Name))
            {
                text = string.Format("{0}.{1}", requestedAssemblyName.CultureInfo.Name, text);
            }
            byte[] rawAssembly;
            using (Stream stream = AssemblyLoader.LoadStream(assemblyNames, text))
            {
                if (stream == null)
                {
                    return null;
                }
                rawAssembly = AssemblyLoader.ReadStream(stream);
            }
            using (Stream stream2 = AssemblyLoader.LoadStream(symbolNames, text))
            {
                if (stream2 != null)
                {
                    byte[] rawSymbolStore = AssemblyLoader.ReadStream(stream2);
                    return Assembly.Load(rawAssembly, rawSymbolStore);
                }
            }
            return Assembly.Load(rawAssembly);
        }

        public static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
        {
            object obj = AssemblyLoader.nullCacheLock;
            lock (obj)
            {
                if (AssemblyLoader.nullCache.ContainsKey(e.Name))
                {
                    return null;
                }
            }
            AssemblyName assemblyName = new AssemblyName(e.Name);
            Assembly assembly = AssemblyLoader.ReadExistingAssembly(assemblyName);
            if (assembly != null)
            {
                return assembly;
            }
            assembly = AssemblyLoader.ReadFromEmbeddedResources(AssemblyLoader.assemblyNames, AssemblyLoader.symbolNames, assemblyName);
            if (assembly == null)
            {
                obj = AssemblyLoader.nullCacheLock;
                lock (obj)
                {
                    AssemblyLoader.nullCache[e.Name] = true;
                }
                if (assemblyName.Flags == AssemblyNameFlags.Retargetable)
                {
                    assembly = Assembly.Load(assemblyName);
                }
            }
            return assembly;
        }

        static AssemblyLoader()
        {
          //  AssemblyLoader.assemblyNames.Add("ihtiyaç duyulan kütüphane", "gömülü olduğu konum");
        }

        public static void Attach()
        {
            if (Interlocked.Exchange(ref AssemblyLoader.isAttached, 1) == 1)
            {
                return;
            }
            AppDomain.CurrentDomain.AssemblyResolve += AssemblyLoader.ResolveAssembly;
        }

        private static readonly object nullCacheLock = new object();

        private static readonly Dictionary<string, bool> nullCache = new Dictionary<string, bool>();

        private static readonly Dictionary<string, string> assemblyNames = new Dictionary<string, string>();

        private static readonly Dictionary<string, string> symbolNames = new Dictionary<string, string>();

        private static int isAttached = 0;
    }
}
