# Unity-Sprite-stacking
<h3>A simple script I made for Unity to make sprite stacking easier!</h3>

Here I have a few examples how everything looks.

![Alt Text](https://media.giphy.com/media/xAlARaQRTFjrU32GON/giphy.gif)

<h3>How does it work?</h3>
This script generates a fake 3D object from 2D sprites. You can adjust the rotation, and offset of each segment.<br>
<br>
<img src="https://media.giphy.com/media/UQEvDaptCSFfukdzcR/giphy.gif"/>

<h3>How to use it?</h3>
After you've downloaded this project, open it in your unity editor. I made a little example scene with the car that you can control with arrow keys or wsad.

To make new 3D object, you need to do the following things:
  * Right-click on your project folder and create new "Stack Object"
  * In the stack object, fill the list with your sprites from bottom one to top one.
  * Create empty game object on the scene and "displayObject.cs" script to it.
  * In the Display Object script in the inspector, drag and drop your stack object you've created earlier into the "Stack Object" variable.
  
<h2> Have Fun!</h2>
