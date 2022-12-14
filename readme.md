# The Futuristic Fish Tank Visualizer

Name: Cillian

Student Number: C19491104

Class Group: DT211C/TU857

# Demo Video

[![IMAGE ALT TEXT HERE](https://user-images.githubusercontent.com/55165823/207372677-99a604e9-8cf5-4dc9-bf08-97261aee40f7.png)](https://www.youtube.com/watch?v=fQQVWsDn_7Q)

https://www.youtube.com/watch?v=fQQVWsDn_7Q

# Description of the project

A futuristic fish tank that acts as a music visualizer

 - There are fish  inside the fish tank moving around the tank on randomly generated path.
 - The fish speed and rotation are random.
 - Music plays and this can be any song.
 - The lighting and colours of the tank will change in beat with the music.
 - There are music visualisers around the fish tank which dance to the music.
 - There is a fish swimming between a generated path of rings.
 - The tank is decorated randomly start of the project.
 - These decorations vary in position, amount, size and rotation.
 - There is a Fish you can control by pressing E and then you can move around the tank and view it in 3rd person with water like physics.
 - When controlling the fish an audio effect will play and the music will be muffled (simulating underwater sound)
 - The fish inside the tank can be collided with by the playable fish or generated decorations and will adjust their path to avoid the collisions.
 - Project can be run in both VR and regular desktop mode (Did not have access to VR hardware so implementation is based on XR emulation).
 
# Instructions for use

**Non VR Setup**

 - Either Download the NonVR build from the builds folder or the releases section and run the FishTank.exe on a windows computer.
 - Alternatively clone the main branch and open the project in the unity editor.

**VR Setup**

 - Download the VR build from the builds folder or the releases section and run the FishTank.exe on a windows computer.
 - Alternatively clone the VRBuild branch and open the project in the unity editor.
 - Ensure you have an XR Compatible headset connected (Or can emulate VR movement with mouse holding right click + mouse button 5)
 
**Controls**

 - E to toggle between viewing the tank and controlling the fish.
 - WASD For moving the fish.
 - Space to swim up.
 - Control to swim down.

**Music**

 - If downloading a build it will contain a default song.
 - To change the song, clone the appropriate branch and change the song in the Unity editor in the Music object.
 - Adjust the song multiplier value to ensure the chosen song gives your desired amount of movement.
 - Quieter songs may require more of a multiplication to ensure all elements of the visualization are seen throughout the song.


# How it works

Spectrum Data is taken from playing music, this music's data is then processed throughout the song playing to find "beats" in the song.
Different intensity and frequency of beats will be used to control different parts of the project.

There are 4 variables for controlling each beat:
 - Bias: How much does the beat have to change from the previous beta to be considered a beat.
 - Time Step: - How much time must pass before triggering another beat.
 - Time to beat: How much time should the beats action take.
 - Rest Smooth Time: How much rest per beat.
 
These 4 variables are adjusted for each item in the project that is changed due to a beat for example the case of the visualiser it is a cube that adjusts its scale when a beat of certain bias is found.

The movement of the fishes is caused by each fish picking a select to point to travel to then randomly chosing the speed it will travel to this point at, oncce it arrives at the point it will rest for a ranodm ammount of time before chosing the next point. While a fish is moving between points if it is collided with it choses an alternative path.

The decoration works by for each decoration point generating a number and that number results in either an item going there or not an item going there. The item also gets given a random size or rotation.

The fish moving around the rings works by generation a circle of gizmos around the fish and at each gizmo in this ring placing a fish ring.

The default camera is moving around the fish tank on a track. However, in VR this camera is move to be the VR headset.

When the user presses E the camera gets moved to a fish in the tank and this fish's path is halted and the user can then control it. When the use switches of controlling the fish it returns to its normal path.

# List of classes/assets in the project and whether made yourself or modified or if it’s from a source, please give the reference

| Class/asset | Source |
|-----------|-----------|
| SongSpectrum.cs | Self written  |
| SongMonitor.cs | Self written but followed tutorial from [https://www.youtube.com/watch?v=PzVbaaxgPco]() |
| BeatMovement.cs | Self Written |
| BeatColour.cs | Self Written |
| CameraSwitch.cs | Self Written |
| DecorationSpawner.cs | Self Written |
| FishPath.cs | Self Written but based on work done in Lab |
| FishSwim.cs | Self Written |
| PlayerFishCamera.cs | Self Written |
| PlayerMovement.cs | Self Written |
| UnderwaterAudio.cs | Self Written |
| VRManager.cs | Self Written |


# References
| Asset | Source |
|-----------|-----------|
| Water Material | https://assetstore.unity.com/packages/vfx/shaders/vertical-fog-and-water-depth-123985 |
| Fish Models | https://assetstore.unity.com/packages/3d/vegetation/fishes-and-underwater-environment-set-123678  |

# What I am most proud of in the assignment

I am most proud of how the visualiser moves and changes as the song progresses, At the start of the default song the visualiser is quite slow and as the song progresses it becomes more rapid and the colour changes begin giving a kind of disco effect when the song reaches it's peak/drop. It has been fun to test it out with multiple songs of different genres and see how it looks. Songs with breaks/big build ups or periods of quietness look very cool with it. I learnt alot about unity development here as it was vital to use good pratices such as coroutines and inheritence.

I am also proud of how the tank looks with the fishes moving around it and the glowing lights of the speakers. The tank being randomly generated with random decoration is also quite cool. It was chalenging to get the fishes movement in the tank to interact and collide with one another. I was glad to get this working properly and it thought me alot about how collisions, rigidbodies ect work in unity.

I also really like how the music sounds when you go underwater as it reminds me of listening to music in the bathroom of a concert with the way it is muffled and you can only hear the bass.

I was also proud to get VR implemented without personally owning a VR headset, I did this by using XR Device Simulation and now have 2 build of the project one with VR and one without. This helped me learn how to programme for VR and will be useful in future projects.


# Proposal submitted earlier can go here:

*Original Proposal*

A futuristic fish tank
I wish to create a futuristic fish tank in unity
I want the fish to be generated using shapes and then to have a randomly selected appearance.
I want the tank to go have a futuristic appearance along with buttons that the user can interact with.
The buttons should change the appearance of both the fish and tanks.
The Fish will move in a generated path using similar trigonometry to what we did in class.




