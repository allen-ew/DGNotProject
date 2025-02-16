using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DgNotification.Shared.Helpers
{
    public class clsOperationResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

        private clsOperationResult (bool prmSucess, string prmMessage, object prmData = null)
        {
            Success = prmSucess;
            Message = prmMessage;
            Data = prmData;
        }
        
        public static clsOperationResult SuccessResult(string prmMessage,object prmData = null)
        {
            return new clsOperationResult(true, prmMessage, prmData);
        }
        public static clsOperationResult FailureResult(string prmMessage, object prmData = null)
        {
            return new clsOperationResult(false, prmMessage, prmData);
        }
    }
}
