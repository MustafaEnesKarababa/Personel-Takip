using BusinessLayer.EntitiesBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ContextBL
{
    public class ProjeContextBL
    {
        public ProjeContextBL()
        {
            DepartmanBL = new DepartmanBL();
            LoginBL = new LoginBL();
            PersonelBL = new PersonelBL();
            YetkiliBL = new YetkiliBL();
        }
        public DepartmanBL DepartmanBL { get; set; }
        public LoginBL LoginBL { get; set; }
        public PersonelBL PersonelBL { get; set; }
        public YetkiliBL YetkiliBL { get; set; }
    }
}
