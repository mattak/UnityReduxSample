using UnityEngine;
using UnityEngine.UI;
using Unidux;

public class CountComponent : MonoBehaviour
{
    public Button countUpButton;
    public Button countDownButton;
    public Text text;

    void Start()
    {
        var store = Unidux.Unidux.Instance.Store;
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

        this.gameObject.AddTo(store, Render);
        this.gameObject.AddTo(store, CountReducer.Reduce);
    }

    public void Render(State state)
    {
        Debug.Log("render: " + state.count);
        text.text = "" + state.count;
    }
}
