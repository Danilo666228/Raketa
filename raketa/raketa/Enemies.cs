using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raketa
{
    public class Enemies
    {
        public int Delta_N;
        public int N_generation;
        public int K_generation;
        public int N;
        public Bugs[] bugs = new Bugs[Form1.N_max];
    }
    public void New_Enemies(Form11 F)
    {
        N_generation = 10;
        Delta_N = Form1.N_max / N_generation;
        k_generation = 0;
        N = 0;
        for (int j = 0; j < Form1.N_max; j++)
            bugs[j] = new Bugs();
    }

}
