# Unity 5.x - Scripts

These are collected and created scripts for use in the Unity 5.x game engine.

#### AnimateTrigger.cs

1.  Create an animation state transition that is connected to a Animator Trigger.  Mine was named 'box'
2.  Drag this script onto your object with an Animation Controller and create a collider trigger on that same object.
3.  Play!  The state will change as the trigger is affected by your collider box.

#### PlayMovieStart.cs

1.  Drag this script onto an object which has a Movie Texture applied.

#### PopupText.cs

1.  Create a UI Canvas and Text object.
2.  Set Canvas render mode to "world space", resize and place where you would like it to pop up.
3.  Type your desired text in the Text object to see how it will look, and place it.
4.  Drag PopupText.cs onto your main object which has a collider trigger, make the Canvas>Text a child of that GameObject.
5.  Type what you would like your text to say in the script "string" box and set the fade amount to your desired speed.  2 works well for me.
6.  If you add more popup events, make a copy of the script and change your new Text UI GameObject to a unique name, change that name in the new script on the line: GameObject.Find ("your text object name")

#### SpookyWall.cs

1.  Create a collider box trigger and drag this script onto it.
2.  Change the script to use the unique name of the GameObject you would like to disappear/reappear.
3.  If using a default object like 'Box', you will need to put the scale that you would like it to be when it 'appears'.  Otherwise, you can make any GameObject/mesh appear with (1,1,1).

#### SoundTrigger.cs

1.  Drag an audio file onto your GameObject.
2.  Create a collider for your player and check "is trigger".
3.  Drag the soundtrigger.cs file onto the same GameObject.

#### SoundTrigger_Button.cs

1.  Follow steps 1 and 2 above for regular soundtrigger.cs interaction.
2.  Add SoundTrigger_Button.cs to the GameObject and edit the .cs file if you would like a specific button.  The default button is 'e'.

#### TeleportPlayer.cs

1.	Drag the TeleportPlayer.cs file onto an object that will teleport you, and make sure that “Instant Teleport” is checked in the properties.
2.	Add a collider (any shape) to that object and click “is trigger”.  Resize or move the green collider shape to where you would like the teleport to trigger.
3.	Drag the TeleportPlayer.cs file onto the object that you will be teleported to.