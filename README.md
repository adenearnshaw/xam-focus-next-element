# Xamarin Forms: Focus next element sample

Here is a simple Xamarin Forms sample app that demonstrates how you can attach a behavior to an Entry element and move the focus to another element when the user clicks enter on the keyboard.

## Using the behavior

Give the element you wish to focus on a name:

```xml
<Entry x:Name="Entry2" Placeholder="Field 2"/>
```

On the element you wish to navigate from, add the behavior and add a reference to the named element.

```xml
<Entry Placeholder="Field 1">
    <Entry.Behaviors>
        <behaviors:SetFocusOnEntryCompletedBehavior  TargetElement="{x:Reference Entry2}" />
    </Entry.Behaviors>
</Entry>
```

When the user presses enter whilst on "Field 1", then focus will moved to "Field 2"
