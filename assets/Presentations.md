### Tracking Workflows
### <u>1-RoiActivity.bonsai</u>

1. Camera (or `FileCapture`) initialises and grabs our camera stream. We'll `Grayscale` this and pass it to a `PublishSubject` called `Image`

One of the most important aspects of behaviour we are all familiar with is locomotion, i.e. **where** our animal is. The arena is 'controlled' in the sense that we know and control a lot of the conditions of our experiment. We know a lot about the camera, the mouse and the environment. For example, the arena is monochrome white under IR light, providing contrast with our mouse. 
2. Many tools are available in `Bonsai.Vision` to process this image and find our mouse.

   - `CropPolygon` to define our arena and remove extra stuff we don't need (and will mess up downstream processing)
   - `Threshold` to filter out everything except our mouse (more or less)
   - `FindContours` to isolate the 'contour' or 'blob'
   - `BinaryRegionAnalysis` and `TakeLargestRegion` to compute the centroid and other properties of the blob.
   - We can take the `Centroid` and drop it on the image from `CropPolygon` to see it is working accurately

   - Other options from `Bonsai.Vision` include:
      - `MorphologicalOperator` methods, Dilate, Erode, Close with filters of defined shape and size.
      - `BackgroundSubtraction` with options for the number of frames, adaptation rate, and thresholding options in the property grid.
   - Also arithmetic operators to apply to image data
      - Average in time and/or space
Major +++ to Bonsai is you can manipulate the parameters of these operators 'on the fly', making it very easy to prototype and find the perfect parameters.

3. `RoiActivity` node allows you to define any number of polygons, which you can shape with a UI, to define ROIs on your setup and report pixel activity in that region.
   - Some shortcuts:
      - left-click and drag to draw a box
      - shift-left-click and drag to draw a circular polygon
      - left-click to select existing polygon: the blue markers show the polygon points that define the ROI polygon
      
         With the polygon selected, clicking inside the polygon:
         - right-click and drag to grab the nearest point and move it
         - double-left-click to create a new point
         - double-right-click to remove a point
4. This will give us a `RegionActivityCollection` which we can index and send to a `Buffer` for a super-simple visualizer.

### <u>2-head-tail.bonsai</u>

1. We can also use these 'first-order' points from computer vision or sleap for example, to infer kinematics and other aspects of the animal subject based again on **knowledge of our system**. 
2. We can find the 'extremes' of the `BinaryRegions`.
3. We compute the velocity of each point over a buffer of ten frames.
4. If the velocity is over a certain threshold, we can infer what the 'front' of the mouse is, and therefore the head. If it's below that threshold, then we use the same rule as before, that the points cannot teleport.

### <u>3-flies13_multiAnimal.bonsai</u>

1. Here again we take an image and do some computer vision processing in the `BlobDetection` `GroupWorkflow` "BlobDetection", but this time we have two flies in our arena that are interacting.
2. Major, well known issue with identifying individuals automatically. IDs are assigned frame by frame essentially randomly, so ID switches are common
3. `SortBinaryRegions` sorts the regions by their size. Disabled here by default, and works quite well in this case because the animals are actually different sizes!
4. Can also sort these using some simple kinematics and knowledge about our system. For example we know that flies do not teleport across the arena, and we are recording fast enough (100Hz) that we know the centroid closest to the centroid in the previous frame is most likely to be the same fly. E.g. `BinaryRegionsTracking` from `BonFly` implements this in the `GroupWorkflow` "BonFlyBlobSorting".
5. A different approach that requires far less knowledge about the system (though significantly ore resources and labour in labelling frames etc) is a 'AI' pose estimation model. Bonsai has two very widely used packages to handle this function, [`Bonsai.sleap`](https://bonsai-rx.org/sleap/index.html) and [`Bonsai.deeplabcut`](https://github.com/bonsai-rx/deeplabcut). These support running inference on pretrained models for markerless pose estimation and identity tracking. 
