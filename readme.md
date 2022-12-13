# The Futuristic Fish Tank Vizualiser

Name: Cillian

Student Number: C19491104

Class Group: DT211C

# Demo Video

Video Here

# Description of the project

A futuristic fish tank that acts as a music visualizer

 - There are fish to be inside the fish tank moving around the tank on ranomly generated path.
 - Music plays and this can be any song.
 - The lighting and colours of the tank will change in beat with the music.
 - There are music visualisers around the fish tank which dance to the music.
 - The tank is decorated randomly on every start of the project.
 - There is be a Fish you can cantrol by pressing E and then you can move around the tank and view it in 3rd person with water like physics.
 - The fish inside the tnak can be collided with by the layable fish and will adjust their path to avoid the collisions.
 - Project can be run in both VR and regular desktop mode (Did not have acess to VR hardware so implemntation is based of XR emualation).
 
# Instructions for use

Non VR Setup

 - Either Download the NonVR builf from the builds folder and run the FishTank.exe on a windows computer.
 - Alternatively clone the main branch and open the project in the unity eidtor.

VR Setup

 - Download the VR build from the builds folder and run the FishTank.exe on a windows computer.
 - Alternatively clone the VRBuild branch and open the project in the unity eidtor.
 - Ensure you have an XR Compatible headset (Or can emualte VR movement with mouse holding right click + mouse button 5)
 
Controls
 - E to toggle between viewing the tank and cotnrolling the fish.
 - WASD For moving the fish.
 - Space to swim up.
 - Control to swim down.

How to change the song

 - If downloading a build it will contian a default song.
 - To change the song clone the apropriate branch and change the song in the UNity editor in the Music object.
 - Adjust the song multiplier value to ensure the chosen song gives your desired ammount of movement.


# How it works

Spectrum Data is taken from playing music, this music's data is then processed throughout the song playing to find "beats" in the song.
Different intensity and frequency of beats will be used to control different parts of the project.

# List of classes/assets in the project and whether made yourself or modified or if its from a source, please give the reference

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

# References
| Asset | Source |
|-----------|-----------|
| Water Material | https://assetstore.unity.com/packages/vfx/shaders/vertical-fog-and-water-depth-123985 |
| Fish Models | https://assetstore.unity.com/packages/3d/vegetation/fishes-and-underwater-environment-set-123678  |

# What I am most proud of in the assignment

# Proposal submitted earlier can go here:

*Original Proposal*

A futuristic fish tank

I wish to create a futuristic fish tank in unity
I want the fish to be generated using shapes and then to have a randomly selected appearence
I want the tank go have a futuristic appearance along with buttons that the user can interact with
The buttons should change the apperence of both the fish and tanks
The Fish will move in a generated path using similar trignamotery to what we did In class




