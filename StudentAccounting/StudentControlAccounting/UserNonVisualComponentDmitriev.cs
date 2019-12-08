using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentControlAccounting
{
    public partial class UserNonVisualComponentDmitriev : Component
    {
        Microsoft.Office.Interop.Word._Application application;
        Microsoft.Office.Interop.Word._Document document;
        Microsoft.Office.Interop.Word.Table table;
        Object missingObj = System.Reflection.Missing.Value;
        Object trueObj = true;
        Object falseObj = false;
        private string[] columns;

        public UserNonVisualComponentDmitriev()
        {
            InitializeComponent();
        }

        public UserNonVisualComponentDmitriev(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void Doc(IEnumerable<object> objects, Object path, string columns)
        {
            application = new Application();

            try
            {
                document = application.Documents.Add();

            }
            catch (Exception error)
            {
                document.Close(ref falseObj, ref missingObj, ref missingObj);
                application.Quit(ref missingObj, ref missingObj, ref missingObj);
                document = null;
                application = null;
                throw error;
            }
            this.columns = columns.Split(',');
            MakeTable(objects);
            Save(document, path);
            document.Close();
            application.Quit();
        }

        private void MakeTable(IEnumerable<object> objects)
        {
            int countColumns = 0;
            int countRows = 0;
            foreach (var column in columns)
            {
                countColumns++;
            }
            foreach (var o in objects)
            {
                countRows++;
            }
            object start = 0;
            object end = 0;
            Range currentRange = document.Range(ref start, ref end);
            table = document.Tables.Add(currentRange, countRows + 2, countColumns, ref missingObj, ref missingObj);
            table.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble;
            table.Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble;
            MakeHeader(table);
            AddData(table, objects);

        }

        private void MakeHeader(Table table)
        {
            Microsoft.Office.Interop.Word.Row row = table.Rows[1];
            Microsoft.Office.Interop.Word.Cell firstCell = row.Cells[1];
            foreach (Microsoft.Office.Interop.Word.Cell currCell in row.Cells)
            {
                if (currCell.ColumnIndex != firstCell.ColumnIndex)
                {
                    firstCell.Merge(currCell);
                }
            }
            firstCell.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalTop;
            Range nameTableRange = table.Cell(1, 1).Range;
            nameTableRange.Text = "Отчет";
            Range headerRange;

            for (int i = 0; i < table.Columns.Count; i++)
            {
                headerRange = table.Cell(2, i + 1).Range;
                headerRange.Text = columns[i];
            }
        }

        private void AddData(Table table, IEnumerable<object> objects)
        {
            var fields = objects.First().GetType().GetFields();

            for (var i = 0; i < columns.Length; i++)
            {
                var field = fields.First(x => x.Name == columns[i]);

                var values = new List<string>();
                var obs = objects.ToArray();
                for (var j = 0; j < obs.Length; j++)
                {
                    table.Cell(j + 3, i + 1).Range.Text = field.GetValue(obs[j]).ToString();
                }
            }
        }

        private void Save(_Document document, Object path)
        {
            Object pathToSaveObj = path;
            document.SaveAs(ref pathToSaveObj, Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatDocument, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj);
        }
    }
}