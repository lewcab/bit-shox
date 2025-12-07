# 🚗 Bit Shox - Unity Vehicle Simulation

A realistic vehicle simulation system in Unity. Bit Shox was developed in Unity 2022.3, and has not been tested in more recent versions of Unity (ex. 2023.x, 6000.x).

## ⚙️ Startup Guide

First, you must ensure the controls are setup properly. This can be done in Unity, by selecting `Tools > Bit Shox > Configure Vehicle Controls`.

After the controls are set up, setting up a car is as easy as dragging and dropping a prefab from `Bit Shox/Samples/Car Setups/` into your scene, and adjusting the parameters from there. These prefabs include a Camera setup which is controlled by the Right Joystick. Other controls and setup can be seen below.

- Throttle: Right Trigger (W)
- Brakes: Left Trigger (S)
- Steering: Left Joystick (A & D)

If you want to setup a car from scratch, do the following:

1. Create an empty `Game Object` in your scene and name it. 
2. Select the `Game Object` and click `Add Component` in the `Inspector`. Add the `BSCar` script.
3. Adjust the `BSCar` script values to your desired vehicle specifications in Unity's Inspector.

**Note:** The `BSCar` script does not have its own camera or camera controller by default. You will need to add your own.
