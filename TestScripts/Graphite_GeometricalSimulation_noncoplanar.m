% NONCOPLANAR DIFFRACTION GEOMETRY
home
clear
close all

% PATH TO DIFFWIZ LIBRARY
addpath(genpath('C:\Users\maher\Dropbox\Physics\lund\DIFFWIZ\'))

% DEFINE YOUR LATTICE OR LOAD LATTICE FROM EXISTING STRUCTURE LIBRARY
load graphite.mat

% DEFINE YOUR CRYSTAL
Lattice.Normal = [0 0 1]; % direction of crystal surface

% DEFINE YOUR X-RAYS
Probe.Type = 'xrays';
Probe.Energy = 15000; % [eV]
Probe.DiffractionGeometry = 'noncoplanar';
Probe.psi = 0.1; % relevant only in noncoplanar geometry

Detector.Shape = 'square';
Detector.Size = 102; % diameter or length
Detector.SpotFWHMx = 3;
Detector.SpotFWHMy = 3;
Detector.DistanceToSample = 50; % sample-detector distance 40-400
Detector.Offset = [0 0]; % offset from center of beam 

hkl = [0:5];

I = GeometricalSimulation1(Lattice, Probe, Detector, hkl, 1);






