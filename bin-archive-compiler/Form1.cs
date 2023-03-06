using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bin_archive_compiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static void ExtractFile(string binFilePath, string outputFolderPath)
        {
            string binFileName = Path.GetFileName(binFilePath);
            string outputFolder = outputFolderPath + "\\disassembled-" + binFileName;

            // Create output folder if it doesn't exist
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }

            // Read archive entries from bin file
            List<ArchiveEntry> entries = new List<ArchiveEntry>();
            using (BinaryReader reader = new BinaryReader(File.Open(binFilePath, FileMode.Open)))
            {
                int entryCount = reader.ReadInt32();

                for (int i = 0; i < entryCount; i++)
                {
                    try
                    {
                        ArchiveEntry entry = new ArchiveEntry();
                        entry.Name = new string(reader.ReadChars(20)).TrimEnd('\0');
                        entry.Offset = reader.ReadInt32();
                        entry.Size = reader.ReadInt32();

                        entries.Add(entry);
                    }
                    catch
                    {

                    }
                }
            }

            // Extract files from bin file
            foreach (ArchiveEntry entry in entries)
            {
                try
                {
                    byte[] data;
                    using (BinaryReader reader = new BinaryReader(File.Open(binFilePath, FileMode.Open)))
                    {
                        reader.BaseStream.Seek(entry.Offset, SeekOrigin.Begin);
                        data = reader.ReadBytes(entry.Size);
                    }


                    string outputFilename = Path.Combine(outputFolder, entry.Name);
                    using (FileStream output = new FileStream(outputFilename, FileMode.Create))
                    {
                        output.Write(data, 0, data.Length);
                    }
                }
                catch
                {
                }
                
                Console.WriteLine($"Extracted {entry.Name}");
            }

            Console.WriteLine("Extraction complete");
        }

        static void InsertFile(string InputeFolderPath, string outputFolderPath, string outputFileName)
        {
            string outputFilePath = outputFolderPath + "\\" + outputFileName;

            // Get all files in input folder
            string[] files = Directory.GetFiles(InputeFolderPath);

            // Create list of archive entries
            List<ArchiveEntry> entries = new List<ArchiveEntry>();
            int offset = 4 + (files.Length * 28);

            foreach (string file in files)
            {
                ArchiveEntry entry = new ArchiveEntry();
                entry.Name = Path.GetFileName(file).PadRight(20, '\0');
                entry.Offset = offset;

                byte[] data = File.ReadAllBytes(file);
                entry.Size = data.Length;

                entries.Add(entry);

                offset += entry.Size;
            }

            // Write archive entries to bin file
            using (BinaryWriter writer = new BinaryWriter(File.Open(outputFilePath, FileMode.Create)))
            {
                writer.Write(entries.Count);

                foreach (ArchiveEntry entry in entries)
                {
                    writer.Write(entry.Name.ToCharArray());
                    writer.Write(entry.Offset);
                    writer.Write(entry.Size);
                }

                // Write files to bin file
                foreach (ArchiveEntry entry in entries)
                {
                    string filePath = Path.Combine(InputeFolderPath, entry.Name.TrimEnd('\0'));
                    byte[] data = File.ReadAllBytes(filePath);
                    writer.Write(data);
                }
            }

            Console.WriteLine("Insertion complete");
        }

        private void ExtractButton_Click(object sender, EventArgs e)
        {
            try
            {
                ExtractValErr.Visible = false;

                if (string.IsNullOrEmpty(ExtractOutputPath.Text))
                {
                    throw new Exception();
                }

                ExtractFile(ExtractFilePath.Text, ExtractOutputPath.Text);

                string fileName = Path.GetFileName(ExtractFilePath.Text);

                InsertFolderPath.Text = ExtractOutputPath.Text + "\\disassembled-" + fileName;
                InsertOutputName.Text = fileName;
            }
            catch
            {
                ExtractValErr.Visible = true;
            }
        }

        private void InsertFile_Click(object sender, EventArgs e)
        {
            try
            {
                InsertValErr.Visible = false;

                if (string.IsNullOrEmpty(InsertOutputPath.Text) || string.IsNullOrEmpty(InsertOutputName.Text))
                {
                    throw new Exception();
                }

                if (!InsertOutputName.Text.EndsWith(".bin"))
                {
                    InsertOutputName.Text += ".bin";
                }

                InsertFile(InsertFolderPath.Text, InsertOutputPath.Text, InsertOutputName.Text);
            }
            catch
            {
                InsertValErr.Visible = true;
            }
        }

        private void ExtractFileSearch_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExtractFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void ExtractOutputSearch_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    ExtractOutputPath.Text = selectedFolderPath;

                    if (string.IsNullOrEmpty(InsertOutputPath.Text))
                    {
                        InsertOutputPath.Text = selectedFolderPath;
                    }
                }
            }
        }

        private void InsertDirectoreSearch_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    InsertFolderPath.Text = selectedFolderPath;
                }
            }
        }

        private void InsertOutputSearch_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    InsertOutputPath.Text = selectedFolderPath;
                }
            }
        }
    }
}
