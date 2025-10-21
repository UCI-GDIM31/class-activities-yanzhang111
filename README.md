# in-class-activities
## Devlogs
### W1
Write your W1 activity Devlog here.

### W2
1. The r, g, and b variables are floats because colors in Unity use numbers with decimals between 0.0 and 1.0. Using floats lets the color change smoothly instead of jumping by whole numbers.
2. The _bounces variable is an int because it counts how many times the ball hits something. It’s always a whole number, so using an integer makes sense.
3. The error said “; expected,” which means I forgot to put a semicolon at the end of the line. It showed that every line of code in C# needs a semicolon to run correctly.

### W4
table 5
line5：_moveSpeed is a member variable of type float. It stores how fast the cat moves. Because of [SerializeField], we can change its value in the Unity Inspector even though it’s private.
line22：translation is a local variable, and the type is float. 
line25：transform is a Component. This line is calling a method named Translate on that component.

For the collider setup, we gave Rigidbodies to the Cat and the SoccerBall so they could move and use physics. The Goal didn’t need a Rigidbody, and we only checked Is Trigger on the Goal so the ball could go through but still be detected.

At first it didn’t work because the BounceOffWall script was missing the Rigidbody reference, so nothing bounced. After dragging the Rigidbody into the script and adjusting Bounce Force, it worked fine.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 
