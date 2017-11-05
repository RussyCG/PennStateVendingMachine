using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineModels.DTOs;
using VendingMachineModels.DTOs.Base;

namespace VendingMachineModels.Connection
{
    /// <summary>
    /// Used to force the api to check the session credentials
    /// </summary>
    public class VMRequest
    {
        #region Fields

        // Session ID of the user requesting to use the WebAPI
        private string sessionID;
        // model for which an action must be performed on
        private BaseModel decisionModel;
        // ID for get methods
        private string id;

        #endregion

        #region Constructors

        public VMRequest()
        {

        }

        public VMRequest(string SessionIDParam)
        {
            NullifyAll();
            this.SessionID = SessionIDParam;
        }

        public VMRequest(string SessionIDParam, BaseModel DecisionModelParam)
        {
            NullifyAll();
            this.SessionID = SessionIDParam;
            this.DecisionModel = DecisionModelParam;
        }

        public VMRequest(string SessionIDParam, string IDParam)
        {
            NullifyAll();
            this.SessionID = SessionIDParam;
            this.ID = IDParam;
        }

        #endregion

        #region Properties

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public BaseModel DecisionModel
        {
            get { return decisionModel; }
            set { decisionModel = value; }
        }

        public string SessionID
        {
            get { return sessionID; }
            set { sessionID = value; }
        }

        #endregion

        #region Methods

        private void NullifyAll()
        {
            this.SessionID = null;
            this.DecisionModel = null;
            this.ID = null;
        }

        #endregion
    }
}
