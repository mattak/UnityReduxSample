using Unidux;
using UnityEngine;
using UnityEngine.UI;

public class MixinCounter : MonoBehaviour
{
    public Button countUpButton;
    public Button countDownButton;
    public Text text;

    void Start()
    {
        var store = Unidux.Unidux.Instance.Store;
        countUpButton.onClick.AddListener(() => { store.Dispatch(CountAction.Increment); });
        countDownButton.onClick.AddListener(() => { store.Dispatch(CountAction.Decrement); });
        this.gameObject.AddTo(store, Render);
        this.gameObject.AddTo(store, CountReducer.Reduce);
    }

    public void Render(State state)
    {
        text.text = state.count.ToString();
    }
}
