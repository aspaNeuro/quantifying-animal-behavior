using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Linq;
using Bonsai;

namespace PackageExample
{
    [Description("SampleSource")]
    [Combinator(MethodName = nameof(Generate))]
    [WorkflowElementCategory(ElementCategory.Source)]
    public class SampleSource
    {
        int value;
        event Action<int> ValueChanged;

        /// <summary>
        /// Gets or sets the value of the property.
        /// </summary>
        [Range(int.MinValue, int.MaxValue)]
        [Description("The value of the property.")]
        [Editor(DesignTypes.NumericUpDownEditor, DesignTypes.UITypeEditor)]
        public int Value
        {
            get { return value; }
            set
            {
                this.value = value;
                OnValueChanged(value);
            }
        }
        void OnValueChanged(int value)
        {
            ValueChanged?.Invoke(value);
        }
        public IObservable<int> Generate()
        {
            return Observable.Defer(() => Observable.Return(value))
            .Concat(Observable.FromEvent<int>(
            handler => ValueChanged += handler,
            handler => ValueChanged -= handler));
        }
    }
}