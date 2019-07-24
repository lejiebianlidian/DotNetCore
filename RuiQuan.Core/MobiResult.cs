namespace RuiQuan.Core
{
    public class MobiResult
    {
        private int results = 0;
        public MobiResult(int returnValue)
        {
            if (returnValue==1)
            {
                code = returnValue;
                msg = "";
                result = "";
            }
            
            
        }

        public int code { get; set; }

        public string msg { get; set; }

        public dynamic result { get; set; } 

    }
}