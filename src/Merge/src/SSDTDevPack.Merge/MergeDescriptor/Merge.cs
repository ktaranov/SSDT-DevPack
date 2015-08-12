﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using SSDTDevPack.Common.Dac;

namespace SSDTDevPack.Merge.MergeDescriptor
{
    public class InScriptDescriptor
    {
        public InScriptDescriptor(int scriptOffset, int scriptLength, string filePath)
        {
            ScriptOffset = scriptOffset;
            ScriptLength = scriptLength;
            FilePath = filePath;
        }

        public int ScriptOffset { get; set; }
        public int ScriptLength { get; set; }
        public string FilePath { get; set; }
    }

    public class Merge
    {
        public MergeStatement Statement { get; set; }

        public InScriptDescriptor ScriptDescriptor { get; set; }

        public DataTable Data { get; set; }

        public TableDescriptor Table;

        public Identifier Name;

        public MergeOptions Option { get; set; }
    }

    public class MergeWriter
    {
        public MergeWriter(Merge merge)
        {
            
        }

        public void Write()
        {
            
        }

    }

}
