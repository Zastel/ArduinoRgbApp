# ArduinoRgbApp

## Introduction
This project is a .NET 7 cross-platform app for RGB LED strip control via arduino. The communication is currently done via USB Serial, but a Bluetooth serial can be easily implemented (only the arduino side needs to be updated).
The platforms currently supported are : 
- Windows

## Features
At the moment, the arduino and app supports 3 modes :
- Static color
- Rainbow mode (gradual transitions between red, green, blue)
- Default mode (jumps between red, green, blue, white)
