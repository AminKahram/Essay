using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Services.BaseServiceModel
{
    public  class OperationResult
    {
        public int RecordID { get;private set; }
        public OperationState.CurrentState CurrentState { get; private set; }
        public string Message { get; private set; }
        public bool Succes { get; private set; }
        public DateTime DateTime { get; private set; }
        public OperationResult(OperationState.CurrentState CurrentState)
        {
            this.CurrentState = CurrentState;
            this.Succes = false;
            this.DateTime = DateTime.Now;
        }
        public OperationResult(int RecordID,OperationState.CurrentState CurrentState)
        {
            this.RecordID = RecordID;
            this.CurrentState = CurrentState;
            this.Succes = false;
            this.DateTime = DateTime.Now;
        }
        public OperationResult Succeeded(string Message)
        {
            this.Succes = true;
            this.Message = Message;
            return this;
        }
        public OperationResult Succeeded(int RecordID,string Message)
        {
            this.RecordID = RecordID;
            this.Succes = true;
            this.Message = Message;
            return this;
        }
        public OperationResult Failed(string Message)
        {
            this.Succes = false;
            this.Message = Message;
            return this;
        }
    }
}
