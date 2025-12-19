namespace ChainResponsibility.homework;

public class AuthHandler: BaseHandler
{
    public override void Handle(Request request)
    {
        if (request.User != null)
        {
            Console.WriteLine("[Auth] User authenticated");
            base.Handle(request);  // 인증이 성공했을 때만 넘어가도록
        }
        else
        {
            Console.WriteLine("[Auth] User not authenticated");
        }
    }
}