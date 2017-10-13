using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess._120_FileSystem
{
    public class FileHandler
    {
        #region Fields

        private string FilePath;

        #endregion

        #region Constructors

        public FileHandler(string FilePathParam, bool CreateFileIfNotExists)
        {
            this.FilePath = FilePathParam;

            if (CreateFileIfNotExists)
                CreateFile();
        }

        #endregion

        #region Methods

        #region Read Methods

        public List<string> Read()
        {
            return ReadData(this.FilePath);
        }

        public List<string> Read(string FilePathToRead)
        {
            return ReadData(FilePathToRead);
        }

        private List<string> ReadData(string filePathParam)
        {
            try
            {
                StreamReader reader = new StreamReader(new FileStream(filePathParam, FileMode.Open, FileAccess.Read));

                List<string> temp = new List<string>();
                while (!reader.EndOfStream)
                {
                    temp.Add(reader.ReadLine());
                }
                return temp;
            }
            catch (Exception) { return null; }
        }

        #endregion

        #region Write Methods

        #region Append Data

        public bool AppendData(List<string> dataToAppend)
        {
            return WriteData(new StreamWriter(new FileStream(this.FilePath, FileMode.Append, FileAccess.Write)), dataToAppend);
        }

        #endregion

        #region Overwrite Data

        public bool OverwriteData(List<string> dataToWrite)
        {
            return WriteData(new StreamWriter(new FileStream(this.FilePath, FileMode.Truncate, FileAccess.Write)), dataToWrite);
        }

        public bool ClearFileContents()
        {
            try
            {
                new FileStream(this.FilePath, FileMode.Truncate, FileAccess.Write);
                return true;
            }
            catch (Exception) { return false; }
        }

        #endregion

        private bool WriteData(StreamWriter writer, List<string> data)
        {
            try
            {
                for (int i = 0; i < data.Count; i++)
                {
                    writer.WriteLine(data[i]);
                }
                writer.Close();
                return true;
            }
            catch (Exception) { return false; }
        }

        #endregion

        #region Other Methods

        private bool CreateFile()
        {
            try
            {
                if (!File.Exists(this.FilePath))
                    new FileStream(this.FilePath, FileMode.CreateNew, FileAccess.Write);

                return true;
            }
            catch (Exception) { return false; }
        }

        #endregion

        #endregion
    }
}
