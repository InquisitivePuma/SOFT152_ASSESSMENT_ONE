using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Months_and_years
{
    class Utils
    // FAIR WARNING: I CODED THIS MESS WHILE ON STRONG PAINKILLERS. I PROBABLY WONT REMEMBER WHAT I WAS THINKING WHILE DOING SO. LORD HELP US ALL. IM GOING TO WRITE CODE NOW.
    {
        private Utils()
        {

        } // This is a utility class. Do not instantiate it.

        public static int SearchDataGridView(string searchTerm, System.Windows.Forms.DataGridView view)
        {
            int fail = -1;
            searchTerm = searchTerm.ToUpper();
            var rows = view.Rows; //Fuck microsoft. This is an array and noone can tell me otherwise.
            String[] firstCollumnValues = new String[rows.Count]; 
            for (int i = 0; i < rows.Count; i++)
            {
                firstCollumnValues[i] = Convert.ToString(rows[i].Cells[0].Value);
                firstCollumnValues[i] = firstCollumnValues[i].ToUpper();
            } //See, I made it into an array. Booyah.

            for (int i = 0; i < firstCollumnValues.Length; i++)
            {
                if (firstCollumnValues[i] == searchTerm)
                {
                    return i;
                }
            }

            return fail;
        } // Linear search of the first collumn. Not case sensitive. Slow and boring.

        
    }
}
