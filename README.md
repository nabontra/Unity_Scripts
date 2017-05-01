# Unity 5.x - Scripts

These are collected and created scripts for use in the Unity 5.x game engine.

#### AnimateTrigger.cs

1.  Create an animation state transition that is connected to a Animator Trigger.  Mine was named 'box'
2.  Drag this script onto your object with an Animation Controller and create a collider trigger on that same object.
3.  Play!  The state will change as the trigger is affected by your collider box.

#### PlayMovieStart.cs

1.  Drag this script onto an object which has a Movie Texture applied.

#### SpookyWall.cs

1.  Create a collider box trigger and drag this script onto it.
2.  Change the script to use the unique name of the GameObject you would like to disappear/reappear.
3.  If using a default object like 'Box', you will need to put the scale that you would like it to be when it 'appears'.  Otherwise, you can make any GameObject/mesh appear with (1,1,1).

#### TeleportPlayer.cs

1.	Drag the TeleportPlayer.cs file onto an object that will teleport you, and make sure that “Instant Teleport” is checked in the properties.
2.	Add a collider (any shape) to that object and click “is trigger”.  Resize or move the green collider shape to where you would like the teleport to trigger.
3.	Drag the TeleportPlayer.cs file onto the object that you will be teleported to.