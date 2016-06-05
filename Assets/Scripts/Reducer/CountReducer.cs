using Unidux;

public static class CountReducer
{
    public static State Reduce(State state, object action)
    {
        if (action is CountAction)
        {
            switch ((CountAction)action)
            {
                case CountAction.Increment:
                    state.count += 1;
                    break;
                case CountAction.Decrement:
                    state.count -= 1;
                    break;
            }
        }

        return state;
    }
}
