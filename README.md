# Unity MR Starter For Quest
This is a getting started package for creating VR experiences for Meta Quest 1,2,3,Pro headsets using Unity.  
Get started by using Mixed Reality Toolkit (MRTK).

# Sample Apps
If you want to try the demos immediately without building in Unity, please download the APKs from the following link:  
[UnityVRStarter v1.0.0](https://github.com/TakashiYoshinaga/UnityVRStarter/releases/tag/v1.0.0)

# Sample Scenes
## 1.Hand Interaction

`StarterWithMRTK2_8/Assets/Scenes/1_Hand Interaction Examples.unity`

Demonstrates a bunch of the MRTK hand interactions, and gives a good starting point of seeing what's possible with the included piano, buttons, sliders, and other interactive components.
![MRTK Hand Interaction](ReadmeFiles/MRTKHandInteractions.jpg)

## 2.Mesh Visualization (for Quest3)

`StarterWithMRTK2_8/Assets/Scenes/2_Mesh Example.unity`  
You can try various mesh samples by enabling/disabling OVRSceneManager_1~3 in the scene.  
*Please enable only one VRSceneManager at a time.  
The video below is of OVRSceneManager_3.  
[video]  
[![Mesh Visualization Example](https://img.youtube.com/vi/HVR5cXg5MSk/0.jpg)](https://www.youtube.com/watch?v=HVR5cXg5MSk)

## 3.Mesh Copy (for Quest3)

`StarterWithMRTK2_8/Assets/Scenes/3_Mesh Copy.unity`  

This sample allows you to duplicate and manipulate room mesh, and save the mesh as obj.
Please note that this sample is experimental and the source may change in the future.  
[video]  
[![Mesh Copy Example](https://img.youtube.com/vi/BvuRo9tyMtM/0.jpg)](https://www.youtube.com/watch?v=BvuRo9tyMtM)

You can use the exported mesh in editor as simulation.

![D2iXxyBQL2](https://github.com/dengxian-xreal/UnityMRStarterForQuest/assets/134575521/a191201c-0a93-44bf-8b1e-92e9b47a4fa0)

You can find the exported mesh in this path:

![Pvb3w8Hjix](https://github.com/dengxian-xreal/UnityMRStarterForQuest/assets/134575521/daed847c-72da-4899-ba32-1596f554a495)


# MRTK Profiles
In your own scene, use the MRTK Configuration Profile:
`Oculus MixedRealityToolkitConfigurationProfile`

![Mixed Reality Toolkit Dialog](ReadmeFiles/MixedRealityToolkit.png)
![MRTK Profile List](ReadmeFiles/MRTKProfiles.png)

This profile is configured to use Hand Tracking and Camera Passthrough.
