@jvoigts following a brief discussion with @aspaNeuro and @NeuroThom we are fleshing out the scope of this session. The original abstract is reproduced below, followed by our comments.

> The potential for closed-loop experiments and manipulations in neuroscience is most limited by our ability to measure animal behavior of interest in real-time. In this session we want to bring together and showcase the many growing options for using Bonsai and state-of-the-art machine learning and computer vision techniques to measure the behavior of animals in real-time, including 2D and 3D pose estimation, statistical techniques for inferring kinematics and behavior syllables, as well as hybrid approaches combining hardware and signal processing techniques to follow the behavior of animals over long periods of time in naturalistic and freely-moving settings.

In this session we want to go beyond the focus on video, and include different ways of performing online statistics and collecting measurements, including quantifying and displaying features measured using any sensor, as well as features extracted from environment or task logic variables. For that reason we propose the following topics:
- Detecting events and different features of interest from video and video tracking data
- Building custom behavior visualizations with the GUI package (including counting occurrences, aggregating mean statistics, assessing behavior trends and performance, and potential model fit (e.g. psychometric curve) and outlier detection)
- Detecting and align to events extracted from other hardware and environmental sensors

## Talk 1

Detection of events and tracking freely moving animals (30 min):
Potential topics:
  - historically: zone activity / centroid blob tracking
  - SLEAP, DLC
  - hand-crafted kinematics vs bonsai ML kinematics;
  - multi-animal tracker by @jfrazao (?)
  - other ML (MOSEQ state-space in bonsai-ml), etc.

## Talk 2

Building behavior visualizations with GUI package (30 min)
Potential topics:
  - Example from curriculum measuring performance
  - Example displaying trial state progression and ethogram
  - Different styles for displaying state (checkboxes, signal state, etc.)
  - Compute and display running summary statistics
  - Example from bonsai ML visualizers building behavior visualizations

## Talk 3

Detect and align to different events related to animal behavior (30 min)
Potential topics:
  - more focus on alternative hardware monitoring / measurements (?):
    - environment sensors
    - lickety split, RFID reader, commutator, etc.
  - focus on alignment and correlation across different modalities
