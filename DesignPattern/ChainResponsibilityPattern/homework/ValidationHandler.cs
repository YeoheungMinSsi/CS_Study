namespace ChainResponsibility.homework;

public class ValidationHandler: BaseHandler
{
    public override void Handle(Request request)
    {
        if (request.Body != null)
        {
            Console.WriteLine("[Validation] Request data valid");
            base.Handle(request);  // 인증이 성공했을 때만 넘어가도록
        }
        else
        {
            Console.WriteLine("[Validation] Request data not invalid");
        }
    }
}