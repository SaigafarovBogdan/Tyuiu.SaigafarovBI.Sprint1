using System.Windows.Markup;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SaigafarovBI.Sprint1.Task6.V10.Lib
{
    public class DataService : ISprint1Task6V10
    {
        public string DeleteMiddleLetter(string value)
        {
            string res = "";
            if (value[0] == ' ')
            {
                res += ' ';
                value = value.Substring(1);
            }
            
            while(value.Length != 0)
            {
                int ind = value.IndexOf(' ');
                int delta = ind != -1 ? -1 : 0;
                if (ind != -1)
                {
                    ind += 1;
                }
                else
                {
                    ind = value.Length;
                } 
                string temp = value[0..ind];
                if ((temp.Length - delta) % 2 != 0)
                {
                    temp = temp.Substring(0, Convert.ToInt32(Math.Floor((temp.Length - 1) / 2.0))) + temp.Substring(Convert.ToInt32(Math.Floor((temp.Length - 1) / 2.0)) + 1);
                }
                res += temp;
                value = value.Substring(ind);
            }
            return res;
        }
    }
}
