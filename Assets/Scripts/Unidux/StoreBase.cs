using System.Collections.Generic;

public class StoreBase {}
/*
public abstract class StoreBase<T>: IStore<T> {
    private IList<IRender> renderList;
    private IList<object> reducerList;
    private T state;
    private bool changed;

    public StoreBase()
    {
        this.renderList = new List<IRender>();
        this.reducerList = new List<object>();
        this.changed = false;
        this.state = CreateState();
    }

    public void SubscribeRender(IRender render)
    {
        renderList.Add(render);
    }

    public void SubscribeReducer<S,T>(IReducer<T> reducer)
    {
        reducerList.Add(reducer);
    }

    public void Dispatch<A>(A action)
    {
        foreach (var _reducer in reducerList)
        {
            if (_reducer is IReducer<A>)
            {
                var reducer = _reducer as IReducer<A>;
                state = reducer.Reduce(state, action);
                changed = true;
            }
        }
    }

    public void Update()
    {
        if (!changed)
        {
            return;
        }

        changed = false;

        foreach (var render in renderList)
        {
            render.Render(state);
        }
    }

    public abstract T CreateState();
}
*/
