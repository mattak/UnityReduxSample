using UnityEngine;
using UnityEngine.UI;

public class MixinCounter : MonoBehaviour, IRender
{
    public Button countUpButton;
    public Button countDownButton;
    public Text text;
    private CountReducer reducer;

    void Start()
    {
        var store = Unidux.Instance.GetStore();
        countUpButton.onClick.AddListener(() => { store.Dispatch(CountAction.Increment); });
        countDownButton.onClick.AddListener(() => { store.Dispatch(CountAction.Decrement); });

        reducer = new CountReducer();
        store.SubscribeReducer(reducer);
        store.SubscribeRender(this);
    }

    public void Render()
    {
        var store = Unidux.Instance.GetStore();
        text.text = store.GetState().count.ToString();
    }
}