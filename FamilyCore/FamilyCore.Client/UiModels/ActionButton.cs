using FamilyCore.Client.Components.Widget.Buttons;
using FamilyCore.Client.Enumerations;

namespace FamilyCore.Client.UiModels;

public class ActionButton
{
    public string? Title { get; set; }
    public Action? Delegate { get; set; }
    public string? ToolTip { get; set; }
    public string? Icon { get; set; }
    public ThemeColor Color { get; set; }
    public ButtonVariant Variant { get; set; }
}