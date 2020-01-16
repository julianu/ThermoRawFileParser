using System;
using System.Collections;

namespace ThermoRawFileParser.Query
{
    public class QueryExecutor
    {
        public QueryExecutor()
        {
            
        }
        
        
        public HashSet<int> ParseRange(String text)
        {
            if (text.Length == 0) return null;
            foreach (char c in text)
            {
                int ic = (int)c;
                if (!((ic == (int)',') || (ic == (int)'-') || (ic == (int)' ') || ('0' <= ic && ic <= '9')))
                {
                    return null;
                }
            }
            
            string[] tokens = text.Split(new char[]{','}, StringSplitOptions.None);
            
            HashSet<int> carbonCounts = new HashSet<int>();
            
            for (int i = 0; i < tokens.Length; ++i)
            {
                if (tokens[i].Length == 0) return null;
                string[] rangeBoundaries = tokens[i].Split(new char[]{'-'}, StringSplitOptions.None);
                if (rangeBoundaries.Length == 1)
                {
                    int rangeStart = 0;
                    try 
                    {
                        rangeStart = Convert.ToInt32(rangeBoundaries[0]);
                    }
                    catch (Exception e)
                    {
                        return null;
                    }
                    if (oddEven == 0 || (oddEven == 1 && (rangeStart % 2 == 1)) || (oddEven == 2 && (rangeStart % 2 == carbonCounts.Add(rangeStart);
                }
                else if (rangeBoundaries.Length == 2)
                {
                    int rangeStart = 0;
                    int rangeEnd = 0;
                    try 
                    {
                        rangeStart = Convert.ToInt32(rangeBoundaries[0]);
                        rangeEnd = Convert.ToInt32(rangeBoundaries[1]);
                    }
                    catch (Exception e)
                    {
                        return null;
                    }
                    for (int l = rangeStart; l <= rangeEnd; ++l)
                    {
                        carbonCounts.Add(l);
                    }
                }
                else return null;
            }
            return carbonCounts;
        }
    }
}