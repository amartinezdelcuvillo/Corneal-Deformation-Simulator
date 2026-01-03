# Cornea-Simulation-Unity

An interactive simulation of **corneal deformation** and **palpation**, built with **Unity 3D** and based on a physical model developed in **ANSYS**. The simulator integrates a **Touch X haptic device** to provide force-feedback, aimed at medical training scenarios (e.g., surgical practice).


## Overview

The workflow follows two main stages:

1. **ANSYS** is used to model the cornea and extract the physical behaviour needed for deformation (including the elastic constant \(K\) derived from force/displacement).
2. The model is then implemented in **Unity** using a **deformable mesh**, enabling real-time interaction. With **Touch X**, users can palpate the cornea and feel the response through haptic feedback.

Additionally, the project supports **MQTT** communication to facilitate integration with external tools or data-processing pipelines.

---

## Key Features

- **ANSYS-based cornea modelling**  
  Physical behaviour is analysed in ANSYS and used to obtain parameters such as the elastic constant \(K\).

- **Real-time deformation in Unity**  
  A deformable mesh reacts instantly to user interaction.

- **Touch X haptic integration**  
  Force-feedback lets the user “feel” the deformation while palpating the cornea (requires Touch X software installed).

- **MQTT support**  
  Enables communication between applications and potential integration with external systems.

---

## Demo Videos

### ANSYS simulation (physics / deformation)

https://github.com/user-attachments/assets/f96d1e84-f960-4ef7-a2b5-72cdb79860ee


### Unity + haptics simulation (real-time palpation)

https://github.com/user-attachments/assets/56652e4a-4db1-40a4-a395-683e8dcacf45


## Note about the videos

The Unity demo video uses a sample value of (K) for demonstration purposes,
while the correct calibrated value is implemented in the full project.

---

## Data

`Cornea Excel.xlsx` contains force measurements used during the ANSYS study. These data points are used to select appropriate elasticity parameters for accurate Unity deformation.

---

## Requirements

- **Unity**: 2021.3.11f1 (LTS)
- **ANSYS**: 2022 R2 (for running/modifying the physical simulation)
- **Editor**: Visual Studio Code (or similar)
- **Hardware (optional)**: Touch X haptic device
- **Touch X software/drivers**: required for haptic interaction

---

## Repository Structure

- `Corneal Palpator with Touch X/Assets` – Unity assets and resources
- `Corneal Palpator with Touch X/Scripts` – core scripts:
  - `CubeSphere.cs` – generates the deformable mesh
  - `MeshDeformer.cs` – applies deformation using Hooke’s law with constant \(K\)
  - `MeshDeformerInput.cs` – handles interaction and applies force
- `Cornea Simulation in Ansys/Cornea_files` – ANSYS model + simulation outputs
- `Cornea Excel.xlsx` – simulation/force data used for parameter calibration

---

## Installation & Usage

1. Clone this repository:
   ```bash
   git clone https://github.com/<YOUR_USERNAME>/<YOUR_REPO>.git

