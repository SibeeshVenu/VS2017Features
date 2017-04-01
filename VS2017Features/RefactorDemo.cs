using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS2017Features
{
    public class RefactorDemo
    {
        private void ChangeObjectInitialize()
        {
            var cst = new Customer();
            cst.CustId = 1;
            cst.CustName = "CustName";
            cst.CustCode = "CST";

        }

        private string MakeStringConcat()
        {
            string strRefactor = "Welcome to this event, I am so happy to see you here. I hope you will like this event. It woulbe great if you can share some feedback. Will you do that?";
            return strRefactor;
        }

        private void InterpolatedString(string firstName, string lastName)
        {
            string customString = string.Format("My full name is '{0}' '{1}'", firstName, lastName);
        }

        private void ShowVarPreferencesBeforeAndAfter()
        {
            //var obj = new Customer();

            //Completion list when backspace or delete
        }

    }


}
