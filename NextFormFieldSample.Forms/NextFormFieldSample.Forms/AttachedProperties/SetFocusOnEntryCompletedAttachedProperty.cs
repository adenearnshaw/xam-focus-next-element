using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NextFormFieldSample.Forms.AttachedProperties
{
    public class SetFocusOnEntryCompleted
    {

        public static readonly BindableProperty TargetElementProperty =
            BindableProperty.CreateAttached("TargetElement", typeof(VisualElement), typeof(SetFocusOnEntryCompleted), default(VisualElement), propertyChanged: OnTargetElementChanged);

        public static VisualElement GetTargetElement(BindableObject view)
        {
            return (VisualElement)view.GetValue(TargetElementProperty);
        }

        public static void SetTargetElement(BindableObject view, VisualElement value)
        {
            view.SetValue(TargetElementProperty, value);
        }

        private static void OnTargetElementChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var entry = bindable as Entry;

            if (entry == null)
                return;

            entry.Completed += (s,e) => GetTargetElement(entry)?.Focus();
        }        
    }
}
