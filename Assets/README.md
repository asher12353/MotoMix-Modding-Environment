# MotoMix Custom Track Creation Guide

### Hello!  
Thank you for taking an interest in making custom content for MotoMix!

---

## How to Make a Custom Track

We've tried to make the process of creating a custom track as simple as possible.  
In this Unity project, you'll find a scene labeled **"Track"**.  
Inside is the basic structure for what you'll need to create a track.  

- **Track Structure:**  
  - Under the **"Track"** object, there is a child object labeled **"Tracks"**.  
  - This is where you will assemble the pieces of your track.  
  - If you already have a complete track model, simply place it under **"Tracks"**.

---

## Placing Pickups
- Pickups are spawned in sets of **three**.  
- If you want individual pickups, contact us for a future update.  
- Pickups are placed under the **"Pickups"** child object.  
- To place pickups:
  1. Create an **empty GameObject** at the desired location.
  2. Rotate it if needed (the parser will respect its rotation).
  3. Add a **Box Collider** with size `(7,1,1)` for visualization.

---

## Adding Portals
Portals allow players to teleport from one part of the track to another.  
Each portal consists of:
- **An entry point**
- **An exit point**
- **A trigger collider to detect when a player enters**

### How to Set Up Portals
1. Inside your **"Track"** object, create a child object named **"Portals"**.  
2. Each individual portal setup should be placed inside **"Portals"**.  
3. The structure of a portal should be:


PortalParent
├── PortalObject (Contains the visual effect)
    ├── Entry (Position where players enter)
    ├── Exit (Position where players will appear)
├── Trigger (Detects players entering)

4. **Naming is important!** Set the **PortalObject's name** to:
- `"R"` for **Red**
- `"Y"` for **Yellow**
- `"B"` for **Blue**
- This ensures that the portal is assigned the correct color automatically.

### How Portals Work
- The **PortalGenerator** script will:
- Instantiate portals at the correct positions.
- Adjust portal orientations.
- Assign colors **(Red, Yellow, or Blue)** based on the **PortalObject’s name**.

---

## Adding a Respawn Plane
The **Respawn Plane** is an invisible surface that detects when a player falls off the track.  
When a player touches the Respawn Plane, they will be **reset to the last valid checkpoint**.

### How to Add a Respawn Plane
1. Inside your **"Track"** object, create a **new GameObject** named **"RespawnPlane"**.
2. Assign it a large **Box Collider** covering areas where players shouldn't be.
3. In the **Inspector**, check **"Is Trigger"** to make it detect objects without causing collisions.
4. When the track loads, the **RespawnPlane** automatically gets the **RespawnPlane** script attached:
```csharp
track.transform.Find("RespawnPlane").gameObject.AddComponent<RespawnPlane>();
```

## Finalizing Your Track
Once you are happy with your track:
1. Select the 'Track' prefab in the Project window.
2. In the Inspector, find the 'AssetBundle' field at the buttom.
3. Click 'None' -> 'New...' and type the name of your track.
4. Go to the top left of the Unity editor: Click 'Assets' -> 'Build AssetBundles'.
5. Your AssetBundle will be generated inside the "AssetBundles" folder.

🎉 Congratulations! You've successfully built a custom track for MotoMix! 🎉

To add this custom track go to the MotoMix directory then ChemKart_Data/StreamingAssets/Tracks and add both your .assetbundle file and your .manifest file to it