using Unidux;
using UnityEngine;

public class ReducerComponent : MonoBehaviour
{
    void Start()
    {
        var store = Unidux.Unidux.Instance.Store;
        this.gameObject.AddTo(store, CountReducer.Reduce);
    }
}
