using Unidux;

public static class CountReducer
{
    public static State Reduce(State state, object action)
    {
        if (action is CountType)
        {
            switch ((CountType)action)
            {
                case CountType.Increment:
                    state.count += 1;
                    break;
                case CountType.Decrement:
                    state.count -= 1;
                    break;
            }
        }

        return state;
    }
}
