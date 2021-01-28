﻿#nullable enable

using Avalonia.Controls.Primitives;

namespace Avalonia.Controls.Automation.Peers
{
    public class ToggleButtonAutomationPeer : ButtonAutomationPeer, IToggleableAutomationPeer
    {
        public ToggleButtonAutomationPeer(Control owner, AutomationRole role = AutomationRole.Toggle)
            : base(owner, role)
        {
        }

        bool? IToggleableAutomationPeer.GetToggleState() => Owner.GetValue(ToggleButton.IsCheckedProperty);
        void IToggleableAutomationPeer.Toggle() => Invoke();
    }
}