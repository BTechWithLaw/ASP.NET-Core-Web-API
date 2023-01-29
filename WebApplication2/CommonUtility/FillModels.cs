
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.CommonUtility
{
    public static class FillModels
    {

        //int 
        //string 
        public static List<EmployeeModel> FillModel()
        {
            //In Memory Data
            //Going FWD will replace this with Data thet is catching from Data Base
            List<EmployeeModel> list = new List<EmployeeModel>()
            {
                new EmployeeModel()
                {
                    EmployeeID=1001,
                    EmployeeName="Vamshi Krishna Bandi",
                    EmailID="bandi.vamshi408@gmail.com",
                    PhoneNo="9999999999"
                },
                new EmployeeModel()
                {
                    EmployeeID=1002,
                    EmployeeName="Rajesh Bandi",
                    EmailID="rajeshbandy@gmail.com",
                    PhoneNo="9999999999"
                },
                new EmployeeModel()
                {
                    EmployeeID=1003,
                    EmployeeName="Gowthami Bandi",
                    EmailID="bandi.gowthami@gmail.com",
                    PhoneNo="9999999999"
                }
            };
            return list;
        }
    }
}
