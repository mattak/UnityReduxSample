using UnityEngine;
using UnityEngine.UI;

public class CountActionButton : MonoBehaviour
{
    public CountAction Action;

    void Start()
    {
        var store = Unidux.Unidux.Instance.Store;
        var button = GetComponent<Button>();
        button.onClick.AddListener(() => { store.Dispatch(Action); });
    }
}
