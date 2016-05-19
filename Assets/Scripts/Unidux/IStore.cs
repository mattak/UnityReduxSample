public interface IStore<S>
{
    // TODO: return Subscription
    void SubscribeRender(IRender render);
    void SubscribeReducer<T>(IReducer<T> reducer);
    void Dispatch<A>(A action);
    void Update();
    S CreateState();
}
