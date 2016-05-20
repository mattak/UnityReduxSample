using UnityEngine;
using UnityEngine.UI;

public class CountRender : MonoBehaviour, IRender
{
    private Text text;
    private Store store;

    void Start()
    {
        text = GetComponent<Text>();
        store = Unidux.Instance.GetStore() as Store;
        store.SubscribeRender(this);

        Render();
    }

    public void Render()
    {
        text.text = store.GetState().count.ToString();
    }
}