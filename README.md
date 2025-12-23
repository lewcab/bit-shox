# 🚗 Bit Shox - Unity Vehicle Simulation

A realistic vehicle simulation system in Unity. Bit Shox was developed in Unity 2022.3, and has not been tested in more recent versions of Unity (ex. 2023.x, 6000.x).

## ⚙️ Startup Guide

First, you must ensure the controls are setup properly. This can be done in Unity, by selecting `Tools > Bit Shox > Configure Vehicle Controls`.

After the controls are set up, setting up a car is as easy as dragging and dropping a prefab from `Samples/Cars/` into your scene, and adjusting the parameters from there. These prefabs include a Camera setup which is controlled by the Right Joystick. Other controls and setup can be seen below.

- Throttle: Right Trigger (W)
- Brakes: Left Trigger (S)
- Steering: Left Joystick (A & D)

If you want to setup a car from scratch, do the following:

1. Create an empty `Game Object` in your scene and name it. 
2. Select the `Game Object` and click `Add Component` in the `Inspector`. Add the `BSCar` script.
3. Adjust the `BSCar` script values to your desired vehicle specifications in Unity's Inspector.

**Note:** The `BSCar` script does not have its own camera or camera controller by default. You will need to add your own.

### 🪛 `BSCar` Parameters

| Parameter | Description |
|-|-|
| **Is Log Inputs** | The mass of the car in kilograms. |
| **Is Keyboard Control** | If enabled, the car will respond to keyboard inputs. |
| **Car Shell Prefab** | The visual representation of the car body. |
| **Wheel Prefab** | The prefab used for the car's wheels. |
| **Wheelbase** | The distance between the front and rear wheels of the car. |
| **Track** | The distance between the left and right wheels of the car. |
| **Car Weight** | The mass of the car in kilograms. |
| **Max Drive Force** | The maximum force the car's engine can apply to the wheels. |
| **Brake Force** | The maximum braking force that can be applied to the wheels. |
| **Top Speed** | The maximum speed the car can reach in meters km/h. |
| **Drive Type** | The type of drive system (e.g., FWD, RWD, AWD). |
| **Steering Angle** | The maximum angle the front wheels can turn for steering. |
| **Suspension Depth** | The distance of the suspensions base from the floor of the car. |
| **Suspension Angle** | The angle at which the suspension arms are positioned. |
| **Suspension Rest Length** | The length of the suspension when at rest. |
| **Suspension Spring Coefficient** | The stiffness of the suspension springs. |
| **Suspension Damping Coefficient** | The damping factor of the suspension. |
| **Tire Friction Coefficient** | The friction coefficient of the tires. |
| **Tire Width** | The width of the tires. |
| **Tire Diameter** | The diameter of the tires. |
| **Ray Count** | The number of rays used for suspension simulation per wheel. |


## Project Structure

- `Editor`: Contains all the editor scripts, primarily used for setting up controls.
- `Runtime`: Contains all the core scripts, including `BSCar` and `BSWheel`.
- `Samples`: Contains sample vehicles and scenes to demonstrate the functionality of Bit Shox. Also contains low fidelity models for wheels and bodies.
- `Documentation~`: Contains more formal documentation, including Physics explanations.
