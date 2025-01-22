# PLC Simulator

This repository contains a complete solution for simulating and controlling a discrete control system. It includes Matlab scripts for calculating and discretizing the controller, integration with the DoMore Simulator for process control via Modbus/TCP, and a Visual Studio application for real-time visualization and interaction with the system.

---

## Simulator Task

### Matlab

    - A script has been created to calculate the parameters of the prescribed continuous controller for a system in the form of K / (Ts + 1), based on selected time constants (closed loop).
    - An appropriate sampling period has been chosen, and the designed controller has been discretized using the prescribed approximation method.
    - The calculated discrete controller values and the sampling period are sent to the DoMore Simulator via the Modbus/TCP protocol.

### DoMore Simulator

    - The simulated process has been set up based on the provided time constant T (transport delay = 0, noise = 0.002).
    - The conversion between ADC/DAC values and y(k)/u(k) values has been implemented based on specified converter ranges, with system gain K taken into account when calculating the DAC values (i.e., DAC <- K * u(k)).
    - The designed discrete controller has been implemented to control the simulated process, with controller parameters and sampling period being configurable from Matlab via Modbus/TCP.
    - It is possible to read the values y(k), u(k), e(k) and write w(k) via Modbus/TCP.
    - Reading of bits X0-X15 and writing of bits Y0-Y15 via Modbus/TCP has been enabled.

### Visual Studio C#

    - Communication with the DoMore Simulator via Modbus/TCP has been implemented.
    - A graphical application has been created to visualize the real-time behavior of y(k), u(k), and e(k) values in the form of graphs.
    - The reference value w(k) can be set within the application.
    - The status of digital inputs X0-X15 is visualized, and it is possible to toggle digital outputs Y0-Y15 on and off.