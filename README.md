# Q_rsqrt_Unity
Quake III Arena: Fast Inverse Square Root in Unity

## The good or bad idea. IDK.

Since I have always been interested in the Quake III engine ([id Tech 3](https://en.wikipedia.org/wiki/Id_Tech_3)) through [Star Wars Jedi Knight II: Jedi Outcast](https://en.wikipedia.org/wiki/Star_Wars_Jedi_Knight_II:_Jedi_Outcast) and am a fan of the [Fast Inverse Square Root Algorithm](https://en.wikipedia.org/wiki/Fast_inverse_square_root) I thought it would be interesting to make the algorithm available in the **UnityEngine**.
Apart from whether it makes sense or not, I just wanted to try it out. And so I started the experiment.

## Installation

### Windows

1. Download the current release for Windows or compile it yourself if you want to.
2. Just put the **Q_rsqrt_Unity_DLL_x86.dll** or **Q_rsqrt_Unity_DLL_x64.dll** in your **Assets/Plugins** folder in Unity.
3. Native plugins are typically bounded to a specific OS or platform. You can use the Unity Inspector to make sure each DLL is included in the right build.

### Linux

Coming soon.

### macOS

Coming soon.

## Usage

1. Import the **Q3** namespace.
2. Just call the static method ```float result = Qmath.Q_rsqrt(float number);```

```csharp
using UnityEngine;
using Q3;

public class Tester : MonoBehaviour
{
    public float testValue = 1f;

    private void Start()
    {
        float result = Qmath.Q_rsqrt(testValue);
        Debug.Log(result);
    }
}
```

## Performance / Profiling

Coming soon.
