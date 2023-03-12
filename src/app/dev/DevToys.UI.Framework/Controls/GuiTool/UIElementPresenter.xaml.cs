﻿using DevToys.Api;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace DevToys.UI.Framework.Controls.GuiTool;

public sealed partial class UIElementPresenter : Control
{
    internal static UIElementPresenter Create(IUIElement element)
    {
        return new()
        {
            UIElement = element
        };
    }

    public UIElementPresenter()
    {
        InitializeComponent();
    }

    public static readonly DependencyProperty UIElementProperty =
        DependencyProperty.Register(
            nameof(UIElement),
            typeof(IUIElement),
            typeof(UIElementPresenter),
            new PropertyMetadata(null));

    public IUIElement UIElement
    {
        get => (IUIElement)GetValue(UIElementProperty);
        set => SetValue(UIElementProperty, value);
    }
}