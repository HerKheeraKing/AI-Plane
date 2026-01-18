<h1 align="center">AI-POWERED FLIGHT SIMULATOR</h1>

##### <p align="center"> Driven by my interest in digital twin fabrication and AI-based simulation, this project explores reinforcement learning agents within a controlled Unreal Engine environment.
</p>

  <p align="center"> Built as an exploration of learning through simulation, this project combines reinforcement learning and real-time physics to study how autonomous agents adapt within a controlled environment. This AI-powered flight simulator trains an intelligent pilot to navigate, steer, and stabilize an aircraft through trial-and-error, using reward-based feedback to improve decision-making and flight behavior over time.
  </p>
  <p align="center"><em>
This project was developed as part of a long-standing, collaborative simulation effort. While the aircraft physics and core flight logic were pre-existing, my contribution focused on building the AI agent framework within Unreal Engine. I worked on integrating reinforcement learning workflows, agent control structures, and training logic, and proposed the addition of AI-assisted flight behavior to the simulation. After my phase, the project was passed on to the next group for continued development.
</em></p>

<div align="center">
  <img 
    src="https://github.com/user-attachments/assets/2641c547-29c5-4129-84d9-65b641fb45c2" 
    width="400" 
    alt="Aircraft"
  />
</div>


<br><br>

# How it works:
**⚙️Phase 1 — Learning Agents Framework (Unreal Engine 5.3)** </p>
This project began by following Unreal Engine’s Learning Agents tutorials to understand how reinforcement learning agents are structured, trained, and evaluated within Unreal. Using the vehicle template, I worked with a pre-built physics system to focus on the AI framework rather than low-level vehicle dynamics.
During this phase, I implemented the core Learning Agents pipeline in Blueprints, including the training manager, agent registration, observation collection, action handling, reward shaping, and episode completion logic.

**🧠Phase 2 — Agent Observation, Actions, and Rewards** </p>
I designed the agent’s observation space to capture position, direction, velocity, and alignment relative to a spline-based track. Actions were mapped to throttle, brake, and steering inputs in real time.
Reward functions were structured to encourage staying centered on the track, maintaining forward alignment, and increasing speed, while penalizing off-track behavior. Episode termination and reset logic ensured consistent training cycles.

**📈Phase 3 — Training & Policy Integration** </p>
Policies and trainers were configured using Unreal’s Learning Agents system, including PPO-based training parameters such as learning rate, batch size, episode length, and environment timing. Neural network assets were integrated through Blueprint-driven training workflows, with logging and checkpoint paths configured for experimentation.

**🔄Phase 4 — Migration to Unreal Engine 5.5 & Flight Simulation Integration** </p>
The Learning Agents framework was later migrated from Unreal Engine 5.3 to 5.5 to support integration with a pre-built 6DOF flight simulator. This required resolving Blueprint incompatibilities and adapting agent, trainer, and policy logic due to engine-level changes between versions.
This phase focused on transferring the AI control framework from a ground vehicle to an aircraft context, enabling AI-assisted flight behavior within a more complex simulation environment.

**✅Phase 5 — Evaluation & Experimentation** </p>
Training runs were tested and evaluated within Unreal, and TensorBoard logging was explored to visualize learning progress, though deep optimization was outside the project’s scope.

**📟UI & Data Integration** </p>
Contributed Blueprint logic to extract live flight and simulation data directly from the aircraft systems and route it into Unreal Engine UI elements for real-time visualization during user-controlled flight.

Tools: Unreal Engine 5.5, Unreal Learning Agents, Reinforcement Learning (RL), Blueprints, Behavior Trees, Git/GitHub
<br><br>

## Demo Videos  

##### 🎮 POV: FLIGHT SIMULATOR in Action -> Click To Watch!
<p align="left">
  <a href="https://youtu.be/qmg-ru8VKl8">
    <img src="https://github.com/user-attachments/assets/67b3a510-70bd-40dc-81d1-621ac7ca7ba6" alt="Flight simulator thumbnail" width="600"/>
  </a>
</p>

<br><br><br>




## ⚠️ Note: Git LFS Required


This project uses [Git Large File Storage (LFS)](https://git-lfs.github.com/) to manage large binaries such as `.exe`, `.dll`, `.pdb`, `.uasset`, and machine learning dependencies.

If you're cloning this repository, make sure Git LFS is installed **before** you clone, otherwise some large files will be missing.

### 🔧 Install Git LFS

- **Windows/macOS/Linux:**
  [Download & install Git LFS](https://git-lfs.github.com/)

Then run:

```bash
git lfs install
```

<br><br><br>
## Explore my 6-DOF motion simulator repo to see how the flight platform is built and how a mini version can be replicated - Click Image To Access Repo 

<a href="https://github.com/HerKheeraKing/6-DOF">
  <img 
    src="https://github.com/user-attachments/assets/50600c9e-af3f-4b49-ab03-23e5a561e88f" 
    width="250" 
    alt="6-DOF Thumbnail"
  />
</a>


<br><br><br>
#### 📄 LICENSE INFO 
This source code is available for viewing only. Usage of the code in any form is prohibited without explicit permission. Please refer to the LICENSE file for more details.

