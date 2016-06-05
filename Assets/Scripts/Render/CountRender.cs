using Unidux;
using UnityEngine;
using UnityEngine.UI;

public class CountRender : MonoBehaviour
{
    private Text text;

    void Start()
    {
        text = GetComponent<Text>();
        var store = Unidux.Unidux.Instance.Store;
        this.gameObject.AddTo(store, Render);

        Render(store.State);
    }

    public void Render(State state)
    {
        text.text = state.count.ToString();
    }
}
