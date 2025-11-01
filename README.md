⛰️ Tilemania – Unity 2D Physics-Based Slope Adventure

🎮 Project Overview

Tilemania is a 2D physics-driven slope adventure game built in Unity as part of the GameDev.tv 2D course.
Players ride across handcrafted terrains, perform flips, boost through slopes, and master control under realistic physics.
The project focuses on terrain sculpting, physics-based gameplay, adaptive difficulty, and smooth camera transitions, offering a visually dynamic and technically rich learning experience.

🧠 Concepts & Systems Implemented

🏞️ Custom Environments

• Designed and sculpted mountain-like terrains using Sprite Renderer and manual node editing for natural slope creation.

• Applied layered tilemaps and composite colliders for seamless and continuous landscapes.

🎥 Dynamic Camera Work

• Integrated Cinemachine virtual cameras to achieve smooth camera movement that dynamically follows the player.

• Tuned camera damping, screen composition, and transition blending for cinematic gameplay flow.

⚙️ Physics Interactions

• Implemented realistic physics using Rigidbody2D and Surface Effector 2D.

• Designed a boost mechanic that temporarily increases player speed (↑ key).

A• dded a brake system for better control on steep slopes (↓ key).

• Developed flip mechanics (forward and backward) tied to player rotation and torque physics.

🔄 Seamless Transitions

• Used Scene Management to handle smooth level transitions.

• Employed the Invoke() method for precise delay handling and scene flow management.

💥 Visual & Audio Flair

• Implemented Particle Systems for snow trails and crash effects triggered on impact.

• Learned and applied Audio Listener, Audio Source, and Audio Clip for immersive sound effects.

• Coordinated multiple audio cues (crash, boost, environment) to enhance player feedback.

🎯 Collision Detection

• Applied tags and layered collisions for precise event detection.

• Ensured smooth and accurate gameplay responses during boosts, flips, and terrain impacts.

🧩 Core Gameplay Elements

• Combined essential Unity components – Sprite Renderer, Collider2D, and Rigidbody2D – to define player and environment behavior.

• Balanced performance and realism by fine-tuning physics materials and drag values.

🤖 AI Integration

🧮 Adaptive Difficulty System

• Conceptualized an AI-based system that adjusts terrain difficulty and player speed dynamically based on real-time performance metrics.

• Adapts to player skill to maintain engagement and balanced challenge levels.

📊 Player Modeling

• Tracks gameplay metrics such as speed, crashes, flips, and completion time.

• Uses these metrics to influence future level difficulty and reward pacing.

💻 C# Programming Concepts Applied

• Physics-Based Movement: Applied forces and torque for authentic motion and control.

• Conditional Logic: Used if and switch statements for state-based event handling.

• Component Communication: Managed inter-object behavior using GetComponent<>() and tag-based interaction.

• Time Management: Used Time.deltaTime for smooth, frame-independent physics.

• Audio & Particle Triggering: Coordinated SFX and particle events with collisions and state transitions.

🧭 Gameplay Flow

🏁 Start Level → ⛰️ Ride Through Slopes → ⚡ Boost / Flip / Brake → 💥 Crash (if physics fail) → 🔄 Restart or Next Scene

🕹️ Controls

↑ Up Arrow – Boost speed

↓ Down Arrow – Apply brakes

← / → Arrows – Perform flips

🧰 Tools & Technologies Used

• Unity Engine (2D)

• C# Programming

• Cinemachine (Camera System)

• Surface Effector 2D

• Rigidbody2D & Colliders

• Particle System & Audio Components

• ML agents toolkit

🎯 Learning Outcomes

• Understood physics-driven movement and surface interactions in Unity.

• Mastered camera systems and smooth transitions using Cinemachine.

• Learned to combine visual, audio, and physics effects for immersive gameplay.

• Designed modular scripts to support adaptive game mechanics.

• Built a foundation for AI-based difficulty adjustment and player modeling.
