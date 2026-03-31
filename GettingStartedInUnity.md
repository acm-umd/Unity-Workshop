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

  3. Camera Setup

Create empty child of Player → CameraPivot

Make Main Camera a child of CameraPivot

Attach PlayerLook to CameraPivot

In Inspector:

Assign playerBody = Player

  5. Ground

Create floor object

Add Box Collider (you're going to need to make it massive)

Set Layer = Ground

  7. Layers

Create Ground layer

Assign it to floor

Set groundLayer in PlayerMovement

  9. Input System
     
Either:

Set Active Input Handling = Both

  11. Hierarchy (Must Match)
      
Player
├── CameraPivot
    └── Main Camera
    
  13. Positioning
      
Player above ground (not intersecting)

Camera offset:

Pivot ≈ (0, 1.5, 0)

Camera ≈ (0, 0, -5)

  15. Critical Constraints
      
Player must have:

Collider ✅

Rigidbody ✅
Ground must have:
Collider ✅
Camera must be:
Child of Player ✅
