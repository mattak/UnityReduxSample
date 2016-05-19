using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountComponent : MonoBehaviour, IRender
{
    public Button countUpButton;
    public Button countDownButton;
    public Text text;

    CountReducer reducer;

    void Start()
    {
        var store = Unidux.Instance.GetStore();
        countUpButton.onClick.AddListener(() =>
        {
            Debug.Log("countup");
            store.Dispatch(CountType.Increment);
        });
        countDownButton.onClick.AddListener(() =>
        {
            Debug.Log("countdown");
            store.Dispatch(CountType.Decrement);
        });

        reducer = new CountReducer();
        store.SubscribeReducer(reducer);
        store.SubscribeRender(this);
    }

    public void Render(IState _state)
    {
        var state = _state as State;
        Debug.Log("render: " + state.count);
        text.text = "" + state.count;
    }
}