using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppVS2017
{
   public class RefractorDemo
    {
        private void ChangeObjectInitialize()
        {
            Customer cst = new Customer()
            {
                CustId = 1,
                CustName = "CustName",
                CustCode = "CST"
            };

        }

        private void MakeStringConcat()
        {
            var strREfactor = "Welcome to this event, I am so happy to see you here. I hope you will like this event. It woulbe great if you can share some feedback. Will you do that?";
            strREfactor = strREfactor + "";            
        }

        private void ShowVarPreferencesBeforeAndAfter()
        {
            //var obj = Customer();
        }
        
    }


}
