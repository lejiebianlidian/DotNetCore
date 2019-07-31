namespace Service
{
    /// <summary>
    /// 一个接口多个实现注入方式Demo
    /// </summary>
    public class WxPayService:IPayService
    {
        public string Pay()
        {
            return "微信支付";
        }
    }
}