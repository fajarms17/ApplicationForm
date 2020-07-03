using Application.DataModel;
using ApplicationForm.ViewModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForm.DataAccess
{
    public class ApplicationRepo
    {
        public static List<ApplicationViewModel> EducationList()
        {
            List<ApplicationViewModel> result = new List<ApplicationViewModel>();
            using (var db = new Context())
            {
                result = (from c in db.tbl_education

                          select new ApplicationViewModel
                          {
                              Id_education=c.id,
                              Last_education=c.last_education


                          }).ToList();

            }
            return result;
        }

    }
}
