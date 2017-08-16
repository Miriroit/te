using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Logic
    {
        List<int> items;
        Dictionary<int, List<int>> dictionary;

        public Logic(List<int> l)
        {

            int temp;
            this.items = l;
            dictionary =
             new Dictionary<int, List<int>>();
            for (int i = 0; i < items.Count; i++)
            {
                temp = l[i];
                List<int> list = new List<int>();
                if (dictionary.ContainsKey(temp))
                {
                    list = dictionary[temp];
                }

                list.Add(i);
                dictionary[temp] = list;
            }
        }

        public int getNewPostion(int pos)
        {
            if (pos < 0)
            {
                throw new System.ArgumentException("Parameter cannot be smaller than 0", "original");
            }
            else
            {
                List<int> resList = new List<int>();
                int temp = items[pos];


                if (dictionary.ContainsKey(temp))
                {
                    resList = dictionary[temp];
                    for (int i = 0; i < resList.Count - 1; i++)
                    {
                        if (resList[i] == pos)
                        {
                            return resList[i + 1];
                        }
                    }

                }






            }
            // throw new System.ArgumentException("invalid result", "original");
            return -1;
        }







    }
}
