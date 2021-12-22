# Medieval VR Axe Throwing
Made by Shannon Yan, CS 4249 (Projects in Virtual Reality)

## Background
This is a VR medieval-style axe-throwing game designed for the Oculus Quest 2. In this game, you can throw axes at targets for points. I love reading books (think A Song of Ice and Fire, The Witcher, etc.) set in medieval time periods. Something I’ve noticed is women in these books often go for long-ranged weapons like bow/arrows, spears, and axes, since it’s a way to compensate for size and physical strength. This summer, I went axe-throwing with some friends and found it to be an empowering and exciting experience, so I wanted to recreate it in VR.

This project implements a variety of techniques taught in CS 4249 such as using grabbables, interactables, physics, and scripts. 

## How to play
Use the left thumbstick to move around the room. 
Use the right trigger to grab axes.
Move your right arm/controller while releasing the trigger to throw.
No need to collect axes, they respawn on their own!

## Design Choices
- Medieval-themed: I chose to go with a medieval theme setting since throwing axes were commonly used during this time period.
- No body/avatar (only arms): I originally tried to implement a full-body avatar using inverse kinematics, but found the experience to be jarring. The misalignment of the legs and torso with the arms/head was extremely off-putting. 
- Respawning/self-deleting axes: Collecting axes off the floor is the most tedious part of the experience, so I made them respawn. This also limits the amount of movement the player goes through, reducing risk of motion sickness.
- Sound effects: I added soft music and sound effects for when the axe collides with any surface for more realism.
- Windows to outdoors: I added windows to the room that shows nice scenery outside to let light in and reduce the sense of claustrophobia. 

## Ideas for improvement
-Make the scoring system work: My target is kinematic, so it cannot detect any collisions. I tried many ways to overcome this, but I still haven’t gotten the scoring system to work properly.
- Second room with harder levels: I would like to add smaller and moving targets into the second room.

