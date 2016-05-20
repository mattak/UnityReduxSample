using System.Collections.Generic;

public class Store : IStore<State>
{
    private IList<IRender> renderList;
    private IList<object> reducerList;
    private State state = new State();
    private bool changed;

    public Store()
    {
        this.renderList = new List<IRender>();
        this.reducerList = new List<object>();
        this.changed = false;
    }

    public void SubscribeRender(IRender render)
    {
        renderList.Add(render);
    }

    public void SubscribeReducer<T>(IReducer<T> reducer)
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
            render.Render();
        }
    }

    public State CreateState()
    {
        return new State();
    }

    public State GetState()
    {
        return state;
    }
}