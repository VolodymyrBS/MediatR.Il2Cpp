namespace MediatR.Il2Cpp
{
    public class HandlerStub
    {
        public static object MakeStub<TRequest, TResponse>()
            where TRequest : IRequest<TResponse>
        {
            return new MediatR.Internal.RequestHandlerWrapperImpl<TRequest,TResponse>();
        }
    }
}
