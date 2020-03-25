using System.Collections.Generic;

namespace Timer
{
    class AbstractNotifier
    {
        // the list of services to be sent notifications
        private ICollection<INotificationListener> listeners;

        // constructor
        public AbstractNotifier()
        {
            // start with an empty list of services
            listeners = new List<INotificationListener>();
        }

        // register a message service
        public void Attach(INotificationListener listener)
        {
            listeners.Add(listener);
        }

        // de-register a message service
        public void Detach(INotificationListener listener)
        {
            listeners.Remove(listener);
        }

        // notify all listeners
        protected void Notify()
        {
            foreach (INotificationListener listener in listeners)
            {
                listener.Update();
            }
        }
    }
}
