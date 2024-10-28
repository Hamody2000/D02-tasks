using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskD02
{
    public class Complex
    {

        int real;
        int img;


        public int Real
        {
            get
            {
                return real;
            }

            set
            {
                real = value;
            }
        }

        public int Img
        {
            get
            {
                return img;
            }

            set
            {
                img = value;
            }
        }




        #region Print

        public override string ToString()
        {
            if (real == 0)
            {
                if (img == 0)
                {
                    return $"0";
                }else if (img == -1)
                {
                    return "-i";
                }else if (img == 1)
                {
                    return "i";
                }
                return $"{img}i";
            }
            else if (img == -1)
            {
                return $"{real}-i";
            }
            else if (img < 0)
            {
                return $"{real}{img}i";
            }
            else if (img == 0 )
            {
                return $"{real}";

            }else if (img == 1)
            {
                return $"{real}+i";

            }
            else
            {
                return $"{real}+{img}i";

            }

        }


        #endregion

    }
}
