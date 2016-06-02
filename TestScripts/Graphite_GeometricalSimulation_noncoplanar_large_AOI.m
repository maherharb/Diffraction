% EXAMPLE SCRIPT TO GENERATE DIFFRACTION PATTERN FROM NONCOPLANAR DIFFRACTION GEOMETRY

% CLEAN WORKSPACE
home
clear
close all

% PATH TO DIFFWIZ LIBRARY
addpath(genpath('C:\Users\maher\Google drive\DIFFWIZ\'))

% DEFINE LATTICE OR LOAD LATTICE FROM EXISTING STRUCTURE LIBRARY
load graphite.mat

% DEFINE DIRECTION OF CRYSTAL NORMAL
Lattice.Normal = [0 0 1]; 

% DEFINE X-RAYS
Probe.Type = 'xrays';
Probe.Energy = 15000; % [eV]
Probe.DiffractionGeometry = 'noncoplanar';
Probe.psi = 12; % This's the grazing angle

% DEFINE DETECTOR
Detector.Shape = 'square';
Detector.Size = 170; % diameter or length in mm
Detector.SpotFWHMx = 4; % Diffraction spot size on detector
Detector.SpotFWHMy = 4;
Detector.DistanceToSample = 70; % Sample-detector distance in mm
Detector.Offset = [0 10]; % offset from center of beam in mm

% MILLER INDICES TO LOOP OVER 
hkl = [0:10];

% MAIN FUNCTION
I = GeometricalSimulation1(Lattice, Probe, Detector, hkl, 1);






