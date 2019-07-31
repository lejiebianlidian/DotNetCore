namespace Service
{
    /// <summary>
    /// 一个接口多个实现注入方式Demo
    /// </summary>
    public class AliPayService : IPayService
    {
        public string Pay()
        {
            return "支付宝支付";
        }
    }
}