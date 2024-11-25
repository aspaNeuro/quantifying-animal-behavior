using Bonsai;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using OpenCV.Net;

[Combinator]
[Description("Validates the heading given two points")]
[WorkflowElementCategory(ElementCategory.Transform)]
public class HeadingCondition
{
    public double MinAngle { get; set; }
    public double MaxAngle { get; set; }
    
    public IObservable<bool> Process(IObservable<double> source)
    {
        return source.Select(angle => 
        {
            return MinAngle <= MaxAngle
              ? MinAngle < angle && angle < MaxAngle
              : angle > MinAngle || angle < MaxAngle;
        });
    }
}
