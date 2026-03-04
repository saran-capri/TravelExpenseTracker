using System;
using System.Runtime.CompilerServices;

namespace TravelExpenseTracker.Controls;

public class BorderlessEntry : Entry
{
    protected override void OnHandlerChanged()
    {
        base.OnHandlerChanged();

        RemoveUnderline();
    }
    protected override void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        base.OnPropertyChanged(propertyName);

        if(propertyName == nameof(BackgroundColor))
        {
            RemoveUnderline();
        }
    }
    private void RemoveUnderline()
    {
    #if ANDROID
            if(Handler is IEntryHandler entryhandler)
            {
                if(BackgroundColor== null)
                {
                    entryHandler.PlatformView.BackgroundTintList = 
                        ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
                }
                else
                {
                     entryHandler.PlatformView.BackgroundTintList = 
                        ColorStateList.ValueOf(BackgroundColor.ToPlatform());                   
                }

            }
    #endif 
    }
}
