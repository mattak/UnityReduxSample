using UnityEngine;
using UnityEngine.UI;

public class CountActionButton : MonoBehaviour
{
    public CountAction Action;

    void Start()
    {
        var store = Unidux.Instance.GetStore();
        var button = GetComponent<Button>();
        button.onClick.AddListener(() => { store.Dispatch(Action); });
    }
}