using Prism.Events;

namespace PersonalInventory.UI.Event
{
    public class AfterItemSavedEvent:PubSubEvent<AfterItemSavedEventArgs>
    {
    }
    public class AfterItemSavedEventArgs
    {
        public int Id { get; set; }

        public string DisplayMember { get; set; }
    }
}
