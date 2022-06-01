using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WPFSpinner
{
    public partial class MyControl : UserControl
    {

        // Create a custom routed event by first registering a RoutedEventID 
        // This event uses the bubbling routing strategy 
        public static readonly RoutedEvent CustomTestEvent = EventManager.RegisterRoutedEvent("CustomTest", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(MyControl));

        // Provide CLR accessors for the event 
        public event RoutedEventHandler CustomTest
        {
            add { AddHandler(CustomTestEvent, value); }
            remove { RemoveHandler(CustomTestEvent, value); }
        }

        public static void RaiseMyEvent(Grid grid)
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(CustomTestEvent);
            grid.RaiseEvent(newEventArgs); // This change fixes the issue.
        }
    }
}
