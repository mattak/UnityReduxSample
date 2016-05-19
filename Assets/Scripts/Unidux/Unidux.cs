public class Unidux : SingletonMonoBehaviour<Unidux>
{
    private Store store;

    public IStore<State> GetStore()
    {
        if (store == null)
        {
            store = new Store();
        }

        return store;
    }

    void Update()
    {
        store.Update();
    }
}
