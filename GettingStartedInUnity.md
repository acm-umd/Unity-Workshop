Instructions on what to do once entering a new Unity project:

The first thing you should do is download the files from the repo, and drag and drop them into your environment. Then you may begin.

  1. Player Object
Create Player
Add:
Rigidbody
Is Kinematic ❌
Freeze Rotation: X, Y, Z ✅
Capsule Collider
Attach scripts:
PlayerMovement
PlayerInputHandler
  2. Camera Setup
Create empty child of Player → CameraPivot
Make Main Camera a child of CameraPivot
Attach PlayerLook to CameraPivot
In Inspector:
Assign playerBody = Player
  3. Ground
Create floor object
Add Box Collider (you're going to need to make it massive)
Set Layer = Ground
  4. Layers
Create Ground layer
Assign it to floor
Set groundLayer in PlayerMovement
  5. Input System
Either:
Set Active Input Handling = Both
  6. Hierarchy (Must Match)
Player
├── CameraPivot
    └── Main Camera
  7. Positioning
Player above ground (not intersecting)
Camera offset:
Pivot ≈ (0, 1.5, 0)
Camera ≈ (0, 0, -5)
  8. Critical Constraints
Player must have:
Collider ✅
Rigidbody ✅
Ground must have:
Collider ✅
Camera must be:
Child of Player ✅
