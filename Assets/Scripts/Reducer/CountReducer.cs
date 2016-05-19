public class CountReducer : IReducer<CountType>
{
    public State Reduce(State state, CountType action)
    {
        switch (action)
        {
            case CountType.Increment:
                state.count += 1;
                break;
            case CountType.Decrement:
                state.count -= 1;
                break;
        }

        return state;
    }
}