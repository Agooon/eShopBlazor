using eShop.UseCases.PluginInterfaces.StateStore;
using System;

namespace eShop.StateStore.DI
{
    public class StateStoreBase : IStateStore
    {
        protected Action listeners;
        public void AddStateChangeListeners(Action listener)
        {
            listeners += listener;
        }

        public void RemoveStateChangeListeners(Action listener)
        {
            listeners -= listeners;
        }

        public void BroadCastStateChange()
        {
            if (listeners != null)
                this.listeners.Invoke();
        }
    }
}
