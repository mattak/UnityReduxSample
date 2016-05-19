public interface IReducer<T>
{
    State Reduce(State state, T action);
}
