﻿//--------------------------------------------------------------------------------------------------------------------------------
// Port of the Legacy Unity "Edge Detect" image effect to Post Processing Stack v2
// Jean Moreno, 2017-2018
// Legacy Image Effect: https://docs.unity3d.com/550/Documentation/Manual/script-EdgeDetectEffectNormals.html
// Post Processing Stack v2: https://github.com/Unity-Technologies/PostProcessing/tree/v2
//--------------------------------------------------------------------------------------------------------------------------------

using UnityEditor.Rendering.PostProcessing;

[PostProcessEditor(typeof(EdgeDetect_AfterStack))]
public sealed class EdgeDetect_AfterStack_Editor : EdgeDetectPostProcessing_Editor<EdgeDetect_AfterStack> { }
