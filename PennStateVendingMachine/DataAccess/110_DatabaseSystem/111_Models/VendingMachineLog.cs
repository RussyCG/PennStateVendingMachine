using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess._110_DatabaseSystem._111_Models
{
    public class VendingMachineLog
    {
        private int iD;
        private VendingMachine vendingMachine;
        private DateTime dateTimeLogged;
        private bool successful;

        public VendingMachineLog()
        {

        }

        public VendingMachineLog(int IDParam, DateTime DateTimeLoggedParam, bool SuccessfulParam)
        {
            this.ID = IDParam;
            this.DateTimeLogged = DateTimeLoggedParam;
            this.Successful = SuccessfulParam;
        }

        public VendingMachine VendingMachine
        {
            get { return vendingMachine; }
            set { vendingMachine = value; }
        }

        public bool Successful
        {
            get { return successful; }
            set { successful = value; }
        }

        public DateTime DateTimeLogged
        {
            get { return dateTimeLogged; }
            set { dateTimeLogged = value; }
        }

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

    }
}
