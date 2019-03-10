![Screenshot](https://cdn.discordapp.com/attachments/377316629220032523/554392474299138058/unknown.png)
# Post Processing Edge Detection
This is a port of the old edge detection image effect for the v2 post processing stack. With UPM integration.

## Installation
If using 2018.3.x, you can add a new entry to the manifest.json file in your Packages folder:
```json
"com.popcron.pp-edge-detection": "https://github.com/popcron/pp-edge-detection.git"
```

## Usage

After installing the package, add the effect just as you would with any other post processing effect. 
The new effect should be available for a post processing profile with different injection points:
![image](https://cdn.discordapp.com/attachments/452940237363216415/553991192841551892/unknown.png)

**Notes:**
- `Edge Detection (Before Transparent)`
Will render the Edge Detect effect before transparent objects are rendered, recommended for Legacy renderer (doesn't work with Scriptable Render Pipelines at time of writing - september 2018)
- `Edge Detection (Before Stack)`
Will render the Edge Detect effect before the built-in Post Processing Stack effects, recommended for Scriptable Render Pipelines
- `Edge Detection (After Stack)`
Will render the Edge Detect effect after the built-in Post Processing Stack effects, if you want the edges to appear on top of every other effect

Thanks to [Jean Moreno](https://github.com/jean-moreno).
