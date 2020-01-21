using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NextFormFieldSample.Forms.Behaviors
{
    public class SetFocusOnEntryCompletedBehavior : BehaviorBase<Entry>
    {
        public static readonly BindableProperty TargetElementProperty
            = BindableProperty.Create(nameof(TargetElement), typeof(VisualElement), typeof(SetFocusOnEntryCompletedBehavior));

        public VisualElement TargetElement
        {
            get => (VisualElement)GetValue(TargetElementProperty);
            set => SetValue(TargetElementProperty, value);
        }

        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            AssociatedObject.Completed += Entry_Completed;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            AssociatedObject.Completed -= Entry_Completed;
            base.OnDetachingFrom(bindable);
        }

        private void Entry_Completed(object sender, EventArgs e)
        {
            TargetElement?.Focus();
        }
    }
}
