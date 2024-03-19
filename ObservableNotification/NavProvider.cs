using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ObservableNotification;

public record NavItem(string Name, string Url);

public class NavProvider
{
    public BindingList<NavItem> Items { get; } = [];
}