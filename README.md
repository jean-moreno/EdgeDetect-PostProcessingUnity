# EdgeDetect-PostProcessingUnity

Port of the legacy Unity "Edge Detect Normals" image effect to Post Processing Stack **v2**

- [Edge Detect Effect Normals - Unity Documentation](https://docs.unity3d.com/550/Documentation/Manual/script-EdgeDetectEffectNormals.html)
- [Post Processing Stack v2 - Unity Technologies GitHub](https://github.com/Unity-Technologies/PostProcessing/tree/v2)

![Screenshot](https://i.imgur.com/8SH535F.gif)

## Installation

Place the `EdgeDetect-PostProcessingUnity` folder anywhere in your project, and make sure that [Post Processing Stack v2](https://github.com/Unity-Technologies/PostProcessing/tree/v2) is in the project as well.

## Usage

The new effect should be available for a post processing profile with different injection points:

- `Add effect... > Unity Legacy > Edge Detection (Before Transparent)`
Will render the Edge Detect effect before transparent objects are rendered, recommended for Legacy renderer (doesn't work with Scriptable Render Pipelines at time of writing - september 2018)
- `Add effect... > Unity Legacy > Edge Detection (Before Stack)`
Will render the Edge Detect effect before the built-in Post Processing Stack effects, recommended for Scriptable Render Pipelines
- `Add effect... > Unity Legacy > Edge Detection (After Stack)`
Will render the Edge Detect effect after the built-in Post Processing Stack effects, if you want the edges to appear on top of everything