# dataLogger_VR
 
Asset Unity for logging user interaction and physiological data in a Virtual Reality experience

#### Table of contents :
[Prerequisites](#Prerequisites)  
[How to use datalogging_VR](#How-to-use-datalogging_VR)
[Important](#Important)

## Prerequisites
Step 1 :  Have an URP unity project (It should work on basics 3D projects but still depreciate and will be disable in futur)  
Step 2 :  Have OVR plugin install. (You should use https://assetstore.unity.com/packages/tools/integration/oculus-integration-82022)  
For more informations about it, follow instructions on https://developer.oculus.com/documentation/unity/move-overview/  
Make sure you had download the Oculus Integration SDK from here -> https://developer.oculus.com/downloads/package/unity-integration/  

## How to use datalogging_VR
Faire en sorte de pouvoir import les scripts  
Step 1 : Import the dataLogger_VR's package in your project
Step 2 :  Add Data Logging script on any object which will be NOT disable or destroy  
Step 3 : Set "path of logs" variable. This will be where your data will be store. This is an example of a correct path C:\PathOfYourProject\Assets\Scripts\Data  
Step 4 : Set the name of the file in "Name of csv file". The name file name will be format after like that YourFilName_YYYYMMDDHHMM  
Step 5 : Set "Time in sec between each logs writte in .CSV file" variable.  
Example : If you put 2, all of the data you want to log will be store on your RAM and after 2 secondes, this data will be writte in to your .CSV file.  
Step 6 : Chose all of the sensors you want to log.  

## Important
If you want to log eyes data and/or try to track them, you will need to do the following things.  
1 : Make sure you use oculus plug-in for your project : Edit->Project Settings-> XR Plug-in Management  
2 : Make sure you don't have issues to fix : Edit->Project Settings->Oculus [And fix all the problems]  
3 : Log on the oculus desktop app with an oculus developper account  
4 : On the oculus desktop app go to Settings->General-> OpenXR Runtime-> Set Oculus as active  
5 : On the oculus desktop app go to Settings->Beta and turn on and agree with Developper runtime features, Pass-through ver Oculus Link, Eye tracking over Oculus link,
Natural facial expressions over Oculus Link and Share point cloud over Oculus Link  
6 : Use the phone where your oculus app is install and where oculus is connect. Go to Menu->Devices->Headset settings->Developer mode (turn on)  
7 : Place InteractionRigOVR-FullSynthetic prefab from oculus integration plug-in in your scene  
8 : Sometimes you will need to go on the InteractionRigOVR-FullSynthetic object. After go to OVRCameraRig and in OVR Manager script turn Body Tracking support, Face Tracking support and eye tracking support  
to Supported and in Permission Requests onstartup in the same script, turn to true body, face and eye tracking  
9 : As the eyeData feature from Unity doesn't seem to work on quest pro, I implement "the eyeTracking feature" from this following Youtube video https://www.youtube.com/watch?v=ZoySn7QlMfQ&pp=ygUScXVlc3QgcHJvIGV5ZSBkYXRh
As the idea in the video is not perfect, I decided to modified it a little. In order to see users eyes ray, you only have to had EyeInteractor prefab asset to InteractionRigOVR-FullSynthetic->
OVRCameraRig->TrackingSpace as it is in the example simpleScene I made. (Don't forget to add one EyeInteractor for each eyes and to turn Eye to left and right the proporty of OVR Eye Gaze script of your EyeInteractors.
Don't forget too to a referenceFrame to your OVR Eye Gaze of EyeInteractors and to put the Tracking mode to Tracking Space. Once again, you only have here to do the same as in the example simpleScene I made.  
10 : If you want to be able to see the color/material of the object the user see, you will need to add to all of objects you want the Eye interactable script and set materials as I made in EyeInteractable prefab.  
11 : I made too a script to place an object exactly where the user is looking at an object in the scene. (It could be usefull in research if you disable the mesh renderer in order to see
in real time exactly the point the user is looking). This script is name draw on see and only need to be place in left and right EyeInteractors  
12 : I writte a script which goes to log the position where the user is looking at an object in the scene instead of place an object in front of the user. This script is named LogOnSee
