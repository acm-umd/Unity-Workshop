# Unity-Workshop
ACM workshop about the Unity game engine, and how to use it for game development.

Unity Setup Guide
A practical guide to installing Unity, configuring your environment, and avoiding the most common setup pitfalls.

Table of Contents
Requirements
Installation
Creating Your First Project
Editor Layout & Basics
Common Setup Errors & Fixes
Frequently Asked Questions
Recommended Settings for New Projects

Requirements
Minimum Hardware
OS: Windows 10/11 (64-bit), macOS 12+, or Ubuntu 20.04+
CPU: x64 architecture with SSE2 support
RAM: 8 GB (16 GB recommended)
GPU: DirectX 11 / Metal / Vulkan-compatible
Storage: 10 GB free (more needed per platform module)
Software Dependencies
Unity Hub (required — manages all Unity installs)
.NET SDK (Unity bundles its own, but Visual Studio / VS Code require it separately)
Visual Studio 2022 or Visual Studio Code (recommended for scripting)
Note: Unity Hub is the mandatory launcher starting from Unity 2020.1. Do not install Unity editors directly — always use Hub.

Installation
Step 1 — Install Unity Hub
Go to https://unity.com/download
Download Unity Hub for your OS
Run the installer and complete setup
Sign in or create a free Unity account (required for activation)
Step 2 — Activate a License
Open Unity Hub → click your avatar (top-left) → Manage licenses
Click Add license
Choose Get a free personal license (for individuals/small teams) or enter your Pro/Plus serial
Click Agree and get personal edition license
⚠️ Without an active license, Unity editors will not open. This is a very common point of failure for first-time setups.
Step 3 — Install a Unity Editor Version
In Unity Hub, go to Installs → Install Editor (we are using Unity 6.4)
Select a version. For most new projects, choose the latest LTS (Long Term Support) release
Select the modules you need:
Module
When to include
Microsoft Visual Studio Community
Always — needed for C# scripting
Android Build Support
Mobile / Android deployment
iOS Build Support
macOS only — Apple devices
WebGL Build Support
Browser-based games
Windows Build Support
Cross-platform Windows builds
Documentation
Offline docs (optional but useful)

Click Install and wait (can take 20–60 minutes depending on modules)
Step 4 — Install Visual Studio Code (Alternative IDE)
If you prefer VS Code over Visual Studio:
Install VS Code
Install the C# Dev Kit extension
Install the Unity extension by Unity Technologies
In Unity: Edit → Preferences → External Tools → External Script Editor → select VS Code

Creating Your First Project
Open Unity Hub → Projects → New project
Select a template:
3D (Core) — Standard 3D project
2D (Core) — Flat sprite-based games
URP (Universal Render Pipeline) — Better visuals, cross-platform
HDRP — High-end PC/console visuals only
Name your project and choose a save location (avoid paths with spaces or special characters)
Click Create project
Tip: Avoid saving projects inside synced cloud folders (OneDrive, iCloud, Dropbox) while actively editing. These can corrupt the Library folder. Use a local path and back up manually, or use source control.

Editor Layout & Basics
Panel
Purpose
Scene
Visual editing of your game world
Game
Preview what the player will see
Hierarchy
List of all GameObjects in the scene
Project
Your assets (files on disk)
Inspector
Properties of the selected object/asset
Console
Logs, errors, and warnings

Essential keyboard shortcuts:
Shortcut
Action
W
Move tool
E
Rotate tool
R
Scale tool
Ctrl+S
Save scene
Ctrl+Z
Undo
F
Focus selected object in Scene
Ctrl+P
Play / Stop


Common Setup Errors & Fixes
❌ "No valid Unity license found"
Cause: License not activated, expired, or tied to a different machine.
 Fix: Unity Hub → avatar → Manage licenses → Add/reactivate license. If reactivating, click Return license first, then re-add it.

❌ Unity Hub is blank / won't load
Cause: Unity Hub's internal browser renderer has failed (common on older GPUs or restricted environments).
 Fix:
Run Hub as Administrator
Disable hardware acceleration: launch Hub with the --disable-gpu flag
Reinstall Unity Hub

❌ Editor stuck on "Loading..." or splash screen
Cause: Corrupted Library folder or incompatible project version.
 Fix: Close Unity, delete the Library and Temp folders from your project directory, then reopen. Unity will regenerate them (this takes a few minutes).
These folders are auto-generated and safe to delete. Do not delete Assets, Packages, or ProjectSettings.

❌ Scripts not compiling / red errors on open
Cause: Missing IDE, wrong .NET version, or corrupted package cache.
 Fix:
