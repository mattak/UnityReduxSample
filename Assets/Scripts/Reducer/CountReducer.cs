using UnityEngine;

public class CountReducer : MonoBehaviour, IReducer<CountAction>
{
    void Start()
    {
        var store = Unidux.Instance.GetStore();
        store.SubscribeReducer(this);
    }

    public State Reduce(State state, CountAction action)
    {
        switch (action)
        {
            case CountAction.Increment:
                state.count += 1;
                break;
            case CountAction.Decrement:
                state.count -= 1;
                break;
        }

        return state;
    }
}