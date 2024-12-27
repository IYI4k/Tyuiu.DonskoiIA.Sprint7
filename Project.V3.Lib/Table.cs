namespace Project.V3.Lib
{
    public class Table
    {
        string[,] table;

        double[] tempArray;

        string[,] temp_table;
        
        Dictionary<string, int> keys = new Dictionary<string, int> { };

        string[] tableTypes;
        public int LoadTable(string path)
        {
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    int tableWidthLength = 0, tableHeigthLength = 0;
                    string line;
                    if ((line = reader.ReadLine()) != null)
                    {
                        string[] TempLine = line.Split(';');
                        tableWidthLength = Convert.ToInt32(TempLine.GetUpperBound(0)) + 1;
                        tableTypes = new string[tableWidthLength];
                        line = reader.ReadLine();
                    }
                    
                    while ((line = reader.ReadLine()) != null)
                    {
                        tableHeigthLength++;
                    }
                    table = new string[tableHeigthLength, tableWidthLength];
                }

                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    if ((line = reader.ReadLine()) != null)
                    {
                        string[] TempLine = line.Split(';');
                        for (int i = 0; i < TempLine.GetUpperBound(0) + 1; i++)
                        {
                            keys.Add(TempLine[i], i);
                        }
                    }

                    if ((line = reader.ReadLine()) != null)
                    {
                        string[] TempLine = line.Split(';');
                        for (int i = 0; i < TempLine.GetUpperBound(0) + 1; i++)
                        {
                            tableTypes[i] = TempLine[i];
                        }
                    }

                    int pos = 0;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] TempLine = line.Split(';');
                        for (int i = 0; i < TempLine.GetUpperBound(0) + 1; i++)
                        {
                            table[pos, i] = TempLine[i];
                        }
                        pos++;
                    }
                }

                return 0;
            }
            catch
            {
                return 1;
            }
        }
        
        public string[,] GetTable()
        {
            return table;
        }
        
        public string[] GetBy(string key)
        {
            string[] OutArr = new string[table.GetUpperBound(0) + 1];

            int index = keys[key];

            for (int i = 0; i < table.GetUpperBound(0) + 1; i++)
            {
                OutArr[i] = table[i, index];
            }

            return OutArr;
        }
        
        public string[,] DelColumn(string key)
        {
            string[,] TempTable = new string[table.GetUpperBound(0) + 1, table.GetUpperBound(1)];

            int index = keys[key];

            for (int i = 0; i < index; i++)
            {
                for (int j = 0; j < table.GetUpperBound(0) + 1; j++)
                {
                    TempTable[j, i] = table[j, i];
                }
            }

            for (int i = index + 1; i < table.GetUpperBound(1) + 1; i++)
            {
                int pos = i - 1;
                for (int j = 0; j < table.GetUpperBound(0) + 1; j++)
                {
                    TempTable[j, pos] = table[j, i];
                }
            }

            table = TempTable;

            return table;
        }
        
        public string[,] DelLine(int index)
        {
            string[,] TempTable = new string[table.GetUpperBound(0), table.GetUpperBound(1) + 1];

            for (int i = 0; i < index; i++)
            {
                for (int j = 0; j < table.GetUpperBound(1) + 1; j++)
                {
                    TempTable[i, j] = table[i, j];
                }
            }

            for (int i = index + 1; i < table.GetUpperBound(0) + 1; i++)
            {
                int pos = i - 1;
                for (int j = 0; j < table.GetUpperBound(1) + 1; j++)
                {
                    TempTable[pos, j] = table[i, j];
                }
            }

            table = TempTable;

            return table;
        }
        
        public string[,] AddLine(string NewLine)
        {
            string[,] TempTable = new string[table.GetUpperBound(0) + 2, table.GetUpperBound(1) + 1];

            for (int i = 0; i < table.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < table.GetUpperBound(1) + 1; j++)
                {
                    TempTable[i, j] = table[i, j];
                }
            }

            string[] Splited_NewLine = NewLine.Split(';');

            for (int i = 0; i < TempTable.GetUpperBound(1) + 1; i++)
            {
                TempTable[TempTable.GetUpperBound(0), i] = Splited_NewLine[i];
            }

            table = TempTable;

            return table;
        }
        
        public string[,] ChangeCell(int line, int column, string NewString)
        {
            table[line,column] = NewString;

            return table;
        }
        
        private bool sort_string(int left, int right, int column)
        {
            if (left == right)
            {
                return false;
            }

            int middle = (left + right) / 2;

            sort_string(left, middle, column);
            sort_string(middle + 1, right, column);

            right++;
            int pos = left;
            int l = left;
            middle++;
            int r = middle;

            while (l < middle && r < right)
            {
                if (String.Compare(table[l, column], table[r, column]) < 0)
                {
                    for (int i = 0; i < table.GetUpperBound(1) + 1; i++)
                    {
                        temp_table[pos, i] = table[l, i];
                    }
                    pos++;
                    l++;
                }
                else
                {
                    for (int i = 0; i < table.GetUpperBound(1) + 1; i++)
                    {
                        temp_table[pos, i] = table[r, i];
                    }
                    pos++;
                    r++;
                }
            }

            while (l < middle)
            {
                for (int i = 0; i < table.GetUpperBound(1) + 1; i++)
                {
                    temp_table[pos, i] = table[l, i];
                }
                pos++;
                l++;
            }

            while (r < right)
            {
                for (int i = 0; i < table.GetUpperBound(1) + 1; i++)
                {
                    temp_table[pos, i] = table[r, i];
                }
                pos++;
                r++;
            }

            for (int i = left; i < right; i++)
            {
                for (int j = 0; j < table.GetUpperBound(1) + 1; j++)
                {
                    table[i, j] = temp_table[i, j];
                }
            }

            return true;
        }
        
        private bool sort_number(int left, int right, int column)
        {
            if (left == right)
            {
                return false;
            }

            int middle = (left + right) / 2;

            sort_number(left, middle, column);
            sort_number(middle + 1, right, column);

            right++;
            int pos = left;
            int l = left;
            middle++;
            int r = middle;

            while (l < middle && r < right)
            {
                if (tempArray[l] < tempArray[r])
                {
                    for (int i = 0; i < table.GetUpperBound(1) + 1; i++)
                    {
                        temp_table[pos, i] = table[l, i];
                    }
                    pos++;
                    l++;
                }
                else
                {
                    for (int i = 0; i < table.GetUpperBound(1) + 1; i++)
                    {
                        temp_table[pos, i] = table[r, i];
                    }
                    pos++;
                    r++;
                }
            }

            while (l < middle)
            {
                for (int i = 0; i < table.GetUpperBound(1) + 1; i++)
                {
                    temp_table[pos, i] = table[l, i];
                }
                pos++;
                l++;
            }

            while (r < right)
            {
                for (int i = 0; i < table.GetUpperBound(1) + 1; i++)
                {
                    temp_table[pos, i] = table[r, i];
                }
                pos++;
                r++;
            }

            for (int i = left; i < right; i++)
            {
                for (int j = 0; j < table.GetUpperBound(1) + 1; j++)
                {
                    table[i, j] = temp_table[i, j];
                }
            }

            return true;
        }
        
        public string[,] SortBy(string key, bool PoVozrostaniy)
        {
            temp_table = new string[table.GetUpperBound(0) + 1, table.GetUpperBound(1) + 1];

            int column = keys[key];

            string tempType = tableTypes[column];

            if (tempType == "string")
            {
                sort_string(0, table.GetUpperBound(0), column);
            }
            else if (tempType == "number")
            {
                tempArray = new double[table.GetUpperBound(0) + 1];

                for (int i = 0; i < table.GetUpperBound(0) + 1; i++)
                {
                    tempArray[i] = Convert.ToDouble(table[i, column]);
                }

                sort_number(0, table.GetUpperBound(0), column);
            }

            if (PoVozrostaniy == false)
            {
                int pos = 0;
                for (int i = table.GetUpperBound(0); i > -1; i--)
                {
                    for (int j = 0; j < table.GetUpperBound(1)+1; j++)
                    {
                        temp_table[pos, j] = table[i, j];
                    }

                    pos++;
                }
                table = temp_table;
            }

            return table;
        }

        public string[,] Search(string Words)
        {
            int[] LinesNumbers = new int[table.GetUpperBound(0) + 1];

            int LinesCount = 0;

            for (int i = 0; i < table.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < table.GetUpperBound(1) + 1; j++)
                {
                    if (table[i, j].Contains(Words)) {
                        LinesNumbers[LinesCount++] = i;
                    }
                }
            }

            temp_table = new string[LinesNumbers.Length, table.GetUpperBound(1) + 1];

            for (int i = 0; i < LinesCount; i++)
            {
                for (int j = 0; j < table.GetUpperBound(1) + 1; j++)
                {
                    temp_table[i, j] = table[LinesNumbers[i], j];
                }
            }

            table = temp_table;

            return table;
        }

        public Dictionary<string, int> ChartCount(string legend)
        {
            int legend_Column = keys[legend];

            Dictionary<string, int> result = new Dictionary<string, int>();

            for (int i = 0; i < table.GetUpperBound(0) + 1; i++)
            {
                result.TryAdd(table[i, legend_Column], 0);
                result[table[i, legend_Column]]++;
            }

            return result;
        }

        public Dictionary<string, double> ChartSum(string legend, string value)
        {
            int legend_Column = keys[legend];
            int value_Column = keys[value];

            Dictionary<string, double> result = new Dictionary<string, double>();

            for (int i = 0; i < table.GetUpperBound(0) + 1; i++)
            {
                result.TryAdd(table[i, legend_Column], 0);
                result[table[i, legend_Column]] += Convert.ToDouble(table[i, value_Column]);
            }

            return result;
        }

        public int GetFirstLength()
        {
            return table.GetUpperBound(0) + 1;
        }
        
        public int GetSecondLength()
        {
            return table.GetUpperBound(1) + 1;
        }

        public string[] GetKeys()
        {
            string[] result = new string[keys.Count()];

            int pos = 0;

            foreach (var (key, value) in keys)
            {
                result[pos++] = key;
            }

            return result;
        }

        public string GetType(int Column)
        {
            return tableTypes[Column];
        }

        public string[] GetTypes()
        {
            return tableTypes;
        }

        public void ReplaceTable(string[,] newtable)
        {
            table = new string[newtable.GetUpperBound(0) + 1, newtable.GetUpperBound(1) + 1];
            for (int i = 0; i < table.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < table.GetUpperBound(1) + 1; j++)
                {
                    table[i, j] = newtable[i, j];
                }
            }
        }
    }
}
