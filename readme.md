# Project Title

Name: The Futuristic Fish Tank Vizualiser

Student Number: C19491104

Class Group: DT211C

# Description of the project

*Proposal*

A futuristic fish tank that acts as a music visualizer

I wish to create a futuristic fish tank in unity.
 - There will be fish to be inside the fish tank moving around the tank on ranomly generated path.
 - Music will be playing.
 - The the lighting and colours will change in beat with the music.
 - There will be music visualisers around the fihs tank.
 - The tank will be decorated randomly on every start of the project.
 - There will be a Fish you can cantrol to move around the tank and view it in first person with water like physics.

# Instructions for use

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
| FishSwim.cs | Self Written but based on work done in Lab |
| PlayerFishCamera.cs | Self Written |
| PlayerMovement.cs | Self Written |

# References
| Asset | Source |
|-----------|-----------|
| Water Material | https://assetstore.unity.com/packages/3d/vegetation/fishes-and-underwater-environment-set-123678 |
| Fish Models | https://assetstore.unity.com/packages/vfx/shaders/vertical-fog-and-water-depth-123985 |

# What I am most proud of in the assignment

# Proposal submitted earlier can go here:

## This is how to markdown text:

This is *emphasis*

This is a bulleted list

- Item
- Item

This is a numbered list

1. Item
1. Item

This is a [hyperlink](http://bryanduggan.org)

# Headings
## Headings
#### Headings
##### Headings

This is code:

```Java
public void render()
{
	ui.noFill();
	ui.stroke(255);
	ui.rect(x, y, width, height);
	ui.textAlign(PApplet.CENTER, PApplet.CENTER);
	ui.text(text, x + width * 0.5f, y + height * 0.5f);
}
```

So is this without specifying the language:

```
public void render()
{
	ui.noFill();
	ui.stroke(255);
	ui.rect(x, y, width, height);
	ui.textAlign(PApplet.CENTER, PApplet.CENTER);
	ui.text(text, x + width * 0.5f, y + height * 0.5f);
}
```

This is an image using a relative URL:

![An image](images/p8.png)

This is an image using an absolute URL:

![A different image](https://bryanduggandotorg.files.wordpress.com/2019/02/infinite-forms-00045.png?w=595&h=&zoom=2)

This is a youtube video:

[![YouTube](http://img.youtube.com/vi/J2kHSSFA4NU/0.jpg)](https://www.youtube.com/watch?v=J2kHSSFA4NU)

This is a table:

| Heading 1 | Heading 2 |
|-----------|-----------|
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |

