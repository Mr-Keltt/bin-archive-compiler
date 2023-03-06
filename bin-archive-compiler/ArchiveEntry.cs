using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bin_archive_compiler
{
    internal class ArchiveEntry
    {
        public string Name { get; set; }
        public int Offset { get; set; }
        public int Size { get; set; }
    }
}
