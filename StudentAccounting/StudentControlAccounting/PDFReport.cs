using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.util;

namespace StudentControlAccounting
{
    public partial class PDFReport : Component
    {
        private List<string> headers = new List<string>();
        private List<List<string>> values = new List<List<string>>();
        public void SetHeaders(List<string> headers)
        {
            this.headers = headers;
        }
        public void SetValues(List<List<string>> values)
        {
            this.values = values;
        }
        private List<int[]> concatenations = new List<int[]>();
        public void SetStringConcatenation(List<int[]> concatenations)
        {
            this.concatenations = concatenations;
        }

        public void Export(string fileName)
        {
            if (headers.Count == 0) throw new Exception("Шапка не задана");
            if (values.Count == 0) throw new Exception("Данные не заданы");

            //из ресрусов получаем шрифт для кирилицы
            if (!File.Exists("TIMCYR.TTF"))
            {
                File.WriteAllBytes("TIMCYR.TTF", Properties.Resources.TIMCYR);
            }
            //открываем файл для работы
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            //создаем документ, задаем границы, связываем документ и поток
            Document doc = new Document();
            doc.SetMargins(0.5f, 0.5f, 0.5f, 0.5f);
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            BaseFont baseFont = BaseFont.CreateFont("TIMCYR.TTF", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            //вставляем таблицу, задаем количество столбцов, и ширину колонок
            var tableColumnsCount = headers.Count > values[0].Count ? headers.Count : values[0].Count;
            PdfPTable table = new PdfPTable(tableColumnsCount)
            {
                TotalWidth = 800F
            };
            var tableColumnsSize = 800F / tableColumnsCount;
            var sizes = new float[tableColumnsCount];
            for (int i = 0; i < tableColumnsCount; i++)
            {
                sizes[i] = tableColumnsSize;
            }
            table.SetTotalWidth(sizes);

            //вставляем шапку
            var fontForCellBold = new Font(baseFont, 10, Font.BOLD);
            for (int i = 0; i < tableColumnsCount; i++)
            {
                if (headers.Count > i)
                {
                    table.AddCell(new PdfPCell(new Phrase(headers[i], fontForCellBold))
                    {
                        HorizontalAlignment = Element.ALIGN_CENTER
                    });
                }
                else
                {
                    table.AddCell(new PdfPCell(new Phrase("", fontForCellBold))
                    {
                        HorizontalAlignment = Element.ALIGN_CENTER
                    });
                }
            }

            //заполняем таблицу
            PdfPCell cell = new PdfPCell();
            var fontForCells = new Font(baseFont, 10);
            List<int> indexesRowspan = new List<int>();
            List<int> countsRowspan = new List<int>();
            for (int i = 0; i < values.Count; i++)
            {
                for (int j = 0; j < tableColumnsCount; j++)
                {
                    if (j < values[i].Count)
                    {
                        cell = new PdfPCell(new Phrase(values[i][j], fontForCells));
                    }
                    else
                    {
                        cell = new PdfPCell(new Phrase("", fontForCells));
                    }

                    bool isAdd = true;
                    concatenations.ForEach(concatenation =>
                    {
                        if (concatenation[0] == i && concatenation[1] == j)
                        {
                            foreach (var index in indexesRowspan.FindAll(x => x == j))
                            {
                                if (index != -1 && countsRowspan[indexesRowspan.FindIndex(x => x == index)] != 0) return;
                            }
                            indexesRowspan.Add(concatenation[1]);
                            countsRowspan.Add(concatenation[2] - 1);
                            cell.Rowspan = concatenation[2];
                            table.AddCell(cell);
                            isAdd = false;
                        }
                    });

                    if (isAdd)
                    {
                        for (int k = 0; k < countsRowspan.Count; k++)
                        {
                            if (indexesRowspan[k] == j)
                            {
                                countsRowspan[k]--;
                                if (countsRowspan[k] <= 0)
                                {
                                    countsRowspan.RemoveAt(k);
                                    indexesRowspan.RemoveAt(k);
                                }
                                isAdd = false;
                            }
                        }
                    }

                    if (isAdd)
                    {
                        table.AddCell(cell);
                    }
                }
            }

            //вставляем таблицу
            doc.Add(table);
            doc.Close();
        }

        public PDFReport()
        {
            InitializeComponent();
        }

        public PDFReport(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}