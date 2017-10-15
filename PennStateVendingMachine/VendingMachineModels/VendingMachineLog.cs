using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineModels
{
    public class VendingMachineLogDTO
    {
        private int iD;
        private VendingMachineDTO vendingMachine;
        private DateTime dateTimeLogged;
        //private bool successful;

        public VendingMachineLogDTO()
        {

        }

        //, bool SuccessfulParam
        public VendingMachineLogDTO(int IDParam, DateTime DateTimeLoggedParam)
        {
            this.ID = IDParam;
            this.DateTimeLogged = DateTimeLoggedParam;
            //this.Successful = SuccessfulParam;
        }

        public VendingMachineDTO VendingMachine
        {
            get { return vendingMachine; }
            set { vendingMachine = value; }
        }

        //public bool Successful
        //{
        //    get { return successful; }
        //    set { successful = value; }
        //}

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
