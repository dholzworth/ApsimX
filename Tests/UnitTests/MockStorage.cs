﻿using System;
using System.Collections.Generic;
using Models.Report;
using Models.Core;
using System.Data;

namespace UnitTests
{
    [Serializable]
    internal class MockStorage : Model, IStorageReader, IStorageWriter
    {
        internal List<string> columnNames = new List<string>();
        internal List<Row> rows = new List<Row>();

        public string[] SimulationNames
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string FileName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IEnumerable<string> TableNames
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        [Serializable]
        internal class Row
        {
            public IEnumerable<object> values;
        }

        /// <summary>Write to permanent storage.</summary>
        /// <param name="simulationName">Name of simulation</param>
        /// <param name="tableName">Name of table</param>
        /// <param name="columnNames">Column names</param>
        /// <param name="columnUnits">Column units</param>
        /// <param name="valuesToWrite">Values of row to write</param>
        public void WriteRow(string simulationName, string tableName, IEnumerable<string> columnNames, IEnumerable<string> columnUnits, IEnumerable<object> valuesToWrite)
        {
            this.columnNames.Clear();
            this.columnNames.AddRange(columnNames);
            rows.Add(new Row() { values = APSIM.Shared.Utilities.ReflectionUtilities.Clone(valuesToWrite) as IEnumerable<object> });
        }

        public DataTable GetData(string tableName, string simulationName = null, IEnumerable<string> fieldNames = null, string filter = null, int from = 0, int count = 0)
        {
            return null;
        }

        public string GetUnits(string tableName, string columnHeading)
        {
            return null;
        }

        public void WriteTable(DataTable table)
        {
        }

        public void DeleteTable(string tableName)
        {
        }

        public DataTable RunQuery(string sql)
        {
            return null;
        }

        public IEnumerable<string> ColumnNames(string tableName)
        {
            return null;
        }

        public void DeleteAllTables(bool cleanSlate = false)
        {
        }

        public void BeginWriting(IEnumerable<string> knownSimulationNames = null, IEnumerable<string> simulationNamesBeingRun = null)
        {
        }

        public void EndWriting()
        {
        }

        public void DeleteAllTables()
        {
        }

        public int GetSimulationID(string simulationName)
        {
            return 0;
        }

        public void AllCompleted()
        {
        }

        public void CompletedWritingSimulationData(string simulationName)
        {
        }

        public void WriteTableRaw(DataTable data)
        {
        }
    }
}