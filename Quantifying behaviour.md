Quantifying behaviour

# Distance from each other

- Graph

- Feeder e.g. 

How does bonsai help?

- Of course quanitifying behaviour is a huge open ended question
- Behaviour boxes and assays often carry many assumptions, or even a list of specific behaviours in specific animals that a paradigm works for 

- Bonsai started with online processing of video
Basic 1st order outputs from Bonsai
- average frames or regions of frames
- thresholding and frame by frame differences 
- background subtraction etc:
- Extremely useful for quantifying many things in video

But much of it takes a good deal of understanding and control of the environment, and time to understand and extract features of interest.

AI and ML applications side step much of this requirements

Once we get more complex: 

- tracking body parts
- specific behaviours
- MOSEQ
- ML and AI

Talk 3
Hardware:

Addition of other sensors beyond a video. Can measure vocalisations synchronised to the video e.g., or feeder hardware

e.g. 
- Capture video with an event
- quality control of behaviour: only count spinning the wheel as digging if using both paws.

uniqueness of bonsai:

More than just video
Real time and live
Can control other synchronised devices with these behaviours or cmbination of behaviours
- Fear of closed loop feedback: am i feeding back what i think i am?

- Can easily waste time in science. Fast prototyping afforded by Bonsai allows testing these things much easier.
- Increase risk taking in experimental fields.

How do we know something is a goal for the animal?

Auditry, olfactory world? What is avaialable to us?

How do you reveal something that isn't obvious to us?


2 things now: 

SLEAP / DLC 
From perspective of Bonsai: main difference is SLEAP can train top-down identities directly from the model off the GPU, while DLC always does bottom-up animal ID. 

This means the DLC has to decide heuristics after grouping found features to identify an instance

SLEAP, independent of the body parts find the identity first in top-down model. Convenient for Bonsai because you can make a single call to the GPU and get everything

DLC finds identities based on post-hoc analysis of a bag of body parts. Need all the body parts and then the identities are computed on a non-trivial algorithm to group body parts with a post-hoc code. This runs in python

# Start session with Jakob talking about how people have tracked and quantified behaviour historically what the problem is

(15mins)

# Bonsai provides this platform to easily prototype and do these things

Me: Right now in bonsai

What can we get from a frame?
Many frames?

background subtraction
thresholding                - upper and/or lower or on average / color channels
                            - can be done on already preprocessed frames 
blob tracking   - centroid
                - grab pixels of blob and analyse further
                    - size of the animal
                    - isolate pixels to find specific features or even colored parts (painted)
                    - darker/lighter parts (fish eyes)
                - dynamic cropping - multianimal workflow
            
frame by frame differences  - motion energy e.g. freezing behaviour
                            - example workflow for the frazao mutli animal tracker and freezing behaviour

Arithmetic operations on the image:
average of images over space - sub-pixel intensities
                             - photodiode measurements
                             - super resolution
                             
- roiActivation         - extension of arithmetic on specific pixels in an image

movingROI
dynamic cropping

# Slide:
first order - things we can get from a video frame
    - arithmetic operators 
    - MorphologicalOperators
    - computer vision functions
potential second order features
    - kinematics (velocity e.g.)
    - hidden states (behavioural states)
    - track environment (like a ball). Interactions between objects and animals
    - interaction between individuals

How far are we from having these things in Bonsai?
How specific are these issues to an experiment?
But how do we get at these in an efficient way? Is it worth pursuing specific vs generic targets?
Are we satisfied with letting people train their own model in ML? - generic tensorflow 

Interesting thought for Bonsai:
Video guided data exploration, GUI style in bonsai - rerun video data but allow scrolling through video and associated data - link timestamps and produce sliding window graph as you navigate around the video, getting all the data to either side
