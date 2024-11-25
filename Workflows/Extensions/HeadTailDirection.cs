using Bonsai;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using OpenCV.Net;

[Combinator]
[Description("")]
[WorkflowElementCategory(ElementCategory.Transform)]
public class HeadTailDirection
{
    public IObservable<HeadTail> Process (IObservable<Tuple<Tuple<Point2f, Point2f>, double, Point2f, IplImage>> source)
    {
        return source.Select(value => new HeadTail{Head = value.Item1.Item1, Tail= value.Item1.Item2, Orientation= value.Item2, Centroid= value.Item3, Image=value.Item4});
    }
}
//new(Item1.Item1 as Head,Item1.Item2 as Tail,Item2 as Orientation,Item3 as Centroid,Item4 as Image)
public struct HeadTail
{
    public Point2f Head;
    public Point2f Tail;
    public double Orientation;
    public Point2f Centroid;
    public IplImage Image;
}