Go to Edit → Preferences → External Tools
Set your script editor and click Regenerate project files
If errors persist: Edit → Project Settings → Player → Other Settings — check that Api Compatibility Level is set to .NET Standard 2.1 (not Framework 4.x unless required)

❌ Visual Studio IntelliSense not working for Unity
Cause: The VS–Unity bridge (.sln files) has not been generated or is stale.
 Fix:
In Unity: Edit → Preferences → External Tools → Regenerate project files
Close and reopen Visual Studio
Ensure the Unity Game Development workload is installed in Visual Studio Installer

❌ Android build fails — "JDK not found" or "SDK not found"
Cause: Android SDK/JDK paths are not configured.
 Fix:
Edit → Preferences → External Tools (or Unity → Preferences on Mac)
Under Android, check JDK Installed with Unity and Android SDK Tools Installed with Unity
If using a custom JDK, ensure it is JDK 11 (Unity is not compatible with JDK 17+ for most versions before 2023)

❌ "Assets/... is not a valid script"
Cause: Script filename does not match the class name inside.
 Fix: The C# filename and the public class ClassName declaration inside the file must match exactly, including capitalization.

❌ Package Manager fails / "Unable to resolve packages"
Cause: Network issues, corporate firewall, or corrupted package cache.
 Fix:
Check your internet connection
Try: Edit → Project Settings → Package Manager — disable "Enable Preview Packages" if toggled on unexpectedly
Clear the global cache: delete %AppData%\Unity\cache (Windows) or ~/Library/Unity/cache (macOS)
Re-open the project

❌ Huge file sizes / .meta files missing in source control
Cause: .meta files were not committed to version control.
 Fix: Every asset in Unity generates a paired .meta file that contains its GUID. Always commit .meta files alongside assets. If missing, Unity will break asset references throughout the project.

❌ "DllNotFoundException" at runtime
Cause: A native plugin or DLL is not present, or is the wrong architecture (e.g., 32-bit DLL in a 64-bit build).
 Fix: Check that the plugin is placed in Assets/Plugins/ and that the platform/architecture settings in the Inspector match your build target.

Frequently Asked Questions
Q: Which Unity version should I use?
 A: Use the latest LTS (Long Term Support) version unless you need a specific feature from a newer release. LTS versions receive bug fixes for two years and are the most stable choice for production.
Q: Can I open a project made in a newer version with an older editor?
 A: No. Unity projects can only be opened by the version that created them or a newer one. Downgrading a project requires manual migration, which is complex and not officially supported.
Q: What is the difference between URP and HDRP?
 A: URP (Universal Render Pipeline) runs on most platforms including mobile, consoles, and PC. HDRP (High Definition Render Pipeline) targets high-end PC and consoles only, offering better visual fidelity but much higher hardware requirements. You cannot easily switch between pipelines after starting a project.
Q: Do I need to pay for Unity?
 A: Unity Personal is free for individuals and companies earning under the current revenue threshold (check Unity's pricing page for the latest limit). Unity Pro and Enterprise are subscription-based. Always verify current terms at unity.com/pricing.
Q: Can I use Unity without an internet connection?
 A: Yes, after initial setup. You can activate an offline license through Unity Hub → Manage licenses → Activate with license request file. You will need internet access to download the editor and modules initially.
Q: Why is my Library folder so large?
 A: The Library folder contains all of Unity's imported and processed versions of your assets. It can grow to several GB on large projects. It is entirely regenerable — exclude it from version control (add Library/ to .gitignore).
Q: How do I switch between 2D and 3D mode?
 A: The Scene view has a 2D toggle button in the toolbar. Note that this only changes the editor camera perspective — your project's rendering mode is set at the project level in Project Settings → Graphics.

Recommended Settings for New Projects
These are good defaults to configure before building anything significant:
Project Settings (Edit → Project Settings):
Player → Company Name / Product Name — set these before your first build
Player → Other Settings → Api Compatibility Level → .NET Standard 2.1
Time → Fixed Timestep → 0.02 (50 physics updates/sec, fine for most games)
Physics → Gravity → -9.81 on Y (default is correct; verify if physics feels wrong)
Editor Preferences (Edit → Preferences):
External Tools → External Script Editor — point to your IDE
Asset Pipeline → Auto Refresh — disable if you prefer manual reimport (faster for large projects)
Version Control: Add a .gitignore for Unity (GitHub has an official template) to avoid committing regenerable folders:
Library/
Temp/
Obj/
Build/
Builds/
Logs/
UserSettings/
*.csproj
*.sln
